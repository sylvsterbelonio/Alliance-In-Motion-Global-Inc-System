<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemList
    Inherits System.Windows.Forms.Form

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
        Me.MyToolStripExtension1 = New PowerNET8.MyToolStripExtension
        Me.tsAdd = New System.Windows.Forms.ToolStripButton
        Me.tsEdit = New System.Windows.Forms.ToolStripButton
        Me.tsSave = New System.Windows.Forms.ToolStripButton
        Me.tsCancel = New System.Windows.Forms.ToolStripButton
        Me.tsPrint = New System.Windows.Forms.ToolStripButton
        Me.pcImage = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtProductName = New System.Windows.Forms.TextBox
        Me.txtCommissionalPoints = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtPositionalPoints = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtSRP = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtDistributorPrice = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtProfit = New System.Windows.Forms.TextBox
        Me.txtRemarks = New System.Windows.Forms.TextBox
        Me.lnkRemove = New System.Windows.Forms.LinkLabel
        Me.lnkUpload = New System.Windows.Forms.LinkLabel
        Me.Label8 = New System.Windows.Forms.Label
        Me.MyToolStripExtension1.SuspendLayout()
        CType(Me.pcImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MyToolStripExtension1
        '
        Me.MyToolStripExtension1.AutoSize = False
        Me.MyToolStripExtension1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.MyToolStripExtension1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsAdd, Me.tsEdit, Me.tsSave, Me.tsCancel, Me.tsPrint})
        Me.MyToolStripExtension1.Location = New System.Drawing.Point(0, 0)
        Me.MyToolStripExtension1.My_BackGround_BorderColor = System.Drawing.Color.White
        Me.MyToolStripExtension1.My_BackGround_BottomColor1 = System.Drawing.Color.LightGray
        Me.MyToolStripExtension1.My_BackGround_BottomColor2 = System.Drawing.Color.White
        Me.MyToolStripExtension1.My_BackGround_Has_Border = True
        Me.MyToolStripExtension1.My_BackGround_Style = PowerNET8.MyToolStripExtension.BackStyle.Standard
        Me.MyToolStripExtension1.My_BackGround_TopColor1 = System.Drawing.Color.White
        Me.MyToolStripExtension1.My_BackGround_TopColor2 = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.MyToolStripExtension1.My_Selection_Style = PowerNET8.MyToolStripExtension.SelectStyleType.Standard
        Me.MyToolStripExtension1.My_Selection_Style_Custom_Select_BorderColor = System.Drawing.Color.Black
        Me.MyToolStripExtension1.My_Selection_Style_Custom_Select_BottomColor1 = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MyToolStripExtension1.My_Selection_Style_Custom_Select_BottomColor2 = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.MyToolStripExtension1.My_Selection_Style_Custom_Select_Has_Border = True
        Me.MyToolStripExtension1.My_Selection_Style_Custom_Select_TopColor1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MyToolStripExtension1.My_Selection_Style_Custom_Select_TopColor2 = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.MyToolStripExtension1.My_Selection_Style_Custom_UnSelect_BorderColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.MyToolStripExtension1.My_Selection_Style_Custom_UnSelect_BottomColor1 = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.MyToolStripExtension1.My_Selection_Style_Custom_UnSelect_BottomColor2 = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.MyToolStripExtension1.My_Selection_Style_Custom_UnSelect_Has_Border = True
        Me.MyToolStripExtension1.My_Selection_Style_Custom_UnSelect_TopColor1 = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.MyToolStripExtension1.My_Selection_Style_Custom_UnSelect_TopColor2 = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.MyToolStripExtension1.My_Standard_Select_FontColor = System.Drawing.Color.DarkGray
        Me.MyToolStripExtension1.My_Standard_Selection_BackColor = System.Drawing.Color.LightSteelBlue
        Me.MyToolStripExtension1.My_Standard_UnSelect_FontColor = System.Drawing.Color.White
        Me.MyToolStripExtension1.My_Transparent_Effect = False
        Me.MyToolStripExtension1.Name = "MyToolStripExtension1"
        Me.MyToolStripExtension1.Size = New System.Drawing.Size(469, 37)
        Me.MyToolStripExtension1.TabIndex = 0
        Me.MyToolStripExtension1.Text = "MyToolStripExtension1"
        '
        'tsAdd
        '
        Me.tsAdd.Image = Global.AIMGS.My.Resources.Resources.add1
        Me.tsAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsAdd.Name = "tsAdd"
        Me.tsAdd.Size = New System.Drawing.Size(33, 34)
        Me.tsAdd.Text = "Add"
        Me.tsAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsEdit
        '
        Me.tsEdit.Image = Global.AIMGS.My.Resources.Resources.pencil
        Me.tsEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsEdit.Name = "tsEdit"
        Me.tsEdit.Size = New System.Drawing.Size(31, 34)
        Me.tsEdit.Text = "Edit"
        Me.tsEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsSave
        '
        Me.tsSave.Image = Global.AIMGS.My.Resources.Resources.save
        Me.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSave.Name = "tsSave"
        Me.tsSave.Size = New System.Drawing.Size(35, 34)
        Me.tsSave.Text = "Save"
        Me.tsSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsCancel
        '
        Me.tsCancel.Image = Global.AIMGS.My.Resources.Resources._erase
        Me.tsCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsCancel.Name = "tsCancel"
        Me.tsCancel.Size = New System.Drawing.Size(47, 34)
        Me.tsCancel.Text = "Cancel"
        Me.tsCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsPrint
        '
        Me.tsPrint.Image = Global.AIMGS.My.Resources.Resources.printer_1_icon
        Me.tsPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsPrint.Name = "tsPrint"
        Me.tsPrint.Size = New System.Drawing.Size(47, 34)
        Me.tsPrint.Text = "Cancel"
        Me.tsPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsPrint.Visible = False
        '
        'pcImage
        '
        Me.pcImage.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pcImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pcImage.Location = New System.Drawing.Point(10, 52)
        Me.pcImage.Name = "pcImage"
        Me.pcImage.Size = New System.Drawing.Size(110, 102)
        Me.pcImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcImage.TabIndex = 2
        Me.pcImage.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(128, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Product Name"
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(229, 56)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(228, 20)
        Me.txtProductName.TabIndex = 4
        Me.txtProductName.Tag = "Product Name"
        '
        'txtCommissionalPoints
        '
        Me.txtCommissionalPoints.Location = New System.Drawing.Point(229, 162)
        Me.txtCommissionalPoints.Name = "txtCommissionalPoints"
        Me.txtCommissionalPoints.Size = New System.Drawing.Size(227, 20)
        Me.txtCommissionalPoints.TabIndex = 8
        Me.txtCommissionalPoints.Tag = "Commissional Points"
        Me.txtCommissionalPoints.Text = "0"
        Me.txtCommissionalPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(128, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Commissional Points"
        '
        'txtPositionalPoints
        '
        Me.txtPositionalPoints.Location = New System.Drawing.Point(229, 188)
        Me.txtPositionalPoints.Name = "txtPositionalPoints"
        Me.txtPositionalPoints.Size = New System.Drawing.Size(227, 20)
        Me.txtPositionalPoints.TabIndex = 10
        Me.txtPositionalPoints.Tag = "Positional Points"
        Me.txtPositionalPoints.Text = "0.0000"
        Me.txtPositionalPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(128, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Positional Points"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(229, 82)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescription.Size = New System.Drawing.Size(228, 72)
        Me.txtDescription.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(128, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Description"
        '
        'txtSRP
        '
        Me.txtSRP.Location = New System.Drawing.Point(229, 266)
        Me.txtSRP.Name = "txtSRP"
        Me.txtSRP.Size = New System.Drawing.Size(227, 20)
        Me.txtSRP.TabIndex = 16
        Me.txtSRP.Tag = "SRP"
        Me.txtSRP.Text = "0.00"
        Me.txtSRP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(128, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Distributor Price"
        '
        'txtDistributorPrice
        '
        Me.txtDistributorPrice.Location = New System.Drawing.Point(229, 215)
        Me.txtDistributorPrice.Name = "txtDistributorPrice"
        Me.txtDistributorPrice.Size = New System.Drawing.Size(227, 20)
        Me.txtDistributorPrice.TabIndex = 12
        Me.txtDistributorPrice.Tag = "Distributor Price"
        Me.txtDistributorPrice.Text = "0.00"
        Me.txtDistributorPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(129, 271)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "SRP"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(129, 246)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Profit"
        '
        'txtProfit
        '
        Me.txtProfit.Location = New System.Drawing.Point(229, 240)
        Me.txtProfit.Name = "txtProfit"
        Me.txtProfit.Size = New System.Drawing.Size(227, 20)
        Me.txtProfit.TabIndex = 14
        Me.txtProfit.Tag = "Profit"
        Me.txtProfit.Text = "0.00"
        Me.txtProfit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(230, 296)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRemarks.Size = New System.Drawing.Size(224, 72)
        Me.txtRemarks.TabIndex = 18
        '
        'lnkRemove
        '
        Me.lnkRemove.AutoSize = True
        Me.lnkRemove.Location = New System.Drawing.Point(62, 158)
        Me.lnkRemove.Name = "lnkRemove"
        Me.lnkRemove.Size = New System.Drawing.Size(47, 13)
        Me.lnkRemove.TabIndex = 2
        Me.lnkRemove.TabStop = True
        Me.lnkRemove.Text = "Remove"
        '
        'lnkUpload
        '
        Me.lnkUpload.AutoSize = True
        Me.lnkUpload.Location = New System.Drawing.Point(23, 158)
        Me.lnkUpload.Name = "lnkUpload"
        Me.lnkUpload.Size = New System.Drawing.Size(41, 13)
        Me.lnkUpload.TabIndex = 1
        Me.lnkUpload.TabStop = True
        Me.lnkUpload.Text = "Upload"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(129, 299)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Remarks"
        '
        'frmItemList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 380)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lnkUpload)
        Me.Controls.Add(Me.lnkRemove)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtProfit)
        Me.Controls.Add(Me.txtDistributorPrice)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtSRP)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtPositionalPoints)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCommissionalPoints)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pcImage)
        Me.Controls.Add(Me.MyToolStripExtension1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmItemList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item List"
        Me.MyToolStripExtension1.ResumeLayout(False)
        Me.MyToolStripExtension1.PerformLayout()
        CType(Me.pcImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MyToolStripExtension1 As PowerNET8.MyToolStripExtension
    Friend WithEvents tsAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents pcImage As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtProductName As System.Windows.Forms.TextBox
    Friend WithEvents txtCommissionalPoints As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPositionalPoints As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSRP As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDistributorPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtProfit As System.Windows.Forms.TextBox
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents lnkRemove As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkUpload As System.Windows.Forms.LinkLabel
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
