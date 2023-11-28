Imports MySql.Data.MySqlClient
Imports System.IO
Public Class users
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            txtsearchuser.Visible = True
            btnsearch.Visible = True
            btnupdateuser.Visible = True
            btnregisteruser.Enabled = False
            btnuploaduser.Enabled = False
        Else
            txtsearchuser.Visible = False
            btnsearch.Visible = False
            btnupdateuser.Visible = False
            btnregisteruser.Enabled = True
            btnuploaduser.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Dashboard.Show()
    End Sub

    Private Sub Btnregisteruser_Click(sender As Object, e As EventArgs) Handles btnregisteruser.Click
        Dim con As New MySqlConnection("server=localhost; database=gerezatrack; username=root; passowrd=;")
        Dim pic As New MemoryStream
        If picuser.Image IsNot Nothing Then
            picuser.Image.Save(pic, picuser.Image.RawFormat)
        Else
            MsgBox("Please Select an Image To Continue", vbExclamation + vbOKCancel, "Gereza Track Technologies")
            Return
        End If
        If txtusernameuser.Text = "" Or
        txtregnumberuser.Text = "" Or
        txtpassworduser.Text = "" Or
        txtuserfullname.Text = "" Or
        txtrankuser.Text = "" Or
        cboroleuser.Text = "" Then
            MsgBox("Please fil the Empty Fields", vbExclamation + vbOKOnly, "Gereza Track Technologies")
        Else
            Try
                con.Open()
                If cboroleuser.Text = "Normal User" Then
                    txtadminaccesscode.Text = "000000"
                End If
                Dim cmd As New MySqlCommand("INSERT INTO `tblusers`(`username`, `regno`, `password`, `fullname`, `Rank`, `Role`,userimage,adminaccesscode) VALUES (@username,@regno,@password,@fullname,@Rank,@Role,@userimage,@adminaccesscode)", con)
                cmd.Parameters.AddWithValue("username", txtusernameuser.Text)
                cmd.Parameters.AddWithValue("regno", txtregnumberuser.Text)
                cmd.Parameters.AddWithValue("password", txtpassworduser.Text)
                cmd.Parameters.AddWithValue("fullname", txtuserfullname.Text)
                cmd.Parameters.AddWithValue("Rank", txtrankuser.Text)
                cmd.Parameters.AddWithValue("Role", cboroleuser.Text)
                cmd.Parameters.AddWithValue("adminaccesscode", txtadminaccesscode.Text)
                cmd.Parameters.Add("userimage", MySqlDbType.LongBlob).Value = (pic).ToArray
                cmd.ExecuteNonQuery()
                MsgBox("User Added Successfully", vbInformation + vbOKOnly, "Gereza Track Technologies")
                clearusercontrols()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Btnuploaduser_Click(sender As Object, e As EventArgs) Handles btnuploaduser.Click
        OpenFileDialog1.ShowDialog()
        Dim paths As String
        OpenFileDialog1.Filter = "JPG files(*.jpg)| *.jpg"
        picuser.SizeMode = PictureBoxSizeMode.StretchImage
        paths = OpenFileDialog1.FileName
        picuser.Image = Image.FromFile(paths)
    End Sub
    Sub clearusercontrols()
        txtusernameuser.Text = ""
        txtregnumberuser.Text = ""
        txtpassworduser.Text = ""
        txtuserfullname.Text = ""
        txtrankuser.Text = ""
        cboroleuser.Text = ""
        txtadminaccesscode.Text = ""
        picuser.Image = Nothing
    End Sub

    Private Sub Btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Dim con As New MySqlConnection("Server=localhost; database=gerezatrack; username=root; password=;")
        Dim adapt As New MySqlDataAdapter
        Dim tbl As New DataTable
        Dim pic() As Byte
        Try
            con.Open()
            Dim cmd As New MySqlCommand("SELECT `username`, `regno`, `password`, `fullname`, `Rank`, `Role`, `userimage` FROM `tblusers` WHERE regno='" & txtsearchuser.Text & "'", con)
            adapt = New MySqlDataAdapter(cmd)
            adapt.Fill(tbl)
            If tbl.Rows.Count > 0 Then
                txtusernameuser.Text = tbl.Rows(0)("username").ToString
                txtregnumberuser.Text = tbl.Rows(0)("regno").ToString
                txtpassworduser.Text = tbl.Rows(0)("password").ToString
                txtuserfullname.Text = tbl.Rows(0)("fullname").ToString
                txtrankuser.Text = tbl.Rows(0)("Rank").ToString
                cboroleuser.Text = tbl.Rows(0)("Role").ToString
                pic = tbl.Rows(0)("userimage")
                Dim ms As New MemoryStream(pic)
                picuser.Image = Image.FromStream(ms)
                picuser.SizeMode = PictureBoxSizeMode.StretchImage
            Else
                MsgBox("User Doesn't Exist", vbExclamation + vbOKOnly, "Users")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Private Sub Btndeleteuser_Click(sender As Object, e As EventArgs) Handles btndeleteuser.Click
    '    Dim con As New MySqlConnection("server=localhost; database=gerezatrack; username=root; password=;")
    '    If txtsearchuser.Text = "" Then
    '        MsgBox("Input the Registration Number", vbExclamation + vbOKCancel, "Gereza Track Technologies")
    '    Else
    '        Try
    '            If MsgBox("Do you really want to delete this user", vbQuestion + vbYesNo) = MsgBoxResult.Yes Then
    '                con.Open()
    '                Dim cmd As New MySqlCommand("DELETE FROM `tblusers` WHERE regno='" & txtsearchuser.Text & "'", con)
    '                cmd.ExecuteNonQuery()

    '            Else
    '                txtsearchuser.Select()
    '            End If
    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        End Try
    '    End If
    'End Sub
    Private Sub Btndeleteuser_Click(sender As Object, e As EventArgs) Handles btndeleteuser.Click
        Dim connectionString As String = "server=localhost; database=gerezatrack; user=root; password=;"
        Dim regNo As String = txtsearchuser.Text.Trim()

        If regNo = "" Then
            MsgBox("Input the Registration Number", vbExclamation + vbOKCancel, "Gereza Track Technologies")
            Return
        End If

        Try
            Using con As New MySqlConnection(connectionString)
                con.Open()

                Dim query As String = "DELETE FROM `tblusers` WHERE regno = @regno"
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@regno", regNo)

                    If MsgBox("Do you really want to delete this user?", vbQuestion + vbYesNo) = MsgBoxResult.Yes Then
                        cmd.ExecuteNonQuery()
                        MsgBox("User deleted successfully.", vbInformation)
                        clearusercontrols()
                    Else
                        txtsearchuser.Select()
        End If
        End Using
        End Using
        Catch ex As Exception
        MsgBox("An error occurred: " & ex.Message, vbExclamation)
        End Try
    End Sub

    Sub fillcontrols()
        Dim con As New MySqlConnection("Server=localhost; database=gerezatrack; username=root; password=;")
        Dim adapt As New MySqlDataAdapter
        Dim tbl As New DataTable
        Dim pic() As Byte
        Try
            con.Open()
            Dim cmd As New MySqlCommand("SELECT `username`, `regno`, `password`, `fullname`, `Rank`, `Role`, `userimage` FROM `tblusers` WHERE regno='" & txtsearchuser.Text & "'", con)
            adapt = New MySqlDataAdapter(cmd)
            adapt.Fill(tbl)
            If tbl.Rows.Count > 0 Then
                txtusernameuser.Text = tbl.Rows(0)("username").ToString
                txtregnumberuser.Text = tbl.Rows(0)("regno").ToString
                txtpassworduser.Text = tbl.Rows(0)("password").ToString
                txtuserfullname.Text = tbl.Rows(0)("fullname").ToString
                txtrankuser.Text = tbl.Rows(0)("Rank").ToString
                cboroleuser.Text = tbl.Rows(0)("Role").ToString
                pic = tbl.Rows(0)("userimage")
                Dim ms As New MemoryStream(pic)
                picuser.Image = Image.FromStream(ms)
                picuser.SizeMode = PictureBoxSizeMode.StretchImage
            Else
                MsgBox("User Doesn't Exist", vbExclamation + vbOKOnly, "Users")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btnupdateuser_Click(sender As Object, e As EventArgs) Handles btnupdateuser.Click
        Dim con As New MySqlConnection("server=localhost; database=gerezatrack; username=root; password=;")
        Try
            con.Open()
            Dim cmd As New MySqlCommand("UPDATE `tblusers` SET `username`=@username,`regno`=@regno,`password`=@password,`fullname`=@fullname,`Rank`=@Rank,`Role`=@Role WHERE regno=@regtext", con)
            cmd.Parameters.AddWithValue("@regtext", txtsearchuser.Text)
            cmd.Parameters.AddWithValue("@username", txtusernameuser.Text)
            cmd.Parameters.AddWithValue("@regno", txtregnumberuser.Text)
            cmd.Parameters.AddWithValue("@password", txtpassworduser.Text)
            cmd.Parameters.AddWithValue("@fullname", txtuserfullname.Text)
            cmd.Parameters.AddWithValue("@Rank", txtrankuser.Text)
            cmd.Parameters.AddWithValue("@Role", cboroleuser.Text)
            cmd.ExecuteNonQuery()
            MsgBox("User Updated Successfully", vbInformation + vbOKOnly, "Gereza Track Technologies")
            clearusercontrols()
        Catch ex As Exception
            MsgBox("Error:" + ex.Message)
        End Try
    End Sub

    Private Sub Cboroleuser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboroleuser.SelectedIndexChanged
        If cboroleuser.Text = "Admin" Then
            lbladminaccesscode.Visible = True
            txtadminaccesscode.Visible = True
        End If
        If cboroleuser.Text = "Normal User" Then
            lbladminaccesscode.Visible = False
            txtadminaccesscode.Visible = False
        End If
    End Sub
End Class