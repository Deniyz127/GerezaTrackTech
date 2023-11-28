Imports MySql.Data.MySqlClient
Public Class visitor
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TabControl1.SelectedTab = TabPage3
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Dashboard.Show()
    End Sub

    Private Sub Visitor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer2.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txttimevis.Text = Date.Now.ToString("hh:mm:ss tt")
        ' txtchecktime.Text = Date.Now.ToString("hh:mm:ss tt")
        txtcheckouttime.Text = Date.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TabControl1.SelectedTab = TabPage2
        rbtnoinc.Checked = True
    End Sub

    Private Sub Rbtincidentyes_CheckedChanged(sender As Object, e As EventArgs) Handles rbtincidentyes.CheckedChanged
        If rbtincidentyes.Checked = True Then
            lblincidentrec.Visible = True
            txtrecincident.Visible = True
        End If
    End Sub

    Private Sub Rbtnoinc_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnoinc.CheckedChanged
        If rbtnoinc.Checked = True Then
            lblincidentrec.Visible = False
            txtrecincident.Visible = False
            'If rbtnoinc.Checked = True Then
            txtrecincident.Text = "No Incident During the Visit"
            'End If
        End If
    End Sub


    Private Sub Btnsearchinmatevisit_Click(sender As Object, e As EventArgs) Handles btnsearchinmatevisit.Click
        Dim con As New MySqlConnection("server=localhost; database=gerezatrack; username=root; password=;")
        Dim adt As New MySqlDataAdapter
        Dim tbl As New DataTable
        Try
            con.Open()
            Dim cmd As New MySqlCommand("SELECT `inmatenumber`, `Fullname`,  `visitorpriviledge` FROM `tblinmate` WHERE inmatenumber='" & txtinmateIDvisit.Text & "'", con)
            adt = New MySqlDataAdapter(cmd)
            adt.Fill(tbl)
            If tbl.Rows.Count > 0 Then
                txtinmatenamevisit.Text = tbl.Rows(0)("Fullname").ToString
                txtvisitorpreviledgevistit.Text = tbl.Rows(0)("visitorpriviledge").ToString
                txtinmatetovisit.Text = tbl.Rows(0)("Fullname").ToString
            Else
                MsgBox("Inmate Doesn't exist", vbExclamation + vbOKOnly, "Gereza Track Technologies")
            End If
            If txtvisitorpreviledgevistit.Text = "Denied" Then
                groupbox1disabled()
                txtvisitorpreviledgevistit.BackColor = Color.Tomato
            End If
            If txtvisitorpreviledgevistit.Text = "Granted" Then
                groupbox1enabled()
                txtvisitorpreviledgevistit.BackColor = Color.Lime
            End If
        Catch ex As Exception
            MsgBox("Error:" + ex.Message)
        End Try

    End Sub
    Sub groupbox1enabled()
        txtvisitornamevisit.Enabled = True
        dtpdisitorvisitdob.Enabled = True
        txtvisitorsIDvisit.Enabled = True
        txtvisitorsphonenumbervisit.Enabled = True
        txtrelationshiptoinmatevisit.Enabled = True
        txtinmatetovisit.Enabled = True
        txtvehicleinfovisit.Enabled = True
        txtnumofvisitorvisit.Enabled = True
        btnrecordvisit.Enabled = True

    End Sub
    Sub groupbox1disabled()
        txtvisitornamevisit.Enabled = False
        dtpdisitorvisitdob.Enabled = False
        txtvisitorsIDvisit.Enabled = False
        txtvisitorsphonenumbervisit.Enabled = False
        txtrelationshiptoinmatevisit.Enabled = False
        txtinmatetovisit.Enabled = False
        txtvehicleinfovisit.Enabled = False
        txtnumofvisitorvisit.Enabled = False
        btnrecordvisit.Enabled = False
    End Sub

    Private Sub Btnrecordvisit_Click(sender As Object, e As EventArgs) Handles btnrecordvisit.Click
        Dim conn As New MySqlConnection("server=localhost; database=gerezatrack; username=root; password=;")
        If txtinmateIDvisit.Text = "" Or
            txttimevis.Text = "" Or
            txtvisitornamevisit.Text = "" Or
            txtinmateIDvisit.Text = "" Or
            txtvisitorsphonenumbervisit.Text = "" Or
            txtrelationshiptoinmatevisit.Text = "" Or
            txtinmatetovisit.Text = "" Or
            txtvehicleinfovisit.Text = "" Or
            txtnumofvisitorvisit.Text = "" Then
            MsgBox("No null Values Accepted ", vbExclamation + vbOKOnly, "Error")
        Else

            Try
                conn.Open()
                Dim slecteddate As Date = dtpvisitdatevisit.Value
                Dim formattedDate As String = slecteddate.ToString("yyyy-MM-dd")
                Dim dob As Date = dtpdisitorvisitdob.Value
                Dim dobstr As String = dob.ToString("yyyy-MM-dd")
                Dim cmd As New MySqlCommand("INSERT INTO `tblvisits`(`inmatenumber`, `visitdate`, `letintime`, `fulllegalname`,`dobvisitor`, `IDvisitor`, `visitorphonenumber`, `relationshiptoinmate`, `inmatetovisit`, `vehicleplatenumber`, `numberofvisitors`,`inmatesname`) VALUES (@inmatenumber,@visitdate,@letintime,@fulllegalname,@dobvisitor,@IDvisitor,@visitorphonenumber,@relationshiptoinmate,@inmatetovisit,@vehicleplatenumber,@numberofvisitors,@inmatesname)", conn)
                cmd.Parameters.AddWithValue("inmatenumber", txtinmateIDvisit.Text)
                cmd.Parameters.AddWithValue("visitdate", formattedDate)
                cmd.Parameters.AddWithValue("letintime", txttimevis.Text)
                cmd.Parameters.AddWithValue("fulllegalname", txtvisitornamevisit.Text)
                cmd.Parameters.AddWithValue("dobvisitor", dobstr)
                cmd.Parameters.AddWithValue("IDvisitor", txtvisitorsIDvisit.Text)
                cmd.Parameters.AddWithValue("visitorphonenumber", txtvisitorsphonenumbervisit.Text)
                cmd.Parameters.AddWithValue("relationshiptoinmate", txtrelationshiptoinmatevisit.Text)
                cmd.Parameters.AddWithValue("inmatetovisit", txtinmatetovisit.Text)
                cmd.Parameters.AddWithValue("vehicleplatenumber", txtvehicleinfovisit.Text)
                cmd.Parameters.AddWithValue("numberofvisitors", txtnumofvisitorvisit.Text)
                cmd.Parameters.AddWithValue("inmatesname", txtinmatenamevisit.Text)
                cmd.ExecuteNonQuery()
                MsgBox("Visitor Recorded Successfully", vbInformation + vbOKOnly, "Gereza Track Technologies")
                clearvisit()
            Catch ex As Exception
                'MsgBox("Error:" + ex.Message)
            End Try
        End If
    End Sub

    Private Sub txtinmateIDvisit_GotFocus(sender As Object, e As EventArgs) Handles txtinmateIDvisit.GotFocus
        btnsearchinmatevisit.Visible = True
    End Sub
    Sub clearvisit()
        txtinmateIDvisit.Text = ""
        txttimevis.Text = ""
        txtvisitornamevisit.Text = ""
        txtinmateIDvisit.Text = ""
        txtvisitorsphonenumbervisit.Text = ""
        txtrelationshiptoinmatevisit.Text = ""
        txtinmatetovisit.Text = ""
        txtvehicleinfovisit.Text = ""
        txtnumofvisitorvisit.Text = ""
        txtinmatenamevisit.Text = ""
        txtvisitorpreviledgevistit.Text = ""
        txtvisitorsIDvisit.Text = ""
        txtinmatetovisit.Text = ""
        dtpdisitorvisitdob.Value = Date.Now.ToString("ddd, dd-MMM-yyyy")
        dtpvisitdatevisit.Value = Date.Now.ToString("ddd, dd-MMM-yyyy")
        txtvisitorpreviledgevistit.BackColor = Color.White
    End Sub

    '    Private Sub Btnsearchcheckout_Click(sender As Object, e As EventArgs) Handles btnsearchcheckout.Click
    '        calculatetime()
    '        Dim con As New MySqlConnection("server=localhost; database=gerezatrack; username=root; password=;")
    '        Dim adapt As New MySqlDataAdapter
    '        Dim tbl As New DataTable
    '        Try
    '            con.Open()
    '            Dim cmd As New MySqlCommand("SELECT `inmatenumber`, `visitdate`, `letintime`, 
    '`fulllegalname`, `dobvisitor`, `IDvisitor`, `visitorphonenumber`,
    '`relationshiptoinmate`, `inmatetovisit`, `vehicleplatenumber`, `numberofvisitors` FROM `tblvisits` WHERE IDvisitor='" & txtsearchvisitorcheckout.Text & "' AND visitdate='" & dtpcheckoutdate.Value & "'", con)
    '            adapt = New MySqlDataAdapter(cmd)
    '            adapt.Fill(tbl)
    '            If tbl.Rows.Count > 0 Then
    '                txtinmateIDcheckout.Text = tbl.Rows(0)("inmatenumber").ToString
    '                'dtpcheckoutdate.Value = tbl.Rows(0)("visitdate").ToString
    '                txtchecktimecheckout.Text = tbl.Rows(0)("letintime").ToString
    '                txtvisitorsnamecheckout.Text = tbl.Rows(0)("fulllegalname").ToString
    '                txtvisitorsdobcheckout.Text = tbl.Rows(0)("dobvisitor").ToString
    '                txtvisitorsIDcheckout.Text = tbl.Rows(0)("IDvisitor").ToString
    '                txtvisitorsphonenumber.Text = tbl.Rows(0)("visitorphonenumber").ToString
    '                txtrelationshiptoinmatecheckout.Text = tbl.Rows(0)("relationshiptoinmate").ToString
    '                txtinmatetovisitcheckout.Text = tbl.Rows(0)("inmatetovisit").ToString
    '                txtvehicleinfocheckout.Text = tbl.Rows(0)("vehicleplatenumber").ToString
    '                txtnumofvixitorscheckout.Text = tbl.Rows(0)("numberofvisitors").ToString
    '            End If
    '        Catch ex As Exception
    '            MsgBox("Error:" + ex.Message)
    '        End Try
    '    End Sub
    Private Sub Btnsearchcheckout_Click(sender As Object, e As EventArgs) Handles btnsearchcheckout.Click

        Dim con As New MySqlConnection("server=localhost; database=gerezatrack; username=root; password=;")
        Dim adapt As New MySqlDataAdapter
        Dim tbl As New DataTable
        If txtsearchvisitorcheckout.Text = "" Or txtdatesearch.Text = "" Then
            MsgBox("Fill The search fields to continue...", vbExclamation + vbOKOnly, "Gereza Track Technologies")
            clearvisits()
        Else
            Try
                con.Open()
                Dim cmd As New MySqlCommand("SELECT `inmatenumber`, `visitdate`, `letintime`, `fulllegalname`, `dobvisitor`, `IDvisitor`, `visitorphonenumber`, `relationshiptoinmate`, `inmatetovisit`, `vehicleplatenumber`, `numberofvisitors`,inmatesname FROM `tblvisits` WHERE IDvisitor = @visitorID and visitdate=@visitDate", con)
                cmd.Parameters.AddWithValue("@visitorID", txtsearchvisitorcheckout.Text)
                cmd.Parameters.AddWithValue("@visitDate", txtdatesearch.Text)

                adapt = New MySqlDataAdapter(cmd)
                adapt.Fill(tbl)
                If tbl.Rows.Count > 0 Then
                    txtinmateIDcheckout.Text = tbl.Rows(0)("inmatenumber").ToString
                    txtchecktimecheckout.Text = tbl.Rows(0)("letintime").ToString
                    txtvisitorsnamecheckout.Text = tbl.Rows(0)("fulllegalname").ToString
                    txtvisitorsdobcheckout.Text = tbl.Rows(0)("dobvisitor").ToString
                    txtvisitorsIDcheckout.Text = tbl.Rows(0)("IDvisitor").ToString
                    txtvisitorsphonenumber.Text = tbl.Rows(0)("visitorphonenumber").ToString
                    txtrelationshiptoinmatecheckout.Text = tbl.Rows(0)("relationshiptoinmate").ToString
                    txtinmatetovisitcheckout.Text = tbl.Rows(0)("inmatetovisit").ToString
                    txtvehicleinfocheckout.Text = tbl.Rows(0)("vehicleplatenumber").ToString
                    txtnumofvixitorscheckout.Text = tbl.Rows(0)("numberofvisitors").ToString
                    txtinmatenamecheckout.Text = tbl.Rows(0)("inmatesname").ToString
                    dtpcheckoutdate.Value = tbl.Rows(0)("visitdate")
                Else
                    MsgBox("Visitors Identification Not Recorded", vbExclamation, "Identification Number Error")
                End If
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            End Try
        End If
        calculatetime()

    End Sub
    Sub calculatetime()
        Dim entryTimeString As String = txtchecktimecheckout.Text
        Dim checkoutTimeString As String = txtcheckouttime.Text

        Dim entryTime As DateTime
        Dim checkoutTime As DateTime
        If DateTime.TryParse(entryTimeString, entryTime) AndAlso DateTime.TryParse(checkoutTimeString, checkoutTime) Then
            Dim timeTaken As TimeSpan = checkoutTime - entryTime

            Dim hours As Integer = timeTaken.Hours
            Dim minutes As Integer = timeTaken.Minutes
            Dim seconds As Integer = timeTaken.Seconds

            txtdurationtakenvisit.Text = hours.ToString() & " hrs " & minutes.ToString() & " mins " & seconds.ToString() & " secs"
        End If
    End Sub

    Private Sub Btnsavesheckout_Click(sender As Object, e As EventArgs) Handles btnsavesheckout.Click
        Dim con As New MySqlConnection("Server=localhost; Database=gerezatrack; username=root; password=;")
        If txtvisitorsIDcheckout.Text = "" Or
        txtcheckouttime.Text = "" Or
        txtdurationtakenvisit.Text = "" Or
        txtrecincident.Text = "" Or
        txtinmateIDcheckout.Text = "" Or
        txtvisitorsnamecheckout.Text = "" Or
        txtvisitorsdobcheckout.Text = "" Or
        txtvisitorsphonenumber.Text = "" Or
        txtrelationshiptoinmatecheckout.Text = "" Or
        txtinmatetovisitcheckout.Text = "" Or
        txtvehicleinfocheckout.Text = "" Or
        txtnumofvixitorscheckout.Text = "" Or
        txtdatesearch.Text = "" Then
            MsgBox("Please Fill the Empty Fields", vbExclamation + vbOKOnly, "Gereza Track Technologies")
        Else
            Try
                con.Open()
                Dim cmd As New MySqlCommand("INSERT INTO `tblvisitorscheckout`(`visitorsID`, `checkouttime`, `duration`, `incident`,inmatesname) VALUES (@visitorsID,@checkouttime,@duration,@incident,@inmatesname)", con)
                cmd.Parameters.AddWithValue("@visitorsID", txtvisitorsIDcheckout.Text)
                cmd.Parameters.AddWithValue("@checkouttime", txtcheckouttime.Text)
                cmd.Parameters.AddWithValue("@duration", txtdurationtakenvisit.Text)
                cmd.Parameters.AddWithValue("@incident", txtrecincident.Text)
                cmd.Parameters.AddWithValue("@inmatesname", txtinmatenamecheckout.Text)
                cmd.ExecuteNonQuery()
                MsgBox("Checkout Recorded Successfully", vbInformation + vbOKOnly, "GerezaTrack Technologies")
                txtsearchvisitorcheckout.Text = ""
                txtdatesearch.Text = ""
                clearvisits()
            Catch ex As Exception
                MsgBox("Error:" + ex.Message)
            End Try
        End If
    End Sub
    Sub incident()
        If rbtnoinc.Checked = True Then
            txtrecincident.Text = "No Incident During the Visit"
        End If
    End Sub
    Sub clearvisits()
        txtvisitorsIDcheckout.Text = ""
        txtinmatenamecheckout.Text = ""
        rbtnoinc.Checked = True
        txtchecktimecheckout.Text = ""
        txtcheckouttime.Text = ""
        txtdurationtakenvisit.Text = ""
        txtrecincident.Text = ""
        txtinmateIDcheckout.Text = ""
        txtvisitorsnamecheckout.Text = ""
        txtvisitorsdobcheckout.Text = ""
        txtvisitorsphonenumber.Text = ""
        txtrelationshiptoinmatecheckout.Text = ""
        txtinmatetovisitcheckout.Text = ""
        txtvehicleinfocheckout.Text = ""
        txtnumofvixitorscheckout.Text = ""
        dtpcheckoutdate.Value = ""
        txtdatesearch.Text = ""
        txtsearchvisitorcheckout.Text = ""
    End Sub

    Private Sub Btnshowallvisitors_Click(sender As Object, e As EventArgs) Handles btnshowallvisitors.Click
        Timer2.Enabled = True
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim connect As New MySqlConnection("server=localhost; database=gerezatrack; username=root; password=;")
        Try
            connect.Open()
            Dim tbl As New DataTable
            Dim com As New MySqlCommand("SELECT `inmatenumber`,`fulllegalname`,`IDvisitor`,  `relationshiptoinmate`, `inmatetovisit`, `visitdate`,letintime, `vehicleplatenumber`FROM `tblvisits`", connect)
            Dim adapt As New MySqlDataAdapter(com)
            adapt.Fill(tbl)
            tbl.Columns("inmatenumber").ColumnName = "Inmate ID"
            tbl.Columns("visitdate").ColumnName = "Visit Date"
            tbl.Columns("letintime").ColumnName = "Checkin"
            tbl.Columns("fulllegalname").ColumnName = "Visitors Name"
            tbl.Columns("IDvisitor").ColumnName = "Visitors ID"
            tbl.Columns("relationshiptoinmate").ColumnName = "R/ship"
            tbl.Columns("inmatetovisit").ColumnName = "Visit Inmate"
            tbl.Columns("vehicleplatenumber").ColumnName = "Vehicle ID"
            dgvlistvisits.DataSource = tbl
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Btnsearchvisitorslist_Click(sender As Object, e As EventArgs) Handles btnsearchvisitorslist.Click
        Timer2.Enabled = False
        btnshowallvisitors.Visible = True
        Dim con As New MySqlConnection("server=localhost; database=gerezatrack; username=root; password=;")
        Try
            If txtsearchvisitorslist.Text = "" Then
                If MsgBox("Input Visitor ID to continue..", vbExclamation + vbOKCancel) = MsgBoxResult.Ok Then
                    txtsearchvisitorcheckout.Select()
                End If
            Else
                con.Open()
            Dim tbl As New DataTable
            Dim com As New MySqlCommand("SELECT `inmatenumber`,`fulllegalname`,`IDvisitor`,  `relationshiptoinmate`, `inmatetovisit`, `visitdate`,letintime, `vehicleplatenumber`FROM `tblvisits` where IDvisitor='" & txtsearchvisitorslist.Text & "' ", con)
            Dim adapt As New MySqlDataAdapter(com)
            adapt.Fill(tbl)
            tbl.Columns("inmatenumber").ColumnName = "Inmate ID"
            tbl.Columns("visitdate").ColumnName = "Visit Date"
            tbl.Columns("letintime").ColumnName = "Checkin"
            tbl.Columns("fulllegalname").ColumnName = "Visitors Name"
            tbl.Columns("IDvisitor").ColumnName = "Visitors ID"
            tbl.Columns("relationshiptoinmate").ColumnName = "R/ship"
            tbl.Columns("inmatetovisit").ColumnName = "Visit Inmate"
            tbl.Columns("vehicleplatenumber").ColumnName = "Vehicle ID"
                dgvlistvisits.DataSource = tbl
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class