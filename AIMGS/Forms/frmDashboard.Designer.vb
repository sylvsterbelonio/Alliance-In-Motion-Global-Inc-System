<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboard
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
        Me.MyMenuStripExtension1 = New PowerNET8.MyMenuStripExtension
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Button1 = New System.Windows.Forms.Button
        Me.cmdDummyAccounts = New System.Windows.Forms.Button
        Me.tsAddNewProspect = New System.Windows.Forms.ToolStripButton
        Me.MyToolStripExtension1.SuspendLayout()
        Me.MyMenuStripExtension1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MyToolStripExtension1
        '
        Me.MyToolStripExtension1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsAddNewProspect})
        Me.MyToolStripExtension1.Location = New System.Drawing.Point(0, 24)
        Me.MyToolStripExtension1.My_BackGround_BorderColor = System.Drawing.Color.White
        Me.MyToolStripExtension1.My_BackGround_BottomColor1 = System.Drawing.Color.LightGray
        Me.MyToolStripExtension1.My_BackGround_BottomColor2 = System.Drawing.Color.White
        Me.MyToolStripExtension1.My_BackGround_Has_Border = False
        Me.MyToolStripExtension1.My_BackGround_Style = PowerNET8.MyToolStripExtension.BackStyle.VerticalGradient
        Me.MyToolStripExtension1.My_BackGround_TopColor1 = System.Drawing.Color.White
        Me.MyToolStripExtension1.My_BackGround_TopColor2 = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.MyToolStripExtension1.My_Selection_Style = PowerNET8.MyToolStripExtension.SelectStyleType.Standard
        Me.MyToolStripExtension1.My_Selection_Style_Custom_Select_BorderColor = System.Drawing.Color.Black
        Me.MyToolStripExtension1.My_Selection_Style_Custom_Select_BottomColor1 = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MyToolStripExtension1.My_Selection_Style_Custom_Select_BottomColor2 = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.MyToolStripExtension1.My_Selection_Style_Custom_Select_Has_Border = False
        Me.MyToolStripExtension1.My_Selection_Style_Custom_Select_TopColor1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MyToolStripExtension1.My_Selection_Style_Custom_Select_TopColor2 = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.MyToolStripExtension1.My_Selection_Style_Custom_UnSelect_BorderColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.MyToolStripExtension1.My_Selection_Style_Custom_UnSelect_BottomColor1 = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.MyToolStripExtension1.My_Selection_Style_Custom_UnSelect_BottomColor2 = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.MyToolStripExtension1.My_Selection_Style_Custom_UnSelect_Has_Border = False
        Me.MyToolStripExtension1.My_Selection_Style_Custom_UnSelect_TopColor1 = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.MyToolStripExtension1.My_Selection_Style_Custom_UnSelect_TopColor2 = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.MyToolStripExtension1.My_Standard_Select_FontColor = System.Drawing.Color.DarkBlue
        Me.MyToolStripExtension1.My_Standard_Selection_BackColor = System.Drawing.Color.SteelBlue
        Me.MyToolStripExtension1.My_Standard_UnSelect_FontColor = System.Drawing.Color.Black
        Me.MyToolStripExtension1.My_Transparent_Effect = False
        Me.MyToolStripExtension1.Name = "MyToolStripExtension1"
        Me.MyToolStripExtension1.Size = New System.Drawing.Size(528, 25)
        Me.MyToolStripExtension1.TabIndex = 2
        Me.MyToolStripExtension1.Text = "MyToolStripExtension1"
        '
        'MyMenuStripExtension1
        '
        Me.MyMenuStripExtension1.BackColor = System.Drawing.Color.Gray
        Me.MyMenuStripExtension1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MyMenuStripExtension1.Location = New System.Drawing.Point(0, 0)
        Me.MyMenuStripExtension1.My_BackGround_BorderColor = System.Drawing.Color.SteelBlue
        Me.MyMenuStripExtension1.My_BackGround_BottomColor1 = System.Drawing.Color.LightGray
        Me.MyMenuStripExtension1.My_BackGround_BottomColor2 = System.Drawing.Color.White
        Me.MyMenuStripExtension1.My_BackGround_HasBorder = False
        Me.MyMenuStripExtension1.My_BackGround_Style = PowerNET8.MyMenuStripExtension.BackStyle.Standard
        Me.MyMenuStripExtension1.My_BackGround_TopColor1 = System.Drawing.Color.White
        Me.MyMenuStripExtension1.My_BackGround_TopColor2 = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.MyMenuStripExtension1.My_Selection_Style = PowerNET8.MyMenuStripExtension.SelectStyleType.Standard
        Me.MyMenuStripExtension1.My_Selection_Style_Custom_Select_BorderColor = System.Drawing.Color.Black
        Me.MyMenuStripExtension1.My_Selection_Style_Custom_Select_BottomColor1 = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MyMenuStripExtension1.My_Selection_Style_Custom_Select_BottomColor2 = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.MyMenuStripExtension1.My_Selection_Style_Custom_Select_Has_Border = True
        Me.MyMenuStripExtension1.My_Selection_Style_Custom_Select_TopColor1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MyMenuStripExtension1.My_Selection_Style_Custom_Select_TopColor2 = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.MyMenuStripExtension1.My_Selection_Style_Custom_UnSelect_BorderColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.MyMenuStripExtension1.My_Selection_Style_Custom_UnSelect_BottomColor1 = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.MyMenuStripExtension1.My_Selection_Style_Custom_UnSelect_BottomColor2 = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.MyMenuStripExtension1.My_Selection_Style_Custom_UnSelect_Has_Border = True
        Me.MyMenuStripExtension1.My_Selection_Style_Custom_UnSelect_TopColor1 = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.MyMenuStripExtension1.My_Selection_Style_Custom_UnSelect_TopColor2 = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.MyMenuStripExtension1.My_Standard_Select_FontColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MyMenuStripExtension1.My_Standard_Selection_BackColor = System.Drawing.Color.BlanchedAlmond
        Me.MyMenuStripExtension1.My_Standard_UnSelect_FontColor = System.Drawing.Color.White
        Me.MyMenuStripExtension1.Name = "MyMenuStripExtension1"
        Me.MyMenuStripExtension1.Size = New System.Drawing.Size(528, 24)
        Me.MyMenuStripExtension1.TabIndex = 3
        Me.MyMenuStripExtension1.Text = "MyMenuStripExtension1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "&View"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(245, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 85)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Just Do It Task"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmdDummyAccounts
        '
        Me.cmdDummyAccounts.Location = New System.Drawing.Point(141, 64)
        Me.cmdDummyAccounts.Name = "cmdDummyAccounts"
        Me.cmdDummyAccounts.Size = New System.Drawing.Size(98, 85)
        Me.cmdDummyAccounts.TabIndex = 5
        Me.cmdDummyAccounts.Text = "Dummy Accounts"
        Me.cmdDummyAccounts.UseVisualStyleBackColor = True
        '
        'tsAddNewProspect
        '
        Me.tsAddNewProspect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsAddNewProspect.Image = Global.AIMGS.My.Resources.Resources.add1
        Me.tsAddNewProspect.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsAddNewProspect.Name = "tsAddNewProspect"
        Me.tsAddNewProspect.Size = New System.Drawing.Size(23, 22)
        Me.tsAddNewProspect.Text = "Add New Prospect"
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(528, 298)
        Me.Controls.Add(Me.cmdDummyAccounts)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MyToolStripExtension1)
        Me.Controls.Add(Me.MyMenuStripExtension1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alliance In Motion Global Inc. - Automated Record and Monitoring System"
        Me.MyToolStripExtension1.ResumeLayout(False)
        Me.MyToolStripExtension1.PerformLayout()
        Me.MyMenuStripExtension1.ResumeLayout(False)
        Me.MyMenuStripExtension1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MyToolStripExtension1 As PowerNET8.MyToolStripExtension
    Friend WithEvents tsAddNewProspect As System.Windows.Forms.ToolStripButton
    Friend WithEvents MyMenuStripExtension1 As PowerNET8.MyMenuStripExtension
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmdDummyAccounts As System.Windows.Forms.Button

End Class
