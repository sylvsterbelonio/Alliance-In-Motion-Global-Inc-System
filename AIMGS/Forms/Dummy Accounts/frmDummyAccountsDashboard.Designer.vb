<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDummyAccountsDashboard
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDummyAccountsDashboard))
        Me.Label1 = New System.Windows.Forms.Label
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenDummyAccountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblDblocked = New System.Windows.Forms.LinkLabel
        Me.lblDInactive = New System.Windows.Forms.LinkLabel
        Me.lblDActive = New System.Windows.Forms.LinkLabel
        Me.lblAllDummies = New System.Windows.Forms.LinkLabel
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.csRefresh = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdTodoList = New PowerNET8.My7GlassButton
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.lblCaption = New System.Windows.Forms.Label
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "All Dummies Account:"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.csRefresh, Me.OpenDummyAccountsToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(203, 48)
        '
        'OpenDummyAccountsToolStripMenuItem
        '
        Me.OpenDummyAccountsToolStripMenuItem.Name = "OpenDummyAccountsToolStripMenuItem"
        Me.OpenDummyAccountsToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.OpenDummyAccountsToolStripMenuItem.Text = "Open Dummy Accounts"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GroupBox1.Controls.Add(Me.lblDblocked)
        Me.GroupBox1.Controls.Add(Me.lblDInactive)
        Me.GroupBox1.Controls.Add(Me.lblDActive)
        Me.GroupBox1.Controls.Add(Me.lblAllDummies)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(436, 145)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(187, 109)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DUMMY ACCOUNTS"
        '
        'lblDblocked
        '
        Me.lblDblocked.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lblDblocked.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDblocked.Location = New System.Drawing.Point(75, 79)
        Me.lblDblocked.Name = "lblDblocked"
        Me.lblDblocked.Size = New System.Drawing.Size(100, 23)
        Me.lblDblocked.TabIndex = 8
        Me.lblDblocked.TabStop = True
        Me.lblDblocked.Text = "0/20"
        Me.lblDblocked.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDInactive
        '
        Me.lblDInactive.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lblDInactive.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDInactive.Location = New System.Drawing.Point(75, 61)
        Me.lblDInactive.Name = "lblDInactive"
        Me.lblDInactive.Size = New System.Drawing.Size(100, 23)
        Me.lblDInactive.TabIndex = 7
        Me.lblDInactive.TabStop = True
        Me.lblDInactive.Text = "0/20"
        Me.lblDInactive.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDActive
        '
        Me.lblDActive.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lblDActive.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDActive.Location = New System.Drawing.Point(75, 43)
        Me.lblDActive.Name = "lblDActive"
        Me.lblDActive.Size = New System.Drawing.Size(100, 23)
        Me.lblDActive.TabIndex = 6
        Me.lblDActive.TabStop = True
        Me.lblDActive.Text = "0/20"
        Me.lblDActive.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAllDummies
        '
        Me.lblAllDummies.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lblAllDummies.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAllDummies.Location = New System.Drawing.Point(127, 24)
        Me.lblAllDummies.Name = "lblAllDummies"
        Me.lblAllDummies.Size = New System.Drawing.Size(48, 23)
        Me.lblAllDummies.TabIndex = 5
        Me.lblAllDummies.TabStop = True
        Me.lblAllDummies.Text = "0/20"
        Me.lblAllDummies.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Blocked"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Inactive"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Active"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox2.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(5, 146)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(425, 108)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "YOUR ACCOUNT"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(251, 69)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Experience:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(251, 53)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Next Level:"
        '
        'Label9
        '
        Me.Label9.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(389, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 31)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "1"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(362, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Lvl"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Your Last Log In:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(68, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "All Dummies Account:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Name:"
        '
        'csRefresh
        '
        Me.csRefresh.Image = Global.AIMGS.My.Resources.Resources.refresh_xxl
        Me.csRefresh.Name = "csRefresh"
        Me.csRefresh.Size = New System.Drawing.Size(202, 22)
        Me.csRefresh.Text = "Refresh"
        '
        'cmdTodoList
        '
        Me.cmdTodoList.Arrow = PowerNET8.My7GlassButton.MB_Arrow.None
        Me.cmdTodoList.BackColor = System.Drawing.Color.Transparent
        Me.cmdTodoList.BaseColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.cmdTodoList.BaseStrokeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdTodoList.FlatAppearance.BorderSize = 0
        Me.cmdTodoList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdTodoList.GroupPosition = PowerNET8.My7GlassButton.MB_GroupPos.None
        Me.cmdTodoList.Image = Global.AIMGS.My.Resources.Resources.todolist
        Me.cmdTodoList.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdTodoList.ImageSize = New System.Drawing.Size(64, 64)
        Me.cmdTodoList.Location = New System.Drawing.Point(7, 260)
        Me.cmdTodoList.MenuListPosition = New System.Drawing.Point(0, 0)
        Me.cmdTodoList.Name = "cmdTodoList"
        Me.cmdTodoList.OnColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.cmdTodoList.OnStrokeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.cmdTodoList.PressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdTodoList.PressStrokeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdTodoList.Radius = 24
        Me.cmdTodoList.ShowBase = PowerNET8.My7GlassButton.MB_ShowBase.Yes
        Me.cmdTodoList.Size = New System.Drawing.Size(93, 101)
        Me.cmdTodoList.SplitButton = PowerNET8.My7GlassButton.MB_SplitButton.No
        Me.cmdTodoList.SplitLocation = PowerNET8.My7GlassButton.MB_SplitLocation.Bottom
        Me.cmdTodoList.TabIndex = 5
        Me.cmdTodoList.Text = "To Do List"
        Me.cmdTodoList.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdTodoList.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.AIMGS.My.Resources.Resources.blue_banner_by_abhishekghosh
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 533)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(629, 27)
        Me.Panel2.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.AIMGS.My.Resources.Resources.Banner_Images_edited
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(629, 140)
        Me.Panel1.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lblCaption)
        Me.Panel3.Location = New System.Drawing.Point(8, 465)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(615, 62)
        Me.Panel3.TabIndex = 6
        '
        'lblCaption
        '
        Me.lblCaption.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaption.ForeColor = System.Drawing.Color.Red
        Me.lblCaption.Location = New System.Drawing.Point(14, 0)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(585, 62)
        Me.lblCaption.TabIndex = 0
        Me.lblCaption.Text = "* YOU NEED BECOME LVL 4 to unlock TO DO LIST"
        Me.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmDummyAccountsDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(629, 560)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmdTodoList)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDummyAccountsDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dummy Accounts - Dashboard"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents csRefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenDummyAccountsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblAllDummies As System.Windows.Forms.LinkLabel
    Friend WithEvents lblDblocked As System.Windows.Forms.LinkLabel
    Friend WithEvents lblDInactive As System.Windows.Forms.LinkLabel
    Friend WithEvents lblDActive As System.Windows.Forms.LinkLabel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdTodoList As PowerNET8.My7GlassButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblCaption As System.Windows.Forms.Label
End Class
