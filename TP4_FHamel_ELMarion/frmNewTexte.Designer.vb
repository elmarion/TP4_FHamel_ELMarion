<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewTexte
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
        Me.txtTitre = New System.Windows.Forms.TextBox()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.cbCategorie = New System.Windows.Forms.ComboBox()
        Me.txtAutreCategorie = New System.Windows.Forms.TextBox()
        Me.btnEnvoye = New System.Windows.Forms.Button()
        Me.lblErreurTitre = New System.Windows.Forms.Label()
        Me.lblErreurMessage = New System.Windows.Forms.Label()
        Me.lblErreurCategorie = New System.Windows.Forms.Label()
        Me.lblErreurNewCategorie = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtTitre
        '
        Me.txtTitre.Location = New System.Drawing.Point(99, 44)
        Me.txtTitre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTitre.Name = "txtTitre"
        Me.txtTitre.Size = New System.Drawing.Size(482, 28)
        Me.txtTitre.TabIndex = 0
        Me.txtTitre.Text = "TITRE"
        Me.txtTitre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(99, 98)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(481, 285)
        Me.txtMessage.TabIndex = 1
        '
        'cbCategorie
        '
        Me.cbCategorie.FormattingEnabled = True
        Me.cbCategorie.Location = New System.Drawing.Point(98, 423)
        Me.cbCategorie.Name = "cbCategorie"
        Me.cbCategorie.Size = New System.Drawing.Size(279, 29)
        Me.cbCategorie.TabIndex = 2
        Me.cbCategorie.Text = "Catégorie"
        Me.cbCategorie.Visible = False
        '
        'txtAutreCategorie
        '
        Me.txtAutreCategorie.Location = New System.Drawing.Point(98, 474)
        Me.txtAutreCategorie.Name = "txtAutreCategorie"
        Me.txtAutreCategorie.Size = New System.Drawing.Size(277, 28)
        Me.txtAutreCategorie.TabIndex = 3
        Me.txtAutreCategorie.Text = "Écrire la nouvelle catégorie"
        Me.txtAutreCategorie.Visible = False
        '
        'btnEnvoye
        '
        Me.btnEnvoye.Location = New System.Drawing.Point(416, 421)
        Me.btnEnvoye.Name = "btnEnvoye"
        Me.btnEnvoye.Size = New System.Drawing.Size(164, 31)
        Me.btnEnvoye.TabIndex = 4
        Me.btnEnvoye.Text = "Envoyé"
        Me.btnEnvoye.UseVisualStyleBackColor = True
        '
        'lblErreurTitre
        '
        Me.lblErreurTitre.AutoSize = True
        Me.lblErreurTitre.ForeColor = System.Drawing.Color.Red
        Me.lblErreurTitre.Location = New System.Drawing.Point(99, 16)
        Me.lblErreurTitre.Name = "lblErreurTitre"
        Me.lblErreurTitre.Size = New System.Drawing.Size(232, 22)
        Me.lblErreurTitre.TabIndex = 5
        Me.lblErreurTitre.Text = "*Vous devez mettre un titre"
        Me.lblErreurTitre.Visible = False
        '
        'lblErreurMessage
        '
        Me.lblErreurMessage.AutoSize = True
        Me.lblErreurMessage.ForeColor = System.Drawing.Color.Red
        Me.lblErreurMessage.Location = New System.Drawing.Point(99, 76)
        Me.lblErreurMessage.Name = "lblErreurMessage"
        Me.lblErreurMessage.Size = New System.Drawing.Size(340, 22)
        Me.lblErreurMessage.TabIndex = 6
        Me.lblErreurMessage.Text = "*Vous devez écrire au moins 3 caractères"
        Me.lblErreurMessage.Visible = False
        '
        'lblErreurCategorie
        '
        Me.lblErreurCategorie.AutoSize = True
        Me.lblErreurCategorie.ForeColor = System.Drawing.Color.Red
        Me.lblErreurCategorie.Location = New System.Drawing.Point(98, 396)
        Me.lblErreurCategorie.Name = "lblErreurCategorie"
        Me.lblErreurCategorie.Size = New System.Drawing.Size(281, 22)
        Me.lblErreurCategorie.TabIndex = 7
        Me.lblErreurCategorie.Text = "*Vous devez choisir une catégorie"
        Me.lblErreurCategorie.Visible = False
        '
        'lblErreurNewCategorie
        '
        Me.lblErreurNewCategorie.AutoSize = True
        Me.lblErreurNewCategorie.ForeColor = System.Drawing.Color.Red
        Me.lblErreurNewCategorie.Location = New System.Drawing.Point(96, 506)
        Me.lblErreurNewCategorie.Name = "lblErreurNewCategorie"
        Me.lblErreurNewCategorie.Size = New System.Drawing.Size(349, 22)
        Me.lblErreurNewCategorie.TabIndex = 8
        Me.lblErreurNewCategorie.Text = "*Vous devez entrer une nouvelle catégorie"
        Me.lblErreurNewCategorie.Visible = False
        '
        'frmNewTexte
        '
        Me.AcceptButton = Me.btnEnvoye
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(690, 549)
        Me.Controls.Add(Me.lblErreurNewCategorie)
        Me.Controls.Add(Me.lblErreurCategorie)
        Me.Controls.Add(Me.lblErreurMessage)
        Me.Controls.Add(Me.lblErreurTitre)
        Me.Controls.Add(Me.btnEnvoye)
        Me.Controls.Add(Me.txtAutreCategorie)
        Me.Controls.Add(Me.cbCategorie)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.txtTitre)
        Me.Font = New System.Drawing.Font("Calisto MT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmNewTexte"
        Me.Text = "frmNewTexte"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents txtTitre As TextBox
    Friend WithEvents txtMessage As TextBox
    Friend WithEvents cbCategorie As ComboBox
    Friend WithEvents txtAutreCategorie As TextBox
    Friend WithEvents btnEnvoye As Button
    Friend WithEvents lblErreurTitre As Label
    Friend WithEvents lblErreurMessage As Label
    Friend WithEvents lblErreurCategorie As Label
    Friend WithEvents lblErreurNewCategorie As Label
End Class
