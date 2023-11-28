<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registerprison
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnsaveinfo = New System.Windows.Forms.Button()
        Me.piclogo = New System.Windows.Forms.PictureBox()
        Me.btnuploadlogo = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtfilledby = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtprisonemailaddress = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtprisonphonenumber = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcapacity = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtprisonlocation = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtprisoname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbosecuritylevel = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.piclogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(438, 47)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(40, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(319, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PRISON REGISTRATION MODULE"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.GerezaTrack_Tech.My.Resources.Resources.escape_room_logo_template_design___Made_with_PosterMyWall__3_
        Me.PictureBox1.Location = New System.Drawing.Point(0, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(438, 523)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btnsaveinfo
        '
        Me.btnsaveinfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnsaveinfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnsaveinfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnsaveinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsaveinfo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsaveinfo.Location = New System.Drawing.Point(88, 531)
        Me.btnsaveinfo.Name = "btnsaveinfo"
        Me.btnsaveinfo.Size = New System.Drawing.Size(126, 28)
        Me.btnsaveinfo.TabIndex = 36
        Me.btnsaveinfo.Text = "Save Info"
        Me.btnsaveinfo.UseVisualStyleBackColor = True
        '
        'piclogo
        '
        Me.piclogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.piclogo.Location = New System.Drawing.Point(130, 62)
        Me.piclogo.Name = "piclogo"
        Me.piclogo.Size = New System.Drawing.Size(162, 162)
        Me.piclogo.TabIndex = 35
        Me.piclogo.TabStop = False
        '
        'btnuploadlogo
        '
        Me.btnuploadlogo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnuploadlogo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnuploadlogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnuploadlogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnuploadlogo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnuploadlogo.Location = New System.Drawing.Point(148, 230)
        Me.btnuploadlogo.Name = "btnuploadlogo"
        Me.btnuploadlogo.Size = New System.Drawing.Size(111, 28)
        Me.btnuploadlogo.TabIndex = 34
        Me.btnuploadlogo.Text = "Upload"
        Me.btnuploadlogo.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(38, 128)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 17)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Prison Logo"
        '
        'txtfilledby
        '
        Me.txtfilledby.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfilledby.Location = New System.Drawing.Point(101, 500)
        Me.txtfilledby.Name = "txtfilledby"
        Me.txtfilledby.Size = New System.Drawing.Size(304, 25)
        Me.txtfilledby.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(39, 505)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 16)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Filled By"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 463)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 16)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Security Level"
        '
        'txtprisonemailaddress
        '
        Me.txtprisonemailaddress.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprisonemailaddress.Location = New System.Drawing.Point(101, 416)
        Me.txtprisonemailaddress.Name = "txtprisonemailaddress"
        Me.txtprisonemailaddress.Size = New System.Drawing.Size(304, 25)
        Me.txtprisonemailaddress.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 421)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 16)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Email Address"
        '
        'txtprisonphonenumber
        '
        Me.txtprisonphonenumber.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprisonphonenumber.Location = New System.Drawing.Point(101, 376)
        Me.txtprisonphonenumber.Name = "txtprisonphonenumber"
        Me.txtprisonphonenumber.Size = New System.Drawing.Size(304, 25)
        Me.txtprisonphonenumber.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 380)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 16)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Phone Number"
        '
        'txtcapacity
        '
        Me.txtcapacity.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcapacity.Location = New System.Drawing.Point(101, 339)
        Me.txtcapacity.Name = "txtcapacity"
        Me.txtcapacity.Size = New System.Drawing.Size(304, 25)
        Me.txtcapacity.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(40, 344)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 16)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Capacity"
        '
        'txtprisonlocation
        '
        Me.txtprisonlocation.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprisonlocation.Location = New System.Drawing.Point(101, 304)
        Me.txtprisonlocation.Name = "txtprisonlocation"
        Me.txtprisonlocation.Size = New System.Drawing.Size(304, 25)
        Me.txtprisonlocation.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 307)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 16)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Location"
        '
        'txtprisoname
        '
        Me.txtprisoname.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprisoname.Location = New System.Drawing.Point(101, 264)
        Me.txtprisoname.Name = "txtprisoname"
        Me.txtprisoname.Size = New System.Drawing.Size(304, 25)
        Me.txtprisoname.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 268)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 16)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Prison Name"
        '
        'cbosecuritylevel
        '
        Me.cbosecuritylevel.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbosecuritylevel.FormattingEnabled = True
        Me.cbosecuritylevel.Location = New System.Drawing.Point(104, 456)
        Me.cbosecuritylevel.Name = "cbosecuritylevel"
        Me.cbosecuritylevel.Size = New System.Drawing.Size(301, 28)
        Me.cbosecuritylevel.TabIndex = 37
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(264, 528)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 30)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "Home"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'registerprison
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 570)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cbosecuritylevel)
        Me.Controls.Add(Me.btnsaveinfo)
        Me.Controls.Add(Me.piclogo)
        Me.Controls.Add(Me.btnuploadlogo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtfilledby)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtprisonemailaddress)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtprisonphonenumber)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtcapacity)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtprisonlocation)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtprisoname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "registerprison"
        Me.Text = "Prison Registration "
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.piclogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnsaveinfo As Button
    Friend WithEvents piclogo As PictureBox
    Friend WithEvents btnuploadlogo As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtfilledby As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtprisonemailaddress As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtprisonphonenumber As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtcapacity As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtprisonlocation As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtprisoname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbosecuritylevel As ComboBox
    Friend WithEvents Button1 As Button
End Class
