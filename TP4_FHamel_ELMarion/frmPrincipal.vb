Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Xml
Public Class rBtnAucun
    Private lstCategorie As New List(Of String)
    Private userActuel As Utilisateurs
    Private _dicoUsers As New Dictionary(Of String, Utilisateurs)
    Private _lstThreads As New List(Of Thread)


    Private Sub rBtnAucun_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ImporterFichier()
        For each elem In _lstThreads
            tvArbre.Nodes.Add(elem)
        Next
        lstCategorie.Add("Autre catégorie")
        Dim frmPremierConnexion As New frmConnexion(_dicoUsers)
        If frmPremierConnexion.ShowDialog = DialogResult.OK Then
            userActuel = frmPremierConnexion.DonnerUtilisateur()
            MSConnexion.Text = userActuel.Login
            RefreshArbre()
        Else
            Me.Close()
        End If

    End Sub


    Private Sub btnThread_Click(sender As Object, e As EventArgs) Handles btnThread.Click
        Dim frmNewThread = New frmNewTexte(True, lstCategorie, userActuel)
        If frmNewThread.ShowDialog() = DialogResult.OK Then
            _lstThreads.Add(frmNewThread.DonnerTexte())
            tvArbre.Nodes.Add(_lstThreads.Last)
        End If
        RefreshArbre()
    End Sub

    Private Sub btnCommentaire_Click(sender As Object, e As EventArgs) Handles btnCommentaire.Click
        If tvArbre.SelectedNode Is Nothing Then
            lblErreur.Visible = True
            lblErreur.Text = "*Vous devez sélectionner quelque chose pour comementer"
        Else
            Dim frmNewCommentaire = New frmNewTexte(False, lstCategorie, userActuel)
            If frmNewCommentaire.ShowDialog() = DialogResult.OK Then
                tvArbre.SelectedNode.Nodes.Add(frmNewCommentaire.DonnerTexte())
            End If
        End If
        RefreshArbre()
    End Sub

    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        If tvArbre.SelectedNode Is Nothing Then
            lblErreur.Visible = True
            lblErreur.Text = "*Vous devez sélectionner quelque chose pour voter"
        Else
            Try
            CType(tvArbre.SelectedNode, Texte).Voter(userActuel, 1)
            Catch ex As Exception
                lblErreur.Text = ex.Message
                lblErreur.Visible = True
            End Try
            RefreshArbre()
        End If
    End Sub

    Private Sub btnDown_Click(sender As Object, e As EventArgs) Handles btnDown.Click
        If tvArbre.SelectedNode Is Nothing Then
            lblErreur.Visible = True
            lblErreur.Text = "*Vous devez sélectionner quelque chose pour voter"
        Else
            Try
                CType(tvArbre.SelectedNode, Texte).Voter(userActuel, -1)
            Catch ex As Exception
                lblErreur.Text = ex.Message
                lblErreur.Visible = True
            End Try

            RefreshArbre()
        End If
    End Sub

    Private Sub DéconnexionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DéconnexionToolStripMenuItem.Click
        Dim frmPremierConnexion As New frmConnexion(_dicoUsers)
        If frmPremierConnexion.ShowDialog = DialogResult.OK Then
            userActuel = frmPremierConnexion.DonnerUtilisateur()
            MSConnexion.Text = userActuel.Login
        End If
    End Sub

    Private Sub RefreshArbre()
        For each elem In _lstThreads
            tvArbre.Nodes.Remove(elem)
        Next
        _lstThreads.Sort(Function(x,y) x.RatioUpAndDown.CompareTo(y.RatioUpAndDown))

        For each elem In _lstThreads
            elem.AffichageDansLeNodes
            tvArbre.Nodes.Add(elem)
            TrierParNombreDeVotes(elem)
        Next
        tvArbre.Refresh
    End Sub

    Private sub TrierParNombreDeVotes(pNoeud As Texte)
        Dim listeNoeuds As New List(Of Texte)

        For each elem In pNoeud.Nodes
            listeNoeuds.Add(elem)
            TrierParNombreDeVotes(elem)
        Next
        For index = 0 To pNoeud.Nodes.Count -1
            pNoeud.Nodes.RemoveAt(0)
        Next
        listeNoeuds.Sort(Function(x,y) x.RatioUpAndDown.CompareTo(y.RatioUpAndDown))
        For each elem In listeNoeuds
            pNoeud.Nodes.Add(elem)
            elem.AffichageDansLeNodes()
        Next
    End sub

    Private Sub tvArbre_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles tvArbre.NodeMouseClick
        txtContenu.Text = CType(e.Node, Texte).Message
    End Sub

    Private Sub rBtnAucun_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim fic As New FileStream("..\..\lesUsers.dat", FileMode.Create)
        Dim bf As New BinaryFormatter
        bf.Serialize(fic, _dicoUsers)
        fic.Close()

        Dim msg As StreamWriter
        If Not File.Exists("..\..\lesMSG.xml")
            msg = New StreamWriter("..\..\lesMSG.xml", FileMode.Create)
            Else
            msg = New StreamWriter("..\..\lesMSG.xml", False)
        End if
        For each elem As Thread In tvArbre.Nodes
            elem.Exporter(msg)
        Next
        msg.Close()

    End Sub


    Private sub ImporterFichier()
        Dim strLeFichierXML As String = ""
        Dim auteur As String = ""
        Dim categorie As String = ""
        Dim titre As String = ""
        Dim message As String = ""
        Dim lstVoteUp As String()
        Dim lstVoteDown As String()
        Dim bThread As Boolean
        Dim bCommentaire As Boolean
        Dim noeudCourant As Texte

        If File.Exists("..\..\lesUsers.dat") Then
            Dim fic As New FileStream("..\..\lesUsers.dat", FileMode.Open)
            Dim binaryReader As New BinaryFormatter
            _dicoUsers = binaryReader.Deserialize(fic)
            fic.Close()
        End If

        If File.Exists("..\..\lesMSG.xml")
            Dim msg As StreamReader
            Dim infoChaqueLigne As String()
            Dim infoEntreChaqueCheverons As String()

            msg = File.OpenText("..\..\lesMSG.xml")

                strLeFichierXML = msg.ReadToEnd

                infoChaqueLigne = strLeFichierXML.Split(vbCrLf)


            For i = 0 To infoChaqueLigne.Count -2
                infoEntreChaqueCheverons = infoChaqueLigne(i).Split("<")
                infoEntreChaqueCheverons = infoEntreChaqueCheverons(1).Split(">")
                
                Select Case infoEntreChaqueCheverons(0)
                    Case "thread"
                        bCommentaire = False
                    Case "/thread"
                        bThread = False
                    Case "commentaire"
                        bCommentaire = True
                    Case "/commentaire"
                        bCommentaire = False
                        noeudCourant = noeudCourant.Parent
                    Case "auteur"
                        auteur = infoEntreChaqueCheverons(1)
                    Case "categorie"
                        categorie = infoEntreChaqueCheverons(1)
                        If not lstCategorie.Contains(categorie) then lstCategorie.Add(categorie)
                    Case "titre"
                        titre = infoEntreChaqueCheverons(1)
                    Case "message"
                        message = infoEntreChaqueCheverons(1)
                    Case "voteUp"
                        lstVoteUp = infoEntreChaqueCheverons(1).Split("|")
                    Case "voteDown"
                        lstVoteDown = infoEntreChaqueCheverons(1).Split("|")
                        If not bCommentaire Then
                            _lstThreads.Add(New Thread(message, _dicoUsers(auteur), titre, categorie))
                            noeudCourant = _lstThreads.Last
                        Else
                            noeudCourant.Nodes.Add(New Texte(message, _dicoUsers(auteur)))
                            noeudCourant = noeudCourant.LastNode
                        End If

                        For each elem In lstVoteUp
                            If elem <> "" Then
                                noeudCourant.EvalUp.Add(_dicoUsers(elem))
                            End If
                        Next
                        For each elem In lstVoteDown
                            If elem <> "" Then
                                noeudCourant.EvalDown.Add(_dicoUsers(elem))
                            End If
                        Next
                End Select
            Next
            msg.Close()
        End If
    End sub

    Private Sub cbFiltres_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFiltres.SelectedIndexChanged
        lbTrier.Items.Clear
        If(rBtnCategorie.Checked) Then
        For each elem In _lstThreads
            If elem.Categorie = cbFiltres.SelectedItem
                lbTrier.Items.Add(elem)
            End If
        Next
        Elseif(rBtnUtilisateur.Checked)
            For each elem In _lstThreads
                If elem.Auteur.Login = ctype(cbFiltres.SelectedItem, Utilisateurs).Login
                    lbTrier.Items.Add(elem)
                End If
                AfficheElementAuteur(cbFiltres.SelectedItem, elem)
            Next
        End If
    End Sub
    Private sub AfficheElementAuteur(pUsers As Utilisateurs, pNoeud As Texte)
        For each elem In pNoeud.Nodes
            If CType(elem, Texte).Auteur.Login = pUsers.Login
                lbTrier.Items.Add(elem)
            End If
            AfficheElementAuteur(pUsers, elem)
        Next
    End sub
    Private Sub rBtnCategorie_CheckedChanged(sender As Object, e As EventArgs) Handles rBtnCategorie.CheckedChanged
        If(rBtnCategorie.Checked) Then
            For each elem In lstCategorie
                cbFiltres.Items.Add(elem)
            Next
        Else
            cbFiltres.Items.Clear
        End If
    End Sub

    Private Sub rBtnUtilisateur_CheckedChanged(sender As Object, e As EventArgs) Handles rBtnUtilisateur.CheckedChanged
        If(rBtnUtilisateur.Checked) Then
            For each elem In _dicoUsers.Values
                cbFiltres.Items.Add(elem)
            Next
        Else
            cbFiltres.Items.Clear
        End If
    End Sub

    Private Sub lbTrier_MouseClick(sender As Object, e As MouseEventArgs) Handles lbTrier.MouseClick
        txtContenu.Text = lbTrier.SelectedItem.Message
    End Sub

    Private Sub rBtnUAucun_CheckedChanged(sender As Object, e As EventArgs) Handles rBtnUAucun.CheckedChanged
        lbTrier.Items.Clear
    End Sub

End Class
