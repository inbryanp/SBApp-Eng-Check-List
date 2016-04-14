Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmSearch
    Dim SQLCon As New SqlConnection

    Private Sub frmSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub dgvSearchResults_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSearchResults.CellDoubleClick
        Try
            If e.RowIndex >= 0 Then
                frmMain.tbJobNumber.Text = Trim(dgvSearchResults.Rows(e.RowIndex).Cells(0).Value)
                frmMain.tbLineItem.Text = Trim(dgvSearchResults.Rows(e.RowIndex).Cells(1).Value)
                frmMain.btnSearchJob_Click(sender, e)
                Me.Dispose()
            Else

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            SQLCon.ConnectionString = String.Format("Server=Jobscope;Database=LIVE;User ID=jsadmin;Password=S0l@r9876")

            Dim dt As New DataTable
            Dim da As New SqlDataAdapter

            Dim jobquery As String = ""
            Dim quotenumberquery As String = ""
            Dim customerquery As String = ""
            Dim customernumberquery As String = ""
            Dim buildquery As String = ""
            Dim engpnquery As String = ""

            If tbJobNumber.Text <> "" Then
                If InStr(tbJobNumber.Text, "%") = 0 Then
                    jobquery = "AND (PPJOBD.RELEASE = '" & tbJobNumber.Text & "') "
                Else
                    jobquery = "AND (PPJOBD.RELEASE LIKE '" & tbJobNumber.Text & "') "
                End If
            End If

            If tbQuoteNumber.Text <> "" Then
                If InStr(tbQuoteNumber.Text, "%") = 0 Then
                    quotenumberquery = "AND (CUSTOMERINQUIRYLINES.CUSTOMERINQUIRYNUMBER = '" & tbQuoteNumber.Text & "') "
                Else
                    quotenumberquery = "AND (CUSTOMERINQUIRYLINES.CUSTOMERINQUIRYNUMBER LIKE '" & tbQuoteNumber.Text & "') "
                End If
            End If

            If tbCustomer.Text <> "" Then
                If InStr(tbCustomer.Text, "%") = 0 Then
                    customerquery = "AND (CUSTOMERINQUIRYMASTER.CUSTOMERNAME = '" & tbCustomer.Text & "') "
                Else
                    customerquery = "AND (CUSTOMERINQUIRYMASTER.CUSTOMERNAME LIKE '" & tbCustomer.Text & "') "
                End If
            End If

            If tbCustomerNumber.Text <> "" Then
                If InStr(tbCustomerNumber.Text, "%") = 0 Then
                    customernumberquery = "AND (CUSTOMERINQUIRYMASTER.CUSTOMERNUMBER = '" & tbCustomerNumber.Text & "') "
                Else
                    customernumberquery = "AND (CUSTOMERINQUIRYMASTER.CUSTOMERNUMBER LIKE '" & tbCustomerNumber.Text & "') "
                End If
            End If

            If tbBuild.Text <> "" Then
                If InStr(tbBuild.Text, "%") = 0 Then
                    buildquery = "AND (PPJOBD.DESCRIPTION = '" & tbBuild.Text & "' OR PPJOBD.DESCRIPTION = 'MODEL: " & tbBuild.Text & "') "
                Else
                    buildquery = "AND (PPJOBD.DESCRIPTION LIKE '" & tbBuild.Text & "' OR PPJOBD.DESCRIPTION LIKE 'MODEL: " & tbBuild.Text & "') "
                End If
            End If

            If tbEngPN.Text <> "" Then
                If InStr(tbEngPN.Text, "%") = 0 Then
                    engpnquery = "AND (PPJOBD.COMPONENT_CAT_NO = '" & tbEngPN.Text & "') "
                Else
                    engpnquery = "AND (PPJOBD.COMPONENT_CAT_NO LIKE '" & tbEngPN.Text & "') "
                End If
            End If

            Dim criteriaquery As String = Replace("AND (" & jobquery & quotenumberquery & customerquery & customernumberquery & buildquery & engpnquery & ")", "(AND ", "(")

            If tbBuild.Text = "" And tbCustomer.Text = "" And tbCustomerNumber.Text = "" And tbEngPN.Text = "" And tbJobNumber.Text = "" And tbQuoteNumber.Text = "" Then
                criteriaquery = ""
            End If

            Dim strQuery As String = "SELECT DISTINCT PPJOBD.RELEASE, PPJOBD.ITEM_NUMBER, PPJOBD.DESCRIPTION, " & _
                "PPJOBD.COMPONENT_CAT_NO, CUSTOMERINQUIRYLINES.CUSTOMERINQUIRYNUMBER, CUSTOMERINQUIRYMASTER.CUSTOMERNAME " & _
                "FROM " & _
                "CUSTOMERINQUIRYLINES " & _
                "FULL JOIN CUSTOMERINQUIRYMASTER " & _
                "ON CUSTOMERINQUIRYLINES.CUSTOMERINQUIRYNUMBER = CUSTOMERINQUIRYMASTER.CUSTOMERINQUIRYNUMBER " & _
                "JOIN " & _
                "PPJOBD " & _
                "ON " & _
                "CUSTOMERINQUIRYLINES.JOBNUMBER = PPJOBD.RELEASE " & _
                "WHERE PPJOBD.ITEM_NUMBER <> '' AND PPJOBD.DESCRIPTION NOT LIKE '%NOTES%' " & _
                "AND PPJOBD.DESCRIPTION NOT LIKE '%MARK%' AND PPJOBD.DESCRIPTION NOT LIKE '%DELIVERY%' " & _
                "AND PPJOBD.COMPONENT_CAT_NO NOT LIKE '%NOTES' " & _
                criteriaquery & " " & _
                "ORDER BY PPJOBD.RELEASE, PPJOBD.ITEM_NUMBER"

            da = New SqlDataAdapter(strQuery, SQLCon)

            SQLCon.Open()
            da.Fill(dt)
            SQLCon.Close()

            dt.Columns(0).ColumnName = "Job"
            dt.Columns(1).ColumnName = "Item"
            dt.Columns(2).ColumnName = "Build"
            dt.Columns(3).ColumnName = "Eng PN"
            dt.Columns(4).ColumnName = "Quote"
            dt.Columns(5).ColumnName = "Customer"

            dgvSearchResults.DataSource = dt

            For i = 0 To dt.Rows.Count - 1
                dt.Rows(i).Item(2) = Replace(Replace(Trim(dt.Rows(i).Item(2)), "Model: ", ""), "MODEL:", "")
            Next

            For i = 0 To 5
                If i = 2 Then
                    dgvSearchResults.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                ElseIf i = 0 Then
                    dgvSearchResults.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                Else
                    dgvSearchResults.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                End If
            Next

        Catch ex As Exception
            SQLCon.Close()
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        tbBuild.Clear()
        tbCustomer.Clear()
        tbCustomerNumber.Clear()
        tbEngPN.Clear()
        tbJobNumber.Clear()
        tbQuoteNumber.Clear()
    End Sub

    Private Sub tbJobNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbJobNumber.KeyUp, tbBuild.KeyUp, tbCustomer.KeyUp, tbCustomerNumber.KeyUp, tbEngPN.KeyUp, tbQuoteNumber.KeyUp
        If e.KeyCode = Keys.Enter Then
            btnSearch_Click(sender, e)
        End If
    End Sub
End Class