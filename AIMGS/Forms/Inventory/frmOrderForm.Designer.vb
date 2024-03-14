<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.dgvDetails = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewImageColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column7 = New System.Windows.Forms.DataGridViewButtonColumn
        Me.pcImage = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmdAccept = New PowerNET8.My8Button
        Me.cmdSelect = New PowerNET8.My8Button
        Me.cmdDecline = New PowerNET8.My8Button
        Me.txtQuantity = New System.Windows.Forms.NumericUpDown
        Me.lblDistributorPrice = New System.Windows.Forms.Label
        Me.lblProductName = New System.Windows.Forms.Label
        Me.cmdOrderNow = New PowerNET8.My8Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblAmountOrdered = New System.Windows.Forms.Label
        Me.lblQuantityOrdered = New System.Windows.Forms.Label
        Me.lblTypeItems = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.udtDateOrdered = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtBCO = New System.Windows.Forms.TextBox
        CType(Me.dgvDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.udtDateOrdered, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDetails
        '
        Me.dgvDetails.AllowUserToAddRows = False
        Me.dgvDetails.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LemonChiffon
        Me.dgvDetails.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDetails.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvDetails.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column5, Me.Column4, Me.Column6, Me.Column7})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDetails.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvDetails.GridColor = System.Drawing.Color.White
        Me.dgvDetails.Location = New System.Drawing.Point(12, 108)
        Me.dgvDetails.MultiSelect = False
        Me.dgvDetails.Name = "dgvDetails"
        Me.dgvDetails.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetails.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvDetails.RowTemplate.Height = 50
        Me.dgvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetails.ShowCellErrors = False
        Me.dgvDetails.ShowCellToolTips = False
        Me.dgvDetails.ShowEditingIcon = False
        Me.dgvDetails.ShowRowErrors = False
        Me.dgvDetails.Size = New System.Drawing.Size(610, 249)
        Me.dgvDetails.TabIndex = 17
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
        Me.Column3.Width = 190
        '
        'Column5
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column5.HeaderText = "DP Price"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column4
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column4.HeaderText = "Quantity"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 80
        '
        'Column6
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column6.HeaderText = "Total Price"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.NullValue = "x"
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column7.HeaderText = ""
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column7.Width = 25
        '
        'pcImage
        '
        Me.pcImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pcImage.Location = New System.Drawing.Point(273, 12)
        Me.pcImage.Name = "pcImage"
        Me.pcImage.Size = New System.Drawing.Size(100, 90)
        Me.pcImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcImage.TabIndex = 18
        Me.pcImage.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(379, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Quantity"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(379, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Product Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(379, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Distributors Price"
        '
        'cmdAccept
        '
        Me.cmdAccept.BorderColors = System.Drawing.Color.White
        Me.cmdAccept.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdAccept.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cmdAccept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAccept.IconTypes = PowerNET8.myIcons.Share.General.IconLibraryTypes.Jquery
        Me.cmdAccept.ImageSize = New System.Drawing.Size(24, 24)
        Me.cmdAccept.JqueryIconColorHover = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.carrat_1_ne
        Me.cmdAccept.JqueryIconTypes = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.NotSet
        Me.cmdAccept.JqueryMobileIconColor = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconColor.NotSet
        Me.cmdAccept.JqueryMobileIconTypes = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet
        Me.cmdAccept.Location = New System.Drawing.Point(483, 72)
        Me.cmdAccept.MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdAccept.MouseOverForecolor = System.Drawing.Color.White
        Me.cmdAccept.MousePressedBackColor = System.Drawing.Color.White
        Me.cmdAccept.MousePressedForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdAccept.Name = "cmdAccept"
        Me.cmdAccept.Size = New System.Drawing.Size(64, 30)
        Me.cmdAccept.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.Green
        Me.cmdAccept.TabIndex = 23
        Me.cmdAccept.Text = "Accept"
        Me.cmdAccept.UseVisualStyleBackColor = True
        Me.cmdAccept.Windows8IconTypes = PowerNET8.myIcons.Share.Windows8.Windows8IconTypes.NotSet
        '
        'cmdSelect
        '
        Me.cmdSelect.BorderColors = System.Drawing.Color.White
        Me.cmdSelect.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cmdSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.cmdSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSelect.IconTypes = PowerNET8.myIcons.Share.General.IconLibraryTypes.Jquery
        Me.cmdSelect.ImageSize = New System.Drawing.Size(24, 24)
        Me.cmdSelect.JqueryIconColorHover = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.carrat_1_ne
        Me.cmdSelect.JqueryIconTypes = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.NotSet
        Me.cmdSelect.JqueryMobileIconColor = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconColor.NotSet
        Me.cmdSelect.JqueryMobileIconTypes = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet
        Me.cmdSelect.Location = New System.Drawing.Point(381, 63)
        Me.cmdSelect.MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.cmdSelect.MouseOverForecolor = System.Drawing.Color.White
        Me.cmdSelect.MousePressedBackColor = System.Drawing.Color.White
        Me.cmdSelect.MousePressedForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.cmdSelect.Name = "cmdSelect"
        Me.cmdSelect.Size = New System.Drawing.Size(240, 39)
        Me.cmdSelect.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.Blue
        Me.cmdSelect.TabIndex = 24
        Me.cmdSelect.Text = "Select"
        Me.cmdSelect.UseVisualStyleBackColor = True
        Me.cmdSelect.Windows8IconTypes = PowerNET8.myIcons.Share.Windows8.Windows8IconTypes.NotSet
        '
        'cmdDecline
        '
        Me.cmdDecline.BorderColors = System.Drawing.Color.White
        Me.cmdDecline.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdDecline.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cmdDecline.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.cmdDecline.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDecline.IconTypes = PowerNET8.myIcons.Share.General.IconLibraryTypes.Jquery
        Me.cmdDecline.ImageSize = New System.Drawing.Size(24, 24)
        Me.cmdDecline.JqueryIconColorHover = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.carrat_1_ne
        Me.cmdDecline.JqueryIconTypes = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.NotSet
        Me.cmdDecline.JqueryMobileIconColor = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconColor.NotSet
        Me.cmdDecline.JqueryMobileIconTypes = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet
        Me.cmdDecline.Location = New System.Drawing.Point(553, 72)
        Me.cmdDecline.MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.cmdDecline.MouseOverForecolor = System.Drawing.Color.White
        Me.cmdDecline.MousePressedBackColor = System.Drawing.Color.White
        Me.cmdDecline.MousePressedForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.cmdDecline.Name = "cmdDecline"
        Me.cmdDecline.Size = New System.Drawing.Size(69, 30)
        Me.cmdDecline.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.Red
        Me.cmdDecline.TabIndex = 25
        Me.cmdDecline.Text = "Decline"
        Me.cmdDecline.UseVisualStyleBackColor = True
        Me.cmdDecline.Windows8IconTypes = PowerNET8.myIcons.Share.Windows8.Windows8IconTypes.NotSet
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(382, 79)
        Me.txtQuantity.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.txtQuantity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(95, 20)
        Me.txtQuantity.TabIndex = 26
        Me.txtQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblDistributorPrice
        '
        Me.lblDistributorPrice.AutoSize = True
        Me.lblDistributorPrice.Location = New System.Drawing.Point(472, 37)
        Me.lblDistributorPrice.Name = "lblDistributorPrice"
        Me.lblDistributorPrice.Size = New System.Drawing.Size(28, 13)
        Me.lblDistributorPrice.TabIndex = 28
        Me.lblDistributorPrice.Text = "0.00"
        '
        'lblProductName
        '
        Me.lblProductName.AutoSize = True
        Me.lblProductName.Location = New System.Drawing.Point(472, 14)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(10, 13)
        Me.lblProductName.TabIndex = 27
        Me.lblProductName.Text = "-"
        '
        'cmdOrderNow
        '
        Me.cmdOrderNow.BorderColors = System.Drawing.Color.White
        Me.cmdOrderNow.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdOrderNow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cmdOrderNow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.cmdOrderNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdOrderNow.IconTypes = PowerNET8.myIcons.Share.General.IconLibraryTypes.Jquery
        Me.cmdOrderNow.ImageSize = New System.Drawing.Size(24, 24)
        Me.cmdOrderNow.JqueryIconColorHover = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.carrat_1_ne
        Me.cmdOrderNow.JqueryIconTypes = PowerNET8.myIcons.Share.Jquery.JqueryIconTypes.NotSet
        Me.cmdOrderNow.JqueryMobileIconColor = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconColor.NotSet
        Me.cmdOrderNow.JqueryMobileIconTypes = PowerNET8.myIcons.Share.JqueryMobile.JqueryMobileIconTypes.NotSet
        Me.cmdOrderNow.Location = New System.Drawing.Point(508, 363)
        Me.cmdOrderNow.MouseOverBackcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.cmdOrderNow.MouseOverForecolor = System.Drawing.Color.White
        Me.cmdOrderNow.MousePressedBackColor = System.Drawing.Color.White
        Me.cmdOrderNow.MousePressedForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.cmdOrderNow.Name = "cmdOrderNow"
        Me.cmdOrderNow.Size = New System.Drawing.Size(114, 48)
        Me.cmdOrderNow.Standard_ThemeColor = PowerNET8.myColor.Share.SystemColor.BackgroundColor.StandardColor.DColors.Blue
        Me.cmdOrderNow.TabIndex = 29
        Me.cmdOrderNow.Text = "Order Now"
        Me.cmdOrderNow.UseVisualStyleBackColor = True
        Me.cmdOrderNow.Windows8IconTypes = PowerNET8.myIcons.Share.Windows8.Windows8IconTypes.NotSet
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.lblAmountOrdered)
        Me.GroupBox1.Controls.Add(Me.lblQuantityOrdered)
        Me.GroupBox1.Controls.Add(Me.lblTypeItems)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(255, 90)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Order Report Summary"
        '
        'lblAmountOrdered
        '
        Me.lblAmountOrdered.Location = New System.Drawing.Point(176, 64)
        Me.lblAmountOrdered.Name = "lblAmountOrdered"
        Me.lblAmountOrdered.Size = New System.Drawing.Size(71, 13)
        Me.lblAmountOrdered.TabIndex = 5
        Me.lblAmountOrdered.Text = "0.00"
        Me.lblAmountOrdered.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblQuantityOrdered
        '
        Me.lblQuantityOrdered.Location = New System.Drawing.Point(176, 42)
        Me.lblQuantityOrdered.Name = "lblQuantityOrdered"
        Me.lblQuantityOrdered.Size = New System.Drawing.Size(71, 13)
        Me.lblQuantityOrdered.TabIndex = 4
        Me.lblQuantityOrdered.Text = "0"
        Me.lblQuantityOrdered.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTypeItems
        '
        Me.lblTypeItems.Location = New System.Drawing.Point(176, 20)
        Me.lblTypeItems.Name = "lblTypeItems"
        Me.lblTypeItems.Size = New System.Drawing.Size(71, 13)
        Me.lblTypeItems.TabIndex = 3
        Me.lblTypeItems.Text = "0"
        Me.lblTypeItems.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Type of Items"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Total Amount of Ordered"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Quantity Items Ordered"
        '
        'udtDateOrdered
        '
        Me.udtDateOrdered.Location = New System.Drawing.Point(131, 390)
        Me.udtDateOrdered.Name = "udtDateOrdered"
        Me.udtDateOrdered.Size = New System.Drawing.Size(144, 21)
        Me.udtDateOrdered.TabIndex = 31
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 394)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 13)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Date Ordered"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 369)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Business Center Office"
        '
        'txtBCO
        '
        Me.txtBCO.Location = New System.Drawing.Point(131, 362)
        Me.txtBCO.Name = "txtBCO"
        Me.txtBCO.Size = New System.Drawing.Size(371, 20)
        Me.txtBCO.TabIndex = 34
        '
        'frmOrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 419)
        Me.Controls.Add(Me.txtBCO)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.udtDateOrdered)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdOrderNow)
        Me.Controls.Add(Me.lblDistributorPrice)
        Me.Controls.Add(Me.lblProductName)
        Me.Controls.Add(Me.cmdSelect)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.cmdDecline)
        Me.Controls.Add(Me.cmdAccept)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pcImage)
        Me.Controls.Add(Me.dgvDetails)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOrderForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order Products"
        CType(Me.dgvDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.udtDateOrdered, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvDetails As System.Windows.Forms.DataGridView
    Friend WithEvents pcImage As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdAccept As PowerNET8.My8Button
    Friend WithEvents cmdSelect As PowerNET8.My8Button
    Friend WithEvents cmdDecline As PowerNET8.My8Button
    Friend WithEvents txtQuantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblDistributorPrice As System.Windows.Forms.Label
    Friend WithEvents lblProductName As System.Windows.Forms.Label
    Friend WithEvents cmdOrderNow As PowerNET8.My8Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblAmountOrdered As System.Windows.Forms.Label
    Friend WithEvents lblQuantityOrdered As System.Windows.Forms.Label
    Friend WithEvents lblTypeItems As System.Windows.Forms.Label
    Friend WithEvents udtDateOrdered As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtBCO As System.Windows.Forms.TextBox
End Class
