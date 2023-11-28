Imports CrystalDecisions.CrystalReports.Engine
Imports MySql.Data.MySqlClient
Public Class print
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Dashboard.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnsearchinmateinreport.Click
        Dim connectionString As String = "server=localhost; database=gerezatrack; username=root; password=;"
        Dim inmateNumber As String = txtsearchinmateinreport.Text
        If rbtinmatereport.Checked = True Then
            If String.IsNullOrEmpty(inmateNumber) Then
                MsgBox("Input the Inmate ID to continue....", vbExclamation + vbOKCancel, "Error!!")
            Else
                Try
                    Using con As New MySqlConnection(connectionString)
                        con.Open()

                        ' Retrieve inmate information based on the provided inmate number
                        Dim inmateInfoQuery As String = "SELECT `inmatenumber`, `Fullname`, `dob`, `countyofbirth`, `nationality`, `Idnumber`, `gender`, `maritalstatus`, `numoftattoos`, `educationlevel`, `mentalstate`, `religion`, `arrestdate`, `sentencedate`, `appealcondition`, `apppealdate`, `courtlocation`, `casenumber`, `allergiescondition`, `allaergies`, `casesentense`, `medications`, `nextofkin`, `emergencycontact`, `visitorpriviledge`, `crimescommited`, `leftpic`,rightpic, `relationtoEC` FROM `tblinmate` where inmatenumber=@inmateNumber"
                        Dim inmateDataAdapter As New MySqlDataAdapter(inmateInfoQuery, con)
                        inmateDataAdapter.SelectCommand.Parameters.AddWithValue("@inmateNumber", inmateNumber)
                        Dim inmateDataTable As New DataTable
                        inmateDataAdapter.Fill(inmateDataTable)

                        Dim inmateReport As New inmatereport
                        inmateReport.SetDataSource(inmateDataTable)
                        CrystalReportViewer1.ReportSource = inmateReport
                    End Using
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message)
                End Try
            End If
        End If
        If rbtvisitor.Checked Then
            Dim visitorID As String = txtsearchinmateinreport.Text.Trim()

            If String.IsNullOrEmpty(visitorID) Then
                MsgBox("Input the visitorID to continue...", vbExclamation + vbOKOnly, "Gereza Track Technologies")
            Else
                Try
                    Using connect As New MySqlConnection(connectionString)
                        connect.Open()

                        Dim query As String = "SELECT `inmatenumber`, `visitdate`, `letintime`, `fulllegalname`, `dobvisitor`, `IDvisitor`, `visitorphonenumber`, `relationshiptoinmate`, `vehicleplatenumber`, `numberofvisitors`, `inmatesname` FROM `tblvisits` WHERE `IDvisitor`=@VisitorID"

                        Using cmd As New MySqlCommand(query, connect)
                            cmd.Parameters.AddWithValue("@VisitorID", visitorID)

                            Dim adap As New MySqlDataAdapter(cmd)
                            Dim tbl As New DataTable
                            adap.Fill(tbl)

                            If tbl.Rows.Count > 0 Then
                                Dim vreport As New visitorsreport
                                vreport.SetDataSource(tbl)
                                CrystalReportViewer1.ReportSource = vreport
                            Else
                                MsgBox("No recorded data of this visitor", vbExclamation + vbOKOnly, "Gereza Track Technologies")
                            End If
                        End Using
                    End Using
                Catch ex As Exception
                    MsgBox("An error occurred: " & ex.Message, vbCritical + vbOKOnly, "Error")
                End Try
            End If
        End If

        If rbtuserreport.Checked = True Then
            Dim userID As String = txtsearchinmateinreport.Text
            If String.IsNullOrEmpty(userID) Then
                MsgBox("Input the User Registration Number to continue", vbExclamation + vbOKOnly, "Gereza Track Technologies")
            Else
                Using con As New MySqlConnection(connectionString)
                    con.Open()
                    Dim dtable As New DataTable
                    Dim query As String = "SELECT `username`, `regno`, `password`, `fullname`, `Rank`, `Role`, `userimage` FROM `tblusers` WHERE regno='" & txtsearchinmateinreport.Text & "'"
                    Dim adapta As New MySqlDataAdapter(query, con)
                    adapta.Fill(dtable)
                    If dtable.Rows.Count > 0 Then
                        Dim rpt As New userssreport
                        rpt.SetDataSource(dtable)
                        CrystalReportViewer1.ReportSource = rpt
                    Else
                        MsgBox("No recorded data of this User", vbExclamation + vbOKCancel, "Gereza Track Technologies")
                    End If
                End Using
            End If
        End If
        If rbtaoutbreak.Checked = True Then
            Dim dname As String = txtsearchinmateinreport.Text
            If String.IsNullOrEmpty(dname) Then

            Else
                Using conn As New MySqlConnection(connectionString)
                    Dim tabl As New DataTable
                    Dim query As String = "SELECT `diseasename`, `dateonset`, `affectedareas`, `numofcases`, `symptoms`, `preventivemeasures`, `peopleinisolation` FROM `tbloutbreak` WHERE `diseasename`='" & txtsearchinmateinreport.Text & "'"
                    Dim adapter As New MySqlDataAdapter(query, conn)
                    adapter.Fill(tabl)
                    If tabl.Rows.Count > 0 Then
                        Dim repot As New outbreaksreport
                        repot.SetDataSource(tabl)
                        CrystalReportViewer1.ReportSource = repot
                    End If
                End Using
            End If
        End If
        If rbtstrikereport.Checked = True Then
            Dim blockno As String = txtsearchinmateinreport.Text
            If String.IsNullOrEmpty(blockno) Then
                MsgBox("No recorded data of this strike", vbExclamation + vbOKCancel, "Gereza Track Technologies")
            Else
                Using connect As New MySqlConnection(connectionString)
                    Dim tabl As New DataTable
                    Dim querystring As String = "SELECT `date`, `starttime`, `block`, `inmatesparticipating`, `duration`, `reason`, `leaders`, `witnesses`, `demandsandreqests`, `destroyedpropertiescondition`, `destroyedproperty`, `actiontaken` FROM `tblstrikes` WHERE block='" & txtsearchinmateinreport.Text & "'"
                    Dim adapt As New MySqlDataAdapter(querystring, connect)
                    adapt.Fill(tabl)
                    If tabl.Rows.Count > 0 Then
                        Dim reports As New strikereport
                        reports.SetDataSource(tabl)
                        CrystalReportViewer1.ReportSource = reports
                    End If
                End Using
            End If
        End If
        If rbtmaintainancereport.Checked = True Then
            Dim startdate As String = txtsearchinmateinreport.Text
            If String.IsNullOrEmpty(startdate) Then
                MsgBox("No recorded data of this strike", vbExclamation + vbOKCancel, "Gereza Track Technologies")
            Else
                Using con As New MySqlConnection(connectionString)
                    Dim tbl As New DataTable
                    Dim querycode As String = " SELECT `maintainancetype`, `commencementdate`, `Decription`, `Equipmentinvlovled`, `Duration`, `materialsused`, `cost`, `attachments`, `headofmaintainnce`, `approvedby`, `comments`, `attachmentdata` FROM `tblmaintainace` WHERE commencementdate='" & txtsearchinmateinreport.Text & "'"
                    Dim adt As New MySqlDataAdapter(querycode, con)
                    adt.Fill(tbl)
                    If tbl.Rows.Count > 0 Then
                        Dim rpt As New maintainancereport
                        rpt.SetDataSource(tbl)
                        CrystalReportViewer1.ReportSource = rpt
                    End If
                End Using
            End If
        End If
        If rbtcrimesreport.Checked = True Then
            Dim crimecode As String = txtsearchinmateinreport.Text
            If String.IsNullOrEmpty(crimecode) Then
                MsgBox("No recorded data of this CrimeID", vbExclamation + vbOKCancel, "Gereza Track Technologies")
            Else
                Using con As New MySqlConnection(connectionString)
                    Dim tabl As New DataTable
                    Dim sqlquery As String = "SELECT `crimecode`, `crimename`, `date`, `typeofcrime`, `causes`, `agebracket`, `gender`, `totalconvicted`, `training` FROM `tblcrimes` WHERE crimecode='" & txtsearchinmateinreport.Text & "'"
                    Dim ada As New MySqlDataAdapter(sqlquery, con)
                    ada.Fill(tabl)
                    If tabl.Rows.Count > 0 Then
                        Dim rt As New crimereport
                        rt.SetDataSource(tabl)
                        CrystalReportViewer1.ReportSource = rt
                    End If
                End Using
            End If
        End If
        If rbttransferreports.Checked Then
            Dim inmateID As String = txtsearchinmateinreport.Text
            If String.IsNullOrEmpty(inmateID) Then
            Else
                Using connect As New MySqlConnection(connectionString)
                    Dim query As String = "SELECT `inmatenumber`, `driversname`, `driversregno`, `carnumberplate`, `departuretime`, `reasonoftransfer`, `transfereto`, `approvedby`, `medicalconditiontransfer`, `transferdate`, `approvaldate` FROM `tbltransfer` WHERE `inmatenumber`='" & txtsearchinmateinreport.Text & "'"
                    Dim adapta As New MySqlDataAdapter(query, connect)
                    Dim tal As New DataTable
                    adapta.Fill(tal)
                    If tal.Rows.Count > 0 Then
                        Dim intransfer As New inmatetransfer
                        intransfer.SetDataSource(tal)
                        CrystalReportViewer1.ReportSource = intransfer
                    End If
                End Using
            End If
        End If
    End Sub
    Private Sub Rbtinmatereport_CheckedChanged(sender As Object, e As EventArgs) Handles rbtinmatereport.CheckedChanged
        If rbtinmatereport.Checked = True Then
            lblsearchlabel.Text = "(Input Inmate's ID)"
        End If
    End Sub

    Private Sub Rbtvisitor_CheckedChanged(sender As Object, e As EventArgs) Handles rbtvisitor.CheckedChanged
        If rbtvisitor.Checked = True Then
            lblsearchlabel.Text = "(Input Visitor's ID)"
        End If
    End Sub

    Private Sub Rbtuserreport_CheckedChanged(sender As Object, e As EventArgs) Handles rbtuserreport.CheckedChanged
        If rbtuserreport.Checked = True Then
            lblsearchlabel.Text = "(Input User's Reg No)"
        End If
    End Sub

    Private Sub Rbtaoutbreak_CheckedChanged(sender As Object, e As EventArgs) Handles rbtaoutbreak.CheckedChanged
        If rbtaoutbreak.Checked = True Then
            lblsearchlabel.Text = "(Input Disease Name)"
        End If
    End Sub

    Private Sub Rbtstrikereport_CheckedChanged(sender As Object, e As EventArgs) Handles rbtstrikereport.CheckedChanged
        If rbtstrikereport.Checked = True Then
            lblsearchlabel.Text = "(Input Block NO)"
        End If
    End Sub

    Private Sub Rbtmaintainancereport_CheckedChanged(sender As Object, e As EventArgs) Handles rbtmaintainancereport.CheckedChanged
        If rbtmaintainancereport.Checked = True Then
            lblsearchlabel.Text = "(Enter Start Date)"
        End If
    End Sub

    Private Sub Rbtcrimesreport_CheckedChanged(sender As Object, e As EventArgs) Handles rbtcrimesreport.CheckedChanged
        If rbtcrimesreport.Checked = True Then
            lblsearchlabel.Text = "(Enter Crime Code)"
        End If
    End Sub
    Private Sub Rbttransferreports_CheckedChanged(sender As Object, e As EventArgs) Handles rbttransferreports.CheckedChanged
        If rbttransferreports.Checked = True Then
            lblsearchlabel.Text = "(Input InmateID)"
        End If
    End Sub

End Class