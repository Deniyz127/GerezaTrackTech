Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Dashboard
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer2.Enabled = True
        Timer3.Enabled = True
        lbluser.Text = login.txtusername.Text
        Try
            Dim connect As New MySqlConnection("server=localhost; username=root; database=gerezatrack; password=;")
            Dim userpic() As Byte
            Dim adapt As New MySqlDataAdapter
            Dim tbl As New DataTable
            Dim cmd As New MySqlCommand("SELECT `username`, `regno`,`userimage` FROM `tblusers` WHERE `regno`='" & login.txtregno.Text & "'", connect)
            adapt = New MySqlDataAdapter(cmd)
            adapt.Fill(tbl)
            If tbl.Rows.Count > 0 Then
                lbluser.Text = tbl.Rows(0)("username").ToString
                userpic = tbl.Rows(0)("userimage")
                Dim ms As New MemoryStream(userpic)
                picuser.Image = Image.FromStream(ms)
                picuser.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbldate.Text = Date.Now.ToString("dd-MM-yyyy")
        lbltime.Text = Date.Now.ToString("hh:mm:ss tt")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        pman.Show()
        Me.Hide()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Hide()
        login.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        crime.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        inmate.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        visitor.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        users.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        print.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Hide()
        info.Show()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ProgressBar1.Value = ProgressBar1.Value + 2
        If ProgressBar1.Value = 100 Then
            lblwelcome.Text = "Dashboard"
            Timer2.Enabled = False
            picdash.Visible = True
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Dim con As New MySqlConnection("server=localhost; database=gerezatrack;username=root;password=;")
        con.Open()

        Try
            Dim cmd1 As New MySqlCommand("SELECT COUNT(*) FROM `tblinmate`", con)
            Dim countinmate As String
            countinmate = cmd1.ExecuteScalar
            lbltotalimates.Text = countinmate
        Catch ex As Exception
        End Try
        Try
            Dim currentDate As String = DateTime.Now.ToString("yyyy-MM-dd")

            Dim cmd2 As New MySqlCommand("SELECT COUNT(*) FROM `tblvisits` WHERE `visitdate` = @currentDate", con)
            cmd2.Parameters.AddWithValue("@currentDate", currentDate)
            Dim visitCount As String = cmd2.ExecuteScalar
            lbltodaysvisits.Text = visitCount
        Catch ex As Exception
        End Try
        Try
            Dim currentdt As String = DateTime.Now.ToString("yyyy-MM-dd")
            Dim cmd3 As New MySqlCommand("SELECT COUNT(*) FROM `tblreleases` WHERE `releasedate`=@currentDate", con)
            cmd3.Parameters.AddWithValue("@currentDate", currentdt)
            Dim todaysrelease As String = cmd3.ExecuteScalar
            lblnewinmates.Text = todaysrelease
        Catch ex As Exception
        End Try
        Try
            Dim cmd4 As New MySqlCommand("SELECT COUNT(*) FROM `tblcrimes`", con)
            Dim countcrimes As String = cmd4.ExecuteScalar
            lbltotalcrimesrecorded.Text = countcrimes
        Catch ex As Exception
        End Try
        Try
            Dim cmd5 As New MySqlCommand("SELECT COUNT(*) FROM tblusers", con)
            Dim countusers As String = cmd5.ExecuteScalar
            lbltotalusers.Text = countusers
        Catch ex As Exception
        End Try
        Try
            Dim datatab As New DataTable
            Dim da As New MySqlDataAdapter("SELECT `inmatenumber`, `Fullname`, `casesentense`, `visitorpriviledge` FROM `tblinmate` ORDER BY CAST(`inmatenumber` AS SIGNED) ASC", con)
            da.Fill(datatab)

            ' Rename the columns
            datatab.Columns("inmatenumber").ColumnName = "Inmate ID"
            datatab.Columns("Fullname").ColumnName = "Full Name"
            datatab.Columns("casesentense").ColumnName = "Court Sentence"
            datatab.Columns("visitorpriviledge").ColumnName = "Visitor Allowance"
            dgvinmatesdashboard.DataSource = datatab
        Catch ex As Exception
        End Try
        Try
            Dim datatbl As New DataTable
            Dim com As New MySqlCommand("SELECT `visitdate`, `fulllegalname`, `IDvisitor`, `relationshiptoinmate`, `inmatetovisit` FROM `tblvisits` ORDER BY CAST(`visitdate` AS DATETIME) DESC", con)
            Dim adapt As New MySqlDataAdapter(com)
            adapt.Fill(datatbl)
            datatbl.Columns("fulllegalname").ColumnName = "Name"
            datatbl.Columns("visitdate").ColumnName = "Visit Date"
            datatbl.Columns("IDvisitor").ColumnName = "Visitor ID"
            datatbl.Columns("relationshiptoinmate").ColumnName = "Relation"
            datatbl.Columns("inmatetovisit").ColumnName = "Visited Inmate"

            dgvtodaysvisitsdasshboard.DataSource = datatbl
        Catch
        End Try

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        users.Show()
        Me.Hide()
    End Sub
    Private Sub dgvinmatesdashboard_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgvinmatesdashboard.CellPainting
        If e.RowIndex = -1 AndAlso e.ColumnIndex >= 0 AndAlso e.PaintParts = DataGridViewPaintParts.ContentForeground Then
            Dim headerCell As DataGridViewColumnHeaderCell = dgvinmatesdashboard.Columns(e.ColumnIndex).HeaderCell
            Dim headerFont As New Font(headerCell.InheritedStyle.Font, FontStyle.Bold)

            e.Paint(e.CellBounds, DataGridViewPaintParts.Background Or DataGridViewPaintParts.Border)

            Dim headerBounds As Rectangle = e.CellBounds
            headerBounds.Y += 2  ' Adjust the position to center the text vertically

            TextRenderer.DrawText(e.Graphics, headerCell.FormattedValue.ToString(), headerFont, headerBounds, headerCell.InheritedStyle.ForeColor, TextFormatFlags.VerticalCenter Or TextFormatFlags.HorizontalCenter)

            e.Handled = True
        End If
    End Sub


End Class