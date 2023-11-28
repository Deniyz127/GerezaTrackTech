Imports MySql.Data.MySqlClient
Imports System.IO
Public Class registerprison
    Private Sub Btnuploadlogo_Click(sender As Object, e As EventArgs) Handles btnuploadlogo.Click
        OpenFileDialog1.Filter = "JPEG files (*.jpg, *.jpeg)|*.jpg;*.jpeg|PNG files (*.png)|*.png|All files (*.*)|*.*"
        OpenFileDialog1.ShowDialog()

        Dim filename As String = OpenFileDialog1.FileName
        piclogo.SizeMode = PictureBoxSizeMode.StretchImage
        piclogo.Image = Image.FromFile(filename)
    End Sub


    Private Sub Btnsaveinfo_Click(sender As Object, e As EventArgs) Handles btnsaveinfo.Click
        Dim connectionString As String = "server=localhost; database=gerezatrack; user=root; password=;"

        Using con As New MySqlConnection(connectionString)
            Dim ms As New MemoryStream()

            If piclogo.Image IsNot Nothing Then
                piclogo.Image.Save(ms, piclogo.Image.RawFormat)
            Else
                MsgBox("Please Select an Image To Continue", vbExclamation + vbOKCancel, "Gereza Track Technologies")
                Return
            End If

            Try
                con.Open()
                Dim query As String = "INSERT INTO `tblprisoninfo` (`Prisonname`, `Location`, `Capacity`, `phonenumber`, `emailadres`, `securitylevel`, `filledby`, `prisonlogo`) VALUES (@Prisonname, @Location, @Capacity, @phonenumber, @emailadres, @securitylevel, @filledby, @prisonlogo)"

                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@Prisonname", txtprisoname.Text)
                    cmd.Parameters.AddWithValue("@Location", txtprisonlocation.Text)
                    cmd.Parameters.AddWithValue("@Capacity", txtcapacity.Text)
                    cmd.Parameters.AddWithValue("@phonenumber", txtprisonphonenumber.Text)
                    cmd.Parameters.AddWithValue("@emailadres", txtprisonemailaddress.Text)
                    cmd.Parameters.AddWithValue("@securitylevel", cbosecuritylevel.Text)
                    cmd.Parameters.AddWithValue("@filledby", txtprisoname.Text)
                    cmd.Parameters.AddWithValue("@prisonlogo", ms.ToArray())

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MsgBox("Data inserted successfully.", vbInformation + vbOKOnly, "Success")
                    Else
                        MsgBox("Data insertion failed.", vbCritical + vbRetryCancel, "Error")
                    End If
                End Using
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dashboard.Show()
    End Sub
End Class
