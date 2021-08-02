Imports System
Imports System.Data
Imports System.Data.Odbc
Imports System.Windows.Forms
Imports Excel = Microsoft.Office.Interop.Excel

Public Class frm_member_listing
    Dim dr_corp As OdbcDataReader
    Dim da As OdbcDataAdapter
    Dim data As DataTable 
    Private Sub frm_member_listing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connection.connect()
        Me.MdiParent = main
        corp_load()
    End Sub

    Private Sub corp_load()
        Dim cmd_corp As New OdbcCommand
        With cmd_corp
            .Connection = connection.conn
            .CommandText = "select corp_id,corporate from corporate order by corporate asc"
        End With
        dr_corp = cmd_corp.ExecuteReader
        While dr_corp.Read()
            cbo_corporate.Items.Add(dr_corp("corporate"))
            'lbl_corp_id.Text = dr_corp.Item(0)
        End While
        dr_corp.Close()
        cmd_corp = Nothing
    End Sub

    Private Sub cbo_corporate_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_corporate.SelectedValueChanged
        Dim cmd_corp As New OdbcCommand
        With cmd_corp
            .Connection = connection.conn
            .CommandText = "select corp_id,corporate from corporate where corporate='" & cbo_corporate.Text & "'"
        End With
        dr_corp = cmd_corp.ExecuteReader
        dr_corp.Read()
        lbl_corp_id.Text = dr_corp.Item(0)
        cmd_corp = Nothing

        load_members()

    End Sub
    Private Sub cbo_corporate_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_corporate.TextChanged
        'Dim cmd_corp As New OdbcCommand
        'With cmd_corp
        '    .Connection = connection.conn
        '    .CommandText = "select corp_id,corporate from corporate where corporate like '%" + cbo_corporate.Text + "%'"
        'End With
        'dr_corp = cmd_corp.ExecuteReader
        'While dr_corp.Read()
        '    cbo_corporate.Items.Add(dr_corp.Item(1))
        'End While
        'dr_corp.Close()
        'cmd_corp = Nothing
    End Sub

    Private Sub load_members()
        data = New DataTable
        da = New OdbcDataAdapter(("SELECT CORPORATE.CORPORATE,MEMBER_INFO.FAMILY_NO,MEMBER_INFO.MEMBER_NO,isnull( MEMBER_INFO.SURNAME, '' ) || isnull( MEMBER_INFO.FIRST_NAME, '' ) || isnull( MEMBER_INFO.OTHER_NAMES, '' ) AS FULL_NAME,FAMILY_RELATION.RELATION,MEMBER_INFO.DOB,MEMBER_INFO.EMPLOYMENT_NO,t_gender.GENDER FROM ( ( CORPORATE INNER JOIN MEMBER_INFO ON CORPORATE.CORP_ID = MEMBER_INFO.corp_id ) INNER JOIN FAMILY_RELATION ON MEMBER_INFO.FAMILY_TITLE = FAMILY_RELATION.CODE ) INNER JOIN t_gender ON t_gender.code = MEMBER_INFO.gender WHERE CORPORATE.corp_id='" & lbl_corp_id.Text & "' ORDER BY MEMBER_INFO.FAMILY_NO ASC  "), connection.conn)
        da.Fill(Me.data)
        dgv_member_listing.DataSource = Me.data
        'dgv_receipts.Columns(0).Visible = False 
    End Sub

    Private Sub btn_export_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_export.Click
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value

        Dim i As Int16, j As Int16

        xlApp = New Excel.ApplicationClass
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")


        'Export Header Names Start
        Dim columnsCount As Integer = dgv_member_listing.Columns.Count
        For Each column In dgv_member_listing.Columns
            xlWorkSheet.Cells(1, column.Index + 1).Value = column.HeaderText
        Next

        'Export the data from the datagrid to an excel spreadsheet
        For i = 0 To dgv_member_listing.RowCount - 1
            For j = 0 To dgv_member_listing.ColumnCount - 1
                xlWorkSheet.Cells(i + 1, j + 1) = dgv_member_listing(j, i).Value
            Next
        Next 

        'Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        '"C:\Users\joseph.mbuthia\Desktop\" & cbo_corporate.Text & ".xls"
        xlWorkBook.SaveAs(cbo_corporate.Text & ".xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, _
         Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)
        xlWorkBook.Close(True, misValue, misValue)
        xlApp.Quit()

        releaseObject(xlWorkSheet)
        releaseObject(xlWorkBook)
        releaseObject(xlApp)

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