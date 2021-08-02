Imports System
Imports System.Data
Imports System.Data.Odbc
Imports System.Windows.Forms
Public Class frm_voucher_reversal_request
    Dim dr_pv, dr_check, dr_clm As OdbcDataReader
    Dim da As OdbcDataAdapter
    Dim data As DataTable
    Private Sub frm_voucher_reversal_request_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connection.connect()
        load_vouchers_app()
        Me.MdiParent = main
    End Sub
    Private Sub load_vouchers()
        data = New DataTable
        da = New OdbcDataAdapter((" select voucher_no as PVS,voucher_date,sum(isnull(net_amt_payable,0))as amount from bills where voucher_no is not null and voucher_date >='" & Format(dtp_date_from.Value.Date, "yyyy-MM-dd") & "' and voucher_date <='" & Format(dtp_date_to.Value.Date, "yyyy-MM-dd") & "' group by PVS,voucher_date order by voucher_no desc"), connection.conn)
        da.Fill(Me.data)
        dgv_vouchers.DataSource = Me.data
        dgv_vouchers.Columns(1).Visible = False
    End Sub
    Private Sub load_vouchers_app()
        data = New DataTable
        da = New OdbcDataAdapter(("select Voucher_no as VoucherNo,Amount,Requester from jm_voucher_reversal where reversed is null order by voucher_no"), connection.conn)
        da.Fill(Me.data)
        dgv_voucher_app.DataSource = Me.data 
    End Sub
    Private Sub add_voucher_request()
        Dim cmd_check As New OdbcCommand
        With cmd_check
            .Connection = connection.conn
            .CommandText = ("select * from jm_voucher_reversal where voucher_no='" & lbl_voucher_no.Text & "'")
        End With
        dr_check = cmd_check.ExecuteReader
        dr_check.Read()

        If dr_check.HasRows = False Then
            Dim cmd_clm As New OdbcCommand
            With cmd_clm
                .Connection = connection.conn
                .CommandText = ("select distinct batch_no from bills where voucher_no='" & lbl_voucher_no.Text & "'")
            End With
            dr_clm = cmd_clm.ExecuteReader
            dr_clm.Read()

            Dim cmd_insert_pv As New OdbcCommand
            With cmd_insert_pv
                .Connection = connection.conn
                .CommandText = "insert into jm_voucher_reversal (voucher_no,requester,request_date,batch_no,amount) values('" & lbl_voucher_no.Text & "','" & main.lbl_username.Text & "',now(),'" & dr_clm.Item(0) & "','" & lbl_amount.Text & "');commit;"
            End With
            cmd_insert_pv.ExecuteNonQuery()

            cmd_insert_pv = Nothing
            cmd_clm = Nothing
        Else
            MsgBox("Voucher already added")
        End If
        load_vouchers_app()
    End Sub
    Private Sub remove_voucher_request()
        Dim cmd_check As New OdbcCommand
        With cmd_check
            .Connection = connection.conn
            .CommandText = ("select * from jm_voucher_reversal where voucher_no='" & lbl_voucher_no.Text & "'")
        End With
        dr_check = cmd_check.ExecuteReader
        dr_check.Read()

        If dr_check.HasRows = True Then

            Dim cmd_insert_pv As New OdbcCommand
            With cmd_insert_pv
                .Connection = connection.conn
                .CommandText = "delete from jm_voucher_reversal where voucher_no='" & lbl_voucher_no.Text & "';commit;"
            End With
            cmd_insert_pv.ExecuteNonQuery()
            cmd_insert_pv = Nothing
        End If
        load_vouchers_app()
    End Sub
    Private Sub btn_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_search.Click
        load_vouchers()
        load_vouchers_app()
    End Sub
    Private Sub dgv_vouchers_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv_vouchers.Click
        Dim view As DataGridView = dgv_vouchers
        lbl_voucher_no.Text = Convert.ToString(view(0, dgv_vouchers.CurrentRow.Index).Value)
        lbl_amount.Text = Convert.ToString(view(2, dgv_vouchers.CurrentRow.Index).Value)
        view = Nothing
        Dim cmd_pv As New OdbcCommand
        With cmd_pv
            .Connection = connection.conn
            .CommandText = ("select voucher_no,voucher_date,sum(isnull(net_amt_payable,0))as amount from bills where voucher_no='" & lbl_voucher_no.Text & "' group by voucher_no,voucher_date")
        End With
        dr_pv = cmd_pv.ExecuteReader

        dr_pv.Read()
        If dr_pv.HasRows Then
            lbl_voucher_no.Text = dr_pv.Item(0)
            lbl_amount.Text = dr_pv.Item(2)
        End If
        cmd_pv = Nothing
    End Sub

    Private Sub dgv_vouchers_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv_vouchers.DoubleClick
        add_voucher_request()
    End Sub

    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        add_voucher_request()
    End Sub

    Private Sub btn_remove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_remove.Click
        remove_voucher_request()
    End Sub

    Private Sub dgv_voucher_app_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv_voucher_app.Click
        Dim view As DataGridView = dgv_voucher_app
        lbl_voucher_no.Text = Convert.ToString(view(0, dgv_voucher_app.CurrentRow.Index).Value)
        view = Nothing
        Dim cmd_pv As New OdbcCommand
        With cmd_pv
            .Connection = connection.conn
            .CommandText = ("select  voucher_no from jm_voucher_reversal where voucher_no='" & lbl_voucher_no.Text & "'")
        End With
        dr_pv = cmd_pv.ExecuteReader

        dr_pv.Read()
        If dr_pv.HasRows Then
            lbl_voucher_no.Text = dr_pv.Item(0)
        End If
        cmd_pv = Nothing
    End Sub

    Private Sub dgv_voucher_app_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv_voucher_app.DoubleClick
        remove_voucher_request()
    End Sub
End Class