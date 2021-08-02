Imports System
Imports System.Data
Imports System.Data.Odbc
Imports System.Windows.Forms
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO

Public Class frm_reinsurance
    Dim dr_re, dr_sch, dr_sch2 As OdbcDataReader
    Dim da As OdbcDataAdapter
    Dim data As DataTable
    Private Sub frm_reinsurance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connection.connect()
        Me.MdiParent = main
        load_re_claimed_unclaimed()
    End Sub
    Public Sub load_re_claimed_unclaimed()
        data = New DataTable
        da = New OdbcDataAdapter(("SELECT jm_reinsurance_report_claimed_unclaimed.*,member_anniversary.start_date,member_anniversary.end_date FROM jm_reinsurance_report_claimed_unclaimed INNER JOIN PRINCIPAL_APPLICANT ON jm_reinsurance_report_claimed_unclaimed.family_no = PRINCIPAL_APPLICANT.FAMILY_NO  INNER JOIN member_anniversary ON PRINCIPAL_APPLICANT.MEMBER_NO = member_anniversary.member_no AND jm_reinsurance_report_claimed_unclaimed.anniv = member_anniversary.anniv order by jm_reinsurance_report_claimed_unclaimed.family_no"), connection.conn)
        da.Fill(Me.data)
        dgv_re_claimed_unclaimed.DataSource = Me.data
        'dgv_re_claimed_unclaimed.Columns(0).Visible = False
    End Sub
    Private Sub btn_run_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_run.Click
        Dim cmd_re As New OdbcCommand
        With cmd_re
            .Connection = connection.conn
            .CommandText = "SELECT total_claim_amt,family_no,anniv,benefit,start_date,end_date FROM jm_reinsurance_report"
        End With
        dr_re = cmd_re.ExecuteReader
        cmd_re = Nothing

        If dr_re.HasRows = False Then
            MsgBox("No data returned", MsgBoxStyle.ApplicationModal, Nothing)
        Else
            While dr_re.Read
                Dim cmd_sch As New OdbcCommand
                With cmd_sch
                    .Connection = connection.conn
                    .CommandText = "SELECT date_run,anniv,family_no,T_claims_amt,re_claim_amt,flagged FROM jm_reinsurance_schedule where family_no=? and anniv=? and date_run=(select max(date_run) from jm_reinsurance_schedule where family_no=? and anniv=?)and T_claims_amt=(select max(T_claims_amt) from jm_reinsurance_schedule where family_no=?  and anniv=?)"
                    cmd_sch.Parameters.Add("P1", OdbcType.VarChar, &H2D).Value = dr_re.Item(1)
                    cmd_sch.Parameters.Add("P1", OdbcType.VarChar, &H2D).Value = dr_re.Item(2)
                    cmd_sch.Parameters.Add("P1", OdbcType.VarChar, &H2D).Value = dr_re.Item(1)
                    cmd_sch.Parameters.Add("P1", OdbcType.VarChar, &H2D).Value = dr_re.Item(2)
                    cmd_sch.Parameters.Add("P1", OdbcType.VarChar, &H2D).Value = dr_re.Item(1)
                    cmd_sch.Parameters.Add("P1", OdbcType.VarChar, &H2D).Value = dr_re.Item(2)
                End With
                dr_sch = cmd_sch.ExecuteReader
                cmd_sch = Nothing
                dr_sch.Read()

                If dr_sch.HasRows = False Then
                    Dim cmd_ins_sch As New OdbcCommand
                    With cmd_ins_sch
                        .Connection = connection.conn
                        .CommandText = "insert into jm_reinsurance_schedule (date_run,anniv,family_no,T_claims_amt,re_claim_amt,flagged) values (?,?,?,?,?,?);commit;"
                        cmd_ins_sch.Parameters.Add("P1", OdbcType.VarChar, &H2D).Value = Strings.Format(Now, "yyyy-MM-dd")
                        cmd_ins_sch.Parameters.Add("P1", OdbcType.VarChar, &H2D).Value = dr_re.Item(2)
                        cmd_ins_sch.Parameters.Add("P1", OdbcType.VarChar, &H2D).Value = dr_re.Item(1)
                        cmd_ins_sch.Parameters.Add("P1", OdbcType.VarChar, &H2D).Value = dr_re.Item(0)
                        cmd_ins_sch.Parameters.Add("P1", OdbcType.Decimal, &H2D).Value = (dr_re.Item(0) - 750000)
                        cmd_ins_sch.Parameters.Add("P1", OdbcType.VarChar, &H2D).Value = 0
                    End With
                    cmd_ins_sch.ExecuteNonQuery()
                    cmd_ins_sch = Nothing
                Else
                    If dr_re.Item(0) > dr_sch.Item(3) Then
                        Dim cmd_sch2 As New OdbcCommand
                        With cmd_sch2
                            .Connection = connection.conn
                            .CommandText = "SELECT sum(re_claim_amt) as re_claim_amt FROM jm_reinsurance_schedule where family_no=? and anniv=?"
                            cmd_sch2.Parameters.Add("P1", OdbcType.VarChar, &H2D).Value = dr_re.Item(1)
                            cmd_sch2.Parameters.Add("P1", OdbcType.VarChar, &H2D).Value = dr_re.Item(2)
                        End With
                        dr_sch2 = cmd_sch2.ExecuteReader
                        cmd_sch2 = Nothing
                        dr_sch2.Read()

                        Dim cmd_ins_sch As New OdbcCommand
                        With cmd_ins_sch
                            .Connection = connection.conn
                            .CommandText = "insert into jm_reinsurance_schedule (date_run,anniv,family_no,T_claims_amt,re_claim_amt,flagged) values (?,?,?,?,?,?);commit;"
                            cmd_ins_sch.Parameters.Add("P1", OdbcType.VarChar, &H2D).Value = Strings.Format(Now, "yyyy-MM-dd")
                            cmd_ins_sch.Parameters.Add("P1", OdbcType.VarChar, &H2D).Value = dr_re.Item(2)
                            cmd_ins_sch.Parameters.Add("P1", OdbcType.VarChar, &H2D).Value = dr_re.Item(1)
                            cmd_ins_sch.Parameters.Add("P1", OdbcType.VarChar, &H2D).Value = dr_re.Item(0)
                            cmd_ins_sch.Parameters.Add("P1", OdbcType.Decimal, &H2D).Value = (dr_re.Item(0) - dr_sch2.Item(0) - 750000)
                            cmd_ins_sch.Parameters.Add("P1", OdbcType.VarChar, &H2D).Value = 0
                        End With
                        cmd_ins_sch.ExecuteNonQuery()
                        cmd_ins_sch = Nothing
                    Else

                    End If
                End If

            End While
        End If
        MsgBox("Run Completed")
        load_re_claimed_unclaimed()
    End Sub

    Private Sub btn_export_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_export.Click
        'Try
        Dim cnt As Integer = 1
        Dim columnsInOrder As New List(Of DataGridViewColumn)

        For Each col As DataGridViewColumn In dgv_re_claimed_unclaimed.Columns
            columnsInOrder.Add(col)
        Next

        columnsInOrder = columnsInOrder.OrderBy(Function(c) c.DisplayIndex).ToList()

        Dim sCSVExportLines As New List(Of String)

        Dim sHeaderText As String = ""

        For Each col As DataGridViewColumn In columnsInOrder

            If col.Visible = True Then

                Dim sValue As String = ""
                sValue = col.HeaderText.ToString

                If sValue.Contains(",") Then
                    sValue = """" + sValue + """"
                End If

                sHeaderText = sHeaderText + sValue + ","

            End If

        Next

        sHeaderText = sHeaderText.Substring(0, sHeaderText.Length - 1)

        If Not String.IsNullOrEmpty(sHeaderText) Then
            sCSVExportLines.Add(sHeaderText)
        End If

        ' get row values
        For Each row As DataGridViewRow In dgv_re_claimed_unclaimed.Rows

            Dim sRowValue As String = ""

            For Each col As DataGridViewColumn In columnsInOrder

                If col.Visible = True Then

                    Dim sValue As String = ""
                    sValue = row.Cells(col.Index).Value.ToString

                    If Not String.IsNullOrEmpty(sValue) Then

                        If sValue.ToString.Contains(",") Then
                            sValue = """" + sValue + """"
                        End If

                        If sValue.ToString.ToUpper = "TRUE" Then
                            sValue = "Yes"
                        End If

                        If sValue.ToString.ToUpper = "FALSE" Then
                            sValue = "No"
                        End If

                    Else

                        sValue = ""

                    End If

                    sRowValue = sRowValue + sValue + ","

                End If
            Next

            sRowValue = sRowValue.Substring(0, sRowValue.Length - 1)

            If Not String.IsNullOrEmpty(sRowValue) Then
                sCSVExportLines.Add(sRowValue)
            End If

            'cnt = cnt + 1
            'If cnt = 217 Then
            '    MsgBox("cnt")
            'End If
        Next

        ' write data to csv file
        Using sw As New IO.StreamWriter("d", False, System.Text.Encoding.UTF8)

            For Each s As String In sCSVExportLines
                sw.WriteLine(s.ToString)
            Next

        End Using

        If MessageBox.Show("CSV file created, open CSV file?", "Export Complete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Process.Start("d")
        End If

        'Catch ex As Exception
        '    MessageBox.Show(ex.ToString, "CSV Export Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try


        'Dim xlApp As Excel.Application
        'Dim xlWorkBook As Excel.Workbook
        'Dim xlWorkSheet As Excel.Worksheet
        'Dim misValue As Object = System.Reflection.Missing.Value

        'Dim i As Int16, j As Int16

        'xlApp = New Excel.ApplicationClass
        'xlWorkBook = xlApp.Workbooks.Add(misValue)
        'xlWorkSheet = xlWorkBook.Sheets("sheet1")


        ''Export Header Names Start
        'Dim columnsCount As Integer = dgv_re_claimed_unclaimed.Columns.Count
        'For Each column In dgv_re_claimed_unclaimed.Columns
        '    xlWorkSheet.Cells(1, column.Index + 1).Value = column.HeaderText
        'Next

        ''Export the data from the datagrid to an excel spreadsheet
        'For i = 0 To dgv_re_claimed_unclaimed.RowCount - 1
        '    For j = 0 To dgv_re_claimed_unclaimed.ColumnCount - 1
        '        xlWorkSheet.Cells(i + 1, j + 1) = dgv_re_claimed_unclaimed(j, i).Value
        '    Next
        'Next

        ''Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        ''"C:\Users\joseph.mbuthia\Desktop\" & cbo_corporate.Text & ".xls"
        'xlWorkBook.SaveAs("Reinsurance" & ".xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, _
        ' Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)
        'xlWorkBook.Close(True, misValue, misValue)
        'xlApp.Quit()

        'releaseObject(xlWorkSheet)
        'releaseObject(xlWorkBook)
        'releaseObject(xlApp)

        MessageBox.Show("Excel Generated successfully")
    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
            MessageBox.Show("Exception Occured while releasing object " + ex.ToString())
        Finally
            GC.Collect()
        End Try
    End Sub
End Class