Imports MySql.Data.MySqlClient
Imports System.IO
Public Class pman
    Private Sub Btnmanage_Click(sender As Object, e As EventArgs) Handles btnmanage.Click
        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub Btnome_Click(sender As Object, e As EventArgs) Handles btnome.Click
        Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub Btnhealth_Click(sender As Object, e As EventArgs) Handles btnhealth.Click
        TabControl1.SelectedTab = TabPage2
        CLEARHEALTHSEARCH()
    End Sub

    Private Sub Btninfrustructure_Click(sender As Object, e As EventArgs) Handles btninfrustructure.Click
        TabControl1.SelectedTab = TabPage3
    End Sub

    Private Sub Btnstrike_Click(sender As Object, e As EventArgs) Handles btnstrike.Click
        TabControl1.SelectedTab = TabPage4
    End Sub

    Private Sub Btnoutbreak_Click(sender As Object, e As EventArgs) Handles btnoutbreak.Click
        TabControl1.SelectedTab = TabPage5
    End Sub

    Private Sub Radyes_CheckedChanged(sender As Object, e As EventArgs) Handles radyes.CheckedChanged
        If radyes.Checked = True Then
            txtrecorddest.Enabled = True
        End If
    End Sub

    Private Sub Radno_CheckedChanged(sender As Object, e As EventArgs) Handles radno.CheckedChanged
        If radno.Checked = True Then
            txtrecorddest.Enabled = False
        End If
    End Sub

    Private Sub Pman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radno.Checked = True
        Dim connect As New MySqlConnection("server=localhost; username=root; password=; database=gerezatrack")
        Dim adapt As New MySqlDataAdapter
        Dim cmd As New MySqlCommand
        Dim query As String
        Dim piccommisioner() As Byte
        Dim picdeputycom() As Byte
        Dim picofficerincharg() As Byte
        Dim picprisonwerden() As Byte
        Dim picregionalcom() As Byte
        Try
            connect.Open()
            query = "SELECT  `commisionergeneral`, `piccommisionergeneral`, `deputycommisioner`,`picdeputycommisioner`, `regionalcommisioner`, `picregionalcommisioner`, `officerincharge`, `picofficerincharge`, `picprisonerwarden` FROM `tblpman`"
            cmd = New MySqlCommand(query, connect)
            adapt = New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            adapt.Fill(dt)
            If dt.Rows.Count > 0 Then
                lblcommisioner.Text = dt.Rows(0)("commisionergeneral").ToString
                lbldeputycommisioner.Text = dt.Rows(0)("deputycommisioner").ToString
                lblofficerincharge.Text = dt.Rows(0)("officerincharge").ToString
                lblregionalcommisioner.Text = dt.Rows(0)("regionalcommisioner").ToString
                piccommisioner = dt.Rows(0)("piccommisionergeneral")
                Dim ms As New MemoryStream(piccommisioner)
                piccommisionergeneral.Image = Image.FromStream(ms)
                piccommisionergeneral.SizeMode = PictureBoxSizeMode.StretchImage
                picdeputycom = dt.Rows(0)("picdeputycommisioner")
                Dim ms1 As New MemoryStream(picdeputycom)
                picdeputycommisioner.Image = Image.FromStream(ms1)
                picdeputycommisioner.SizeMode = PictureBoxSizeMode.StretchImage
                picofficerincharg = dt.Rows(0)("picofficerincharge")
                Dim ms2 As New MemoryStream(picofficerincharg)
                picofficerincharge.Image = Image.FromStream(ms2)
                picofficerincharge.SizeMode = PictureBoxSizeMode.StretchImage
                picregionalcom = dt.Rows(0)("picregionalcommisioner")
                Dim ms3 As New MemoryStream(picofficerincharg)
                picregionalcommisioner.Image = Image.FromStream(ms3)
                picregionalcommisioner.SizeMode = PictureBoxSizeMode.StretchImage
                picprisonwerden = dt.Rows(0)("picprisonerwarden")
                Dim ms4 As New MemoryStream(picprisonwerden)
                picprisonwarden.Image = Image.FromStream(ms4)
                picprisonwarden.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Hide()
        admin.Show()
    End Sub

    Private Sub Btnmansave_Click(sender As Object, e As EventArgs) Handles btnmansave.Click
        Dim con As New MySqlConnection("server=localhost;username=root;password=;database=gerezatrack")
        Dim query As String
        Dim cmd As New MySqlCommand
        If cbomaintainance.Text = "" Or txtdescription.Text = "" Or txtequipments.Text = "" Or txtduration.Text = "" Or txtmaterials.Text = "" Or txtcost.Text = "" Or txtheadofmaintainance.Text = "" Or txtapprovedby.Text = "" Or txtcomments.Text = "" Or txtattachments.Text = "" Then
            MsgBox("No null values allowed", vbExclamation + vbOKOnly, "Gereza Track Technologies")
        Else
            Dim filepath As String = OpenFileDialog1.FileName
            txtattachments.Text = filepath
            Dim filebytes As Byte() = System.IO.File.ReadAllBytes(filepath)
            Dim filename As String = System.IO.Path.GetFileName(filepath)
            Try
                con.Open()
                query = "INSERT INTO `tblmaintainace`(`maintainancetype`, `commencementdate`, `Decription`, `Equipmentinvlovled`, `Duration`, `materialsused`, `cost`, `attachments`, `headofmaintainnce`, `approvedby`, `comments`,`attachmentdata`) VALUES (@maintainance, @commencement, @description, @equipment, @duration, @materials, @cost, @attachments, @headofmaintenance, @approvedby, @comments, @fileData)"

                cmd = New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@maintainance", cbomaintainance.Text)
                cmd.Parameters.AddWithValue("@commencement", dtpcommencement.Value)
                cmd.Parameters.AddWithValue("@description", txtdescription.Text)
                cmd.Parameters.AddWithValue("@equipment", txtequipments.Text)
                cmd.Parameters.AddWithValue("@duration", txtduration.Text)
                cmd.Parameters.AddWithValue("@materials", txtmaterials.Text)
                cmd.Parameters.AddWithValue("@cost", txtcost.Text)
                cmd.Parameters.AddWithValue("@attachments", txtattachments.Text)
                cmd.Parameters.AddWithValue("@headofmaintenance", txtheadofmaintainance.Text)
                cmd.Parameters.AddWithValue("@approvedby", txtapprovedby.Text)
                cmd.Parameters.AddWithValue("@comments", txtcomments.Text)
                cmd.Parameters.AddWithValue("@fileData", filebytes)
                cmd.ExecuteNonQuery()
                MsgBox("Maintenance Recorded Successfully", vbInformation + vbOKOnly, "Gereza Track Technologies")
                clear()

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close() ' Close the connection when done.
            End Try
        End If
    End Sub
    Sub clear()
        cbomaintainance.Text = ""
        dtpcommencement.Value = Date.Now.ToString("ddd, dd-MMM-yyyy")
        txtdescription.Text = ""
        txtequipments.Text = ""
        txtduration.Text = ""
        txtmaterials.Text = ""
        txtcost.Text = ""
        txtattachments.Text = ""
        txtheadofmaintainance.Text = ""
        txtapprovedby.Text = ""
        txtcomments.Text = ""
    End Sub

    Private Sub Btnstrikesave_Click(sender As Object, e As EventArgs) Handles btnstrikesave.Click
        Dim con As New MySqlConnection("server=localhost;database=gerezatrack;username=root;password=;")
        Dim cmd As MySqlCommand
        Dim sqlquery As String

        If radyes.Checked = True Then
            txtdestcondition.Text = "Yes"
        End If
        If radno.Checked = True Then
            txtdestcondition.Text = "No"
            txtrecorddest.Text = "N/A"
        End If
        Try
            If txtstarttime.Text = "" Or txtstrikeblock.Text = "" Or txtNoparticipants.Text = "" Or txtstrikereason.Text = "" Or txtstrikeleaders.Text = "" Or txtstrikeduration.Text = "" Or txtstrikedemands.Text = "" Or txtstrikewitness.Text = "" Or txtdestcondition.Text = "" Or txtrecorddest.Text = "" Or txtstrikeactiontaken.Text = "" Then
                MsgBox("No null values Allowed", vbExclamation + vbOKCancel, "Gereza Track Technologies")
            Else
                con.Open()
                sqlquery = "INSERT INTO `tblstrikes`(`date`, `starttime`, `block`, `inmatesparticipating`, `duration`, `reason`, `leaders`, `witnesses`, `demandsandreqests`, `destroyedpropertiescondition`, `destroyedproperty`, `actiontaken`) VALUES 
( @strikedate,@strikestarttime,@strikeblock,@noofparticipants,@strikeduration,@strikereason,@strikeleaders,@strikewitnesses,@strikedemands,@destractioncondition,@recorddestraction,@strikeactiontaken)"
                cmd = New MySqlCommand(sqlquery, con)
                cmd.Parameters.AddWithValue("@strikedate", dtpstrikedate.Value)
                cmd.Parameters.AddWithValue("@strikestarttime", txtstarttime.Text)
                cmd.Parameters.AddWithValue("@strikeblock", txtstrikeblock.Text)
                cmd.Parameters.AddWithValue("@noofparticipants", txtNoparticipants.Text)
                cmd.Parameters.AddWithValue("@strikeduration", txtstrikeduration.Text)
                cmd.Parameters.AddWithValue("@strikereason", txtstrikereason.Text)
                cmd.Parameters.AddWithValue("@strikeleaders", txtstrikeleaders.Text)
                cmd.Parameters.AddWithValue("@strikewitnesses", txtstrikewitness.Text)
                cmd.Parameters.AddWithValue("@strikedemands", txtstrikedemands.Text)
                cmd.Parameters.AddWithValue("@destractioncondition", txtdestcondition.Text)
                cmd.Parameters.AddWithValue("@recorddestraction", txtrecorddest.Text)
                cmd.Parameters.AddWithValue("@strikeactiontaken", txtstrikeactiontaken.Text)
                cmd.ExecuteNonQuery()
            MsgBox("Strike Recorded Successfully", vbInformation + vbOKOnly, "Gereza Track Technologies")
                strclear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

            End Try

    End Sub
    Sub strclear()
        dtpstrikedate.Value = Date.Now.ToString("ddd, dd-MMM-yyyy")
        txtstarttime.Text = ""
        txtstrikeblock.Text = ""
        txtNoparticipants.Text = ""
        txtduration.Text = ""
        txtstrikereason.Text = ""
        txtstrikeleaders.Text = ""
        txtstrikeduration.Text = ""
        txtstrikewitness.Text = ""
        txtstrikedemands.Text = ""
        radno.Checked = True
        txtdestcondition.Text = ""
        txtrecorddest.Text = ""
        txtstrikeactiontaken.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OpenFileDialog1.Filter = "PDF Files | *.pdf"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            txtattachments.Text = OpenFileDialog1.FileName
            Dim filepath As String = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnprintreport.Click
        print.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnsaveoutbreak.Click
        Dim con As New MySqlConnection("server=localhost;database=gerezatrack;username=root;password=;")
        Dim cmd As New MySqlCommand

        Try
            If txtdiseasename.Text = "" Or txtaffectedareas.Text = "" Or txtcasesnum.Text = "" Or txtsymptoms.Text = "" Or txtpreventive.Text = "" Or txttotalnumisolation.Text = "" Then
                MsgBox("No null values accepted", vbExclamation + vbRetryCancel)
            Else
                con.Open()

                Dim outquery As String
                outquery = "INSERT INTO `tbloutbreak`(`diseasename`, `dateonset`, `affectedareas`, `numofcases`, `symptoms`, `preventivemeasures`, `peopleinisolation`) VALUES (@name, @dateonset, @affectedareas, @cases, @symptoms, @preventivemeasures, @peopleinisolation)"

                cmd = New MySqlCommand(outquery, con)

                cmd.Parameters.AddWithValue("@name", txtdiseasename.Text)
                cmd.Parameters.AddWithValue("@dateonset", dtponset.Value)
                cmd.Parameters.AddWithValue("@affectedareas", txtaffectedareas.Text)
                cmd.Parameters.AddWithValue("@cases", txtcasesnum.Text)
                cmd.Parameters.AddWithValue("@symptoms", txtsymptoms.Text)
                cmd.Parameters.AddWithValue("@preventivemeasures", txtpreventive.Text)
                cmd.Parameters.AddWithValue("@peopleinisolation", txttotalnumisolation.Text)

                cmd.ExecuteNonQuery()
                MsgBox("Outbreak Recorded Successfully", vbInformation + vbOKOnly, "Gereza Track Technologies")
                outbreakclear()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Sub outbreakclear()
        txtdiseasename.Text = ""
        dtponset.Value = Date.Now.ToString("ddd, dd-MMM-yyyy")
        txtaffectedareas.Text = ""
        txtcasesnum.Text = ""
        txtsymptoms.Text = ""
        txtpreventive.Text = ""
        txttotalnumisolation.Text = ""
    End Sub

    Private Sub Btnclearouttbreakcontrols_Click(sender As Object, e As EventArgs) Handles btnclearouttbreakcontrols.Click
        outbreakclear()
    End Sub

    Private Sub Btnsearchpman_Click(sender As Object, e As EventArgs) Handles btnsearchpman.Click
        Dim connection As New MySqlConnection("server=localhost;database=gerezatrack;username=root;password=;")
        Dim adapt As New MySqlDataAdapter
        Dim dtable As New DataTable
        Dim pic() As Byte
        connection.Open()
        Try
            Dim cmd As New MySqlCommand("SELECT `inmatenumber`, `Fullname`, `dob`, `gender`, `medications`, `nextofkin`,`emergencycontact`,allaergies, `rightpic` FROM `tblinmate` WHERE `inmatenumber`='" & txtsearchpman.Text & "'", connection)
            adapt = New MySqlDataAdapter(cmd)
            adapt.Fill(dtable)
            If dtable.Rows.Count > 0 Then
                lblinmateIDpman.Text = dtable.Rows(0)("inmatenumber").ToString
                lblnamepman.Text = dtable.Rows(0)("Fullname").ToString
                lbldobpman.Text = dtable.Rows(0)("dob").ToString
                lblgenderpman.Text = dtable.Rows(0)("gender").ToString
                lblmedicationpman.Text = dtable.Rows(0)("medications").ToString
                lblnextofkinpman.Text = dtable.Rows(0)("nextofkin").ToString
                lblemergencynumberpman.Text = dtable.Rows(0)("emergencycontact").ToString
                txtallergiespman.Text = dtable.Rows(0)("allaergies").ToString
                pic = dtable.Rows(0)("rightpic")
                Dim mst As New MemoryStream(pic)
                picpman.Image = Image.FromStream(mst)
                picpman.SizeMode = PictureBoxSizeMode.StretchImage
            Else
                MsgBox("The Inmate Doesnt Exist", vbExclamation + vbOKOnly, "Gereza Track Technologies")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            'Dim connect As New MySqlConnection("server=localhost;database=gerezatrack;username=root;password=;")
            Dim adp As New MySqlDataAdapter
            Dim tbl As New DataTable
            'connection.Open()
            Dim cmd As New MySqlCommand("SELECT `inmatenumber`, `pendingappoinntments`, `recentappointments`, `majordiseasesaffectedwith`, `medicalheathcondition` FROM `tblinmatehealth` WHERE inmatenumber='" & txtsearchpman.Text & "'", connection)
            adp = New MySqlDataAdapter(cmd)
            adp.Fill(tbl)
            If tbl.Rows.Count > 0 Then
                txtpendingappointmentspman.Text = tbl.Rows(0)("pendingappoinntments").ToString
                txtrecentappointmentspman.Text = tbl.Rows(0)("recentappointments").ToString
                txtmajordiseasespman.Text = tbl.Rows(0)("majordiseasesaffectedwith").ToString
                lblmedicalhealthconditionpman.Text = tbl.Rows(0)("medicalheathcondition").ToString
            Else
                txtpendingappointmentspman.Text = "N/A"
                txtrecentappointmentspman.Text = "N/A"
                txtmajordiseasespman.Text = "N/A"
                lblmedicalhealthconditionpman.Text = "N/A"
            End If
        Catch ex As Exception
            MsgBox("Error" + ex.Message)
        End Try
    End Sub
    Sub CLEARHEALTHSEARCH()
        txtpendingappointmentspman.Text = ""
        txtrecentappointmentspman.Text = ""
        txtmajordiseasespman.Text = ""
        lblmedicalhealthconditionpman.Text = ""
        lblinmateIDpman.Text = ""
        lblnamepman.Text = ""
        lbldobpman.Text = ""
        lblgenderpman.Text = ""
        lblmedicationpman.Text = ""
        lblnextofkinpman.Text = ""
        lblemergencynumberpman.Text = ""
        txtallergiespman.Text = ""
        txtsearchpman.Text = ""
        picpman.Image = Nothing
    End Sub

    Private Sub Btncommisionergeneral_Click(sender As Object, e As EventArgs) Handles btncommisionergeneral.Click
        Dim filepath1 As String
        OpenFileDialog2.ShowDialog()
        OpenFileDialog2.Filter = "JPG files (*.jpg)| *jpg"
        piccommisionergeneral.SizeMode = PictureBoxSizeMode.StretchImage
        filepath1 = OpenFileDialog2.FileName
        piccommisionergeneral.Image = Image.FromFile(filepath1)
    End Sub

    Private Sub Btndeputycommisioner_Click(sender As Object, e As EventArgs) Handles btndeputycommisioner.Click
        Dim filepath2 As String
        OpenFileDialog3.ShowDialog()
        OpenFileDialog3.Filter = "JPG files (*.jpg) | *jpg"
        picdeputycommisioner.SizeMode = PictureBoxSizeMode.StretchImage
        filepath2 = OpenFileDialog3.FileName
        picdeputycommisioner.Image = Image.FromFile(filepath2)
    End Sub

    Private Sub Btnregionalcommisioner_Click(sender As Object, e As EventArgs) Handles btnregionalcommisioner.Click
        OpenFileDialog4.ShowDialog()
        Dim filepath3 As String
        OpenFileDialog4.Filter = "JPG files (*.jpg) | *jpg"
        picregionalcommisioner.SizeMode = PictureBoxSizeMode.StretchImage
        filepath3 = OpenFileDialog4.FileName
        picregionalcommisioner.Image = Image.FromFile(filepath3)
    End Sub

    Private Sub Btnofficerincharge_Click(sender As Object, e As EventArgs) Handles btnofficerincharge.Click
        OpenFileDialog5.ShowDialog()
        Dim filepath4 As String
        OpenFileDialog5.Filter = "JPG files (*.jpg) | *jpg"
        picofficerincharge.SizeMode = PictureBoxSizeMode.StretchImage
        filepath4 = OpenFileDialog5.FileName
        picofficerincharge.Image = Image.FromFile(filepath4)
    End Sub

    Private Sub Btnprisonwadens_Click(sender As Object, e As EventArgs) Handles btnprisonwadens.Click
        OpenFileDialog6.ShowDialog()
        Dim filepath5 As String
        OpenFileDialog6.Filter = "JPG files (*.jpg) | *jpg"
        picprisonwarden.SizeMode = PictureBoxSizeMode.StretchImage
        filepath5 = OpenFileDialog6.FileName
        picprisonwarden.Image = Image.FromFile(filepath5)
    End Sub

    Private Sub Btnsavehierachy_Click(sender As Object, e As EventArgs) Handles btnsavehierachy.Click
        Dim con As New MySqlConnection("server=localhost; database=gerezatrack; username=root; password=;")
        Dim mscommisionnergeneral As New MemoryStream
        Dim msdeputycommisioner As New MemoryStream
        Dim msregionalmanager As New MemoryStream
        Dim msofficerincharge As New MemoryStream
        Dim msprisonwarden As New MemoryStream

        Try
            If piccommisionergeneral.Image IsNot Nothing AndAlso picdeputycommisioner.Image IsNot Nothing AndAlso picofficerincharge.Image IsNot Nothing AndAlso picregionalcommisioner.Image IsNot Nothing AndAlso picprisonwarden.Image IsNot Nothing Or txtcommisonergeneral.Text = "" Or
                txtdeputycomissioner.Text = "" Or
                txtofficerincharge.Text = "" Or
                txtregionalcommieionser.Text = "" Then
                piccommisionergeneral.Image.Save(mscommisionnergeneral, piccommisionergeneral.Image.RawFormat)
                picdeputycommisioner.Image.Save(msdeputycommisioner, picdeputycommisioner.Image.RawFormat)
                picofficerincharge.Image.Save(msregionalmanager, picofficerincharge.Image.RawFormat)
                picregionalcommisioner.Image.Save(msofficerincharge, picregionalcommisioner.Image.RawFormat)
                picprisonwarden.Image.Save(msprisonwarden, picprisonwarden.Image.RawFormat)
            Else
                MsgBox("Please Select Images and chack empty fields", vbExclamation + vbOKOnly)
                Return
            End If
            con.Open()

            Dim query As String = "INSERT INTO `tblpman` (`commisionergeneral`, `piccommisionergeneral`, `deputycommisioner`, `picdeputycommisioner`, `regionalcommisioner`, `picregionalcommisioner`, `officerincharge`, `picofficerincharge`, `picprisonerwarden`) VALUES (@commisionergeneral, @piccommisionergeneral, @deputycommisioner, @picdeputycommisioner, @regionalcommisioner, @picregionalcommisioner, @officerincharge, @picofficerincharge, @picprisonerwarden)"
            Dim cmd As New MySqlCommand(query, con)
            ' Add parameters with appropriate values
            cmd.Parameters.AddWithValue("@commisionergeneral", txtcommisonergeneral.Text)
            cmd.Parameters.Add("@piccommisionergeneral", MySqlDbType.LongBlob).Value = mscommisionnergeneral.ToArray()
            cmd.Parameters.AddWithValue("@deputycommisioner", txtdeputycomissioner.Text)
            cmd.Parameters.Add("@picdeputycommisioner", MySqlDbType.LongBlob).Value = msdeputycommisioner.ToArray()
            cmd.Parameters.AddWithValue("@regionalcommisioner", txtregionalcommieionser.Text)
            cmd.Parameters.Add("@picregionalcommisioner", MySqlDbType.LongBlob).Value = msregionalmanager.ToArray()
            cmd.Parameters.AddWithValue("@officerincharge", txtofficerincharge.Text)
            cmd.Parameters.Add("@picofficerincharge", MySqlDbType.LongBlob).Value = msofficerincharge.ToArray()
            cmd.Parameters.Add("@picprisonerwarden", MySqlDbType.LongBlob).Value = msprisonwarden.ToArray()

            ' Execute the query
            cmd.ExecuteNonQuery()

            MsgBox("Information Recorded Successfully", vbInformation + vbOKOnly, "Gereza Track Technologies")

        Catch ex As Exception
            ' Display any exceptions that occur during the execution
            MsgBox(ex.Message)
        Finally
            ' Close the connection in the finally block to ensure it's always closed
            con.Close()
        End Try
    End Sub
    Sub clearpmans()
        piccommisionergeneral.Image = Nothing
        picdeputycommisioner.Image = Nothing
        picofficerincharge.Image = Nothing
        picprisonwarden.Image = Nothing
        picregionalcommisioner.Image = Nothing
        txtcommisonergeneral.Text = ""
        txtdeputycomissioner.Text = ""
        txtofficerincharge.Text = ""
        txtregionalcommieionser.Text = ""
    End Sub
End Class