<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_FichierConfiguration
    Inherits Telerik.WinControls.UI.RadForm

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_FichierConfiguration))
        Me.OpenFileFicCpta = New System.Windows.Forms.OpenFileDialog
        Me.FolderRepjournal = New System.Windows.Forms.FolderBrowserDialog
        Me.FolderRepsaving = New System.Windows.Forms.FolderBrowserDialog
        Me.OpenFileGesCom = New System.Windows.Forms.OpenFileDialog
        Me.FolderRepFact = New System.Windows.Forms.FolderBrowserDialog
        Me.FolderRepSave = New System.Windows.Forms.FolderBrowserDialog
        Me.OpenFileAccess = New System.Windows.Forms.OpenFileDialog
        Me.OpenProgExterne = New System.Windows.Forms.OpenFileDialog
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel
        Me.txtServeurSql = New Telerik.WinControls.UI.RadTextBox
        Me.txtBDSql = New Telerik.WinControls.UI.RadTextBox
        Me.txtPasswordSql = New Telerik.WinControls.UI.RadTextBox
        Me.txtuserSql = New Telerik.WinControls.UI.RadTextBox
        Me.BtnTestConnexion = New Telerik.WinControls.UI.RadButton
        Me.BtnFermer = New Telerik.WinControls.UI.RadButton
        Me.BtnSave = New Telerik.WinControls.UI.RadButton
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme
        Me.AquaTheme1 = New Telerik.WinControls.Themes.AquaTheme
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtServeurSql, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBDSql, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPasswordSql, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtuserSql, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnTestConnexion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnFermer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FolderRepjournal
        '
        Me.FolderRepjournal.RootFolder = System.Environment.SpecialFolder.DesktopDirectory
        Me.FolderRepjournal.ShowNewFolderButton = False
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Controls.Add(Me.RadLabel4)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel3)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel2)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel1)
        Me.RadGroupBox1.Controls.Add(Me.txtServeurSql)
        Me.RadGroupBox1.Controls.Add(Me.txtBDSql)
        Me.RadGroupBox1.Controls.Add(Me.txtPasswordSql)
        Me.RadGroupBox1.Controls.Add(Me.txtuserSql)
        Me.RadGroupBox1.HeaderText = "Zone de Configuration Serveur "
        Me.RadGroupBox1.Location = New System.Drawing.Point(8, 11)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(427, 151)
        Me.RadGroupBox1.TabIndex = 64
        Me.RadGroupBox1.Text = "Zone de Configuration Serveur "
        Me.RadGroupBox1.ThemeName = "Aqua"
        '
        'RadLabel4
        '
        Me.RadLabel4.Location = New System.Drawing.Point(31, 118)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(115, 18)
        Me.RadLabel4.TabIndex = 79
        Me.RadLabel4.Text = "Base de Données SQL"
        '
        'RadLabel3
        '
        Me.RadLabel3.Location = New System.Drawing.Point(31, 89)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(67, 18)
        Me.RadLabel3.TabIndex = 78
        Me.RadLabel3.Text = "Serveur SQL"
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(31, 58)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(73, 18)
        Me.RadLabel2.TabIndex = 77
        Me.RadLabel2.Text = "Mot de Passe"
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(31, 27)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(80, 18)
        Me.RadLabel1.TabIndex = 76
        Me.RadLabel1.Text = "Utilisateur SQL"
        '
        'txtServeurSql
        '
        Me.txtServeurSql.Location = New System.Drawing.Point(148, 87)
        Me.txtServeurSql.Name = "txtServeurSql"
        Me.txtServeurSql.Size = New System.Drawing.Size(247, 20)
        Me.txtServeurSql.TabIndex = 75
        Me.txtServeurSql.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBDSql
        '
        Me.txtBDSql.Location = New System.Drawing.Point(148, 118)
        Me.txtBDSql.Name = "txtBDSql"
        Me.txtBDSql.Size = New System.Drawing.Size(247, 20)
        Me.txtBDSql.TabIndex = 74
        Me.txtBDSql.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPasswordSql
        '
        Me.txtPasswordSql.Location = New System.Drawing.Point(148, 54)
        Me.txtPasswordSql.Name = "txtPasswordSql"
        Me.txtPasswordSql.PasswordChar = Global.Microsoft.VisualBasic.ChrW(64)
        Me.txtPasswordSql.Size = New System.Drawing.Size(247, 20)
        Me.txtPasswordSql.TabIndex = 73
        Me.txtPasswordSql.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtuserSql
        '
        Me.txtuserSql.Location = New System.Drawing.Point(148, 25)
        Me.txtuserSql.Name = "txtuserSql"
        Me.txtuserSql.Size = New System.Drawing.Size(247, 20)
        Me.txtuserSql.TabIndex = 72
        Me.txtuserSql.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnTestConnexion
        '
        Me.BtnTestConnexion.Image = Global.Maayane.My.Resources.Resources.fichiers_ini
        Me.BtnTestConnexion.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnTestConnexion.Location = New System.Drawing.Point(30, 179)
        Me.BtnTestConnexion.Name = "BtnTestConnexion"
        Me.BtnTestConnexion.Size = New System.Drawing.Size(124, 24)
        Me.BtnTestConnexion.TabIndex = 65
        Me.BtnTestConnexion.Text = "&Test Connexion"
        '
        'BtnFermer
        '
        Me.BtnFermer.Image = Global.Maayane.My.Resources.Resources.btSupprimer22
        Me.BtnFermer.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnFermer.Location = New System.Drawing.Point(294, 179)
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.Size = New System.Drawing.Size(110, 24)
        Me.BtnFermer.TabIndex = 63
        Me.BtnFermer.Text = "&Quitter"
        '
        'BtnSave
        '
        Me.BtnSave.Image = Global.Maayane.My.Resources.Resources.agt_action_success
        Me.BtnSave.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSave.Location = New System.Drawing.Point(176, 179)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(110, 24)
        Me.BtnSave.TabIndex = 62
        Me.BtnSave.Text = "&Enregistrer"
        '
        'Frm_FichierConfiguration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 213)
        Me.Controls.Add(Me.BtnTestConnexion)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.Controls.Add(Me.BtnFermer)
        Me.Controls.Add(Me.BtnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_FichierConfiguration"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fichier de Configuration"
        Me.ThemeName = "Windows8"
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtServeurSql, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBDSql, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPasswordSql, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtuserSql, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnTestConnexion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnFermer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileFicCpta As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FolderRepjournal As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents FolderRepsaving As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents OpenFileGesCom As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FolderRepFact As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents FolderRepSave As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents OpenFileAccess As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OpenProgExterne As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BtnSave As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnFermer As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtServeurSql As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtBDSql As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtPasswordSql As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtuserSql As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents BtnTestConnexion As Telerik.WinControls.UI.RadButton
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents AquaTheme1 As Telerik.WinControls.Themes.AquaTheme
End Class
