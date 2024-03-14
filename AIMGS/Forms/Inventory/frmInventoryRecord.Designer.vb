<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventoryRecord
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.cmdItemConfig = New PowerNET8.My8Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.itemOrdered = New System.Windows.Forms.LinkLabel
        Me.itemSold = New System.Windows.Forms.LinkLabel
        Me.lblTypeItems = New System.Windows.Forms.Label
        Me.lnkTypeofItems = New System.Windows.Forms.LinkLabel
        Me.cmdOrder = New PowerNET8.My8Button
        Me.My8Button2 = New PowerNET8.My8Button
        Me.dgvDetails = New System.Windows.Forms.DataGridView
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewImageColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblitemAvailable = New System.Windows.Forms.Label
        Me.lblItemQOrdered = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblItemTypeAvailable = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdItemConfig
        '
        Me.cmdItemConfig.BorderColors = System.Drawing.Color.White
        Me.cmdItemConfig.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdItemConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cmdItemConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.cmdItemConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdItemConfig.IconTypes = PowerNET8.myIcons.Share.General.IconLibraryTypes.Jquery
        Me.cmdItemConfig.ImageSize = New System.Drawing.Size(24, 24)
        Me.cmdItemConfig.JqueryIconColorHover = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.carrat_1_ne
        Me.cmdItemConfig.JqueryIconTypes = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.NotSet
        Me.cmdItemConfig.JqueryMobileIconColor = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconColor.NotSet
        Me.cmdItemConfig.JqueryMobileIconTypes = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet
        Me.cmdItemConfig.Location = New System.Drawing.Point(386, 83)
        Me.cmdItemConfig.MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.cmdItemConfig.MouseOverForecolor = System.Drawing.Color.White
        Me.cmdItemConfig.MousePressedBackColor = System.Drawing.Color.White
        Me.cmdItemConfig.MousePressedForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.cmdItemConfig.Name = "cmdItemConfig"
        Me.cmdItemConfig.Size = New System.Drawing.Size(75, 31)
        Me.cmdItemConfig.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.Blue
        Me.cmdItemConfig.TabIndex = 5
        Me.cmdItemConfig.Text = "Item Config"
        Me.cmdItemConfig.UseVisualStyleBackColor = True
        Me.cmdItemConfig.Windows8IconTypes = PowerNET8.myIcons.Share.Windows8.Windows8IconTypes.NotSet
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.lblItemTypeAvailable)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblItemQOrdered)
        Me.GroupBox1.Controls.Add(Me.lblitemAvailable)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.itemOrdered)
        Me.GroupBox1.Controls.Add(Me.itemSold)
        Me.GroupBox1.Controls.Add(Me.lblTypeItems)
        Me.GroupBox1.Controls.Add(Me.lnkTypeofItems)
        Me.GroupBox1.Location = New System.Drawing.Point(467, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 387)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'itemOrdered
        '
        Me.itemOrdered.AutoSize = True
        Me.itemOrdered.Location = New System.Drawing.Point(11, 94)
        Me.itemOrdered.Name = "itemOrdered"
        Me.itemOrdered.Size = New System.Drawing.Size(110, 13)
        Me.itemOrdered.TabIndex = 4
        Me.itemOrdered.TabStop = True
        Me.itemOrdered.Text = "Item Quantity Ordered"
        '
        'itemSold
        '
        Me.itemSold.AutoSize = True
        Me.itemSold.Location = New System.Drawing.Point(11, 113)
        Me.itemSold.Name = "itemSold"
        Me.itemSold.Size = New System.Drawing.Size(93, 13)
        Me.itemSold.TabIndex = 2
        Me.itemSold.TabStop = True
        Me.itemSold.Text = "Item Quantity Sold"
        '
        'lblTypeItems
        '
        Me.lblTypeItems.Location = New System.Drawing.Point(107, 20)
        Me.lblTypeItems.Name = "lblTypeItems"
        Me.lblTypeItems.Size = New System.Drawing.Size(87, 24)
        Me.lblTypeItems.TabIndex = 1
        Me.lblTypeItems.Text = "0"
        Me.lblTypeItems.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lnkTypeofItems
        '
        Me.lnkTypeofItems.AutoSize = True
        Me.lnkTypeofItems.Location = New System.Drawing.Point(11, 20)
        Me.lnkTypeofItems.Name = "lnkTypeofItems"
        Me.lnkTypeofItems.Size = New System.Drawing.Size(71, 13)
        Me.lnkTypeofItems.TabIndex = 0
        Me.lnkTypeofItems.TabStop = True
        Me.lnkTypeofItems.Text = "Type of Items"
        '
        'cmdOrder
        '
        Me.cmdOrder.BorderColors = System.Drawing.Color.White
        Me.cmdOrder.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cmdOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdOrder.IconTypes = PowerNET8.myIcons.Share.General.IconLibraryTypes.Jquery
        Me.cmdOrder.ImageSize = New System.Drawing.Size(24, 24)
        Me.cmdOrder.JqueryIconColorHover = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.carrat_1_ne
        Me.cmdOrder.JqueryIconTypes = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.NotSet
        Me.cmdOrder.JqueryMobileIconColor = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconColor.NotSet
        Me.cmdOrder.JqueryMobileIconTypes = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet
        Me.cmdOrder.Location = New System.Drawing.Point(7, 83)
        Me.cmdOrder.MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdOrder.MouseOverForecolor = System.Drawing.Color.White
        Me.cmdOrder.MousePressedBackColor = System.Drawing.Color.White
        Me.cmdOrder.MousePressedForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdOrder.Name = "cmdOrder"
        Me.cmdOrder.Size = New System.Drawing.Size(75, 31)
        Me.cmdOrder.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.Green
        Me.cmdOrder.TabIndex = 7
        Me.cmdOrder.Text = "Order"
        Me.cmdOrder.UseVisualStyleBackColor = True
        Me.cmdOrder.Windows8IconTypes = PowerNET8.myIcons.Share.Windows8.Windows8IconTypes.NotSet
        '
        'My8Button2
        '
        Me.My8Button2.BorderColors = System.Drawing.Color.White
        Me.My8Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.My8Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.My8Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.My8Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.My8Button2.IconTypes = PowerNET8.myIcons.Share.General.IconLibraryTypes.Jquery
        Me.My8Button2.ImageSize = New System.Drawing.Size(24, 24)
        Me.My8Button2.JqueryIconColorHover = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.carrat_1_ne
        Me.My8Button2.JqueryIconTypes = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.NotSet
        Me.My8Button2.JqueryMobileIconColor = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconColor.NotSet
        Me.My8Button2.JqueryMobileIconTypes = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet
        Me.My8Button2.Location = New System.Drawing.Point(88, 83)
        Me.My8Button2.MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.My8Button2.MouseOverForecolor = System.Drawing.Color.White
        Me.My8Button2.MousePressedBackColor = System.Drawing.Color.White
        Me.My8Button2.MousePressedForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.My8Button2.Name = "My8Button2"
        Me.My8Button2.Size = New System.Drawing.Size(75, 31)
        Me.My8Button2.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.Red
        Me.My8Button2.TabIndex = 8
        Me.My8Button2.Text = "Dispose"
        Me.My8Button2.UseVisualStyleBackColor = True
        Me.My8Button2.Windows8IconTypes = PowerNET8.myIcons.Share.Windows8.Windows8IconTypes.NotSet
        '
        'dgvDetails
        '
        Me.dgvDetails.AllowUserToAddRows = False
        Me.dgvDetails.AllowUserToDeleteRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.LemonChiffon
        Me.dgvDetails.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvDetails.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvDetails.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDetails.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvDetails.GridColor = System.Drawing.Color.White
        Me.dgvDetails.Location = New System.Drawing.Point(7, 120)
        Me.dgvDetails.MultiSelect = False
        Me.dgvDetails.Name = "dgvDetails"
        Me.dgvDetails.ReadOnly = True
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetails.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvDetails.RowTemplate.Height = 50
        Me.dgvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetails.ShowCellErrors = False
        Me.dgvDetails.ShowCellToolTips = False
        Me.dgvDetails.ShowEditingIcon = False
        Me.dgvDetails.ShowRowErrors = False
        Me.dgvDetails.Size = New System.Drawing.Size(454, 339)
        Me.dgvDetails.TabIndex = 16
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.AIMGS.My.Resources.Resources.Banner_Images_edited
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(673, 66)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = ""
        Me.Column2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.Column2.MinimumWidth = 50
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column2.Width = 50
        '
        'Column3
        '
        Me.Column3.HeaderText = "Product Name"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 240
        '
        'Column4
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle8
        Me.Column4.HeaderText = "Quantity"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Item Quantity Available"
        '
        'lblitemAvailable
        '
        Me.lblitemAvailable.Location = New System.Drawing.Point(144, 75)
        Me.lblitemAvailable.Name = "lblitemAvailable"
        Me.lblitemAvailable.Size = New System.Drawing.Size(50, 19)
        Me.lblitemAvailable.TabIndex = 6
        Me.lblitemAvailable.Text = "0"
        Me.lblitemAvailable.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblItemQOrdered
        '
        Me.lblItemQOrdered.Location = New System.Drawing.Point(127, 94)
        Me.lblItemQOrdered.Name = "lblItemQOrdered"
        Me.lblItemQOrdered.Size = New System.Drawing.Size(67, 19)
        Me.lblItemQOrdered.TabIndex = 7
        Me.lblItemQOrdered.Text = "0"
        Me.lblItemQOrdered.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(107, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "0"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblItemTypeAvailable
        '
        Me.lblItemTypeAvailable.Location = New System.Drawing.Point(144, 57)
        Me.lblItemTypeAvailable.Name = "lblItemTypeAvailable"
        Me.lblItemTypeAvailable.Size = New System.Drawing.Size(50, 19)
        Me.lblItemTypeAvailable.TabIndex = 10
        Me.lblItemTypeAvailable.Text = "0"
        Me.lblItemTypeAvailable.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Item Type Available"
        '
        'frmInventoryRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 463)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dgvDetails)
        Me.Controls.Add(Me.My8Button2)
        Me.Controls.Add(Me.cmdOrder)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdItemConfig)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmInventoryRecord"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory Record Status Board"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdItemConfig As PowerNET8.My8Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTypeItems As System.Windows.Forms.Label
    Friend WithEvents lnkTypeofItems As System.Windows.Forms.LinkLabel
    Friend WithEvents cmdOrder As PowerNET8.My8Button
    Friend WithEvents My8Button2 As PowerNET8.My8Button
    Friend WithEvents dgvDetails As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents itemSold As System.Windows.Forms.LinkLabel
    Friend WithEvents itemOrdered As System.Windows.Forms.LinkLabel
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblItemQOrdered As System.Windows.Forms.Label
    Friend WithEvents lblitemAvailable As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblItemTypeAvailable As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
