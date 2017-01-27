Public Class frmNewTexte
    Private bNewThread As Boolean
    Private lstCategorie As List(Of String)
    Private userActuel As Utilisateurs
    Private newthread As Thread
    Private newtexte As Texte

    Public Sub New(pNewThread As Boolean, plstCategorie As List(Of String), pUserActuel As Utilisateurs)
        InitializeComponent()
        bNewThread = pNewThread
        lstCategorie = plstCategorie
        userActuel = pUserActuel
    End Sub
    Private Sub frmNewTexte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblErreurCategorie.Visible = False
        lblErreurMessage.Visible = False
        lblErreurTitre.Visible = False
        If bNewThread Then
            txtTitre.Visible = True
            cbCategorie.Visible = True
            For Each elem In lstCategorie
                cbCategorie.Items.Add(elem)
            Next
            txtAutreCategorie.Visible = False
        Else
            txtTitre.Visible = False
            cbCategorie.Visible = False
            txtAutreCategorie.Visible = False
        End If
    End Sub

    Private Sub btnEnvoye_Click(sender As Object, e As EventArgs) Handles btnEnvoye.Click
        If bNewThread Then
            If txtTitre.Text = "TITRE" OrElse txtTitre.Text = "" Then
                lblErreurTitre.Visible = True
                lblErreurMessage.Visible = False
                lblErreurCategorie.Visible = False
                lblErreurNewCategorie.Visible = False
                txtTitre.Focus()
            ElseIf txtMessage.Text.Count < 3 Then
                lblErreurMessage.Visible = True
                lblErreurTitre.Visible = False
                lblErreurCategorie.Visible = False
                lblErreurNewCategorie.Visible = False
                txtMessage.Focus()
            ElseIf cbCategorie.SelectedIndex = -1 Then
                lblErreurCategorie.Visible = True
                lblErreurMessage.Visible = False
                lblErreurTitre.Visible = False
                lblErreurNewCategorie.Visible = False
                cbCategorie.Focus()
            ElseIf cbCategorie.SelectedItem.ToString = "Autre catégorie" Then
                txtAutreCategorie.Visible = True
                txtAutreCategorie.Focus()
                If txtAutreCategorie.Text = "Écrire la nouvelle catégorie" Then
                    lblErreurNewCategorie.Visible = True
                    lblErreurCategorie.Visible = False
                    lblErreurMessage.Visible = False
                    lblErreurTitre.Visible = False
                    txtAutreCategorie.Focus()
                Else
                    lstCategorie.Add(txtAutreCategorie.Text)
                    newthread = New Thread(txtMessage.Text, userActuel, txtTitre.Text, txtAutreCategorie.Text)
                    Me.DialogResult = DialogResult.OK
                End If
            Else
                newthread = New Thread(txtMessage.Text, userActuel, txtTitre.Text, cbCategorie.SelectedItem.ToString)
                Me.DialogResult = DialogResult.OK
            End If
        Else
            If txtMessage.Text.Count < 3 Then
                lblErreurMessage.Visible = True
                lblErreurTitre.Visible = False
                lblErreurCategorie.Visible = False
                lblErreurNewCategorie.Visible = False
                txtMessage.Focus()
            Else
                newtexte = New Texte(txtMessage.Text, userActuel)
                Me.DialogResult = DialogResult.OK
            End If
        End If
    End Sub

    Public Function DonnerTexte() As Texte
        If bNewThread Then
            Return newthread
        Else
            Return newtexte
        End If
    End Function

    Private Sub cbCategorie_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCategorie.SelectedIndexChanged
        If cbCategorie.SelectedItem.ToString = "Autre catégorie" Then
            txtAutreCategorie.Visible = True
        Else
            txtAutreCategorie.Visible = False
        End If
    End Sub
End Class