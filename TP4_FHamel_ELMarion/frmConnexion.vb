Public Class frmConnexion

    Private userConnect As Utilisateurs
    Private _dicoUsers As New Dictionary(Of String, Utilisateurs)

    Public Sub New(pDicoUser As Dictionary(Of String, Utilisateurs))
        InitializeComponent()
        _dicoUsers = pDicoUser
    End Sub

    Public Function DonnerUtilisateur() As Utilisateurs
        Return userConnect
    End Function

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If txtLogin.Text = "" Then
            lblErreurUtilisateur.Visible = True
            LblErreurMDP.Visible = False
        ElseIf txtMdp.Text = "" Then
            LblErreurMDP.Visible = True
            lblErreurUtilisateur.Visible = False
        ElseIf _dicoUsers.ContainsKey(txtLogin.Text) Then
            If _dicoUsers(txtLogin.Text).Psw = txtMdp.Text Then
                userConnect = _dicoUsers(txtLogin.Text)
                Me.DialogResult = DialogResult.OK
            End If
        Else
            lblErreurUtilisateur.Visible = True
            LblErreurMDP.Visible = False
        End If

    End Sub

    Private Sub btnInscrire_Click(sender As Object, e As EventArgs) Handles btnInscrire.Click
        Dim frmInscription As New frmInscrire(_dicoUsers)
        If frmInscription.ShowDialog() = DialogResult.OK Then
            txtLogin.Text = frmInscription.DonnerCle()
            txtMdp.Focus()
        End If
    End Sub
End Class