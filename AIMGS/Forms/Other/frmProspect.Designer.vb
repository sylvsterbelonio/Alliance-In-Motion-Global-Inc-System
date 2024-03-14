<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProspect
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.txtMiddleName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.optM = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.optF = New System.Windows.Forms.RadioButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.cboMonth = New System.Windows.Forms.ComboBox
        Me.cboDay = New System.Windows.Forms.ComboBox
        Me.txtYear = New System.Windows.Forms.MaskedTextBox
        Me.txtMNo = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtFB = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.cboStatus = New System.Windows.Forms.ComboBox
        Me.txtRemarks = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.MyToolStripExtension1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MyToolStripExtension1
        '
        Me.MyToolStripExtension1.AutoSize = False
        Me.MyToolStripExtension1.BackColor = System.Drawing.Color.MediumTurquoise
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
        Me.MyToolStripExtension1.My_Standard_Selection_BackColor = System.Drawing.Color.SteelBlue
        Me.MyToolStripExtension1.My_Standard_UnSelect_FontColor = System.Drawing.Color.White
        Me.MyToolStripExtension1.My_Transparent_Effect = False
        Me.MyToolStripExtension1.Name = "MyToolStripExtension1"
        Me.MyToolStripExtension1.Size = New System.Drawing.Size(362, 37)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "FirstName"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(87, 47)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(260, 20)
        Me.txtFirstName.TabIndex = 2
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Location = New System.Drawing.Point(87, 73)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(260, 20)
        Me.txtMiddleName.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Middle Name"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(87, 99)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(260, 20)
        Me.txtLastName.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Last Name"
        '
        'optM
        '
        Me.optM.AutoSize = True
        Me.optM.Checked = True
        Me.optM.Location = New System.Drawing.Point(234, 127)
        Me.optM.Name = "optM"
        Me.optM.Size = New System.Drawing.Size(48, 17)
        Me.optM.TabIndex = 8
        Me.optM.TabStop = True
        Me.optM.Text = "Male"
        Me.optM.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(168, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Gender"
        '
        'optF
        '
        Me.optF.AutoSize = True
        Me.optF.Location = New System.Drawing.Point(288, 127)
        Me.optF.Name = "optF"
        Me.optF.Size = New System.Drawing.Size(59, 17)
        Me.optF.TabIndex = 9
        Me.optF.Text = "Female"
        Me.optF.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Birthdate"
        '
        'cboMonth
        '
        Me.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonth.FormattingEnabled = True
        Me.cboMonth.Items.AddRange(New Object() {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"})
        Me.cboMonth.Location = New System.Drawing.Point(87, 155)
        Me.cboMonth.Name = "cboMonth"
        Me.cboMonth.Size = New System.Drawing.Size(137, 21)
        Me.cboMonth.TabIndex = 11
        '
        'cboDay
        '
        Me.cboDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDay.FormattingEnabled = True
        Me.cboDay.Items.AddRange(New Object() {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"})
        Me.cboDay.Location = New System.Drawing.Point(234, 155)
        Me.cboDay.Name = "cboDay"
        Me.cboDay.Size = New System.Drawing.Size(48, 21)
        Me.cboDay.TabIndex = 12
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(292, 156)
        Me.txtYear.Mask = "0000"
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(55, 20)
        Me.txtYear.TabIndex = 13
        Me.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMNo
        '
        Me.txtMNo.Location = New System.Drawing.Point(87, 209)
        Me.txtMNo.Name = "txtMNo"
        Me.txtMNo.Size = New System.Drawing.Size(260, 20)
        Me.txtMNo.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Mobile No."
        '
        'txtFB
        '
        Me.txtFB.Location = New System.Drawing.Point(87, 183)
        Me.txtFB.Name = "txtFB"
        Me.txtFB.Size = New System.Drawing.Size(260, 20)
        Me.txtFB.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "FB Link"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 239)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Status"
        '
        'cboStatus
        '
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Not Presented", "Undecided", "Not Interested", "Interested"})
        Me.cboStatus.Location = New System.Drawing.Point(87, 235)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(260, 21)
        Me.cboStatus.TabIndex = 19
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(87, 262)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(260, 108)
        Me.txtRemarks.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 265)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Remarks"
        '
        'frmProspect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(362, 382)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.cboStatus)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtFB)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtMNo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.cboDay)
        Me.Controls.Add(Me.cboMonth)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.optF)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.optM)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMiddleName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MyToolStripExtension1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmProspect"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Prospect Form"
        Me.MyToolStripExtension1.ResumeLayout(False)
        Me.MyToolStripExtension1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MyToolStripExtension1 As PowerNET8.MyToolStripExtension
    Friend WithEvents tsAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtMiddleName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents optM As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents optF As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboMonth As System.Windows.Forms.ComboBox
    Friend WithEvents cboDay As System.Windows.Forms.ComboBox
    Friend WithEvents txtYear As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtMNo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtFB As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tsPrint As System.Windows.Forms.ToolStripButton
End Class
