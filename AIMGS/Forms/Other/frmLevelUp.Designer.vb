<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLevelUp
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lvlLevel = New System.Windows.Forms.Label
        Me.lblRank = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtNextRank = New System.Windows.Forms.TextBox
        Me.imgRank = New System.Windows.Forms.PictureBox
        CType(Me.imgRank, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Green
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(32, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "YOU ARE NOW"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Green
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(96, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "LEVEL"
        '
        'lvlLevel
        '
        Me.lvlLevel.BackColor = System.Drawing.Color.Green
        Me.lvlLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvlLevel.ForeColor = System.Drawing.Color.White
        Me.lvlLevel.Location = New System.Drawing.Point(94, 69)
        Me.lvlLevel.Name = "lvlLevel"
        Me.lvlLevel.Size = New System.Drawing.Size(97, 114)
        Me.lvlLevel.TabIndex = 2
        Me.lvlLevel.Text = "-"
        Me.lvlLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRank
        '
        Me.lblRank.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRank.ForeColor = System.Drawing.Color.Green
        Me.lblRank.Location = New System.Drawing.Point(412, 46)
        Me.lblRank.Name = "lblRank"
        Me.lblRank.Size = New System.Drawing.Size(345, 66)
        Me.lblRank.TabIndex = 4
        Me.lblRank.Text = "Private 1st Class"
        Me.lblRank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Green
        Me.Label5.Location = New System.Drawing.Point(412, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 31)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "RANK:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Green
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(257, 215)
        Me.Panel1.TabIndex = 6
        '
        'txtNextRank
        '
        Me.txtNextRank.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNextRank.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNextRank.ForeColor = System.Drawing.Color.Green
        Me.txtNextRank.Location = New System.Drawing.Point(413, 116)
        Me.txtNextRank.Multiline = True
        Me.txtNextRank.Name = "txtNextRank"
        Me.txtNextRank.ReadOnly = True
        Me.txtNextRank.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNextRank.Size = New System.Drawing.Size(344, 111)
        Me.txtNextRank.TabIndex = 7
        Me.txtNextRank.Text = "-"
        '
        'imgRank
        '
        Me.imgRank.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.imgRank.Location = New System.Drawing.Point(275, 12)
        Me.imgRank.Name = "imgRank"
        Me.imgRank.Size = New System.Drawing.Size(131, 215)
        Me.imgRank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgRank.TabIndex = 3
        Me.imgRank.TabStop = False
        '
        'frmLevelUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(769, 239)
        Me.Controls.Add(Me.txtNextRank)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblRank)
        Me.Controls.Add(Me.imgRank)
        Me.Controls.Add(Me.lvlLevel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLevelUp"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.imgRank, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lvlLevel As System.Windows.Forms.Label
    Friend WithEvents imgRank As System.Windows.Forms.PictureBox
    Friend WithEvents lblRank As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtNextRank As System.Windows.Forms.TextBox
End Class
