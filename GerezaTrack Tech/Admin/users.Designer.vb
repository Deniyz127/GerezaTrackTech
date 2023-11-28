<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class users
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.btnuploaduser = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtuserfullname = New System.Windows.Forms.TextBox()
        Me.btnregisteruser = New System.Windows.Forms.Button()
        Me.btndeleteuser = New System.Windows.Forms.Button()
        Me.btnupdateuser = New System.Windows.Forms.Button()
        Me.picuser = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtusernameuser = New System.Windows.Forms.TextBox()
        Me.txtpassworduser = New System.Windows.Forms.TextBox()
        Me.txtregnumberuser = New System.Windows.Forms.TextBox()
        Me.txtrankuser = New System.Windows.Forms.TextBox()
        Me.txtsearchuser = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboroleuser = New System.Windows.Forms.ComboBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lbladminaccesscode = New System.Windows.Forms.Label()
        Me.txtadminaccesscode = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.picuser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(673, 48)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(174, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(296, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "USER MANAGEMENT MODULE"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(12, 61)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(109, 20)
        Me.RadioButton1.TabIndex = 2
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Add New User"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(124, 62)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(80, 20)
        Me.RadioButton2.TabIndex = 3
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Edit User"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'btnsearch
        '
        Me.btnsearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnsearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsearch.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.Location = New System.Drawing.Point(477, 51)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(118, 34)
        Me.btnsearch.TabIndex = 4
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = True
        Me.btnsearch.Visible = False
        '
        'btnuploaduser
        '
        Me.btnuploaduser.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnuploaduser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnuploaduser.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnuploaduser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnuploaduser.Location = New System.Drawing.Point(407, 325)
        Me.btnuploaduser.Name = "btnuploaduser"
        Me.btnuploaduser.Size = New System.Drawing.Size(210, 44)
        Me.btnuploaduser.TabIndex = 7
        Me.btnuploaduser.Text = "Upload Image"
        Me.btnuploaduser.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 18)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Full Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 18)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Username"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Reg Number"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(51, 148)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 18)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Rank"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 253)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 18)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Password"
        '
        'txtuserfullname
        '
        Me.txtuserfullname.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuserfullname.Location = New System.Drawing.Point(96, 110)
        Me.txtuserfullname.Multiline = True
        Me.txtuserfullname.Name = "txtuserfullname"
        Me.txtuserfullname.Size = New System.Drawing.Size(282, 25)
        Me.txtuserfullname.TabIndex = 21
        '
        'btnregisteruser
        '
        Me.btnregisteruser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnregisteruser.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnregisteruser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnregisteruser.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnregisteruser.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.btnregisteruser.Location = New System.Drawing.Point(13, 375)
        Me.btnregisteruser.Name = "btnregisteruser"
        Me.btnregisteruser.Size = New System.Drawing.Size(157, 44)
        Me.btnregisteruser.TabIndex = 29
        Me.btnregisteruser.Text = "Register"
        Me.btnregisteruser.UseVisualStyleBackColor = True
        '
        'btndeleteuser
        '
        Me.btndeleteuser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btndeleteuser.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btndeleteuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndeleteuser.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndeleteuser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btndeleteuser.Location = New System.Drawing.Point(338, 375)
        Me.btndeleteuser.Name = "btndeleteuser"
        Me.btndeleteuser.Size = New System.Drawing.Size(157, 44)
        Me.btndeleteuser.TabIndex = 30
        Me.btndeleteuser.Text = "Delete"
        Me.btndeleteuser.UseVisualStyleBackColor = True
        '
        'btnupdateuser
        '
        Me.btnupdateuser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnupdateuser.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnupdateuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdateuser.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdateuser.ForeColor = System.Drawing.Color.Maroon
        Me.btnupdateuser.Location = New System.Drawing.Point(175, 375)
        Me.btnupdateuser.Name = "btnupdateuser"
        Me.btnupdateuser.Size = New System.Drawing.Size(157, 44)
        Me.btnupdateuser.TabIndex = 31
        Me.btnupdateuser.Text = "Update"
        Me.btnupdateuser.UseVisualStyleBackColor = True
        Me.btnupdateuser.Visible = False
        '
        'picuser
        '
        Me.picuser.BackColor = System.Drawing.Color.Transparent
        Me.picuser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picuser.Image = Global.GerezaTrack_Tech.My.Resources.Resources.Icons_Land_Vista_People_Office_Customer_Male_Light_128
        Me.picuser.Location = New System.Drawing.Point(394, 94)
        Me.picuser.Name = "picuser"
        Me.picuser.Size = New System.Drawing.Size(234, 225)
        Me.picuser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picuser.TabIndex = 6
        Me.picuser.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.GerezaTrack_Tech.My.Resources.Resources.escape_room_logo_template_design___Made_with_PosterMyWall__3_
        Me.PictureBox1.Location = New System.Drawing.Point(0, 48)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(673, 427)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Red
        Me.Button3.Image = Global.GerezaTrack_Tech.My.Resources.Resources.home
        Me.Button3.Location = New System.Drawing.Point(508, 375)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(157, 44)
        Me.Button3.TabIndex = 32
        Me.Button3.Text = "  Exit"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtusernameuser
        '
        Me.txtusernameuser.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusernameuser.Location = New System.Drawing.Point(96, 213)
        Me.txtusernameuser.Multiline = True
        Me.txtusernameuser.Name = "txtusernameuser"
        Me.txtusernameuser.Size = New System.Drawing.Size(282, 25)
        Me.txtusernameuser.TabIndex = 33
        '
        'txtpassworduser
        '
        Me.txtpassworduser.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassworduser.Location = New System.Drawing.Point(96, 249)
        Me.txtpassworduser.Multiline = True
        Me.txtpassworduser.Name = "txtpassworduser"
        Me.txtpassworduser.Size = New System.Drawing.Size(282, 25)
        Me.txtpassworduser.TabIndex = 34
        '
        'txtregnumberuser
        '
        Me.txtregnumberuser.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtregnumberuser.Location = New System.Drawing.Point(96, 179)
        Me.txtregnumberuser.Multiline = True
        Me.txtregnumberuser.Name = "txtregnumberuser"
        Me.txtregnumberuser.Size = New System.Drawing.Size(282, 25)
        Me.txtregnumberuser.TabIndex = 35
        '
        'txtrankuser
        '
        Me.txtrankuser.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrankuser.Location = New System.Drawing.Point(96, 146)
        Me.txtrankuser.Multiline = True
        Me.txtrankuser.Name = "txtrankuser"
        Me.txtrankuser.Size = New System.Drawing.Size(282, 25)
        Me.txtrankuser.TabIndex = 36
        '
        'txtsearchuser
        '
        Me.txtsearchuser.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearchuser.Location = New System.Drawing.Point(201, 58)
        Me.txtsearchuser.Multiline = True
        Me.txtsearchuser.Name = "txtsearchuser"
        Me.txtsearchuser.Size = New System.Drawing.Size(270, 25)
        Me.txtsearchuser.TabIndex = 5
        Me.txtsearchuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtsearchuser.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(53, 290)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 18)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Role"
        '
        'cboroleuser
        '
        Me.cboroleuser.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboroleuser.FormattingEnabled = True
        Me.cboroleuser.Items.AddRange(New Object() {"Admin", "Normal User"})
        Me.cboroleuser.Location = New System.Drawing.Point(96, 287)
        Me.cboroleuser.Name = "cboroleuser"
        Me.cboroleuser.Size = New System.Drawing.Size(282, 26)
        Me.cboroleuser.TabIndex = 37
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lbladminaccesscode
        '
        Me.lbladminaccesscode.AutoSize = True
        Me.lbladminaccesscode.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lbladminaccesscode.Location = New System.Drawing.Point(13, 328)
        Me.lbladminaccesscode.Name = "lbladminaccesscode"
        Me.lbladminaccesscode.Size = New System.Drawing.Size(119, 16)
        Me.lbladminaccesscode.TabIndex = 38
        Me.lbladminaccesscode.Text = "Admin Access NO"
        Me.lbladminaccesscode.Visible = False
        '
        'txtadminaccesscode
        '
        Me.txtadminaccesscode.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtadminaccesscode.Location = New System.Drawing.Point(135, 323)
        Me.txtadminaccesscode.Multiline = True
        Me.txtadminaccesscode.Name = "txtadminaccesscode"
        Me.txtadminaccesscode.Size = New System.Drawing.Size(243, 25)
        Me.txtadminaccesscode.TabIndex = 39
        Me.txtadminaccesscode.Visible = False
        '
        'users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 475)
        Me.Controls.Add(Me.txtadminaccesscode)
        Me.Controls.Add(Me.lbladminaccesscode)
        Me.Controls.Add(Me.cboroleuser)
        Me.Controls.Add(Me.txtrankuser)
        Me.Controls.Add(Me.txtregnumberuser)
        Me.Controls.Add(Me.txtpassworduser)
        Me.Controls.Add(Me.txtusernameuser)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnupdateuser)
        Me.Controls.Add(Me.btndeleteuser)
        Me.Controls.Add(Me.btnregisteruser)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtuserfullname)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnuploaduser)
        Me.Controls.Add(Me.picuser)
        Me.Controls.Add(Me.txtsearchuser)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "users"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gereza Track Technologies"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picuser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents btnsearch As Button
    Friend WithEvents picuser As PictureBox
    Friend WithEvents btnuploaduser As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtuserfullname As TextBox
    Friend WithEvents btnregisteruser As Button
    Friend WithEvents btndeleteuser As Button
    Friend WithEvents btnupdateuser As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents txtusernameuser As TextBox
    Friend WithEvents txtpassworduser As TextBox
    Friend WithEvents txtregnumberuser As TextBox
    Friend WithEvents txtrankuser As TextBox
    Friend WithEvents txtsearchuser As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboroleuser As ComboBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents lbladminaccesscode As Label
    Friend WithEvents txtadminaccesscode As TextBox
End Class
