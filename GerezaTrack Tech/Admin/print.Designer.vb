<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class print
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbtaoutbreak = New System.Windows.Forms.RadioButton()
        Me.rbtstrikereport = New System.Windows.Forms.RadioButton()
        Me.rbtmaintainancereport = New System.Windows.Forms.RadioButton()
        Me.rbtcrimesreport = New System.Windows.Forms.RadioButton()
        Me.rbtinmaterelease = New System.Windows.Forms.RadioButton()
        Me.rbttransferreports = New System.Windows.Forms.RadioButton()
        Me.rbtvisitor = New System.Windows.Forms.RadioButton()
        Me.rbtuserreport = New System.Windows.Forms.RadioButton()
        Me.rbtinmatereport = New System.Windows.Forms.RadioButton()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.btnsearchinmateinreport = New System.Windows.Forms.Button()
        Me.txtsearchinmateinreport = New System.Windows.Forms.TextBox()
        Me.lblsearchlabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.rbtaoutbreak)
        Me.Panel1.Controls.Add(Me.rbtstrikereport)
        Me.Panel1.Controls.Add(Me.rbtmaintainancereport)
        Me.Panel1.Controls.Add(Me.rbtcrimesreport)
        Me.Panel1.Controls.Add(Me.rbtinmaterelease)
        Me.Panel1.Controls.Add(Me.rbttransferreports)
        Me.Panel1.Controls.Add(Me.rbtvisitor)
        Me.Panel1.Controls.Add(Me.rbtuserreport)
        Me.Panel1.Controls.Add(Me.rbtinmatereport)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(170, 650)
        Me.Panel1.TabIndex = 0
        '
        'rbtaoutbreak
        '
        Me.rbtaoutbreak.AutoSize = True
        Me.rbtaoutbreak.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbtaoutbreak.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtaoutbreak.Location = New System.Drawing.Point(15, 449)
        Me.rbtaoutbreak.Name = "rbtaoutbreak"
        Me.rbtaoutbreak.Size = New System.Drawing.Size(142, 21)
        Me.rbtaoutbreak.TabIndex = 14
        Me.rbtaoutbreak.Text = "Outbreak Reports"
        Me.rbtaoutbreak.UseVisualStyleBackColor = True
        '
        'rbtstrikereport
        '
        Me.rbtstrikereport.AutoSize = True
        Me.rbtstrikereport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbtstrikereport.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtstrikereport.Location = New System.Drawing.Point(15, 421)
        Me.rbtstrikereport.Name = "rbtstrikereport"
        Me.rbtstrikereport.Size = New System.Drawing.Size(119, 21)
        Me.rbtstrikereport.TabIndex = 13
        Me.rbtstrikereport.Text = "Strike Reports"
        Me.rbtstrikereport.UseVisualStyleBackColor = True
        '
        'rbtmaintainancereport
        '
        Me.rbtmaintainancereport.AutoSize = True
        Me.rbtmaintainancereport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbtmaintainancereport.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtmaintainancereport.Location = New System.Drawing.Point(15, 369)
        Me.rbtmaintainancereport.Name = "rbtmaintainancereport"
        Me.rbtmaintainancereport.Size = New System.Drawing.Size(111, 38)
        Me.rbtmaintainancereport.TabIndex = 12
        Me.rbtmaintainancereport.Text = "Maintainance" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Reports"
        Me.rbtmaintainancereport.UseVisualStyleBackColor = True
        '
        'rbtcrimesreport
        '
        Me.rbtcrimesreport.AutoSize = True
        Me.rbtcrimesreport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbtcrimesreport.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtcrimesreport.Location = New System.Drawing.Point(15, 338)
        Me.rbtcrimesreport.Name = "rbtcrimesreport"
        Me.rbtcrimesreport.Size = New System.Drawing.Size(122, 21)
        Me.rbtcrimesreport.TabIndex = 11
        Me.rbtcrimesreport.Text = "Crime Reports"
        Me.rbtcrimesreport.UseVisualStyleBackColor = True
        '
        'rbtinmaterelease
        '
        Me.rbtinmaterelease.AutoSize = True
        Me.rbtinmaterelease.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbtinmaterelease.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtinmaterelease.Location = New System.Drawing.Point(15, 294)
        Me.rbtinmaterelease.Name = "rbtinmaterelease"
        Me.rbtinmaterelease.Size = New System.Drawing.Size(132, 38)
        Me.rbtinmaterelease.TabIndex = 10
        Me.rbtinmaterelease.Text = "Inmate Release " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Reports"
        Me.rbtinmaterelease.UseVisualStyleBackColor = True
        '
        'rbttransferreports
        '
        Me.rbttransferreports.AutoSize = True
        Me.rbttransferreports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbttransferreports.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbttransferreports.Location = New System.Drawing.Point(15, 262)
        Me.rbttransferreports.Name = "rbttransferreports"
        Me.rbttransferreports.Size = New System.Drawing.Size(144, 21)
        Me.rbttransferreports.TabIndex = 9
        Me.rbttransferreports.Text = "Transfers Reports"
        Me.rbttransferreports.UseVisualStyleBackColor = True
        '
        'rbtvisitor
        '
        Me.rbtvisitor.AutoSize = True
        Me.rbtvisitor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbtvisitor.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtvisitor.Location = New System.Drawing.Point(15, 202)
        Me.rbtvisitor.Name = "rbtvisitor"
        Me.rbtvisitor.Size = New System.Drawing.Size(114, 21)
        Me.rbtvisitor.TabIndex = 8
        Me.rbtvisitor.Text = "Visitor Report"
        Me.rbtvisitor.UseVisualStyleBackColor = True
        '
        'rbtuserreport
        '
        Me.rbtuserreport.AutoSize = True
        Me.rbtuserreport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbtuserreport.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtuserreport.Location = New System.Drawing.Point(15, 233)
        Me.rbtuserreport.Name = "rbtuserreport"
        Me.rbtuserreport.Size = New System.Drawing.Size(121, 21)
        Me.rbtuserreport.TabIndex = 7
        Me.rbtuserreport.Text = "Users Reports"
        Me.rbtuserreport.UseVisualStyleBackColor = True
        '
        'rbtinmatereport
        '
        Me.rbtinmatereport.AutoSize = True
        Me.rbtinmatereport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbtinmatereport.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtinmatereport.Location = New System.Drawing.Point(15, 172)
        Me.rbtinmatereport.Name = "rbtinmatereport"
        Me.rbtinmatereport.Size = New System.Drawing.Size(118, 21)
        Me.rbtinmatereport.TabIndex = 5
        Me.rbtinmatereport.Text = "Inmate Report"
        Me.rbtinmatereport.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.GerezaTrack_Tech.My.Resources.Resources.home
        Me.Button4.Location = New System.Drawing.Point(0, 600)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(168, 48)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "  Dashboard"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.GerezaTrack_Tech.My.Resources.Resources.escape_room_logo_template_design___Made_with_PosterMyWall__1_
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(168, 152)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(170, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1074, 49)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(310, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(443, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "GENERATE PRINTABLE  REPORTS PLATFORM"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(170, 80)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1079, 569)
        Me.CrystalReportViewer1.TabIndex = 2
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'btnsearchinmateinreport
        '
        Me.btnsearchinmateinreport.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnsearchinmateinreport.BackColor = System.Drawing.Color.White
        Me.btnsearchinmateinreport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsearchinmateinreport.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnsearchinmateinreport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnsearchinmateinreport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnsearchinmateinreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsearchinmateinreport.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearchinmateinreport.Location = New System.Drawing.Point(1030, 51)
        Me.btnsearchinmateinreport.Name = "btnsearchinmateinreport"
        Me.btnsearchinmateinreport.Size = New System.Drawing.Size(118, 27)
        Me.btnsearchinmateinreport.TabIndex = 4
        Me.btnsearchinmateinreport.Text = "Search"
        Me.btnsearchinmateinreport.UseVisualStyleBackColor = False
        '
        'txtsearchinmateinreport
        '
        Me.txtsearchinmateinreport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txtsearchinmateinreport.Location = New System.Drawing.Point(435, 55)
        Me.txtsearchinmateinreport.Name = "txtsearchinmateinreport"
        Me.txtsearchinmateinreport.Size = New System.Drawing.Size(580, 20)
        Me.txtsearchinmateinreport.TabIndex = 3
        '
        'lblsearchlabel
        '
        Me.lblsearchlabel.AutoSize = True
        Me.lblsearchlabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsearchlabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblsearchlabel.Location = New System.Drawing.Point(300, 56)
        Me.lblsearchlabel.Name = "lblsearchlabel"
        Me.lblsearchlabel.Size = New System.Drawing.Size(103, 16)
        Me.lblsearchlabel.TabIndex = 5
        Me.lblsearchlabel.Text = "(Input Inmate ID)"
        '
        'print
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1244, 650)
        Me.Controls.Add(Me.lblsearchlabel)
        Me.Controls.Add(Me.txtsearchinmateinreport)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnsearchinmateinreport)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "print"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gereza Track Technologies"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents rbtvisitor As RadioButton
    Friend WithEvents rbtuserreport As RadioButton
    Friend WithEvents rbtinmatereport As RadioButton
    Friend WithEvents Button4 As Button
    Friend WithEvents rbtinmaterelease As RadioButton
    Friend WithEvents rbttransferreports As RadioButton
    Friend WithEvents rbtaoutbreak As RadioButton
    Friend WithEvents rbtstrikereport As RadioButton
    Friend WithEvents rbtmaintainancereport As RadioButton
    Friend WithEvents rbtcrimesreport As RadioButton
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnsearchinmateinreport As Button
    Friend WithEvents txtsearchinmateinreport As TextBox
    Friend WithEvents lblsearchlabel As Label
End Class
