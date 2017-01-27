<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConnexion
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelUser = New System.Windows.Forms.Label()
        Me.lblErreurUtilisateur = New System.Windows.Forms.Label()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.LblErreurMDP = New System.Windows.Forms.Label()
        Me.txtMdp = New System.Windows.Forms.TextBox()
        Me.LabelMDP = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.LabelPasCompte = New System.Windows.Forms.Label()
        Me.btnInscrire = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelUser
        '
        Me.LabelUser.AutoSize = True
        Me.LabelUser.Location = New System.Drawing.Point(48, 38)
        Me.LabelUser.Name = "LabelUser"
        Me.LabelUser.Size = New System.Drawing.Size(143, 20)
        Me.LabelUser.TabIndex = 0
        Me.LabelUser.Text = "Nom d'utilisateur :"
        '
        'lblErreurUtilisateur
        '
        Me.lblErreurUtilisateur.AutoSize = True
        Me.lblErreurUtilisateur.ForeColor = System.Drawing.Color.Red
        Me.lblErreurUtilisateur.Location = New System.Drawing.Point(48, 93)
        Me.lblErreurUtilisateur.Name = "lblErreurUtilisateur"
        Me.lblErreurUtilisateur.Size = New System.Drawing.Size(116, 20)
        Me.lblErreurUtilisateur.TabIndex = 9
        Me.lblErreurUtilisateur.Text = "*Nom invalide"
        Me.lblErreurUtilisateur.Visible = False
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(52, 62)
        Me.txtLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(303, 27)
        Me.txtLogin.TabIndex = 7
        Me.txtLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblErreurMDP
        '
        Me.LblErreurMDP.AutoSize = True
        Me.LblErreurMDP.ForeColor = System.Drawing.Color.Red
        Me.LblErreurMDP.Location = New System.Drawing.Point(48, 185)
        Me.LblErreurMDP.Name = "LblErreurMDP"
        Me.LblErreurMDP.Size = New System.Drawing.Size(173, 20)
        Me.LblErreurMDP.TabIndex = 12
        Me.LblErreurMDP.Text = "*Mot de passe invalide"
        Me.LblErreurMDP.Visible = False
        '
        'txtMdp
        '
        Me.txtMdp.Location = New System.Drawing.Point(52, 154)
        Me.txtMdp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMdp.Name = "txtMdp"
        Me.txtMdp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMdp.Size = New System.Drawing.Size(303, 27)
        Me.txtMdp.TabIndex = 11
        Me.txtMdp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelMDP
        '
        Me.LabelMDP.AutoSize = True
        Me.LabelMDP.Location = New System.Drawing.Point(48, 130)
        Me.LabelMDP.Name = "LabelMDP"
        Me.LabelMDP.Size = New System.Drawing.Size(112, 20)
        Me.LabelMDP.TabIndex = 10
        Me.LabelMDP.Text = "Mot de passe :"
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(52, 244)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(133, 31)
        Me.btnOk.TabIndex = 13
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'LabelPasCompte
        '
        Me.LabelPasCompte.AutoSize = True
        Me.LabelPasCompte.ForeColor = System.Drawing.Color.Black
        Me.LabelPasCompte.Location = New System.Drawing.Point(227, 220)
        Me.LabelPasCompte.Name = "LabelPasCompte"
        Me.LabelPasCompte.Size = New System.Drawing.Size(123, 20)
        Me.LabelPasCompte.TabIndex = 14
        Me.LabelPasCompte.Text = "Pas de compte ?"
        '
        'btnInscrire
        '
        Me.btnInscrire.Location = New System.Drawing.Point(222, 244)
        Me.btnInscrire.Name = "btnInscrire"
        Me.btnInscrire.Size = New System.Drawing.Size(133, 33)
        Me.btnInscrire.TabIndex = 15
        Me.btnInscrire.Text = "S'inscrire"
        Me.btnInscrire.UseVisualStyleBackColor = True
        '
        'frmConnexion
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(403, 315)
        Me.Controls.Add(Me.btnInscrire)
        Me.Controls.Add(Me.LabelPasCompte)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.LblErreurMDP)
        Me.Controls.Add(Me.txtMdp)
        Me.Controls.Add(Me.LabelMDP)
        Me.Controls.Add(Me.lblErreurUtilisateur)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.LabelUser)
        Me.Font = New System.Drawing.Font("Calisto MT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmConnexion"
        Me.Text = "Connexion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelUser As Label
    Friend WithEvents lblErreurUtilisateur As Label
    Friend WithEvents txtLogin As TextBox
    Friend WithEvents LblErreurMDP As Label
    Friend WithEvents txtMdp As TextBox
    Friend WithEvents LabelMDP As Label
    Friend WithEvents btnOk As Button
    Friend WithEvents LabelPasCompte As Label
    Friend WithEvents btnInscrire As Button
End Class
