Imports System
Imports System.Data
Imports System.Data.Odbc
Imports System.Windows.Forms
Public Class frm_payment_details_update
    Dim dr_pv, dr_bp, dr_bills, dr_payment_no As OdbcDataReader
    Dim da As OdbcDataAdapter
    Dim data As DataTable
    Dim nxt_payment_no As Integer
    Dim receipt_date As Date
    Private Sub frm_payment_details_update_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connection.connect()
        Me.MdiParent = main
    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        Dim cmd_pv As New OdbcCommand
        With cmd_pv
            .Connection = connection.conn
            .CommandText = "select provider,cheque_no,voucher_no,DATEFORMAT(payment_date,'yyyy-mm-dd') as cheque_date,Amount from jm_sap_payment_details_todate where voucher_no not in (select voucher_no from bills_payment)"
        End With
        dr_pv = cmd_pv.ExecuteReader
        cmd_pv = Nothing
        If dr_pv.HasRows = False Then
            MsgBox("No sap data returned", MsgBoxStyle.ApplicationModal, Nothing)
        Else
            While dr_pv.Read
                Dim cmd_bills As New OdbcCommand
                With cmd_bills
                    .Connection = connection.conn
                    .CommandText = "select voucher_no,provider from bills where voucher_no=?"
                    cmd_bills.Parameters.Add("P1", OdbcType.VarChar, &H2D).Value = dr_pv.Item(2)
                End With
                dr_bills = cmd_bills.ExecuteReader
                cmd_bills = Nothing
                If dr_bills.HasRows = True Then
                    Dim cmd_bills_payment As New OdbcCommand
                    With cmd_bills_payment
                        .Connection = connection.conn
                        .CommandText = "select payment_no,voucher_no from bills_payment where voucher_no=?"
                        cmd_bills_payment.Parameters.Add("P1", OdbcType.VarChar, &H2D).Value = dr_pv.Item(2)
                    End With
                    dr_bp = cmd_bills_payment.ExecuteReader
                    cmd_bills_payment = Nothing
                    If dr_bp.HasRows = False Then
                        Dim cmd_payment_no As New OdbcCommand
                        With cmd_payment_no
                            .Connection = connection.conn
                            .CommandText = "select max(isnull(cast(payment_no as integer),0)) as next_pay_no  from bills_payment"
                        End With
                        dr_payment_no = cmd_payment_no.ExecuteReader
                        dr_payment_no.Read()
                        nxt_payment_no = dr_payment_no.Item(0) + 1
                        cmd_payment_no = Nothing

                        Dim cmd_ins_bp As New OdbcCommand
                        With cmd_ins_bp
                            .Connection = connection.conn
                            .CommandText = "INSERT INTO BILLS_PAYMENT (PAYMENT_NO,CHEQUE_NO,CHEQUE_DATE,CHEQUE_AMOUNT,PROVIDER,MEMBER_NO,CORP_ID,DISPATCHED,DATE_DISPATCHED,USER_ID,DATE_ENTERED,admin_fee,corp_paid_for,acct_no,bank,self_fund,agent_id,user_dispatched,cheque_acc,voucher_no,cancelled,proxy_payee ) VALUES ('" & nxt_payment_no & "','" & dr_pv.Item(1) & "','" & dr_pv.Item(3) & "','" & dr_pv.Item(4) & "','" & dr_bills.Item(1) & "',NULL,NULL,NULL,NULL,NULL,DATEFORMAT(GETDATE(), 'YYYY-MM-DD'),NULL,NULL,NULL,NULL,NULL,NULL,NULL,'MEDICAL A/C','" & dr_pv.Item(2) & "',NULL,NULL);commit;"
                            'DATEFORMAT( '" & dr_pv.Item(3) & "' ,'YYYY-MM-DD')
                        End With
                        cmd_ins_bp.ExecuteNonQuery()
                        cmd_ins_bp = Nothing

                        Dim cmd_update_bills As New OdbcCommand
                        With cmd_update_bills
                            .Connection = connection.conn
                            .CommandText = "update bills set payment_no='" & nxt_payment_no & "',cheque_no='" & dr_pv.Item(1) & "',cheque_date='" & dr_pv.Item(3) & "' where VOUCHER_NO='" & dr_pv.Item(2) & "';commit;"
                        End With
                        cmd_update_bills.ExecuteNonQuery()
                        cmd_update_bills = Nothing

                    End If
                    'cmd_bills_payment = Nothing

                End If
                'cmd_bills = Nothing
            End While

            Dim cmd_bills_payment_no As New OdbcCommand
            With cmd_bills_payment_no
                .Connection = connection.conn
                .CommandText = "update BILLS set BILLS.payment_no=BILLS_PAYMENT.payment_no FROM BILLS INNER JOIN BILLS_PAYMENT ON BILLS.VOUCHER_NO = BILLS_PAYMENT.voucher_no WHERE BILLS.payment_no is null  and BILLS_PAYMENT.cheque_amount>0 ;commit;"
            End With
            cmd_bills_payment_no.ExecuteNonQuery()
            cmd_bills_payment_no = Nothing

        End If
        'cmd_pv = Nothing
        MsgBox("Completed")
    End Sub
End Class