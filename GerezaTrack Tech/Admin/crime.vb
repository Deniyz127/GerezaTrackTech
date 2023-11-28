Imports MySql.Data.MySqlClient
Public Class crime
    Private Sub Crime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControl1.SelectedTab = TabPage1
        Timer1.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TabControl1.SelectedTab = TabPage2
        Timer1.Enabled = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TabControl1.SelectedTab = TabPage4

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Dashboard.Show()
    End Sub

    Private Sub Btnsavecrime_Click(sender As Object, e As EventArgs) Handles btnsavecrime.Click
        Dim con As New MySqlConnection("Server=localhost;username=root;password=;database=gerezatrack")
        Dim selecteddate As Date = dtpaddcrimedate.Value
        Dim rectified As String = selecteddate.ToString("yyyy-MM-dd")
        Try
            If txtcrimecodeadd.Text = "" Or txtcrimenameadd.Text = "" Or txtcrimetypeadd.Text = "" Or txtcausesadd.Text = "" Or txtconvictedinmtesadd.Text = "" Or cbogenderadd.Text = "" Or txtconvictedinmtesadd.Text = "" Or txttrainingadd.Text = "" Then
                MsgBox("Please fill the empty fields", vbExclamation + vbOKOnly)
            Else
                con.Open()
                Dim query As String = "INSERT INTO `tblcrimes`(`crimecode`, `crimename`, `date`, `typeofcrime`, `causes`, `agebracket`, `gender`, `totalconvicted`, `training`) VALUES (@crimecode,@crimename,@date,@typeofcrime,@causes,@agebracket,@gender,@totalconvicted,@training)"
                cmd = New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@crimecode", txtcrimecodeadd.Text)
            cmd.Parameters.AddWithValue("@crimename", txtcrimenameadd.Text)
                cmd.Parameters.AddWithValue("@date", rectified)
                cmd.Parameters.AddWithValue("@typeofcrime", txtcrimetypeadd.Text)
            cmd.Parameters.AddWithValue("@causes", txtcausesadd.Text)
            cmd.Parameters.AddWithValue("@agebracket", txtconvictedinmtesadd.Text)
            cmd.Parameters.AddWithValue("@gender", cbogenderadd.Text)
            cmd.Parameters.AddWithValue("@totalconvicted", txtconvictedinmtesadd.Text)
            cmd.Parameters.AddWithValue("@training", txttrainingadd.Text)
            cmd.ExecuteNonQuery()
            MsgBox("Crime Recorded Successfully", vbInformation + vbOKOnly)
            clearaddcrimecontrol()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Sub clearaddcrimecontrol()
        txtcrimecodeadd.Text = ""
        txtcrimenameadd.Text = ""
        dtpaddcrimedate.Value = Date.Now.ToString("ddd, dd-MMM-yyy")
        txtcrimetypeadd.Text = ""
        txtcausesadd.Text = ""
        txtconvictedinmtesadd.Text = ""
        cbogenderadd.Text = ""
        txtconvictedinmtesadd.Text = ""
        txttrainingadd.Text = ""
        cboagebracketadd.Text = ""
    End Sub

    Private Sub Btnsearchcrime_Click(sender As Object, e As EventArgs) Handles btnsearchcrime.Click
        Dim conn As New MySqlConnection("server=localhost;database=gerezatrack;username=root;password=;")
        Try
            conn.Open()
            Dim adapt As New MySqlDataAdapter
            Dim tbl As New DataTable
            Dim cmd As New MySqlCommand("SELECT `crimecode`, `crimename`, `date`, `typeofcrime`, `causes`, `agebracket`, `gender`, `totalconvicted`, `training` FROM `tblcrimes` WHERE `crimecode` = '" & txtsearchupdate.Text & "'", conn)
            adapt = New MySqlDataAdapter(cmd)
            adapt.Fill(tbl)
            If tbl.Rows.Count > 0 Then
                txtcrimenameupdate.Text = tbl.Rows(0)("crimename").ToString
                txtcrimecodeupdate.Text = tbl.Rows(0)("crimecode").ToString
                dtpcrimedateupdate.Value = tbl.Rows(0)("date")
                txtcrimetypeupdate.Text = tbl.Rows(0)("typeofcrime").ToString
                cboagebracketupdate.Text = tbl.Rows(0)("agebracket").ToString
                cbocrimegenderupdate.Text = tbl.Rows(0)("gender").ToString
                txtcrimecausesupdate.Text = tbl.Rows(0)("causes").ToString
                txttrainingupdate.Text = tbl.Rows(0)("training").ToString
                txtconvictedinmatesupdate.Text = tbl.Rows(0)("totalconvicted").ToString
            Else
                MsgBox("Crime Not Recorded in the System", vbExclamation + vbOKOnly, "Gereza Track Technologies")

            End If
        Catch ex As Exception
            MsgBox("Error:" + ex.Message)
        End Try

    End Sub


    Private Sub txtcrimenameadd_GotFocus(sender As Object, e As EventArgs) Handles txtcrimenameadd.GotFocus
        Dim connectionString As String = "Server=localhost;database=gerezatrack;username=root;password=;"
        Dim query As String = "SELECT Count(*) FROM `tblinmate` WHERE crimescommited LIKE CONCAT('%', @crimename, '%')"
        Dim count As Integer

        Using connect As New MySqlConnection(connectionString)
            If txtcrimenameadd.Text = "" Then
                txtconvictedinmtesadd.Text = ""
            Else
                Try
                    connect.Open()
                    Using comm As New MySqlCommand(query, connect)
                        comm.Parameters.AddWithValue("@crimename", txtcrimenameadd.Text)
                        count = Convert.ToInt32(comm.ExecuteScalar())
                    End Using
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message)
                End Try
            End If
        End Using
        txtconvictedinmtesadd.Text = count.ToString()
    End Sub

    Private Sub Btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Dim selecteddate As Date = dtpcrimedateupdate.Value
        Dim rectified As String = selecteddate.ToString("yyyy-MM-dd")
        Dim con As New MySqlConnection("server=localhost;database=gerezatrack;username=root;password=;")
        If txtcrimecodeupdate.Text = "" Or
            txtcrimenameupdate.Text = "" Or
        txtcrimetypeupdate.Text = "" Or
            txtcrimecausesupdate.Text = "" Or
            cboagebracketupdate.Text = "" Or
        cbocrimegenderupdate.Text = "" Or
            txtconvictedinmatesupdate.Text = "" Or
            txttrainingupdate.Text = "" Or
            txtsearchupdate.Text = "" Then
            MsgBox("No null values Accepted!!", vbExclamation + vbOKOnly, "Gereza Track Technologies")
        Else

            Try
                con.Open()
                Dim cmd As New MySqlCommand("UPDATE `tblcrimes` SET `crimecode`='" & txtcrimecodeupdate.Text & "',`crimename`='" & txtcrimenameupdate.Text & "',`date`=@rectified,`typeofcrime`='" & txtcrimetypeupdate.Text & "',`causes`='" & txtcrimecausesupdate.Text & "',`agebracket`='" & cboagebracketupdate.Text & "',`gender`='" & cbocrimegenderupdate.Text & "',`totalconvicted`='" & txtconvictedinmatesupdate.Text & "',`training`='" & txttrainingupdate.Text & "' WHERE crimecode='" & txtsearchupdate.Text & "'", con)
                cmd.Parameters.AddWithValue("@rectified", rectified)
                cmd.ExecuteNonQuery()
                MsgBox("Crime Updated Successfully", vbInformation + vbOKOnly, "Gereza Track Technologies")
                clearcrimeupdate()
            Catch ex As Exception
                MsgBox("Error:" + ex.Message)
            End Try
        End If
    End Sub
    Sub clearcrimeupdate()
        txtcrimecodeupdate.Text = ""
        txtcrimenameupdate.Text = ""
        dtpcrimedateupdate.Value = Date.Now.ToString("ddd, dd-MMM-yyyy ")
        txtcrimetypeupdate.Text = ""
        txtcrimecausesupdate.Text = ""
        cboagebracketupdate.Text = ""
        cbocrimegenderupdate.Text = ""
        txtconvictedinmatesupdate.Text = ""
        txttrainingupdate.Text = ""
        txtsearchupdate.Text = ""
    End Sub

    Private Sub Dgvinmates_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcrimes.CellContentClick

    End Sub



    Private Sub Btnsearchcrimeslist_Click(sender As Object, e As EventArgs) Handles btnsearchcrimeslist.Click
        If txtseaarchcrimelist.Text = "" Then
            If MsgBox("Input Inmate number to continue..", vbExclamation + vbOKCancel) = MsgBoxResult.Ok Then
                txtseaarchcrimelist.Select()
            End If
        Else
            Dim con As New MySqlConnection("Server=LocalHost; Database=gerezatrack; username=root; password=;")
            Timer1.Enabled = False
            btnshowallcrimes.Visible = True
            Try
                con.Open()
                Dim tbl As New DataTable
                Dim comnd As New MySqlCommand("SELECT `crimecode`, `crimename`,  date,`typeofcrime`, `agebracket`, `gender`, `totalconvicted` FROM `tblcrimes` WHERE crimecode='" & txtseaarchcrimelist.Text & "'", con)
                Dim adt As New MySqlDataAdapter(comnd)
                adt.Fill(tbl)
                tbl.Columns("crimecode").ColumnName = "Crime Code"
                tbl.Columns("date").ColumnName = "Date"
                tbl.Columns("crimename").ColumnName = "Crime Name"
                tbl.Columns("typeofcrime").ColumnName = "Type Of Crime"
                tbl.Columns("agebracket").ColumnName = "Age Bracket Convicted"
                tbl.Columns("gender").ColumnName = "Gender Affected"
                tbl.Columns("totalconvicted").ColumnName = "Total Convicted"
                dgvcrimes.DataSource = tbl
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub Btnshowallcrimes_Click(sender As Object, e As EventArgs) Handles btnshowallcrimes.Click
        Timer1.Enabled = True
        txtseaarchcrimelist.Clear()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim con As New MySqlConnection("Server=LocalHost; Database=gerezatrack; username=root; password=;")
        Try
            con.Open()
            Dim tbl As New DataTable
            Dim comnd As New MySqlCommand("SELECT `crimecode`, `crimename`,  date,`typeofcrime`, `agebracket`, `gender`, `totalconvicted` FROM `tblcrimes`", con)
            Dim adt As New MySqlDataAdapter(comnd)
            adt.Fill(tbl)
            tbl.Columns("crimecode").ColumnName = "Crime Code"
            tbl.Columns("date").ColumnName = "Date"
            tbl.Columns("crimename").ColumnName = "Crime Name"
            tbl.Columns("typeofcrime").ColumnName = "Type Of Crime"
            tbl.Columns("agebracket").ColumnName = "Age Bracket Convicted"
            tbl.Columns("gender").ColumnName = "Gender Affected"
            tbl.Columns("totalconvicted").ColumnName = "Total Convicted"
            dgvcrimes.DataSource = tbl
        Catch ex As Exception
        End Try
    End Sub
End Class