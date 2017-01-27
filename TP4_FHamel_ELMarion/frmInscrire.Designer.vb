<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInscrire
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
        Me.btnInscrire = New System.Windows.Forms.Button()
        Me.LblErreurPsw1 = New System.Windows.Forms.Label()
        Me.txtPsw1 = New System.Windows.Forms.TextBox()
        Me.LabelMDP = New System.Windows.Forms.Label()
        Me.lblErreurUtilisateur = New System.Windows.Forms.Label()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.LabelUser = New System.Windows.Forms.Label()
        Me.lblErreurPsw2 = New System.Windows.Forms.Label()
        Me.txtPsw2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnInscrire
        '
        Me.btnInscrire.Location = New System.Drawing.Point(109, 321)
        Me.btnInscrire.Name = "btnInscrire"
        Me.btnInscrire.Size = New System.Drawing.Size(133, 33)
        Me.btnInscrire.TabIndex = 24
        Me.btnInscrire.Text = "S'inscrire"
        Me.btnInscrire.UseVisualStyleBackColor = True
        '
        'LblErreurPsw1
        '
        Me.LblErreurPsw1.AutoSize = True
        Me.LblErreurPsw1.ForeColor = System.Drawing.Color.Red
        Me.LblErreurPsw1.Location = New System.Drawing.Point(23, 186)
        Me.LblErreurPsw1.Name = "LblErreurPsw1"
        Me.LblErreurPsw1.Size = New System.Drawing.Size(173, 20)
        Me.LblErreurPsw1.TabIndex = 21
        Me.LblErreurPsw1.Text = "*Mot de passe invalide"
        Me.LblErreurPsw1.Visible = False
        '
        'txtPsw1
        '
        Me.txtPsw1.Location = New System.Drawing.Point(27, 155)
        Me.txtPsw1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPsw1.Name = "txtPsw1"
        Me.txtPsw1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPsw1.Size = New System.Drawing.Size(303, 27)
        Me.txtPsw1.TabIndex = 20
        Me.txtPsw1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelMDP
        '
        Me.LabelMDP.AutoSize = True
        Me.LabelMDP.Location = New System.Drawing.Point(23, 131)
        Me.LabelMDP.Name = "LabelMDP"
        Me.LabelMDP.Size = New System.Drawing.Size(112, 20)
        Me.LabelMDP.TabIndex = 19
        Me.LabelMDP.Text = "Mot de passe :"
        '
        'lblErreurUtilisateur
        '
        Me.lblErreurUtilisateur.AutoSize = True
        Me.lblErreurUtilisateur.ForeColor = System.Drawing.Color.Red
        Me.lblErreurUtilisateur.Location = New System.Drawing.Point(23, 94)
        Me.lblErreurUtilisateur.Name = "lblErreurUtilisateur"
        Me.lblErreurUtilisateur.Size = New System.Drawing.Size(116, 20)
        Me.lblErreurUtilisateur.TabIndex = 18
        Me.lblErreurUtilisateur.Text = "*Nom invalide"
        Me.lblErreurUtilisateur.Visible = False
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(27, 63)
        Me.txtLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(303, 27)
        Me.txtLogin.TabIndex = 17
        Me.txtLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelUser
        '
        Me.LabelUser.AutoSize = True
        Me.LabelUser.Location = New System.Drawing.Point(23, 39)
        Me.LabelUser.Name = "LabelUser"
        Me.LabelUser.Size = New System.Drawing.Size(143, 20)
        Me.LabelUser.TabIndex = 16
        Me.LabelUser.Text = "Nom d'utilisateur :"
        '
        'lblErreurPsw2
        '
        Me.lblErreurPsw2.AutoSize = True
        Me.lblErreurPsw2.ForeColor = System.Drawing.Color.Red
        Me.lblErreurPsw2.Location = New System.Drawing.Point(23, 279)
        Me.lblErreurPsw2.Name = "lblErreurPsw2"
        Me.lblErreurPsw2.Size = New System.Drawing.Size(308, 20)
        Me.lblErreurPsw2.TabIndex = 27
        Me.lblErreurPsw2.Text = "*Les mots de passes ne correspondent pas"
        Me.lblErreurPsw2.Visible = False
        '
        'txtPsw2
        '
        Me.txtPsw2.Location = New System.Drawing.Point(27, 248)
        Me.txtPsw2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPsw2.Name = "txtPsw2"
        Me.txtPsw2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPsw2.Size = New System.Drawing.Size(303, 27)
        Me.txtPsw2.TabIndex = 23
        Me.txtPsw2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 224)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 20)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Répéter le mot de passe :"
        '
        'frmInscrire
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(352, 380)
        Me.Controls.Add(Me.lblErreurPsw2)
        Me.Controls.Add(Me.txtPsw2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnInscrire)
        Me.Controls.Add(Me.LblErreurPsw1)
        Me.Controls.Add(Me.txtPsw1)
        Me.Controls.Add(Me.LabelMDP)
        Me.Controls.Add(Me.lblErreurUtilisateur)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.LabelUser)
        Me.Font = New System.Drawing.Font("Calisto MT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmInscrire"
        Me.Text = "Inscription"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnInscrire As Button
    Friend WithEvents LblErreurPsw1 As Label
    Friend WithEvents txtPsw1 As TextBox
    Friend WithEvents LabelMDP As Label
    Friend WithEvents lblErreurUtilisateur As Label
    Friend WithEvents txtLogin As TextBox
    Friend WithEvents LabelUser As Label
    Friend WithEvents lblErreurPsw2 As Label
    Friend WithEvents txtPsw2 As TextBox
    Friend WithEvents Label2 As Label
End Class
