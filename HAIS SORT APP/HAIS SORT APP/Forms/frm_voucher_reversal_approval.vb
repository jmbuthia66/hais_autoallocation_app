Imports System
Imports System.Data
Imports System.Data.Odbc
Imports System.Windows.Forms
Public Class frm_voucher_reversal_approval
    Dim dr_pv, dr_check As OdbcDataReader
    Dim da As OdbcDataAdapter
    Dim data As DataTable
    Private Sub frm_voucher_reversal_approval_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connection.connect()
        load_pending_approval()
        load_approved()
        Me.MdiParent = main
    End Sub
    Private Sub load_pending_approval()
        data = New DataTable
        da = New OdbcDataAdapter(("select Voucher_no as VoucherNo,Amount,Requester from jm_voucher_reversal where reversed is null"), connection.conn)
        da.Fill(Me.data)
        dgv_pending.DataSource = Me.data
    End Sub
    Private Sub load_approved()
        data = New DataTable
        da = New OdbcDataAdapter(("select Voucher_no as VoucherNo,Amount,Approver from jm_voucher_reversal where reversed=1 order by approver_date desc"), connection.conn)
        da.Fill(Me.data)
        dgv_approved.DataSource = Me.data
    End Sub

    Private Sub btn_filter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_filter.Click
        load_pending_approval()
        load_approved()
    End Sub
    Private Sub dgv_pending_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv_pending.Click
        Dim view As DataGridView = dgv_pending
        lbl_voucher_no.Text = Convert.ToString(view(0, dgv_pending.CurrentRow.Index).Value)
        view = Nothing
        Dim cmd_pv As New OdbcCommand
        With cmd_pv
            .Connection = connection.conn
            .CommandText = ("select voucher_no amount from jm_voucher_reversal where voucher_no='" & lbl_voucher_no.Text & "'")
        End With
        dr_pv = cmd_pv.ExecuteReader

        dr_pv.Read()
        If dr_pv.HasRows Then
            lbl_voucher_no.Text = dr_pv.Item(0)
        End If
        cmd_pv = Nothing
    End Sub

    Private Sub btn_approve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_approve.Click
        approve_voucher_reversal()
    End Sub

    Private Sub dgv_pending_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv_pending.DoubleClick
        approve_voucher_reversal()
    End Sub

    Private Sub btn_remove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_remove.Click

    End Sub
    Private Sub approve_voucher_reversal()
        'Dim transaction As OdbcTransaction = connection.conn.BeginTransaction(IsolationLevel.ReadCommitted)
        'Try
        Dim cmd_check As New OdbcCommand
        With cmd_check
            .Connection = connection.conn
            .CommandText = ("select * from jm_voucher_reversal where voucher_no='" & lbl_voucher_no.Text & "'")
        End With
        dr_check = cmd_check.ExecuteReader
        dr_check.Read()

        If dr_check.HasRows = True Then
            Dim cmd_reverse As New OdbcCommand
            With cmd_reverse
                .Connection = connection.conn
                .CommandText = "update bills set paid=0,pv_authorized=0,payment_no=NULL,rejected_pv=1,vet_status=1 where voucher_no='" & lbl_voucher_no.Text & "';commit;"
            End With
            cmd_reverse.ExecuteNonQuery()

            Dim cmd_approve As New OdbcCommand
            With cmd_approve
                .Connection = connection.conn
                .CommandText = "update jm_voucher_reversal set approver='" & main.lbl_username.Text & "',approver_date=now(),reversed=1 where voucher_no='" & lbl_voucher_no.Text & "';commit;"
            End With
            cmd_approve.ExecuteNonQuery()

            cmd_approve = Nothing
            cmd_reverse = Nothing
        Else
            MsgBox("Voucher already added")
        End If
        load_pending_approval()
        load_approved()

        'Catch exception1 As Exception
        '    Dim ex As Exception = exception1
        '    MessageBox.Show(ex.Message, "Error Approving Reversal", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        '    'transaction.Rollback()
        'End Try
    End Sub
End Class