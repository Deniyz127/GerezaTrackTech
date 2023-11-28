Imports MySql.Data.MySqlClient
Module DBconn
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Sub connection()
        Try
            conn = New MySqlConnection
            conn.ConnectionString = ("server=localhost;username=root;password=;database=gerezatrack")
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
