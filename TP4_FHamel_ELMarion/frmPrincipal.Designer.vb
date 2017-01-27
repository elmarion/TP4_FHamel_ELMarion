<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rBtnAucun
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rBtnAucun))
        Me.tvArbre = New System.Windows.Forms.TreeView()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MSConnexion = New System.Windows.Forms.ToolStripMenuItem()
        Me.DéconnexionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtContenu = New System.Windows.Forms.TextBox()
        Me.cbFiltres = New System.Windows.Forms.ComboBox()
        Me.rBtnCategorie = New System.Windows.Forms.RadioButton()
        Me.rBtnUtilisateur = New System.Windows.Forms.RadioButton()
        Me.rBtnUAucun = New System.Windows.Forms.RadioButton()
        Me.gbTrier = New System.Windows.Forms.GroupBox()
        Me.lbTrier = New System.Windows.Forms.ListBox()
        Me.btnThread = New System.Windows.Forms.Button()
        Me.btnCommentaire = New System.Windows.Forms.Button()
        Me.lblErreur = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout
        Me.gbTrier.SuspendLayout
        Me.SuspendLayout
        '
        'tvArbre
        '
        Me.tvArbre.Location = New System.Drawing.Point(92, 87)
        Me.tvArbre.Name = "tvArbre"
        Me.tvArbre.Size = New System.Drawing.Size(437, 426)
        Me.tvArbre.TabIndex = 0
        '
        'btnUp
        '
        Me.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUp.Image = CType(resources.GetObject("btnUp.Image"),System.Drawing.Image)
        Me.btnUp.Location = New System.Drawing.Point(22, 87)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(55, 55)
        Me.btnUp.TabIndex = 1
        Me.btnUp.UseVisualStyleBackColor = true
        '
        'btnDown
        '
        Me.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDown.Image = CType(resources.GetObject("btnDown.Image"),System.Drawing.Image)
        Me.btnDown.Location = New System.Drawing.Point(22, 148)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(55, 55)
        Me.btnDown.TabIndex = 2
        Me.btnDown.UseVisualStyleBackColor = true
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MSConnexion})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1349, 28)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MSConnexion
        '
        Me.MSConnexion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DéconnexionToolStripMenuItem})
        Me.MSConnexion.Font = New System.Drawing.Font("Calisto MT", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.MSConnexion.Name = "MSConnexion"
        Me.MSConnexion.Size = New System.Drawing.Size(100, 24)
        Me.MSConnexion.Text = "Connexion"
        '
        'DéconnexionToolStripMenuItem
        '
        Me.DéconnexionToolStripMenuItem.Name = "DéconnexionToolStripMenuItem"
        Me.DéconnexionToolStripMenuItem.Size = New System.Drawing.Size(173, 24)
        Me.DéconnexionToolStripMenuItem.Text = "Déconnexion"
        '
        'txtContenu
        '
        Me.txtContenu.Location = New System.Drawing.Point(562, 87)
        Me.txtContenu.Multiline = true
        Me.txtContenu.Name = "txtContenu"
        Me.txtContenu.Size = New System.Drawing.Size(325, 290)
        Me.txtContenu.TabIndex = 4
        '
        'cbFiltres
        '
        Me.cbFiltres.Font = New System.Drawing.Font("Calisto MT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cbFiltres.FormattingEnabled = true
        Me.cbFiltres.Location = New System.Drawing.Point(16, 79)
        Me.cbFiltres.Name = "cbFiltres"
        Me.cbFiltres.Size = New System.Drawing.Size(351, 24)
        Me.cbFiltres.TabIndex = 5
        '
        'rBtnCategorie
        '
        Me.rBtnCategorie.AutoSize = true
        Me.rBtnCategorie.Font = New System.Drawing.Font("Calisto MT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.rBtnCategorie.Location = New System.Drawing.Point(16, 47)
        Me.rBtnCategorie.Name = "rBtnCategorie"
        Me.rBtnCategorie.Size = New System.Drawing.Size(83, 20)
        Me.rBtnCategorie.TabIndex = 9
        Me.rBtnCategorie.Text = "Catégorie"
        Me.rBtnCategorie.UseVisualStyleBackColor = true
        '
        'rBtnUtilisateur
        '
        Me.rBtnUtilisateur.AutoSize = true
        Me.rBtnUtilisateur.Font = New System.Drawing.Font("Calisto MT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.rBtnUtilisateur.Location = New System.Drawing.Point(136, 47)
        Me.rBtnUtilisateur.Name = "rBtnUtilisateur"
        Me.rBtnUtilisateur.Size = New System.Drawing.Size(93, 20)
        Me.rBtnUtilisateur.TabIndex = 10
        Me.rBtnUtilisateur.Text = "Utilisateurs"
        Me.rBtnUtilisateur.UseVisualStyleBackColor = true
        '
        'rBtnUAucun
        '
        Me.rBtnUAucun.AutoSize = true
        Me.rBtnUAucun.Checked = true
        Me.rBtnUAucun.Font = New System.Drawing.Font("Calisto MT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.rBtnUAucun.Location = New System.Drawing.Point(282, 47)
        Me.rBtnUAucun.Name = "rBtnUAucun"
        Me.rBtnUAucun.Size = New System.Drawing.Size(67, 20)
        Me.rBtnUAucun.TabIndex = 11
        Me.rBtnUAucun.TabStop = true
        Me.rBtnUAucun.Text = "Aucun"
        Me.rBtnUAucun.UseVisualStyleBackColor = true
        '
        'gbTrier
        '
        Me.gbTrier.Controls.Add(Me.rBtnUAucun)
        Me.gbTrier.Controls.Add(Me.rBtnCategorie)
        Me.gbTrier.Controls.Add(Me.cbFiltres)
        Me.gbTrier.Controls.Add(Me.rBtnUtilisateur)
        Me.gbTrier.Font = New System.Drawing.Font("Calisto MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.gbTrier.Location = New System.Drawing.Point(920, 87)
        Me.gbTrier.Name = "gbTrier"
        Me.gbTrier.Size = New System.Drawing.Size(392, 132)
        Me.gbTrier.TabIndex = 12
        Me.gbTrier.TabStop = false
        Me.gbTrier.Text = "Trier par "
        '
        'lbTrier
        '
        Me.lbTrier.FormattingEnabled = true
        Me.lbTrier.ItemHeight = 16
        Me.lbTrier.Location = New System.Drawing.Point(920, 236)
        Me.lbTrier.Name = "lbTrier"
        Me.lbTrier.Size = New System.Drawing.Size(392, 276)
        Me.lbTrier.TabIndex = 13
        '
        'btnThread
        '
        Me.btnThread.Location = New System.Drawing.Point(562, 411)
        Me.btnThread.Name = "btnThread"
        Me.btnThread.Size = New System.Drawing.Size(325, 39)
        Me.btnThread.TabIndex = 14
        Me.btnThread.Text = "Nouveau Thread"
        Me.btnThread.UseVisualStyleBackColor = true
        '
        'btnCommentaire
        '
        Me.btnCommentaire.Location = New System.Drawing.Point(562, 474)
        Me.btnCommentaire.Name = "btnCommentaire"
        Me.btnCommentaire.Size = New System.Drawing.Size(325, 39)
        Me.btnCommentaire.TabIndex = 15
        Me.btnCommentaire.Text = "Faire un commentaire"
        Me.btnCommentaire.UseVisualStyleBackColor = true
        '
        'lblErreur
        '
        Me.lblErreur.AutoSize = true
        Me.lblErreur.ForeColor = System.Drawing.Color.Red
        Me.lblErreur.Location = New System.Drawing.Point(88, 52)
        Me.lblErreur.Name = "lblErreur"
        Me.lblErreur.Size = New System.Drawing.Size(55, 17)
        Me.lblErreur.TabIndex = 16
        Me.lblErreur.Text = "*Erreur"
        Me.lblErreur.Visible = false
        '
        'rBtnAucun
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1349, 553)
        Me.Controls.Add(Me.lblErreur)
        Me.Controls.Add(Me.btnCommentaire)
        Me.Controls.Add(Me.btnThread)
        Me.Controls.Add(Me.lbTrier)
        Me.Controls.Add(Me.gbTrier)
        Me.Controls.Add(Me.txtContenu)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.btnUp)
        Me.Controls.Add(Me.tvArbre)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Calisto MT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "rBtnAucun"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reddit - edit"
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        Me.gbTrier.ResumeLayout(false)
        Me.gbTrier.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents tvArbre As TreeView
    Friend WithEvents btnUp As Button
    Friend WithEvents btnDown As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MSConnexion As ToolStripMenuItem
    Friend WithEvents txtContenu As TextBox
    Friend WithEvents cbFiltres As ComboBox
    Friend WithEvents rBtnCategorie As RadioButton
    Friend WithEvents rBtnUtilisateur As RadioButton
    Friend WithEvents rBtnUAucun As RadioButton
    Friend WithEvents gbTrier As GroupBox
    Friend WithEvents lbTrier As ListBox
    Friend WithEvents btnThread As Button
    Friend WithEvents btnCommentaire As Button
    Friend WithEvents lblErreur As Label
    Friend WithEvents DéconnexionToolStripMenuItem As ToolStripMenuItem
End Class
