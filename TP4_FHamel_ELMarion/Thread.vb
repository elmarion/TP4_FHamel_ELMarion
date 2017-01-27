Imports System.IO

Public Class Thread
    Inherits Texte
    Private _Titre As String
    Private _Categorie As String
#Region "get/set"
    Public Property Categorie() As String
        Get
            Return _Categorie
        End Get
        Set(ByVal value As String)
            _Categorie = value
        End Set
    End Property
    Public Property Titre() As String
        Get
            Return _Titre
        End Get
        Set(ByVal value As String)
            _Titre = value
        End Set
    End Property
#End Region

    Public Sub New(pMessage As String, pAuteur As Utilisateurs, pTitre As String, pCategorie As String)
        MyBase.New(pMessage, pAuteur)
        Titre = pTitre
        Categorie = pCategorie
    End Sub

    ''' <summary>
    ''' Formatage de l'écriture des noeuds
    ''' </summary>
    Public Overrides Sub AffichageDansLeNodes()
        If Titre.Length >= 20 Then
            Me.Text = Auteur.Login + ": " + Titre.Substring(0, 20) + "... " + EvalUp.Count.ToString + " up | " + EvalDown.Count.ToString + " down"
        Else
            Me.Text = Auteur.Login + ": " + Titre + " " + EvalUp.Count.ToString + " up | " + EvalDown.Count.ToString + " down"
        End If
    End Sub


    ''' <summary>
    ''' Exporter les textes dans un fichier XML
    ''' </summary>
    ''' <param name="sw">fichier à écrire</param>
    Public Overrides Sub Exporter(sw As StreamWriter)
        sw.WriteLine("<thread>")
        sw.WriteLine("<auteur>" & Auteur.Login & "</auteur>")
        sw.WriteLine("<categorie>" & Categorie & "</categorie>")
        sw.WriteLine("<titre>" & Titre & "</titre>")
        sw.WriteLine("<message>" & Message & "</message>")
        sw.Write("<voteUp>")
        For each elem In EvalUp
            sw.Write(elem.Login.ToString & "|")
        Next
        sw.WriteLine("</voteUp>")
        sw.Write("<voteDown>")
        For each elem In EvalDown
            sw.Write(elem.Login.ToString & "|")
        Next
        sw.WriteLine("</voteDown>")

        For Each elem as Texte In Me.Nodes
            elem.Exporter(sw)
        Next
        sw.WriteLine("</thread>")
    End Sub

    Public Overrides Function ToString() As String
        Return Auteur.Login + ":" + vbTab + Titre
    End Function
End Class
