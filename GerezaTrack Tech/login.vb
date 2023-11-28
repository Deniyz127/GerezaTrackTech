Imports MySql.Data.MySqlClient
Public Class login
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            txtpassword.PasswordChar = ""
        Else
            txtpassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection()
        dtlogin.Enabled = True
    End Sub

    Private Sub Dtlogin_Tick(sender As Object, e As EventArgs) Handles dtlogin.Tick
        lbldate.Text = Date.Now.ToString("hh:mm:ss tt")
        lbltime.Text = Date.Now.ToString("dd-MM-yyyy")
    End Sub

    Private Sub Btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim con As New MySqlConnection("server=localhost;username=root;password=;database=gerezatrack")
        Dim dr As MySqlDataReader
        Dim cmd As MySqlCommand
        If txtusername.Text = "" Or txtregno.Text = "" Or txtpassword.Text = "" Then
            MsgBox("Please Fill the Null values ", vbOK + vbExclamation, "Gereza Technologies")
        Else
            Try
                con.Open()
                Dim query As String
                query = "SELECT username,regno,password FROM tblusers WHERE username='" & txtusername.Text & "' and regno='" & txtregno.Text & "' and password='" & txtpassword.Text & "'"
                cmd = New MySqlCommand(query, con)
                dr = cmd.ExecuteReader
                Dim count As Integer
                count = 0
                While dr.Read
                    count = count + 1
                End While
                If count = 1 Then
                    MsgBox("Welcome " & txtusername.Text & " To gereza technologies", vbOKOnly + vbInformation, "Gereza Technology")
                    Dashboard.Show()
                    Me.Hide()
                    clear()
                Else
                    MsgBox("Invalid Credendials", vbExclamation + vbRetryCancel, "Gereza Technologies")
                    clear()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Sub clear()
        txtusername.Text = ""
        txtregno.Text = ""
        txtpassword.Text = ""
        txtusername.Select()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("The application will be closed", vbCritical + vbYesNo) = vbYes Then
            Me.Close()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        admin.Show()
    End Sub
End Class