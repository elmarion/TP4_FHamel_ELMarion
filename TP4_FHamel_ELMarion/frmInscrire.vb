Public Class frmInscrire

    Private _dicoUsers As New Dictionary(Of String, Utilisateurs)
    Private _cle As String

    Public Sub New(pDicoUsers As Dictionary(Of String, Utilisateurs))
        InitializeComponent()
        _dicoUsers = pDicoUsers
    End Sub
    Public Function DonnerCle() As String
        Return _cle
    End Function

    Private Sub btnInscrire_Click(sender As Object, e As EventArgs) Handles btnInscrire.Click
        If txtLogin.Text = "" Then
            lblErreurUtilisateur.Visible = True
            lblErreurUtilisateur.Text = "Ce champs ne peut être vide"
            LblErreurPsw1.Visible = False
            lblErreurPsw2.Visible = False
        ElseIf txtPsw1.Text = "" Then
            LblErreurPsw1.Visible = True
            lblErreurUtilisateur.Visible = False
            lblErreurPsw2.Visible = False
        ElseIf txtPsw2.Text = "" Then
            lblErreurPsw2.Visible = True
            lblErreurPsw2.Text = "Ce champs ne peut être vide"
            LblErreurPsw1.Visible = False
            lblErreurUtilisateur.Visible = False
        ElseIf _dicoUsers.ContainsKey(txtLogin.Text) Then
            lblErreurUtilisateur.Visible = True
            lblErreurUtilisateur.Text = "Ce nom d'utilisateur existe déjà"
            LblErreurPsw1.Visible = False
            lblErreurPsw2.Visible = False
        Else
            If txtPsw1.Text = txtPsw2.Text Then
                _dicoUsers.Add(txtLogin.Text, New Utilisateurs(txtLogin.Text, txtPsw1.Text))
                _cle = txtLogin.Text
                Me.DialogResult = DialogResult.OK
            Else
                lblErreurPsw2.Visible = True
                lblErreurPsw2.Text = "Les mots de passe ne concorde pas."
                LblErreurPsw1.Visible = False
                lblErreurUtilisateur.Visible = False
            End If
        End If
    End Sub
End Class