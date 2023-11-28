Imports MySql.Data.MySqlClient
Imports System.IO
Public Class inmate
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TabControl1.SelectedTab = TabPage1
        txtinmatenumber.Select()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TabControl1.SelectedTab = TabPage2
        Timer1.Enabled = True

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TabControl1.SelectedTab = TabPage3
        txtsearchdetails.Select()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TabControl1.SelectedTab = TabPage4
        txtsearchedit.Select()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TabControl1.SelectedTab = TabPage5
        txtsearchdemise.Select()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TabControl1.SelectedTab = TabPage6
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TabControl1.SelectedTab = TabPage7
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Hide()
        Dashboard.Show()
    End Sub

    Private Sub Rballergiesyes_CheckedChanged(sender As Object, e As EventArgs) Handles rballergiesyes.CheckedChanged
        If rballergiesyes.Checked = True Then
            txtallergies.Enabled = True
            txtallergiesconditions.Text = "Yes"
            txtallergies.Text = ""
        Else
            txtallergies.Enabled = False
            txtallergiesconditions.Text = "No"
            txtallergies.Text = "N/A"
        End If
    End Sub

    Private Sub Inmate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbappno.Checked = True
        rballlno.Checked = True
        Timer1.Enabled = True
    End Sub

    Private Sub Rbappealyes_CheckedChanged_1(sender As Object, e As EventArgs) Handles rbappealyes.CheckedChanged
        If rbappealyes.Checked = True Then
            dtpappeal.Enabled = True
            txtcourtlocation.Enabled = True
            txtcasenumber.Enabled = True
            txtappealcondition.Text = "Yes"
        End If
    End Sub

    Private Sub Rbedityes_CheckedChanged(sender As Object, e As EventArgs) Handles rbedityes.CheckedChanged
        If rbedityes.Checked = True Then
            btneditdemise.Visible = True
        End If
    End Sub

    Private Sub Rbeditno_CheckedChanged(sender As Object, e As EventArgs) Handles rbeditno.CheckedChanged
        If rbeditno.Checked = True Then
            btneditdemise.Visible = False
        End If
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        TabControl1.SelectedTab = TabPage8
    End Sub

    Private Sub Rbyeshealth_CheckedChanged(sender As Object, e As EventArgs) Handles rbyeshealth.CheckedChanged
        If rbyeshealth.Checked = True Then
            txtsearchhealth.Visible = True
            btnsearchhealth.Visible = True
            btnhealthupdates.Visible = True
            Label180.Visible = True
        End If
    End Sub

    Private Sub Rbnohealth_CheckedChanged(sender As Object, e As EventArgs) Handles rbnohealth.CheckedChanged
        If rbnohealth.Checked = True Then
            txtsearchhealth.Visible = False
            btnsearchhealth.Visible = False
            btnhealthupdates.Visible = False
            Label180.Visible = False
        End If
    End Sub

    Private Sub Btnsearchinmatedetails_Click(sender As Object, e As EventArgs) Handles btnsearchinmatedetails.Click
        TabControl1.SelectedTab = TabPage3
    End Sub

    Private Sub Btnupdateinmateadd_Click(sender As Object, e As EventArgs) Handles btnupdateinmateadd.Click
        TabControl1.SelectedTab = TabPage4
    End Sub

    Private Sub Btnleftpic_Click(sender As Object, e As EventArgs) Handles btnleftpic.Click
        Dim filepath As String
        OpenFileDialog1.ShowDialog()
        OpenFileDialog1.Filter = "JPG files (*.jpg)| *jpg"
        picleftside.SizeMode = PictureBoxSizeMode.StretchImage
        filepath = OpenFileDialog1.FileName
        picleftside.Image = Image.FromFile(filepath)
    End Sub

    Private Sub Btnfrontpic_Click(sender As Object, e As EventArgs) Handles btnfrontpic.Click
        Dim pathfile As String
        OpenFileDialog2.ShowDialog()
        OpenFileDialog2.Filter = "JPG files(*.jpg)|*.jpg"
        picfrontside.SizeMode = PictureBoxSizeMode.StretchImage
        pathfile = OpenFileDialog2.FileName
        picfrontside.Image = Image.FromFile(pathfile)
    End Sub

    Private Sub Btnrightpic_Click(sender As Object, e As EventArgs) Handles btnrightpic.Click
        OpenFileDialog3.ShowDialog()
        Dim paths As String
        OpenFileDialog3.Filter = "JPG files(*.jpg)| *.jpg"
        picrightside.SizeMode = PictureBoxSizeMode.StretchImage
        paths = OpenFileDialog3.FileName
        picrightside.Image = Image.FromFile(paths)
    End Sub

    Private Sub Btnsaveinmate_Click(sender As Object, e As EventArgs) Handles btnsaveinmate.Click
        Dim con As New MySqlConnection("server=localhost;username=root;password=;database=gerezatrack")
        Dim msleft As New MemoryStream
        Dim msfront As New MemoryStream
        Dim msright As New MemoryStream

        Try
            If picleftside.Image IsNot Nothing AndAlso picrightside.Image IsNot Nothing AndAlso picfrontside.Image IsNot Nothing Then
                picleftside.Image.Save(msleft, picleftside.Image.RawFormat)
                picrightside.Image.Save(msfront, picrightside.Image.RawFormat)
                picfrontside.Image.Save(msright, picfrontside.Image.RawFormat)
            Else

                MsgBox("Please Select Images", vbExclamation + vbOKOnly)
                Return
            End If
            If txtinmatenumber.Text = "" Or txtfullname.Text = "" Or txtcounttyofbirth.Text = "" Or Txtnationality.Text = "" Or txtidnum.Text = "" Or cbogender.Text = "" Or cbomaritalstatus.Text = "" Or txtnumoftattoos.Text = "" Or cbolevelofeducation.Text = "" Or cbomentalhealthcondition.Text = "" Or txtinmatereligion.Text = "" Or txtappealcondition.Text = "" Or txtcasenumber.Text = "" Or txtallergiesconditions.Text = "" Or txtallergies.Text = "" Or txtcourtsentences.Text = "" Or txtmedications.Text = "" Or txtnextofkin.Text = "" Or txtemergencycontact.Text = "" Or cbovisitorpreviladge.Text = "" Or txtcrimescomminted.Text = "" Or txtrelationtoEC.Text = "" Then
                MsgBox("Please fill the empty fields", vbExclamation + vbOKCancel, "GerezaTrack Technologies")

            Else
                con.Open()
                Dim slecteddate As Date = dtparrestdate.Value
                Dim formattedDate As String = slecteddate.ToString("yyyy-MM-dd")
                Dim dob As Date = dtpdop.Value
                Dim dobstr As String = dob.ToString("yyyy-MM-dd")
                Dim query As String = "INSERT INTO `tblinmate`(`inmatenumber`, `Fullname`, `dob`, `countyofbirth`, `nationality`, `Idnumber`, `gender`, `maritalstatus`, `numoftattoos`, `educationlevel`, `mentalstate`, `religion`, `arrestdate`, `sentencedate`, `appealcondition`, `apppealdate`, `courtlocation`, `casenumber`, `allergiescondition`, `allaergies`, `casesentense`, `medications`, `nextofkin`, `emergencycontact`, `visitorpriviledge`, `crimescommited`, `leftpic`, `frontpic`, `rightpic`, `relationtoEC`) VALUES (@inmatenum, @fullname, @dob, @countyofbirth, @nationality, @idnumber, @gender, @maritalstatus, @numoftattoos, @educationlevel, @mentalstate, @religion, @arrestdate, @sentencedate, @appealcondition, @appealdate, @courtlocation, @casenumber, @allergiescondition, @allergies, @casesentense, @medications, @nextofkin, @emergencycontact, @visitorspriviledge, @crimescommited, @leftpic, @frontpic, @rightpic, @relationtoEC)"
                Dim cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@inmatenum", txtinmatenumber.Text)
                cmd.Parameters.AddWithValue("@fullname", txtfullname.Text)
                cmd.Parameters.AddWithValue("@dob", dtpdop.Value)
                cmd.Parameters.AddWithValue("@countyofbirth", txtcounttyofbirth.Text)
                cmd.Parameters.AddWithValue("@nationality", Txtnationality.Text)
                cmd.Parameters.AddWithValue("@idnumber", txtidnum.Text)
                cmd.Parameters.AddWithValue("@gender", cbogender.Text)
                cmd.Parameters.AddWithValue("@maritalstatus", cbomaritalstatus.Text)
                cmd.Parameters.AddWithValue("@numoftattoos", txtnumoftattoos.Text)
                cmd.Parameters.AddWithValue("@educationlevel", cbolevelofeducation.Text)
                cmd.Parameters.AddWithValue("@mentalstate", cbomentalhealthcondition.Text)
                cmd.Parameters.AddWithValue("@religion", txtinmatereligion.Text)
                cmd.Parameters.AddWithValue("@arrestdate", formattedDate)
                cmd.Parameters.AddWithValue("@sentencedate", dobstr)
                cmd.Parameters.AddWithValue("@appealcondition", txtappealcondition.Text)
                cmd.Parameters.AddWithValue("@appealdate", dtpappeal.Value)
                cmd.Parameters.AddWithValue("@courtlocation", txtcourtlocation.Text)
                cmd.Parameters.AddWithValue("@casenumber", txtcasenumber.Text)
                cmd.Parameters.AddWithValue("@allergiescondition", txtallergiesconditions.Text)
                cmd.Parameters.AddWithValue("@allergies", txtallergies.Text)
                cmd.Parameters.AddWithValue("@casesentense", txtcourtsentences.Text)
                cmd.Parameters.AddWithValue("@medications", txtmedications.Text)
                cmd.Parameters.AddWithValue("@nextofkin", txtnextofkin.Text)
                cmd.Parameters.AddWithValue("@emergencycontact", txtemergencycontact.Text)
                cmd.Parameters.AddWithValue("@visitorspriviledge", cbovisitorpreviladge.Text)
                cmd.Parameters.AddWithValue("@crimescommited", txtcrimescomminted.Text)
                cmd.Parameters.Add("@leftpic", MySqlDbType.LongBlob).Value = msleft.ToArray()
                cmd.Parameters.Add("@frontpic", MySqlDbType.LongBlob).Value = msfront.ToArray()
                cmd.Parameters.Add("@rightpic", MySqlDbType.LongBlob).Value = msright.ToArray()
                cmd.Parameters.AddWithValue("@relationtoEC", txtrelationtoEC.Text)

                cmd.ExecuteNonQuery()
                MsgBox("Inmate Information Recorded Successfully", vbInformation + vbOKOnly, "Gereza Track Technologies")
                clearfields()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Rbappno_CheckedChanged(sender As Object, e As EventArgs) Handles rbappno.CheckedChanged
        If rbappno.Checked = True Then
            dtpappeal.Value = dtpappeal.MinDate
            dtpappeal.Enabled = False
            txtcourtlocation.Enabled = False
            txtcasenumber.Enabled = False
            txtappealcondition.Text = "No : Appeal Date is Invalid"
            txtcourtlocation.Text = "N/A"
            txtcasenumber.Text = "N/A"
        Else
            dtpappeal.Enabled = True
            txtcourtlocation.Enabled = True
            txtcasenumber.Enabled = True
            txtappealcondition.Text = "Yes"
            txtcourtlocation.Text = ""
            txtcasenumber.Text = ""
            dtpappeal.Value = Date.Now.ToString("ddd, dd-MMM-yyyy")
        End If
    End Sub
    Sub clearfields()
        txtinmatenumber.Text = ""
        txtfullname.Text = ""
        dtpdop.Value = Date.Now.ToString("ddd, dd-MMM-yyyy")
        txtcounttyofbirth.Text = ""
        Txtnationality.Text = ""
        txtidnum.Text = ""
        cbogender.Text = ""
        cbomaritalstatus.Text = ""
        txtnumoftattoos.Text = ""
        cbolevelofeducation.Text = ""
        cbomentalhealthcondition.Text = ""
        txtinmatereligion.Text = ""
        dtparrestdate.Value = Date.Now.ToString("ddd, dd-MMM-yyyy")
        dtpsentencedate.Value = Date.Now.ToString("ddd, dd-MMM-yyyy")
        txtappealcondition.Text = ""
        dtpappeal.Value = Date.Now.ToString("ddd, dd-MMM-yyyy")
        txtcourtlocation.Text = ""
        txtcasenumber.Text = ""
        txtallergiesconditions.Text = ""
        txtallergies.Text = ""
        txtcourtsentences.Text = ""
        txtmedications.Text = ""
        txtnextofkin.Text = ""
        txtemergencycontact.Text = ""
        cbovisitorpreviladge.Text = ""
        txtcrimescomminted.Text = ""
        txtrelationtoEC.Text = ""
        rballlno.Checked = True
        rbappno.Checked = True
        picleftside.Image = Nothing
        picfrontside.Image = Nothing
        picrightside.Image = Nothing
    End Sub
    'This Code from here should be reviewed For correction the sentense Txt is Not being Fieled Up
    Private Sub Btnsearchdetails_Click_1(sender As Object, e As EventArgs) Handles btnsearchinfo.Click
        Dim con As New MySqlConnection("server=localhost;username=root;password=;database=gerezatrack;")
        Dim ad As New MySqlDataAdapter
        Dim pic() As Byte
        Dim dt As New DataTable
        Try
            If txtsearchdetails.Text = "" Then
                MsgBox("Please Enter the inmate Number to continue... ", vbExclamation + vbOKCancel, "Gereza Track Technologies")
                searchclear()
            Else
                Dim cmd As New MySqlCommand("SELECT `inmatenumber`, `Fullname`, `dob`, `countyofbirth`, `nationality`, `Idnumber`, `gender`, `maritalstatus`, `numoftattoos`, `educationlevel`, `mentalstate`, `religion`, `arrestdate`, `sentencedate`, `appealcondition`, `apppealdate`, `courtlocation`,`casenumber`, `allergiescondition`, `allaergies`, `casesentense`, `medications`, `nextofkin`, `emergencycontact`, `visitorpriviledge`, `crimescommited`, `rightpic`, `relationtoEC` FROM `tblinmate` WHERE `inmatenumber`='" & txtsearchdetails.Text & "'", con)
                ad = New MySqlDataAdapter(cmd)
                ad.Fill(dt)

                If dt.Rows.Count > 0 Then
                    txtinmatenumsearch.Text = dt.Rows(0)("inmatenumber").ToString
                    txtfullnamesearch.Text = dt.Rows(0)("Fullname").ToString
                    txtdobsearch.Text = dt.Rows(0)("dob").ToString
                    agedetails()
                    txtcountysearch.Text = dt.Rows(0)("countyofbirth").ToString
                    txtnationallitysearch.Text = dt.Rows(0)("nationality").ToString
                    txtidsearch.Text = dt.Rows(0)("Idnumber").ToString
                    cbogendersearch.Text = dt.Rows(0)("gender").ToString
                    cbomaritalsearch.Text = dt.Rows(0)("maritalstatus").ToString
                    txttatoossearch.Text = dt.Rows(0)("numoftattoos").ToString
                    cboeducationlevelsearch.Text = dt.Rows(0)("educationlevel").ToString
                    cbomentalillsearch.Text = dt.Rows(0)("mentalstate").ToString
                    txtreligionsearch.Text = dt.Rows(0)("religion").ToString
                    txtarrestdatesearch.Text = dt.Rows(0)("arrestdate").ToString
                    txtcourtdatesearch.Text = dt.Rows(0)("sentencedate").ToString
                    txtsentencesearch.Text = dt.Rows(0)("casesentense").ToString
                    cbovisitorspreviledgesearch.Text = dt.Rows(0)("visitorpriviledge").ToString
                    txtappealconditionsearch.Text = dt.Rows(0)("appealcondition").ToString
                    txtappealdatesearch.Text = dt.Rows(0)("apppealdate").ToString
                    txtcourtlocationsearch.Text = dt.Rows(0)("courtlocation").ToString
                    txtcasenumbersearch.Text = dt.Rows(0)("casenumber").ToString
                    txtallergiesconditionsearch.Text = dt.Rows(0)("allergiescondition").ToString
                    txtallergiessearch.Text = dt.Rows(0)("allaergies").ToString
                    txtmedicationssearch.Text = dt.Rows(0)("medications").ToString
                    txtnextofkinsearch.Text = dt.Rows(0)("nextofkin").ToString
                    txtemergencycontactsearch.Text = dt.Rows(0)("emergencycontact").ToString
                    txtrelationtoECsearch.Text = dt.Rows(0)("relationtoEC").ToString
                    txtcrimescommitedsearch.Text = dt.Rows(0)("crimescommited").ToString
                    pic = dt.Rows(0)("rightpic")
                    Dim mst As New MemoryStream(pic)
                    picfrontsearch.Image = Image.FromStream(mst)
                    picfrontsearch.SizeMode = PictureBoxSizeMode.StretchImage
                Else
                    If MsgBox("The Inmate Has not been Recorded In the System", vbExclamation, "Gereza Track Tech") = MsgBoxResult.Ok Then

                    End If
                End If
                If txtallergiesconditionsearch.Text = "Yes" Then
                    rballergiesyessearch.Checked = True
                Else
                    rballerrgiesnosearch.Checked = True
                End If
                If txtappealconditionsearch.Text = "Yes" Then
                    rbappealyessearch.Checked = True
                    txtappealdatesearch.Text = dt.Rows(0)("apppealdate").ToString
                Else
                    rbappealnosearch.Checked = True
                    txtappealdatesearch.Text = "N/A"
                End If
                If cbovisitorspreviledgesearch.Text = "Granted" Then
                    cbovisitorspreviledgesearch.BackColor = Color.Lime
                    cbovisitorspreviledgesearch.ForeColor = Color.Black
                    cbovisitorspreviledgesearch.Font = New Font(cbovisitorspreviledgesearch.Font, FontStyle.Bold)
                End If

                If cbovisitorspreviledgesearch.Text = "Denied" Then
                    cbovisitorspreviledgesearch.BackColor = Color.Salmon
                    cbovisitorspreviledgesearch.ForeColor = Color.White
                    cbovisitorspreviledgesearch.Font = New Font(cbovisitorspreviledgesearch.Font, FontStyle.Bold)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            If txtsearchdetails.Text = "" Then
                txtreleaseconditiondetails.Text = ""
            Else

                Dim connection As New MySqlConnection("server=localhost;database=gerezatrack;username=root;password=;")
                connection.Open()
                Dim adapta As New MySqlDataAdapter
                Dim com As New MySqlCommand("SELECT `inmatenumber` FROM `tblreleases` WHERE inmatenumber = '" & txtsearchdetails.Text & "'", connection)
                Dim dtable As New DataTable
                adapta = New MySqlDataAdapter(com)
                adapta.Fill(dtable)
                If dtable.Rows.Count > 0 Then
                    txtreleaseconditiondetails.Text = "Inmate Released"
                    txtreleaseconditiondetails.BackColor = Color.Lime
                ElseIf dtable.Rows.Count < 0 Then
                    txtreleaseconditiondetails.Text = "Inmate Serving Sentence"
                    txtreleaseconditiondetails.BackColor = Color.Salmon
                Else
                    txtreleaseconditiondetails.Text = "N/A"
                    txtreleaseconditiondetails.BackColor = Color.White
                End If
            End If
        Catch ex As Exception

        End Try
        Try
            If txtsearchdetails.Text = "" Then
                txtindisciplinecasessearch.Text = ""
            Else

                Dim cn As New MySqlConnection("server=localhost;database=gerezatrack;username=root;password=;")
                cn.Open()
                Dim indisciplineCmd As New MySqlCommand("SELECT `indisciplinecase` FROM `tblindiscipline` WHERE `inmatenumber` = @inmatenumber", cn)
                indisciplineCmd.Parameters.AddWithValue("@inmatenumber", txtinmatenumsearch.Text)

                Dim indisciplineReader As MySqlDataReader = indisciplineCmd.ExecuteReader()

                If indisciplineReader.Read() Then
                    txtindisciplinecasessearch.Text = indisciplineReader("indisciplinecase").ToString()

                Else
                    txtindisciplinecasessearch.Text = "No indiscipline case found."

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub
    Sub agedetails()
        Dim bdate As DateTime = txtdobsearch.Text
        Dim dtoday As DateTime = DateTime.Today
        Dim agesearch As Integer = dtoday.Year - bdate.Year
        txtagedetails.Text = agesearch.ToString
    End Sub
    Private Sub Rballlno_CheckedChanged(sender As Object, e As EventArgs) Handles rballlno.CheckedChanged
        If rballlno.Checked = True Then
            txtallergiesconditions.Text = "No"
            txtallergies.Text = "N/A"
        End If
    End Sub



    Private Sub Btnsearchedit_Click(sender As Object, e As EventArgs) Handles btnsearchedit.Click
        Dim con As New MySqlConnection("server=localhost;database=gerezatrack;username=root;password=;")
        Dim dt As New DataTable
        Dim ad As New MySqlDataAdapter
        Dim photo() As Byte
        Try
            con.Open()

            If txtsearchedit.Text = "" Then
                MsgBox("Please Input the Inmate number")
            Else
                Dim cmd As New MySqlCommand("SELECT `inmatenumber`, `Fullname`, `dob`, `countyofbirth`,`nationality`, `Idnumber`, `gender`, `maritalstatus`, `numoftattoos`, `educationlevel`, `mentalstate`, `religion`, `arrestdate`, `sentencedate`, `appealcondition`, `apppealdate`, `courtlocation`,`casenumber`, `allergiescondition`, `allaergies`, `casesentense`,`medications`, `nextofkin`, `emergencycontact`, `visitorpriviledge`, `crimescommited`, `rightpic`, `relationtoEC` FROM `tblinmate` WHERE `inmatenumber`='" & txtsearchedit.Text & "'", con)
                ad = New MySqlDataAdapter(cmd)
                ad.Fill(dt)
                editclear()
                If dt.Rows.Count > 0 Then
                    txtinmatenumedit.Text = dt.Rows(0)("inmatenumber").ToString
                    txtfullnameedit.Text = dt.Rows(0)("Fullname").ToString
                    txtdobedit.Text = dt.Rows(0)("dob").ToString
                    txtcountyedit.Text = dt.Rows(0)("countyofbirth").ToString
                    txtnationallityedit.Text = dt.Rows(0)("nationality").ToString
                    txtidedit.Text = dt.Rows(0)("Idnumber").ToString
                    cbogenderedit.Text = dt.Rows(0)("gender").ToString
                    cbomaritalstatusedit.Text = dt.Rows(0)("maritalstatus").ToString
                    txttattosedit.Text = dt.Rows(0)("numoftattoos").ToString
                    cboeducationleveledit.Text = dt.Rows(0)("educationlevel").ToString
                    cbomentalilledit.Text = dt.Rows(0)("mentalstate").ToString
                    txtreligionedit.Text = dt.Rows(0)("religion").ToString
                    dtparrestdateedit.Value = dt.Rows(0)("arrestdate").ToString
                    dtpcourtdateedit.Value = dt.Rows(0)("sentencedate").ToString
                    txtcourtsentenceedit.Text = dt.Rows(0)("casesentense").ToString
                    cbovisitiorspreviledgeedit.Text = dt.Rows(0)("visitorpriviledge").ToString
                    txtappealcondititonedit.Text = dt.Rows(0)("appealcondition").ToString
                    dtpappealdateedit.Value = dt.Rows(0)("apppealdate").ToString
                    txtcourtlocationedit.Text = dt.Rows(0)("courtlocation").ToString
                    txtcasenumberedit.Text = dt.Rows(0)("casenumber").ToString
                    txtallergiesconditionedit.Text = dt.Rows(0)("allergiescondition").ToString
                    txtrecordallergiesedit.Text = dt.Rows(0)("allaergies").ToString
                    txtmedicationedit.Text = dt.Rows(0)("medications").ToString
                    txtnextofkinedit.Text = dt.Rows(0)("nextofkin").ToString
                    txtemergencycontactedit.Text = dt.Rows(0)("emergencycontact").ToString
                    txtrelationtoECedit.Text = dt.Rows(0)("relationtoEC").ToString
                    txtcrimecommitededit.Text = dt.Rows(0)("crimescommited").ToString
                    photo = dt.Rows(0)("rightpic")
                    Dim mst As New MemoryStream(photo)
                    picedit.Image = Image.FromStream(mst)
                    picedit.SizeMode = PictureBoxSizeMode.StretchImage
                    If txtindisciplinecasesedit.Text = "" Then
                        txtindisciplinecasesedit.Text = "N/A"
                    End If
                Else
                    MsgBox("Inmate Doesn't Exist", vbExclamation + vbRetry, "Gereza Track Tech")
                End If
                If txtallergiesconditionedit.Text = "Yes" Then
                    radyesallergiesedit.Checked = True
                Else

                    radnoallergiesedit.Checked = True
                End If
                If txtappealcondititonedit.Text = "Yes" Then
                    radappealyesedit.Checked = True
                    dtpappealdateedit.Value = dt.Rows(0)("apppealdate").ToString
                Else
                    radappealnoedit.Checked = True
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        Try
            con.Open()
            Dim dmt As New DataTable
            Dim cmd As New MySqlCommand("SELECT  `inmatenumber`, `indisciplinecase` FROM `tblindiscipline` WHERE `inmatenumber`='" & txtsearchedit.Text & "'", con)
            Dim adt As New MySqlDataAdapter
            adt = New MySqlDataAdapter(cmd)
            adt.Fill(dmt)
            If dmt.Rows.Count > 0 Then
                txtindisciplinecasesedit.Text = dmt.Rows(0)("indisciplinecase").ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btnsaveupdates_Click(sender As Object, e As EventArgs) Handles btnsaveupdates.Click
        Dim con As New MySqlConnection("server=localhost;database=gerezatrack;username=root;password=;")
        Try
            If txtsearchedit.Text = "" Then
                MsgBox("No null values Allowed", vbExclamation + vbRetryCancel, "Gereza Track Technologies")
            Else
                con.Open()
                Dim cmd As New MySqlCommand("UPDATE `tblinmate` SET `inmatenumber`='" & txtinmatenumedit.Text & "',`Fullname`='" & txtfullnameedit.Text & "',`dob`='" & txtdobedit.Text & "',`countyofbirth`='" & txtcountyedit.Text & "',`nationality`='" & txtnationallityedit.Text & "',`Idnumber`='" & txtidedit.Text & "',`gender`='" & cbogenderedit.Text & "',`maritalstatus`='" & cbomaritalstatusedit.Text & "',`numoftattoos`='" & txttattosedit.Text & "',`educationlevel`='" & cboeducationleveledit.Text & "',`mentalstate`='" & cbomaritalstatusedit.Text & "',`religion`='" & txtreligionedit.Text & "',`arrestdate`='" & dtparrestdateedit.Value & "',`sentencedate`='" & dtpcourtdateedit.Value & "',`appealcondition`='" & txtappealcondititonedit.Text & "',`apppealdate`='" & dtpappealdateedit.Value & "',`courtlocation`='" & txtcourtlocationedit.Text & "',`casenumber`='" & txtcasenumberedit.Text & "',`allergiescondition`='" & txtallergiesconditionedit.Text & "',`allaergies`='" & txtrecordallergiesedit.Text & "',`medications`='" & txtmedicationedit.Text & "',`nextofkin`='" & txtnextofkinedit.Text & "',`emergencycontact`='" & txtemergencycontactedit.Text & "',`visitorpriviledge`='" & cbovisitiorspreviledgeedit.Text & "',`crimescommited`='" & txtcrimecommitededit.Text & "',`relationtoEC`='" & txtrelationtoECedit.Text & "' WHERE `inmatenumber`='" & txtsearchedit.Text & "'", con)
                cmd.ExecuteNonQuery()
                MsgBox("Data Updated Successfully", vbInformation + vbOKCancel, "Gereza Tarch Technologies")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        Try
            con.Open()
            Dim line As String = "INSERT INTO `tblindiscipline`(`inmatenumber`, `indisciplinecase`) VALUES (@numinmate,@indiscipline)"
            Dim com As New MySqlCommand(line, con)
            com.Parameters.AddWithValue("@numinmate", txtinmatenumedit.Text)
            com.Parameters.AddWithValue("@indiscipline", txtindisciplinecasesedit.Text)
            com.ExecuteNonQuery()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
        Try
            Dim qline As String = "UPDATE `tblindiscipline` SET `inmatenumber`='" & txtinmatenumedit.Text & "',`indisciplinecase`='" & txtindisciplinecasesedit.Text & "' WHERE `inmatenumber`='" & txtsearchedit.Text & "'"
            Dim cmd As New MySqlCommand(qline, con)
            cmd.ExecuteNonQuery()
            editclear()
        Catch ex As Exception
        End Try

    End Sub
    Sub editclear()
        txtinmatenumedit.Text = ""
        txtfullnameedit.Text = ""
        txtdobedit.Text = ""
        txtcountyedit.Text = ""
        txtnationallityedit.Text = ""
        txtidedit.Text = ""
        cbogenderedit.Text = ""
        cbomaritalstatusedit.Text = ""
        txttattosedit.Text = ""
        cboeducationleveledit.Text = ""
        cbomentalilledit.Text = ""
        txtreligionedit.Text = ""
        txtcourtsentenceedit.Text = ""
        cbovisitiorspreviledgeedit.Text = ""
        txtappealcondititonedit.Text = ""
        txtcourtlocationedit.Text = ""
        txtcasenumberedit.Text = ""
        txtallergiesconditionedit.Text = ""
        txtrecordallergiesedit.Text = ""
        txtmedicationedit.Text = ""
        txtnextofkinedit.Text = ""
        txtemergencycontactedit.Text = ""
        txtrelationtoECedit.Text = ""
        txtcrimecommitededit.Text = ""
        txtindisciplinecasesedit.Text = ""
        picedit.Image = Nothing
    End Sub
    Sub searchclear()
        txtinmatenumsearch.Text = ""
        txtfullnamesearch.Text = ""
        txtdobsearch.Text = ""
        txtcountysearch.Text = ""
        txtnationallitysearch.Text = ""
        txtidsearch.Text = ""
        cbogendersearch.Text = ""
        cbomaritalsearch.Text = ""
        txttatoossearch.Text = ""
        cboeducationlevelsearch.Text = ""
        cbomentalillsearch.Text = ""
        txtreligionsearch.Text = ""
        txtindisciplinecasessearch.Text = ""
        txtcourtdatesearch.Text = ""
        txtsentencesearch.Text = ""
        cbovisitorspreviledgesearch.Text = ""
        txtappealconditionsearch.Text = ""
        txtappealdatesearch.Text = ""
        txtcourtlocationsearch.Text = ""
        txtcasenumbersearch.Text = ""
        txtallergiesconditionsearch.Text = ""
        txtallergiessearch.Text = ""
        txtmedicationssearch.Text = ""
        txtnextofkinsearch.Text = ""
        txtemergencycontactsearch.Text = ""
        txtrelationtoECsearch.Text = ""
        txtcrimescommitedsearch.Text = ""
        txtindisciplinecasessearch.Clear()
        picfrontsearch.Image = Nothing
        cbovisitorspreviledgesearch.BackColor = Color.White
        txtsearchdetails.Text = ""
        txtreleaseconditiondetails.Text = ""
        txtreleaseconditiondetails.BackColor = Color.White
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        searchclear()
    End Sub

    Private Sub Btnuploaddemise_Click(sender As Object, e As EventArgs) Handles btnuploaddemise.Click
        OpenFileDialog4.Filter = "PDF files| *.pdf"
        If OpenFileDialog4.ShowDialog() = DialogResult.OK Then
            txtautopsydemise.Text = OpenFileDialog4.FileName
            Dim fileroute As String = OpenFileDialog4.FileName
        End If
    End Sub

    Private Sub Btnsavedemise_Click(sender As Object, e As EventArgs) Handles btnsavedemise.Click

        Dim con As New MySqlConnection("server=localhost;database=gerezatrack;username=root;password=;")
        If txtautopsydemise.Text = "" Then
            MsgBox("An Autopsy Report Must Be available", vbExclamation + vbOKOnly, "Gereza Track Technologies")
        Else
            Dim pathfile As String = OpenFileDialog4.FileName
        txtautopsydemise.Text = pathfile
        Dim filebytes As Byte() = System.IO.File.ReadAllBytes(pathfile)
        Dim filename As String = System.IO.Path.GetFileName(pathfile)

        Try
                con.Open()
                Dim com As New MySqlCommand("INSERT INTO `tbldemise`(`inmatenumber`, `demisedate`, `causeofdemise`, `demiselocation`, `autopsyreport`, `recordedby`) VALUES(@inmatenum,@demisedate,@causeofdemise,@demiselocation,@autopsyreport,@recordedby)", con)
                com.Parameters.AddWithValue("@inmatenum", txtinmatenumdemise.Text)
                com.Parameters.AddWithValue("@demisedate", dtpdemisedate.Value)
                com.Parameters.AddWithValue("@causeofdemise", txtcausedemise.Text)
                com.Parameters.AddWithValue("@demiselocation", txtlocationdemise.Text)
                com.Parameters.AddWithValue("@autopsyreport", filebytes)
                com.Parameters.AddWithValue("@recordedby", txtrecordedbydemise.Text)
                com.ExecuteNonQuery()
                MsgBox("Demise Recorded Successfully", vbInformation + vbOKOnly, "Gereza Track Technologies")
                demiseclear()
            Catch ex As Exception
                MsgBox("An Autopsy Report Must Be available")
            End Try
        End If
    End Sub
    'Searching Demise 
    Private Sub Btnsearchdemise_Click(sender As Object, e As EventArgs) Handles btnsearchdemise.Click
        Dim con As New MySqlConnection("server=localhost;database=gerezatrack;username=root;password=;")
        Dim adap As MySqlDataAdapter
        Dim tbl As New DataTable
        If txtsearchdemise.Text = "" Then
            MsgBox("Please Enter The Inmate Number To Comtinue...", vbExclamation + vbOKOnly, "Gereza Track Technologies")
        Else
            Try
                con.Open()
                Dim cmd As New MySqlCommand("SELECT `inmatenumber`, `Fullname`, `dob`, `countyofbirth`, `nationality`, `Idnumber`, `gender`, `maritalstatus`, `religion`, `sentencedate`, `casesentense`, `nextofkin`, `emergencycontact`,`relationtoEC` FROM `tblinmate` WHERE inmatenumber='" & txtsearchdemise.Text & "'", con)
                adap = New MySqlDataAdapter(cmd)
                adap.Fill(tbl)
                If tbl.Rows.Count > 0 Then
                    txtinmatenumdemise.Text = tbl.Rows(0)("inmatenumber").ToString
                    txtfellnamedemise.Text = tbl.Rows(0)("Fullname").ToString
                    txtdobdemise.Text = tbl.Rows(0)("dob").ToString
                    txtcountyofbirthdemise.Text = tbl.Rows(0)("countyofbirth").ToString
                    txtnationalitydemise.Text = tbl.Rows(0)("nationality").ToString
                    txtiddemise.Text = tbl.Rows(0)("Idnumber").ToString
                    cbogenderdemise.Text = tbl.Rows(0)("gender").ToString
                    cbomaritaldemise.Text = tbl.Rows(0)("maritalstatus").ToString

                    txtreligiondemise.Text = tbl.Rows(0)("religion").ToString
                    dtpsentencedemise.Value = tbl.Rows(0)("sentencedate").ToString
                    txtcourtsentensedemise.Text = tbl.Rows(0)("casesentense").ToString
                    txtnextofkindemise.Text = tbl.Rows(0)("nextofkin").ToString
                    txtemergencycontactdemise.Text = tbl.Rows(0)("emergencycontact").ToString
                    txtrelationdemise.Text = tbl.Rows(0)("relationtoEC").ToString
                Else
                    MsgBox("Inmate Doesn't Exist", vbExclamation + vbRetry, "Gereza Track Technologies")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    'clearing Demise Tab Page
    Sub demiseclear()
        txtinmatenumdemise.Text = ""
        txtfellnamedemise.Text = ""
        txtdobdemise.Text = ""
        txtcountyofbirthdemise.Text = ""
        txtnationalitydemise.Text = ""
        txtiddemise.Text = ""
        cbogenderdemise.Text = ""
        cbomaritaldemise.Text = ""
        txtreligiondemise.Text = ""
        txtautopsydemise.Text = ""
        txtcourtsentensedemise.Text = ""
        txtnextofkindemise.Text = ""
        txtemergencycontactdemise.Text = ""
        txtrelationdemise.Text = ""
        txtinmatenumdemise.Text = ""
        txtcausedemise.Text = ""
        txtlocationdemise.Text = ""
        txtrecordedbydemise.Text = ""
    End Sub
    'Edit Demise Details
    Private Sub Btneditdemise_Click(sender As Object, e As EventArgs) Handles btneditdemise.Click
        MsgBox("Coming soon in Version 1.2 Please Wait...", vbInformation + vbOKOnly, "Gereza Track Technologies")
    End Sub
    'Searching Release Details
    Private Sub Btnsearchrelease_Click(sender As Object, e As EventArgs) Handles btnsearchrelease.Click
        Dim con As New MySqlConnection("server=localhost;database=gerezatrack;username=root;password=;")
        Dim ad As New MySqlDataAdapter
        Dim datble As New DataTable
        Dim pic As Byte()
        Try
            con.Open()
            Dim cmd As New MySqlCommand("SELECT `inmatenumber`, `Fullname`, `dob`, `countyofbirth`, `nationality`, `Idnumber`, `gender`, `maritalstatus`, `numoftattoos`, `educationlevel`, `mentalstate`, `religion`, `arrestdate`,  `casesentense`, `nextofkin`, `emergencycontact`, `visitorpriviledge`, `crimescommited`, `rightpic`, `relationtoEC` FROM `tblinmate` WHERE `inmatenumber` = '" & txtsearchrelease.Text & "'", con)
            ad = New MySqlDataAdapter(cmd)
            ad.Fill(datble)
            If txtsearchrelease.Text = "" Then
                MsgBox("Please input the Inmate Number In the search box to continue....", vbExclamation + vbOKCancel)
            Else
                If datble.Rows.Count > 0 Then
                    txtinmatenumrelease.Text = datble.Rows(0)("inmatenumber").ToString
                    txtfullnamerelease.Text = datble.Rows(0)("Fullname").ToString
                    txtdobrelease.Text = datble.Rows(0)("dob").ToString
                    txtcountyrelease.Text = datble.Rows(0)("countyofbirth").ToString
                    txtnationallityrelease.Text = datble.Rows(0)("nationality").ToString
                    txtidnorelease.Text = datble.Rows(0)("Idnumber").ToString
                    cbogenderrelease.Text = datble.Rows(0)("gender").ToString
                    cbomaritalstatusrelease.Text = datble.Rows(0)("maritalstatus").ToString
                    txttattosrelease.Text = datble.Rows(0)("numoftattoos").ToString
                    cboeducationlevelrelease.Text = datble.Rows(0)("educationlevel").ToString
                    cbomentallillrelease.Text = datble.Rows(0)("mentalstate").ToString
                    txtreligionrelease.Text = datble.Rows(0)("religion").ToString
                    dtparrestdaterelease.Value = datble.Rows(0)("arrestdate").ToString
                    txtcourtsentencerelease.Text = datble.Rows(0)("casesentense").ToString
                    txtnextofkinrelease.Text = datble.Rows(0)("nextofkin").ToString
                    txtemergencyrelease.Text = datble.Rows(0)("emergencycontact").ToString
                    txtrelationtoECrelease.Text = datble.Rows(0)("relationtoEC").ToString
                    pic = datble.Rows(0)("rightpic")
                    Dim mst As New MemoryStream(pic)
                    picfrontrelease.Image = Image.FromStream(mst)
                    picfrontrelease.SizeMode = PictureBoxSizeMode.StretchImage
                Else
                    MsgBox("The inmate Doesn't Exist", vbExclamation + vbRetry, "Gereza Track Technologies")
                End If
                Try
                    Dim tbl As New DataTable
                    Dim adapt As New MySqlDataAdapter
                    Dim commnd As New MySqlCommand("SELECT `inmatenumber`, `indisciplinecase` FROM `tblindiscipline` WHERE inmatenumber= @primary", con)
                    commnd.Parameters.AddWithValue("@primary", txtsearchrelease.Text)
                    adapt = New MySqlDataAdapter(commnd)
                    adapt.Fill(tbl)
                    If tbl.Rows.Count > 0 Then
                        txtindisciplinecaserelease.Text = tbl.Rows(0)("indisciplinecase").ToString
                    Else
                        txtindisciplinecaserelease.Text = "No Indiscipline Cases Recorded."
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        releasedetails()
    End Sub

    Private Sub Btnsaverelease_Click(sender As Object, e As EventArgs) Handles btnsaverelease.Click
        Dim con As New MySqlConnection("server=localhost;database=gerezatrack;username=root;password=;")

        Try
            If txtmedicalcondrelease.Text = "" Or txtreasonforrelease.Text = "" Or txtreleasecourses.Text = "" Or txtapprovedbyrelease.Text = "" Then
                MsgBox("Please Fill The Fields To continue...", vbExclamation + vbRetry, "Gereza Track Technologies")
            Else
                Dim slecteddate As Date = dtpreleasedaterelease.Value
                Dim formattedDate As String = slecteddate.ToString("yyyy-MM-dd")
                con.Open()
                Dim comnd As New MySqlCommand("INSERT INTO `tblreleases`(`inmatenumber`, `releasedate`, `medicalcondition`, `reasonforrelease`, `releasegraduatedcourse`,`approvedby`) VALUES(@inmatenumber,@releasedate,@medicalcondition,@reasonforrelease,@releasegraduatecourse,@approvedby)", con)
                comnd.Parameters.AddWithValue("@inmatenumber", txtinmatenumrelease.Text)
                comnd.Parameters.AddWithValue("@releasedate", formattedDate)
                comnd.Parameters.AddWithValue("@medicalcondition", txtmedicalcondrelease.Text)
                comnd.Parameters.AddWithValue("@reasonforrelease", txtreasonforrelease.Text)
                comnd.Parameters.AddWithValue("@releasegraduatecourse", txtreleasecourses.Text)
                comnd.Parameters.AddWithValue("@approvedby", txtapprovedbyrelease.Text)
                comnd.ExecuteNonQuery()
                MsgBox("Data Recorded Successfully", vbInformation + vbOKOnly)
                clearrrelease()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Searching the release details from the Database
    Sub releasedetails()
        Dim con As New MySqlConnection("server=localhost;database=gerezatrack;username=root;password=;")
        Dim adt As New MySqlDataAdapter
        Dim dtb As New DataTable
        Try
            con.Open()
            Dim cmd As New MySqlCommand("SELECT `inmatenumber`, `releasedate`, `medicalcondition`, `reasonforrelease`, `releasegraduatedcourse`, `approvedby` FROM `tblreleases` WHERE inmatenumber='" & txtsearchrelease.Text & "'", con)
            adt = New MySqlDataAdapter(cmd)
            adt.Fill(dtb)

            If dtb.Rows.Count > 0 Then
                dtpreleasedaterelease.Enabled = False
                txtmedicalcondrelease.Enabled = False
                txtreasonforrelease.Enabled = False
                txtreleasecourses.Enabled = False
                txtapprovedbyrelease.Enabled = False
                btnsaverelease.Enabled = False
                dtpreleasedaterelease.Value = dtb.Rows(0)("releasedate").ToString
                txtmedicalcondrelease.Text = dtb.Rows(0)("medicalcondition").ToString
                txtreasonforrelease.Text = dtb.Rows(0)("reasonforrelease").ToString
                txtreleasecourses.Text = dtb.Rows(0)("releasegraduatedcourse").ToString
                txtapprovedbyrelease.Text = dtb.Rows(0)("approvedby").ToString
            Else
                dtpreleasedaterelease.Enabled = True
                txtmedicalcondrelease.Enabled = True
                txtreasonforrelease.Enabled = True
                btnsaverelease.Enabled = True
                txtreleasecourses.Enabled = True
                txtapprovedbyrelease.Enabled = True
                dtpreleasedaterelease.Value = Date.Now.ToString("ddd, dd-MMM-yyyy")
                txtmedicalcondrelease.Text = ""
                txtreasonforrelease.Text = ""
                txtreleasecourses.Text = ""
                txtapprovedbyrelease.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Clearing the Release Controls
    Sub clearrrelease()
        txtmedicalcondrelease.Text = ""
        txtreasonforrelease.Text = ""
        txtreleasecourses.Text = ""
        txtapprovedbyrelease.Text = ""
        txtinmatenumrelease.Text = ""
        txtfullnamerelease.Text = ""
        txtindisciplinecaserelease.Text = ""
        txtdobrelease.Text = ""
        txtcountyrelease.Text = ""
        txtnationallityrelease.Text = ""
        txtidnorelease.Text = ""
        cbogenderrelease.Text = ""
        txttattosrelease.Text = ""
        cboeducationlevelrelease.Text = ""
        cbomentallillrelease.Text = ""
        txtreligionrelease.Text = ""
        txtcourtsentencerelease.Text = ""
        txtnextofkinrelease.Text = ""
        txtemergencyrelease.Text = ""
        txtrelationtoECrelease.Text = ""
        picfrontrelease.Image = Nothing
    End Sub

    Private Sub Btnsearchtransfers_Click(sender As Object, e As EventArgs) Handles btnsearchtransfers.Click
        Dim conn As New MySqlConnection("server=localhost;database=gerezatrack;username=root;password=;")
        Dim adapt As New MySqlDataAdapter
        Dim photo() As Byte
        Dim dtabl As New DataTable
        If txtsearchtransfers.Text = " " Then
            MsgBox("Please Input the Inmate Number To Continue....", vbExclamation + vbOKOnly)
        Else
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT `inmatenumber`, `Fullname`, `dob`, `countyofbirth`, `nationality`,`Idnumber`, `gender`, `casesentense`, `nextofkin`, `emergencycontact`,`rightpic`, `relationtoEC` FROM `tblinmate` WHERE `inmatenumber` = '" & txtsearchtransfers.Text & "'", conn)
                adapt = New MySqlDataAdapter(cmd)
                adapt.Fill(dtabl)
                If dtabl.Rows.Count > 0 Then
                    availaabletransfers()
                    txtinmatenumbertransfer.Text = dtabl.Rows(0)("inmatenumber").ToString
                    txtfullnametransfer.Text = dtabl.Rows(0)("Fullname").ToString
                    txtdobtransfer.Text = dtabl.Rows(0)("dob").ToString
                    txtcountytransfer.Text = dtabl.Rows(0)("countyofbirth").ToString
                    txtnationallitytransfer.Text = dtabl.Rows(0)("nationality").ToString
                    txtidnotransfer.Text = dtabl.Rows(0)("Idnumber").ToString
                    cbogendertransfer.Text = dtabl.Rows(0)("gender").ToString
                    txtcourtsentensetransfer.Text = dtabl.Rows(0)("casesentense").ToString
                    txtnextofkintransfer.Text = dtabl.Rows(0)("nextofkin").ToString
                    txtrelationtoECtransfer.Text = dtabl.Rows(0)("relationtoEC").ToString
                    txtemergencycontacttransfer.Text = dtabl.Rows(0)("emergencycontact").ToString
                    photo = dtabl.Rows(0)("rightpic")
                    Dim ms As New MemoryStream(photo)
                    picfronttransfer.Image = Image.FromStream(ms)
                    picfronttransfer.SizeMode = PictureBoxSizeMode.StretchImage
                Else
                    MsgBox("Inmate Doesnt Exist", vbExclamation + vbOKOnly, "Gereza Track Technologies")
                    transfersnotavailable()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Try
                'conn.Open()
                Dim table As New DataTable
                Dim ada As New MySqlDataAdapter
                Dim com As New MySqlCommand("SELECT `inmatenumber`, `driversname`, `driversregno`, `carnumberplate`, `departuretime`, `reasonoftransfer`, `transfereto`, `approvedby`, `medicalconditiontransfer`, `transferdate`, `approvaldate` FROM `tbltransfer` WHERE inmatenumber='" & txtinmatenumbertransfer.Text & "'", conn)
                ada = New MySqlDataAdapter(com)
                ada.Fill(table)
                If table.Rows.Count > 0 Then
                    availaabletransfers()
                    txtdriversnametransfer.Text = table.Rows(0)("driversname").ToString
                    txtdriverregnotransfer.Text = table.Rows(0)("driversregno").ToString
                    txtcarnumberplatetransfer.Text = table.Rows(0)("carnumberplate").ToString
                    txtdeparturetimetranfer.Text = table.Rows(0)("departuretime").ToString
                    txtreasonfortransfertransfer.Text = table.Rows(0)("reasonoftransfer").ToString
                    txtdesstinationrelease.Text = table.Rows(0)("transfereto").ToString
                    txtaprovedbytransfer.Text = table.Rows(0)("approvedby").ToString
                    txtmedicalconditiontransfer.Text = table.Rows(0)("medicalconditiontransfer").ToString
                    dtptransferdate.Value = table.Rows(0)("transferdate").ToString
                    dtpapprovaldayrelease.Value = table.Rows(0)("approvaldate").ToString
                Else
                    transfersnotavailable()
                    clearfieldsavailable()
                End If
            Catch ex As Exception
                MsgBox("Error:" + ex.Message)
            End Try
        End If
    End Sub
    Sub clearfieldsavailable()
        txtinmatenumbertransfer.Text = ""
        txtdriversnametransfer.Text = ""
        txtdriverregnotransfer.Text = ""
        txtcarnumberplatetransfer.Text = ""
        txtdeparturetimetranfer.Text = ""
        txtreasonfortransfertransfer.Text = ""
        txtaprovedbytransfer.Text = ""
        txtmedicalconditiontransfer.Text = ""
        txtdesstinationrelease.Text = ""
    End Sub
    Private Sub Btnrecordtransfers_Click(sender As Object, e As EventArgs) Handles btnrecordtransfers.Click
        Dim connn As New MySqlConnection("server=localhost;database=gerezatrack;username=root;password=;")
        If txtinmatenumbertransfer.Text = "" Or
            txtdriversnametransfer.Text = "" Or
            txtdriverregnotransfer.Text = "" Or
            txtcarnumberplatetransfer.Text = "" Or
            txtdeparturetimetranfer.Text = "" Or
            txtreasonfortransfertransfer.Text = "" Or
            txtaprovedbytransfer.Text = "" Or
            txtmedicalconditiontransfer.Text = "" Then
            MsgBox("No Null Values Accepted", vbExclamation + vbOKOnly, "Gereza Track Technologies")
        Else
            Try
                connn.Open()
                Dim cmd As New MySqlCommand("INSERT INTO `tbltransfer` (`inmatenumber`, `driversname`, `driversregno`, `carnumberplate`, `departuretime`, `reasonoftransfer`, `transfereto`, `approvedby`, `medicalconditiontransfer`,`transferdate`, `approvaldate`) VALUES (@inmatenumber, @driversname, @driversregno, @carnumberplate, @departuretime, @reasonoftransfer, @transferto, @approvedby, @medicalconditiontransfer,@transferdate, @approvaldate)", connn)
                cmd.Parameters.AddWithValue("@inmatenumber", txtinmatenumbertransfer.Text)
                cmd.Parameters.AddWithValue("@driversname", txtdriversnametransfer.Text)
                cmd.Parameters.AddWithValue("@driversregno", txtdriverregnotransfer.Text)
                cmd.Parameters.AddWithValue("@carnumberplate", txtcarnumberplatetransfer.Text)
                cmd.Parameters.AddWithValue("@departuretime", txtdeparturetimetranfer.Text)
                cmd.Parameters.AddWithValue("@reasonoftransfer", txtreasonfortransfertransfer.Text)
                cmd.Parameters.AddWithValue("@transferto", txtdesstinationrelease.Text) ' Set this parameter accordingly
                cmd.Parameters.AddWithValue("@approvedby", txtaprovedbytransfer.Text)
                cmd.Parameters.AddWithValue("@medicalconditiontransfer", txtmedicalconditiontransfer.Text)
                cmd.Parameters.AddWithValue("@transferdate", dtpreleasedaterelease.Value)
                cmd.Parameters.AddWithValue("@approvaldate", dtpapprovaldayrelease.Value)
                cmd.ExecuteNonQuery()
                MsgBox("Transfer Recorded Successfully", vbInformation + vbOKOnly, "Gereza Tarck Technologies")
                clearrelease()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

    End Sub


    Sub clearrelease()
        txtinmatenumbertransfer.Text = ""
        txtdriversnametransfer.Text = ""
        txtdriverregnotransfer.Text = ""
        txtcarnumberplatetransfer.Text = ""
        txtdeparturetimetranfer.Text = ""
        txtreasonfortransfertransfer.Text = ""
        txtaprovedbytransfer.Text = ""
        txtmedicalconditiontransfer.Text = ""
        txtinmatenumbertransfer.Text = ""
        txtfullnametransfer.Text = ""
        txtdobtransfer.Text = ""
        txtcountytransfer.Text = ""
        txtnationallitytransfer.Text = ""
        txtdesstinationrelease.Text = ""
        txtidnotransfer.Text = ""
        cbogendertransfer.Text = ""
        txtcourtsentensetransfer.Text = ""
        txtnextofkintransfer.Text = ""
        txtrelationtoECtransfer.Text = ""
        txtemergencycontacttransfer.Text = ""
        'dtpapprovaldayrelease.Value = Date.Now.ToString("ddd, dd-MM-yyyy")
        'dtpreleasedaterelease.Value = Date.Now.ToString("ddd, dd-MMM-yyyy")
        picfrontrelease.Image = Nothing
    End Sub
    Sub availaabletransfers()
        txtinmatenumbertransfer.Enabled = False
        txtdriversnametransfer.Enabled = False
        txtdriverregnotransfer.Enabled = False
        txtcarnumberplatetransfer.Enabled = False
        txtdeparturetimetranfer.Enabled = False
        txtreasonfortransfertransfer.Enabled = False
        txtaprovedbytransfer.Enabled = False
        txtmedicalconditiontransfer.Enabled = False
        txtinmatenumbertransfer.Enabled = False
        txtfullnametransfer.Enabled = False
        txtdobtransfer.Enabled = False
        txtcountytransfer.Enabled = False
        txtnationallitytransfer.Enabled = False
        txtdesstinationrelease.Enabled = False
        txtidnotransfer.Enabled = False
        cbogendertransfer.Enabled = False
        txtcourtsentensetransfer.Enabled = False
        txtnextofkintransfer.Enabled = False
        txtrelationtoECtransfer.Enabled = False
        txtemergencycontacttransfer.Enabled = False
        dtpapprovaldayrelease.Enabled = False
        dtpreleasedaterelease.Enabled = False
        btnrecordtransfers.Enabled = False
        picfrontrelease.Image = Nothing
    End Sub
    Sub transfersnotavailable()
        txtinmatenumbertransfer.Enabled = True
        txtdriversnametransfer.Enabled = True
        txtdriverregnotransfer.Enabled = True
        txtcarnumberplatetransfer.Enabled = True
        txtdeparturetimetranfer.Enabled = True
        txtreasonfortransfertransfer.Enabled = True
        txtaprovedbytransfer.Enabled = True
        txtmedicalconditiontransfer.Enabled = True
        txtinmatenumbertransfer.Enabled = True
        txtfullnametransfer.Enabled = True
        txtdobtransfer.Enabled = True
        txtcountytransfer.Enabled = True
        txtnationallitytransfer.Enabled = True
        txtdesstinationrelease.Enabled = True
        txtidnotransfer.Enabled = True
        cbogendertransfer.Enabled = True
        txtcourtsentensetransfer.Enabled = True
        txtnextofkintransfer.Enabled = True
        txtrelationtoECtransfer.Enabled = True
        txtemergencycontacttransfer.Enabled = True
        dtpapprovaldayrelease.Enabled = True
        dtpreleasedaterelease.Enabled = True
        btnrecordtransfers.Enabled = True
        picfrontrelease.Image = Nothing
    End Sub

    Private Sub Btnhealthupdates_Click(sender As Object, e As EventArgs) Handles btnhealthupdates.Click
        MsgBox("Updates Comming soon with Version 1.2...Please Wait...", vbInformation + vbOKOnly, "Gererza Track Technologies")
    End Sub

    Private Sub Btnsearchhealth_Click(sender As Object, e As EventArgs) Handles btnsearchhealth.Click
        Dim con As New MySqlConnection("server=localhost;database=gerezatrack;username=root;password=;")
        If txtsearchhealth.Text = Nothing Then
            MsgBox("Please Input the Inmate Number To Continue...")
        Else
            Try
                Dim ad As New MySqlDataAdapter
                Dim tbl As New DataTable
                Dim cmd As New MySqlCommand("SELECT `inmatenumber`, `Fullname`, `dob`, `gender`,`allaergies`,`medications`, `nextofkin`, `emergencycontact` FROM `tblinmate` WHERE inmatenumber='" & txtsearchhealth.Text & "'", con)
                ad = New MySqlDataAdapter(cmd)
                ad.Fill(tbl)
                If tbl.Rows.Count > 0 Then

                    txtinmatenumberhealth.Text = tbl.Rows(0)("inmatenumber").ToString
                    txtnamehealth.Text = tbl.Rows(0)("Fullname").ToString
                    dtpdobhealth.Value = tbl.Rows(0)("dob").ToString
                    age()
                    cbogenderhealth.Text = tbl.Rows(0)("gender").ToString
                    txtallergieshealth.Text = tbl.Rows(0)("allaergies").ToString
                    txtmedicationhealth.Text = tbl.Rows(0)("medications").ToString
                    txtnextofkinhealth.Text = tbl.Rows(0)("nextofkin").ToString
                    txtemergencycontacthalth.Text = tbl.Rows(0)("emergencycontact").ToString
                Else
                    MsgBox("Inmate Doesnt Exist", vbExclamation + vbOKOnly, "Gereza Track Technologies")
                End If
            Catch ex As Exception
                MsgBox("Error" + ex.Message + vbExclamation)
            End Try
            Try
                con.Open()
                Dim comm As New MySqlCommand("SELECT `inmatenumber`, `pendingappoinntments`, `recentappointments`, `majordiseasesaffectedwith`, `medicalheathcondition`, `hospitaladmision` FROM `tblinmatehealth` WHERE inmatenumber='" & txtsearchhealth.Text & "'", con)
                Dim adapta As New MySqlDataAdapter
                Dim dtbl As New DataTable
                adapta = New MySqlDataAdapter(comm)
                adapta.Fill(dtbl)
                If dtbl.Rows.Count > 0 Then
                    txtpendingappointmentshealth.Text = dtbl.Rows(0)("pendingappoinntments").ToString
                    txtrecentappointmenthealth.Text = dtbl.Rows(0)("recentappointments").ToString
                    txtmajordiseasehealth.Text = dtbl.Rows(0)("majordiseasesaffectedwith").ToString
                    txtmedicalconditionhealth.Text = dtbl.Rows(0)("medicalheathcondition").ToString
                    txthospitaladmhealth.Text = dtbl.Rows(0)("hospitaladmision").ToString
                Else
                    txtpendingappointmentshealth.Text = ""
                    txtrecentappointmenthealth.Text = ""
                    txtmajordiseasehealth.Text = ""
                    txtmedicalconditionhealth.Text = ""
                    txthospitaladmhealth.Text = ""
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Btnsaveheath_Click(sender As Object, e As EventArgs) Handles btnsaveheath.Click
        Dim conn As New MySqlConnection("server=localhost;database=gerezatrack;password=;username=root;")
        conn.Open()
        If txtinmatenumberhealth.Text = "" Or
        txtpendingappointmentshealth.Text = "" Or
        txtrecentappointmenthealth.Text = "" Or
        txtmajordiseasehealth.Text = "" Or
txtmedicalconditionhealth.Text = "" Or
            txthospitaladmhealth.Text = "" Then

            MsgBox("No Void Values Accepted!!", vbExclamation + vbOKCancel, "Gereza Trach Technologies")
        Else
            Try
                Dim cmd As New MySqlCommand("INSERT INTO `tblinmatehealth`(`inmatenumber`, `pendingappoinntments`, `recentappointments`, `majordiseasesaffectedwith`, `medicalheathcondition`,`hospitaladmision`) VALUES (@inmatenumber,@pendingappoinntments,@recentappointments,@majordiseasesaffectedwith,@medicalheathcondition,@hospitaladmision)", conn)
                cmd.Parameters.AddWithValue("@inmatenumber", txtinmatenumberhealth.Text)
                cmd.Parameters.AddWithValue("@pendingappoinntments", txtpendingappointmentshealth.Text)
                cmd.Parameters.AddWithValue("@recentappointments", txtrecentappointmenthealth.Text)
                cmd.Parameters.AddWithValue("@majordiseasesaffectedwith", txtmajordiseasehealth.Text)
                cmd.Parameters.AddWithValue("@medicalheathcondition", txtmedicalconditionhealth.Text)
                cmd.Parameters.AddWithValue("@hospitaladmision", txthospitaladmhealth.Text)
                cmd.ExecuteNonQuery()
                MsgBox("Health Data Inserted Successfully", vbInformation + vbOKOnly, "Gereza Track Technologies")
                controlsempty()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
        End If
    End Sub
    Sub age()
        Dim dob As DateTime = dtpdobhealth.Value
        Dim today As DateTime = DateTime.Today
        Dim age As Integer = today.Year - dob.Year
        txtagehealth.Text = age.ToString
    End Sub
    Sub controlsempty()
        txtinmatenumberhealth.Text = ""
        txtpendingappointmentshealth.Text = ""
        txtrecentappointmenthealth.Text = ""
        txtmajordiseasehealth.Text = ""
        txtinmatenumber.Text = ""
        txtinmatenumberhealth.Text = ""
        txtnamehealth.Text = ""
        dtpdobhealth.Value = Date.Now.ToString("ddd, dd-MMM-yyy")
        cbogenderhealth.Text = ""
        txtallergieshealth.Text = ""
        txtmedicationhealth.Text = ""
        txtnextofkinhealth.Text = ""
        txtemergencycontacthalth.Text = ""
        txthospitaladmhealth.Text = ""
        txtmedicalconditionhealth.Text = ""
        txtagehealth.Text = ""
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim conn As New MySqlConnection("server=localhost; database=gerezatrack; username=root; password=;")
        Try
            Dim dtable As New DataTable
            Dim cmd As New MySqlCommand("SELECT `inmatenumber`, `Fullname`,  `Idnumber`, `gender`,  `educationlevel`, `arrestdate`, `sentencedate`, `visitorpriviledge`,nextofkin,relationtoEC FROM `tblinmate`ORDER BY CAST(`inmatenumber` AS SIGNED) DESC", conn)
            Dim adapt As New MySqlDataAdapter(cmd)
            adapt.Fill(dtable)
            dtable.Columns("inmatenumber").ColumnName = "Inmate ID"
            dtable.Columns("Fullname").ColumnName = "Full Name"
            dtable.Columns("Idnumber").ColumnName = "ID Number"
            dtable.Columns("gender").ColumnName = "Gender"
            dtable.Columns("educationlevel").ColumnName = "Education Level"
            dtable.Columns("arrestdate").ColumnName = "Arrest Date"
            dtable.Columns("sentencedate").ColumnName = "Sentence Date"
            dtable.Columns("visitorpriviledge").ColumnName = "Visitors"
            dtable.Columns("nextofkin").ColumnName = "Next Of Kin"
            dtable.Columns("relationtoEC").ColumnName = "Relationship"
            dgvinmates.DataSource = dtable
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim conn As New MySqlConnection("server=localhost; database=gerezatrack; username=root; password=;")
        Timer1.Enabled = False
        btnshowall.Visible = True
        Try
            Dim dtable As New DataTable
            Dim cmd As New MySqlCommand("SELECT `inmatenumber`, `Fullname`,  `Idnumber`, `gender`,  `educationlevel`, `arrestdate`, `sentencedate`, `visitorpriviledge`,nextofkin,relationtoEC FROM `tblinmate` WHERE inmatenumber='" & txtsearchlist.Text & "'", conn)
            Dim adapt As New MySqlDataAdapter(cmd)
            adapt.Fill(dtable)
            dtable.Columns("inmatenumber").ColumnName = "Inmate ID"
            dtable.Columns("Fullname").ColumnName = "Full Name"
            dtable.Columns("Idnumber").ColumnName = "ID Number"
            dtable.Columns("gender").ColumnName = "Gender"
            dtable.Columns("educationlevel").ColumnName = "Education Level"
            dtable.Columns("arrestdate").ColumnName = "Arrest Date"
            dtable.Columns("sentencedate").ColumnName = "Sentence Date"
            dtable.Columns("visitorpriviledge").ColumnName = "Visitors"
            dtable.Columns("nextofkin").ColumnName = "Next Of Kin"
            dtable.Columns("relationtoEC").ColumnName = "Relationship"
            dgvinmates.DataSource = dtable
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btnshowall_Click(sender As Object, e As EventArgs) Handles btnshowall.Click
        Timer1.Enabled = True
        txtsearchlist.Clear()
    End Sub
End Class