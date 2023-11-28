Imports MySql.Data.MySqlClient
Public Class admin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click

        Dim con As New MySqlConnection("server=localhost; username=root; database=gerezatrack; password=;")
        Dim rd As MySqlDataReader
        Dim cmd As MySqlCommand

        Try
            con.Open()
            Dim query As String = "SELECT `username`, `regno`, `password`, `adminaccesscode` FROM `tblusers` WHERE username='" & txtusername.Text & "' and regno='" & txtregno.Text & "' and password='" & txtpassword.Text & "' and adminaccesscode='" & txtadminaccesscode.Text & "' "
            cmd = New MySqlCommand(query, con)
            rd = cmd.ExecuteReader
            Dim count As Integer
            count = 0
            While rd.Read
                count = count + 1
            End While
            If count = 1 Then
                MsgBox("Welcome " & txtusername.Text & " To gereza technologies", vbOKOnly + vbInformation, "Gereza Technology")
                clear()
                pman.Show()
                Me.Hide()
                pman.btncommisionergeneral.Visible = True
                pman.btndeputycommisioner.Visible = True
                pman.btnregionalcommisioner.Visible = True
                pman.btnofficerincharge.Visible = True
                pman.btnprisonwadens.Visible = True
                pman.txtcommisonergeneral.Visible = True
                pman.txtdeputycomissioner.Visible = True
                pman.txtregionalcommieionser.Visible = True
                pman.txtofficerincharge.Visible = True
                pman.btnsavehierachy.Visible = True
            Else
                pman.btncommisionergeneral.Visible = False
                pman.btndeputycommisioner.Visible = False
                pman.btnregionalcommisioner.Visible = False
                pman.btnofficerincharge.Visible = False
                pman.btnprisonwadens.Visible = False
                pman.txtcommisonergeneral.Visible = False
                pman.txtdeputycomissioner.Visible = False
                pman.txtregionalcommieionser.Visible = False
                pman.txtofficerincharge.Visible = False
                pman.btnsavehierachy.Visible = False
                MsgBox("Invalid Credendials", vbExclamation + vbRetryCancel, "Gereza Technologies")
                clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub clear()
        txtusername.Text = ""
        txtregno.Text = ""
        txtpassword.Text = ""
        txtadminaccesscode.Clear()
        txtusername.Select()
    End Sub

    Private Sub Dtlogin_Tick(sender As Object, e As EventArgs) Handles dtlogin.Tick
        lbldate.Text = Date.Now.ToString("dd-MM-yyyy")

        lbltime.Text = Date.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtlogin.Enabled = True
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        login.Show()
    End Sub

    Private Sub Chkboxpassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkboxpassword.CheckedChanged
        If chkboxpassword.Checked = True Then
            txtpassword.PasswordChar = ""
        Else
            txtpassword.PasswordChar = "*"
        End If
    End Sub
End Class