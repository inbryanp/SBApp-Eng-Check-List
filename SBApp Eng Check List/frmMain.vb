Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Globalization

Public Class frmMain

    Dim SQLCon As New SqlConnection
    

    Public Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            SQLCon.ConnectionString = String.Format("Server=Jobscope;Database=LIVE;User ID=jsadmin;Password=S0l@r9876")

            Dim dt As New DataTable
            Dim da As New SqlDataAdapter
            Dim cbquery As String = ""
            Dim rcquery As String = ""
            Dim siquery As String = ""
            Dim psquery As String = ""
            Dim wiquery As String = ""
            Dim ptquery As String = ""
            Dim datefrom As DateTime = DTPFrom.Value.Date.ToString
            Dim redatefrom As String = datefrom.ToString("yyyyMMdd", CultureInfo.InvariantCulture)
            Dim dateto As DateTime = DTPTo.Value.Date.ToString
            Dim redateto As String = dateto.ToString("yyyyMMdd", CultureInfo.InvariantCulture)

            If lstVCriteria.Items(0).Checked = True Then
                cbquery = "PRODUCT_LINE = 'AC' OR PRODUCT_LINE = 'C' OR PRODUCT_LINE = 'CS' OR PRODUCT_LINE = 'DC' OR PRODUCT_LINE = 'DS' OR PRODUCT_LINE = 'M' OR PRODUCT_LINE = 'SS' " & _
                    "OR PRODUCT_LINE = 'ST' OR PRODUCT_LINE = 'UC' OR PRODUCT_LINE = 'AC' "
            End If

            If lstVCriteria.Items(1).Checked = True Then
                rcquery = "PRODUCT_LINE = 'BE' OR PRODUCT_LINE = 'BR' OR PRODUCT_LINE = 'CE' OR PRODUCT_LINE = 'CR' OR PRODUCT_LINE = 'FB' OR PRODUCT_LINE = 'FC' OR PRODUCT_LINE = 'CR' " & _
                    "OR PRODUCT_LINE = 'LD' OR PRODUCT_LINE = 'LF' OR PRODUCT_LINE = 'LR' OR PRODUCT_LINE = 'ND' OR PRODUCT_LINE = 'NF' OR PRODUCT_LINE = 'NR' OR PRODUCT_LINE = 'RC' "
            End If

            If lstVCriteria.Items(2).Checked = True Then
                siquery = "PRODUCT_LINE = 'CC' OR PRODUCT_LINE = 'CF' OR PRODUCT_LINE = 'CJ' OR PRODUCT_LINE = 'J' OR PRODUCT_LINE = 'G' OR PRODUCT_LINE = 'SI' "
            End If

            If lstVCriteria.Items(3).Checked = True Then
                psquery = "PRODUCT_LINE = 'PS' "
            End If

            If lstVCriteria.Items(4).Checked = True Then
                wiquery = "PRODUCT_LINE = 'WI' "
            End If

            If lstVCriteria.Items(5).Checked = True Then
                ptquery = "PRODUCT_LINE = 'PT' "
            End If

            Dim criteriaquery As String = "AND PRODUCT_LINE ='' "
            If lstVCriteria.Items(0).Checked = True Or lstVCriteria.Items(1).Checked = True Or lstVCriteria.Items(2).Checked = True Or lstVCriteria.Items(3).Checked = True Or lstVCriteria.Items(4).Checked = True Or lstVCriteria.Items(5).Checked = True Then
                criteriaquery = Replace(Replace("AND (" & cbquery & rcquery & siquery & psquery & wiquery & ptquery & ")", "' P", "' OR P"), "' )", "')")
            Else
            End If
            Dim Lookfor As String = ""
            Dim rellookfor As String = ""
            Dim datequery As String = ""

            Select Case Trim(cbLookFor.Text).ToUpper
                Case "UNRELEASED"
                    Lookfor = "WHERE (PPJOBD.SHIP_COMPLETE <> 'C' OR PPJOBD.PAINT_CODE <> 'NB') "
                    rellookfor = "AND (JOBLINEITEMS.ENDUNITSERIALNUMBER IS NULL OR JOBLINEITEMS.ENDUNITSERIALNUMBER = '') "
                    datequery = "AND PPWOM.SCHEDULE_BEGUN > CONVERT(VARCHAR(8),GETDATE(),112)-100 "
                Case "RELEASED"
                    Lookfor = "WHERE PPJOBD.PAINT_CODE <>'NB' "
                    rellookfor = "AND (JOBLINEITEMS.ENDUNITSERIALNUMBER IS NOT NULL OR JOBLINEITEMS.ENDUNITSERIALNUMBER <> '') "
                    datequery = "AND PPWOM.SCHEDULE_BEGUN > '" & redatefrom & "' AND PPWOM.SCHEDULE_BEGUN < '" & redateto & "' "
                Case "PENDING DRAWINGS"
                    Lookfor = "<>"
                    rellookfor = "AND (JOBLINEITEMS.ENDUNITSERIALNUMBER IS NULL OR JOBLINEITEMS.ENDUNITSERIALNUMBER = '') "
                Case "PENDING BOM"
                    Lookfor = "<>"
                    rellookfor = "AND (JOBLINEITEMS.ENDUNITSERIALNUMBER IS NULL OR JOBLINEITEMS.ENDUNITSERIALNUMBER = '') "
            End Select



            Dim strQuery As String = "SELECT DISTINCT PPJOBD.RELEASE, PPJOBD.ITEM_NUMBER, PPJOBD.DESCRIPTION, JOBLINEITEMS.ENDUNITSERIALNUMBER, PPWOM.SCHEDULE_BEGUN, PPJOBD.DATE_REQUESTED, PPJOBD.LOCATION_CODE " & _
                                    "FROM PPJOBD " & _
                                    "FULL JOIN JOBLINEITEMS ON PPJOBD.RELEASE = JOBLINEITEMS.JOBNUMBER AND PPJOBD.ITEM_NUMBER = JOBLINEITEMS.LINENUMBER " & _
                                    "FULL JOIN PPWOM ON JOBLINEITEMS.JOBNUMBER = PPWOM.RELEASE AND JOBLINEITEMS.LINENUMBER = PPWOM.ITEM_NUMBER " & _
                                    Lookfor & _
                                    rellookfor & _
                                    "AND (PPJOBD.COMPONENT_CAT_NO NOT LIKE '%NOTES%' AND PPJOBD.COMPONENT_CAT_NO NOT LIKE '%LOT%' AND PPJOBD.COMPONENT_CAT_NO NOT LIKE '%T&C%') " & _
                                    datequery & _
                                    criteriaquery & " " & _
                                    "ORDER BY PPWOM.SCHEDULE_BEGUN ASC, PPJOBD.RELEASE ASC, PPJOBD.ITEM_NUMBER ASC"

            da = New SqlDataAdapter(strQuery, SQLCon)

            SQLCon.Open()
            da.Fill(dt)
            SQLCon.Close()

            dt.Columns(0).ColumnName = "Job"
            dt.Columns(1).ColumnName = "Item"
            dt.Columns(2).ColumnName = "Build"
            dt.Columns(4).ColumnName = "Due Date"
            dt.Columns(5).ColumnName = "FBOM Date"
            dt.Columns(6).ColumnName = "Loc"

            For i = 0 To dt.Rows.Count - 1
                dt.Rows(i).Item(2) = Replace(dt.Rows(i).Item(2), "Model: ", "")
                Dim str() As String
                str = Split(DateTime.ParseExact(dt.Rows(i).Item(4), "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None), " ")
                dt.Rows(i).Item(4) = str(0)

                Dim str1() As String
                str1 = Split(DateTime.ParseExact(dt.Rows(i).Item(5) - 2, "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None), " ")
                dt.Rows(i).Item(5) = str1(0)

                Select Case dt.Rows(i).Item(6)
                    Case "MI"

                    Case Else
                        dt.Rows(i).Item(6) = "LV"
                End Select
            Next

            dgvTaskList.DataSource = dt
            dgvTaskList.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvTaskList.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            dgvTaskList.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgvTaskList.Columns(3).Visible = False
            dgvTaskList.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvTaskList.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            dgvTaskList.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader

            'For i = 0 To 5
            '    dgvTaskList.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
            'Next

        Catch ex As Exception
            SQLCon.Close()
        End Try

    End Sub

    Private Sub EngineeringCheckListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EngineeringCheckListToolStripMenuItem.Click
        Process.Start("S:\Quality Control\Quality Controlled Documents\Engineering")
    End Sub

    Private Sub ETLGeneratorsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ETLGeneratorsToolStripMenuItem.Click
        Process.Start("S:\Production Drawings\ETL Per Order\ETL Templates")
    End Sub

    Public Sub btnSearchJob_Click(sender As Object, e As EventArgs) Handles btnSearchJob.Click
        tbSerialNumber.Clear()
        rtbComments.Clear()
        tbEngPN.Clear()
        tbBuild.Clear()
        lstViewWO.Clear()
        tbInquiry.Clear()
        tbCustomer.Clear()

        Dim drawingpath As String = ""
        Dim inquirynumber As String = ""
        Dim customer As String = ""
        Dim sales As String = ""

        Try
            SQLCon.ConnectionString = String.Format("Server=Jobscope;Database=LIVE;User ID=jsadmin;Password=S0l@r9876")
            Dim dt As New DataTable
            Dim dt1 As New DataTable
            Dim dt2 As New DataTable
            Dim dt4 As New DataTable

            Dim da As New SqlDataAdapter
            Dim da1 As New SqlDataAdapter
            Dim da2 As New SqlDataAdapter
            Dim da4 As New SqlDataAdapter

            da = New SqlDataAdapter("SELECT SEQUENCENUMBER, DESCRIPTION, FULLPATHNAME FROM DBO.JOBDOCUMENTS WHERE JOBNUMBER = '" & tbJobNumber.Text & "'", SQLCon)
            da1 = New SqlDataAdapter("SELECT DESCRIPTION, ENDUNITSERIALNUMBER, COMMENT, QUANTITY FROM DBO.JOBLINEITEMS WHERE JOBNUMBER = '" & tbJobNumber.Text & "' AND LINENUMBER = '" & tbLineItem.Text & "'", SQLCon)
            da2 = New SqlDataAdapter("SELECT DRAWING_NUMBER, CATALOGUE_NUMBER, RELEASE_WO FROM DBO.PPWOM WHERE RELEASE = '" & tbJobNumber.Text & "' AND ITEM_NUMBER = '" & tbLineItem.Text & "' ORDER BY RELEASE_WO ASC", SQLCon)
            da4 = New SqlDataAdapter("SELECT CATALOGUE_NUMBER, RELEASE_WO FROM DBO.PPBOMF WHERE RELEASE = '" & tbJobNumber.Text & "'", SQLCon)

            SQLCon.Open()
            da.Fill(dt)
            da1.Fill(dt1)
            da2.Fill(dt2)
            da4.Fill(dt4)

            SQLCon.Close()
            dt.Columns(0).ColumnName = "Doc #"
            dt.Columns(2).ColumnName = "Path"

            For i As Integer = dt.Rows.Count - 1 To 0 Step -1
                If InStr(CStr(dt.Rows(i).Item(1)).ToUpper, "CHANGE") >= 1 Then

                ElseIf InStr(CStr(dt.Rows(i).Item(1)).ToUpper, "SCB") >= 1 Then
                    If InStr(CStr(dt.Rows(i).Item(1)).ToUpper, "LI-") >= 1 Then
                        If InStr(CStr(dt.Rows(i).Item(1)).ToUpper, "LI-" & tbLineItem.Text) >= 1 Then
                        Else
                            dt.Rows(i).Delete()
                        End If
                    Else
                        For j As Integer = 0 To dt2.Rows.Count - 1
                            If InStr(CStr(dt.Rows(i).Item(1)).ToUpper, "WO-" & Microsoft.VisualBasic.Right(dt2.Rows(j).Item(2), 4)) >= 1 Then

                            Else
                                dt.Rows(i).Delete()
                            End If
                        Next
                    End If
                ElseIf InStr(CStr(dt.Rows(i).Item(1)).ToUpper, "WIRE") >= 1 Then
                    If InStr(CStr(dt.Rows(i).Item(1)).ToUpper, "LI-") >= 1 Then
                        If InStr(CStr(dt.Rows(i).Item(1)).ToUpper, "LI-" & tbLineItem.Text) >= 1 Then
                        Else
                            dt.Rows(i).Delete()
                        End If
                    Else
                        For j As Integer = 0 To dt2.Rows.Count - 1
                            If InStr(CStr(dt.Rows(i).Item(1)).ToUpper, "WO-" & Microsoft.VisualBasic.Right(dt2.Rows(j).Item(2), 4)) >= 1 Then

                            Else
                                dt.Rows(i).Delete()
                            End If
                        Next
                    End If
                ElseIf InStr(CStr(dt.Rows(i).Item(1)).ToUpper, "FUSE") >= 1 Then

                ElseIf InStr(CStr(dt.Rows(i).Item(1)).ToUpper, "ETL") >= 1 Then
                    If InStr(CStr(dt.Rows(i).Item(1)).ToUpper, "LI-") >= 1 Then
                        If InStr(CStr(dt.Rows(i).Item(1)).ToUpper, "LI-" & tbLineItem.Text) >= 1 Then
                        Else
                            dt.Rows(i).Delete()
                        End If
                    Else
                        For j As Integer = 0 To dt2.Rows.Count - 1
                            If InStr(CStr(dt.Rows(i).Item(1)).ToUpper, "WO-" & Microsoft.VisualBasic.Right(dt2.Rows(j).Item(2), 4)) >= 1 Then

                            Else
                                dt.Rows(i).Delete()
                            End If
                        Next
                    End If
                ElseIf InStr(CStr(dt.Rows(i).Item(1)).ToUpper, "DRAWING") >= 1 Then

                Else
                    dt.Rows(i).Delete()
                End If
            Next

            For i As Integer = dt4.Rows.Count - 1 To 0 Step -1
                Dim countmatch As Long = 0

                For j As Integer = 0 To dt2.Rows.Count - 1
                    If dt4.Rows(i).Item(1) <> dt2.Rows(j).Item(2) Then

                    Else
                        countmatch = countmatch + 1
                    End If
                Next

                If countmatch = 0 Then
                    dt4.Rows(i).Delete()
                End If
            Next

            Dim dt5 As New DataTable
            Dim da5 As New SqlDataAdapter

            da5 = New SqlDataAdapter("SELECT PARTNUMBER, URL_DOCUMENT FROM DBO.PARTDOCUMENTS", SQLCon)

            SQLCon.Open()
            da5.Fill(dt5)
            SQLCon.Close()

            dt4.Columns.Add("Drawing")

            Try
                For i As Integer = 0 To dt4.Rows.Count - 1
                    For j As Integer = 0 To dt5.Rows.Count - 1
                        If Trim(dt4.Rows(i).Item(0)) = Trim(dt5.Rows(j).Item(0)) Then
                            dt4.Rows(i)("Drawing") = dt5.Rows(j).Item(1)
                        End If
                    Next
                Next
            Catch ex As Exception

            End Try

            Try
                For i As Integer = dt4.Rows.Count - 1 To 0
                    If InStr(dt4.Rows(i).Item(2), "S:") >= 1 Then
                    Else
                        dt4.Rows(i).Delete()
                    End If
                Next

                For i As Integer = 0 To dt2.Rows.Count - 1
                    lstViewWO.Items.Add(Microsoft.VisualBasic.Right(dt2.Rows(i).Item(2), 4))
                Next
            Catch ex As Exception

            End Try



            Try
                tbBuild.Text = dt1.Rows(0).Item(0)
            Catch ex As Exception

            End Try

            Try
                tbSerialNumber.Text = dt1.Rows(0).Item(1)
            Catch ex As Exception

            End Try

            Try
                rtbComments.Text = dt1.Rows(0).Item(2)
            Catch ex As Exception

            End Try

            Try
                tbQty.Text = dt1.Rows(0).Item(3)
            Catch ex As Exception

            End Try

            Try
                tbEngPN.Text = Trim(dt2.Rows(0).Item(1))
            Catch ex As Exception

            End Try

            Try
                Select Case Trim(dt2.Rows(0).Item(0)).ToUpper
                    Case "LINKED"
                        Dim dt3 As New DataTable
                        Dim da3 As New SqlDataAdapter

                        da3 = New SqlDataAdapter("SELECT URL_DOCUMENT FROM DBO.PARTDOCUMENTS WHERE PARTNUMBER = '" & Trim(tbEngPN.Text) & "'", SQLCon)

                        SQLCon.Open()
                        da3.Fill(dt3)
                        SQLCon.Close()

                        drawingpath = dt3.Rows(0).Item(0)
                    Case ""

                    Case Else
                        Dim dt3 As New DataTable
                        Dim da3 As New SqlDataAdapter

                        da3 = New SqlDataAdapter("SELECT URL_DRAWING FROM DBO.PARTDRAWINGS WHERE PARTNUMBER = '" & Trim(dt2.Rows(0).Item(0)) & "'", SQLCon)

                        SQLCon.Open()
                        da3.Fill(dt3)
                        SQLCon.Close()

                        drawingpath = dt3.Rows(0).Item(0)
                End Select
            Catch ex As Exception
                SQLCon.Close()
            End Try

            Try
                Dim dt6 As New DataTable
                Dim da6 As New SqlDataAdapter

                da6 = New SqlDataAdapter("SELECT CUSTOMERINQUIRYNUMBER, CUSTOMERNAME, SALESMAN1 FROM DBO.CUSTOMERINQUIRYMASTER WHERE JOBNUMBER = '" & tbJobNumber.Text & "'", SQLCon)

                SQLCon.Open()
                da6.Fill(dt6)
                SQLCon.Close()

                inquirynumber = dt6.Rows(0).Item(0)
                customer = dt6.Rows(0).Item(1)
                sales = dt6.Rows(0).Item(2)

            Catch ex As Exception
                SQLCon.Close()
            End Try

            tbInquiry.Text = Trim(inquirynumber)
            tbCustomer.Text = Trim(customer)
            tbSales.Text = Trim(sales)

            dt4.Columns(0).ColumnName = "Part Number"
            dt4.Rows.Add(tbEngPN.Text, "", drawingpath)
            dgvLinkedDocs.DataSource = dt4
            dgvLinkedDocs.Columns(1).Visible = False
            dgvLinkedDocs.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvLinkedDocs.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dt.Columns(1).ColumnName = "Description"
            dgvLinkedDocs.Sort(dgvLinkedDocs.Columns(2), System.ComponentModel.ListSortDirection.Descending)
            dgvJobDocs.DataSource = dt
            dgvJobDocs.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            dgvJobDocs.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        Catch ex As Exception
            SQLCon.Close()
            MsgBox("Job Number/Line Item does not exist.")
        End Try

    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click

        Select Case TabControl1.SelectedIndex
            Case 0
                Try
                    For Each objRow As DataGridViewRow In dgvJobDocs.SelectedRows
                        If dgvJobDocs.Rows.Count >= 0 Then
                            Process.Start(objRow.Cells(2).Value)
                        End If
                    Next
                Catch ex As Exception
                    MsgBox("Document does not exist.")
                End Try
            Case 1
                Try
                    For Each objRow As DataGridViewRow In dgvLinkedDocs.SelectedRows
                        If dgvJobDocs.Rows.Count >= 0 Then
                            Process.Start(objRow.Cells(2).Value)
                        End If
                    Next
                Catch ex As Exception
                    MsgBox("Document does not exist.")
                End Try
        End Select

    End Sub

    Private Sub tbLineItem_TextChanged(ByVal sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbLineItem.KeyPress, tbInquiry.KeyPress, tbSales.KeyPress, tbQty.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub dgvJobDocs_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvJobDocs.CellDoubleClick
        Try
            Process.Start(dgvJobDocs.Rows(e.RowIndex).Cells(2).Value)
        Catch ex As Exception
            MsgBox("Document does not exist.")
        End Try
    End Sub

    Private Sub btnUpdateSerial_Click(sender As Object, e As EventArgs) Handles btnUpdateSerial.Click
        Try
            Dim cmd As New SqlCommand
            SQLCon.ConnectionString = String.Format("Server=Jobscope;Database=LIVE;User ID=jsadmin;Password=S0l@r9876")

            SQLCon.Open()
            cmd.Connection = SQLCon
            cmd.CommandText = "UPDATE DBO.JOBLINEITEMS SET ENDUNITSERIALNUMBER = '" & tbSerialNumber.Text & "' WHERE JOBNUMBER = '" & tbJobNumber.Text & "' AND LINENUMBER = '" & tbLineItem.Text & "'"

            cmd.ExecuteNonQuery()
            SQLCon.Close()
            MsgBox("Serial number has been updated.")
        Catch ex As Exception
            SQLCon.Close()
        End Try

        frmMain_Load(sender, e)
    End Sub

    Private Sub dgvLinkedDocs_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLinkedDocs.CellDoubleClick
        Try
            Process.Start(dgvLinkedDocs.Rows(e.RowIndex).Cells(2).Value)
        Catch ex As Exception
            MsgBox("Document does not exist.")
        End Try
    End Sub

    Private Sub btnUpdateGrid_Click(sender As Object, e As EventArgs) Handles btnUpdateGrid.Click
        frmMain_Load(sender, e)
    End Sub

    Private Sub dgvTaskList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTaskList.CellDoubleClick
        Try
            If e.RowIndex >= 0 Then
                tbJobNumber.Text = Trim(dgvTaskList.Rows(e.RowIndex).Cells(0).Value)
                tbLineItem.Text = Trim(dgvTaskList.Rows(e.RowIndex).Cells(1).Value)
                btnSearchJob_Click(sender, e)
            Else

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        frmMain_Load(sender, e)
    End Sub

    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
        frmSearch.ShowDialog()
    End Sub

    Private Sub lstVCriteria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstVCriteria.ItemChecked
        frmMain_Load(sender, e)
    End Sub

    Private Sub DTPFrom_ValueChanged(sender As Object, e As EventArgs) Handles DTPFrom.ValueChanged
        frmMain_Load(sender, e)
    End Sub

    Private Sub DTPTo_ValueChanged(sender As Object, e As EventArgs) Handles DTPTo.ValueChanged
        frmMain_Load(sender, e)
    End Sub

    Private Sub cbLookFor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLookFor.SelectedIndexChanged
        Select Case Trim(cbLookFor.Text).ToUpper
            Case "UNRELEASED"
                DTPFrom.Enabled = False
                DTPTo.Enabled = False
            Case "RELEASED"
                DTPFrom.Enabled = True
                DTPTo.Enabled = True
        End Select
        frmMain_Load(sender, e)

    End Sub

End Class
