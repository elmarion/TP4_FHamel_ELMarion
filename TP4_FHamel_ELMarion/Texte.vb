Imports System.IO

Public Class Texte
    Inherits TreeNode
    Private _ratioUpAndDown As Integer
    Public Property RatioUpAndDown() As Integer
        Get
            Return (EvalUp.Count - EvalDown.Count) * -1
        End Get
        Set(ByVal value As Integer)
            _ratioUpAndDown = value
        End Set
    End Property
    Private _evalUp As List(Of Utilisateurs)
    Private _evalDown As List(Of Utilisateurs)
    Private _message As String
    Private _auteur As Utilisateurs

#Region "get/set"
    Public Property Auteur() As Utilisateurs
        Get
            Return _auteur
        End Get
        Set(ByVal value As Utilisateurs)
            _auteur = value
        End Set
    End Property
    Public Property Message() As String
        Get
            Return _message
        End Get
        Set(ByVal value As String)
            _message = value
        End Set
    End Property
    Public Property EvalDown() As List(Of Utilisateurs)
        Get
            Return _evalDown
        End Get
        Set(ByVal value As List(Of Utilisateurs))
            _evalDown = value
        End Set
    End Property
    Public Property EvalUp() As List(Of Utilisateurs)
        Get
            Return _evalUp
        End Get
        Set(ByVal value As List(Of Utilisateurs))
            _evalUp = value
        End Set
    End Property
#End Region

    Public Sub New(pMessage As String, pAuteur As Utilisateurs)
        Message = pMessage
        Auteur = pAuteur
        EvalDown = New List(Of Utilisateurs)
        EvalUp = New List(Of Utilisateurs)
    End Sub

    ''' <summary>
    ''' Formatage de l'écriture des noeuds.
    ''' </summary>
    Public overridable Sub AffichageDansLeNodes()
        If Message.Length >= 20 then
            Me.Text = Auteur.Login + ": " + Message.Substring(0, 20) + "... " + EvalUp.Count.ToString + " up | " + EvalDown.Count.ToString + " down"
        Else
            Me.Text = Auteur.Login + ": " + Message + " " + EvalUp.Count.ToString + " up | " + EvalDown.Count.ToString + " down"
        End If
    End Sub

    ''' <summary>
    ''' Voter pour un texte écrit par un autre utilisateur
    ''' </summary>
    ''' <param name="pLeVoteur">Auteur du vote</param>
    ''' <param name="pUpOrDown">1 Pour vote positif, -1 pour vote négatif</param>
    Public Sub Voter(pLeVoteur As Utilisateurs, pUpOrDown As Integer)
        If EvalUp.Contains(pLeVoteur) OrElse EvalDown.Contains(pLeVoteur) Then
            Throw New Exception("Vous avez déjà voté pour ce texte !")
        ElseIf pLeVoteur.Login = Auteur.Login AndAlso pLeVoteur.Psw = Auteur.Psw Then
            Throw New Exception("Vous ne pouvez pas voter pour vos propres textes !")
        Else
            Select Case pUpOrDown
                Case 1
                    EvalUp.Add(pLeVoteur)
                Case -1
                    EvalDown.Add(pLeVoteur)
            End Select
        End If
    End Sub

    ''' <summary>
    ''' Exporter les textes dans un fichier XML
    ''' </summary>
    ''' <param name="sw">fichier à écrire</param>
    Public overridable Sub Exporter(sw As StreamWriter)
        sw.WriteLine("<commentaire>")
        sw.WriteLine("<auteur>" & Auteur.Login &"</auteur>")
        sw.WriteLine("<message>"& Message &"</message>")
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
        'Exporter enfants..
        For each elem As Texte In Me.Nodes
            elem.Exporter(sw)
        Next
        sw.WriteLine("</commentaire>")
    End Sub

    Public Overrides Function ToString() As String
        Return Auteur.Login + ":" + vbTab + Message
    End Function

End Class