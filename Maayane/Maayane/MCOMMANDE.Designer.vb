<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MCOMMANDE
    Inherits Telerik.WinControls.UI.RadForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem
        Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MCOMMANDE))
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel
        Me.txtPiece = New Telerik.WinControls.UI.RadTextBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblsms = New Telerik.WinControls.UI.RadLabel
        Me.txtNcommande = New Telerik.WinControls.UI.RadTextBox
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel
        Me.GB = New Telerik.WinControls.UI.RadGroupBox
        Me.AquaTheme1 = New Telerik.WinControls.Themes.AquaTheme
        Me.BL = New Telerik.WinControls.UI.RadRadioButton
        Me.FC = New Telerik.WinControls.UI.RadRadioButton
        Me.F = New Telerik.WinControls.UI.RadRadioButton
        Me.ListPiece = New Telerik.WinControls.UI.RadDropDownList
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme
        Me.BtnMettreJour = New Telerik.WinControls.UI.RadButton
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPiece, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblsms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNcommande, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB.SuspendLayout()
        CType(Me.BL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.F, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListPiece, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnMettreJour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.RadLabel2.Location = New System.Drawing.Point(20, 90)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(124, 18)
        Me.RadLabel2.TabIndex = 1
        Me.RadLabel2.Text = "N° Pièce                     :"
        '
        'txtPiece
        '
        Me.txtPiece.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtPiece.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtPiece.Location = New System.Drawing.Point(148, 85)
        Me.txtPiece.Name = "txtPiece"
        Me.txtPiece.Size = New System.Drawing.Size(174, 20)
        Me.txtPiece.TabIndex = 6
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lblsms
        '
        Me.lblsms.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsms.ForeColor = System.Drawing.Color.Red
        Me.lblsms.Location = New System.Drawing.Point(69, 208)
        Me.lblsms.Name = "lblsms"
        Me.lblsms.Size = New System.Drawing.Size(2, 2)
        Me.lblsms.TabIndex = 11
        Me.lblsms.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNcommande
        '
        Me.txtNcommande.Location = New System.Drawing.Point(148, 114)
        Me.txtNcommande.Name = "txtNcommande"
        Me.txtNcommande.Size = New System.Drawing.Size(174, 20)
        Me.txtNcommande.TabIndex = 9
        Me.txtNcommande.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel5
        '
        Me.RadLabel5.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.RadLabel5.Location = New System.Drawing.Point(21, 116)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(124, 18)
        Me.RadLabel5.TabIndex = 8
        Me.RadLabel5.Text = "N° de Commande      :"
        '
        'GB
        '
        Me.GB.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.GB.Controls.Add(Me.F)
        Me.GB.Controls.Add(Me.FC)
        Me.GB.Controls.Add(Me.BL)
        Me.GB.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.GB.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
        Me.GB.HeaderText = "Types des Documents [Ventes]"
        Me.GB.Location = New System.Drawing.Point(15, 7)
        Me.GB.Name = "GB"
        Me.GB.Size = New System.Drawing.Size(314, 68)
        Me.GB.TabIndex = 12
        Me.GB.Text = "Types des Documents [Ventes]"
        Me.GB.ThemeName = "Aqua"
        CType(Me.GB.GetChildAt(0), Telerik.WinControls.UI.RadGroupBoxElement).InvalidateMeasureInMainLayout = 3
        CType(Me.GB.GetChildAt(0), Telerik.WinControls.UI.RadGroupBoxElement).BackColor2 = System.Drawing.SystemColors.ButtonHighlight
        CType(Me.GB.GetChildAt(0), Telerik.WinControls.UI.RadGroupBoxElement).BackColor3 = System.Drawing.Color.AliceBlue
        CType(Me.GB.GetChildAt(0), Telerik.WinControls.UI.RadGroupBoxElement).BorderLeftColor = System.Drawing.SystemColors.ActiveCaption
        CType(Me.GB.GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.LightSkyBlue
        '
        'BL
        '
        Me.BL.Location = New System.Drawing.Point(10, 35)
        Me.BL.Name = "BL"
        Me.BL.Size = New System.Drawing.Size(87, 18)
        Me.BL.TabIndex = 0
        Me.BL.Text = "Bon Livraison"
        '
        'FC
        '
        Me.FC.Location = New System.Drawing.Point(180, 35)
        Me.FC.Name = "FC"
        Me.FC.Size = New System.Drawing.Size(125, 18)
        Me.FC.TabIndex = 1
        Me.FC.Text = "Facture Comptabilisé"
        '
        'F
        '
        Me.F.Location = New System.Drawing.Point(111, 35)
        Me.F.Name = "F"
        Me.F.Size = New System.Drawing.Size(57, 18)
        Me.F.TabIndex = 2
        Me.F.Text = "Facture"
        '
        'ListPiece
        '
        Me.ListPiece.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem1.Text = "Bon de Livraison"
        RadListDataItem1.TextWrap = True
        RadListDataItem2.Text = "Facture Comptabilisé"
        RadListDataItem2.TextWrap = True
        RadListDataItem3.Text = "Facture"
        RadListDataItem3.TextWrap = True
        Me.ListPiece.Items.Add(RadListDataItem1)
        Me.ListPiece.Items.Add(RadListDataItem2)
        Me.ListPiece.Items.Add(RadListDataItem3)
        Me.ListPiece.Location = New System.Drawing.Point(3, 199)
        Me.ListPiece.Name = "ListPiece"
        Me.ListPiece.Size = New System.Drawing.Size(174, 20)
        Me.ListPiece.TabIndex = 14
        '
        'BtnMettreJour
        '
        Me.BtnMettreJour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnMettreJour.Enabled = False
        Me.BtnMettreJour.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnMettreJour.Image = Global.Maayane.My.Resources.Resources.AnalyzeWizard
        Me.BtnMettreJour.ImageAlignment = System.Drawing.ContentAlignment.TopRight
        Me.BtnMettreJour.Location = New System.Drawing.Point(150, 148)
        Me.BtnMettreJour.Name = "BtnMettreJour"
        Me.BtnMettreJour.Size = New System.Drawing.Size(174, 28)
        Me.BtnMettreJour.TabIndex = 4
        Me.BtnMettreJour.Text = "Mettre à jour"
        '
        'MCOMMANDE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 194)
        Me.Controls.Add(Me.ListPiece)
        Me.Controls.Add(Me.GB)
        Me.Controls.Add(Me.txtNcommande)
        Me.Controls.Add(Me.RadLabel5)
        Me.Controls.Add(Me.lblsms)
        Me.Controls.Add(Me.txtPiece)
        Me.Controls.Add(Me.BtnMettreJour)
        Me.Controls.Add(Me.RadLabel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MCOMMANDE"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modification du N° Commande (Maayane)"
        Me.ThemeName = "Windows8"
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPiece, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblsms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNcommande, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB.ResumeLayout(False)
        Me.GB.PerformLayout()
        CType(Me.BL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.F, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListPiece, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnMettreJour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents BtnMettreJour As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtPiece As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblsms As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtNcommande As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents GB As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents AquaTheme1 As Telerik.WinControls.Themes.AquaTheme
    Friend WithEvents FC As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents BL As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents F As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents ListPiece As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
End Class

