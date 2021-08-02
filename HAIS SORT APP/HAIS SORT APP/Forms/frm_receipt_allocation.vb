Imports System
Imports System.Data
Imports System.Data.Odbc
Imports System.Windows.Forms
Public Class frm_receipt_allocation
    Dim dr_user, dr_allocate, dr_receipt, dr_pr_inv, dr_id_key, dr_insert_pids, dr_pids, dr_t_allocate, dr_get_all, dr_levy As OdbcDataReader
    Dim da As OdbcDataAdapter
    Dim data As DataTable
    Dim levied, receipt_bal, unallocated_amt, all_amt, t_allocate As Double
    Private Sub frm_receipt_allocation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connection.connect()
        Me.MdiParent = main
    End Sub

    Private Sub btn_load_receipts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_load_receipts.Click
        'Dim cmd_user As New OdbcCommand
        'With cmd_user
        '    .Connection = connection.conn
        '    .CommandText = "select * from users where user_name='joseph.mbuthia'"
        'End With
        'dr_user = cmd_user.ExecuteReader
        'If dr_user.HasRows = False Then
        '    MsgBox("Wrong UserName or Password", MsgBoxStyle.ApplicationModal, Nothing)
        'Else
        load_receipts()
        'End If
        'cmd_user = Nothing
    End Sub

    Public Sub load_receipts()
        If rbn_family.Checked = True Then
            data = New DataTable
            da = New OdbcDataAdapter(("with a as (SELECT MEMBER_INFO.MEMBER_NO,TRIM(MEMBER_INFO.SURNAME)||' '||TRIM(MEMBER_INFO.FIRST_NAME)||' '||TRIM(MEMBER_INFO.OTHER_NAMES) as FULL_NAME,PREMIUM_RECEIPT.INVOICE_NO,PREMIUM_RECEIPT.RECEIPT_NO,PREMIUM_RECEIPT.RECEIPT_DATE,sum(PREMIUM_RECEIPT.RECEIPT_AMOUNT) as RECEIPT_AMOUNT FROM MEMBER_INFO INNER JOIN PREMIUM_RECEIPT ON MEMBER_INFO.MEMBER_NO = PREMIUM_RECEIPT.MEMBER_NO WHERE PREMIUM_RECEIPT.RECEIPT_DATE >='2021-01-01' and RECEIPT_DATE <='2021-08-01' group by MEMBER_INFO.MEMBER_NO,FULL_NAME,PREMIUM_RECEIPT.RECEIPT_NO,PREMIUM_RECEIPT.INVOICE_NO,PREMIUM_RECEIPT.RECEIPT_DATE order by PREMIUM_RECEIPT.INVOICE_NO),b as (select RECEIPT_NO,sum(ALLOCATED_AMT) as ALLOCATED_AMT ,sum(isnull(levied,0)) as LEVIED from premium_invoice_details_sammary where receipt_no is not null group by receipt_no) select a.*,b.ALLOCATED_AMT,b.LEVIED,a.receipt_amount-b.allocated_amt AS UNALLOCATED_AMT from a inner join b on a.receipt_no=b.receipt_no"), connection.conn)
            da.Fill(Me.data)
            dgv_receipts.DataSource = Me.data
            'dgv_receipts.Columns(0).Visible = False
        ElseIf rbn_corporate.Checked = True Then
            data = New DataTable
            da = New OdbcDataAdapter(("with a as (SELECT CORPORATE.CORP_ID,CORPORATE.CORPORATE,PREMIUM_RECEIPT.INVOICE_NO,PREMIUM_RECEIPT.RECEIPT_NO,PREMIUM_RECEIPT.RECEIPT_DATE,sum(PREMIUM_RECEIPT.RECEIPT_AMOUNT) as RECEIPT_AMOUNT FROM CORPORATE INNER JOIN PREMIUM_RECEIPT ON CORPORATE.CORP_ID = PREMIUM_RECEIPT.CORP_ID WHERE PREMIUM_RECEIPT.RECEIPT_DATE >='2021-01-01' and RECEIPT_DATE <='2021-08-01' group by CORPORATE.CORP_ID,CORPORATE.CORPORATE,PREMIUM_RECEIPT.INVOICE_NO,PREMIUM_RECEIPT.RECEIPT_NO,PREMIUM_RECEIPT.RECEIPT_DATE order by PREMIUM_RECEIPT.INVOICE_NO),b as (select RECEIPT_NO,sum(ALLOCATED_AMT) as ALLOCATED_AMT ,sum(isnull(levied,0)) as LEVIED from premium_invoice_details_sammary where receipt_no is not null group by receipt_no) select a.*,b.ALLOCATED_AMT,b.LEVIED,a.receipt_amount-b.allocated_amt AS UNALLOCATED_AMT from a inner join b on a.receipt_no=b.receipt_no"), connection.conn)
            da.Fill(Me.data)
            dgv_receipts.DataSource = Me.data
            'dgv_receipts.Columns(0).Visible = False
        Else
            MsgBox("PLease choose either Corporate or Family first")
        End If
    End Sub

    Private Sub btn_allocate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_allocate.Click
        'Dim transaction As OdbcTransaction = connection.conn.BeginTransaction(IsolationLevel.ReadCommitted)
        'Try
        'get the receipts by date range

        Dim cmd_receipt As New OdbcCommand
        With cmd_receipt
            If rbn_family.Checked = True Then
                If rbt_date_range.Checked = True Then
                    .Connection = connection.conn
                    .CommandText = "select PREMIUM_RECEIPT.invoice_no,PREMIUM_RECEIPT.receipt_no,sum(PREMIUM_RECEIPT.receipt_amount) as receipt_amount,PREMIUM_RECEIPT.receipt_date from PREMIUM_RECEIPT inner join MEMBER_INFO ON PREMIUM_RECEIPT.MEMBER_NO=MEMBER_INFO.MEMBER_NO  where PREMIUM_RECEIPT.receipt_date>='" & Format(dtp_date_from.Value.Date, "yyyy-MM-dd") & "' and PREMIUM_RECEIPT.receipt_date <='" & Format(dtp_date_to.Value.Date, "yyyy-MM-dd") & "' group by PREMIUM_RECEIPT.invoice_no,PREMIUM_RECEIPT.receipt_no,PREMIUM_RECEIPT.receipt_date"
                ElseIf rbt_debit.Checked = True Then
                    .Connection = connection.conn
                    .CommandText = "select PREMIUM_RECEIPT.invoice_no,PREMIUM_RECEIPT.receipt_no,sum(PREMIUM_RECEIPT.receipt_amount) as receipt_amount,PREMIUM_RECEIPT.receipt_date from PREMIUM_RECEIPT inner join MEMBER_INFO ON PREMIUM_RECEIPT.MEMBER_NO=MEMBER_INFO.MEMBER_NO  where PREMIUM_RECEIPT.invoice_no='" & txt_debit_no.Text & "' group by PREMIUM_RECEIPT.invoice_no,PREMIUM_RECEIPT.receipt_no,PREMIUM_RECEIPT.receipt_date"
                Else
                    MsgBox("Please choose to process by date range or Debit", MsgBoxStyle.ApplicationModal, Nothing)
                End If
            ElseIf rbn_corporate.Checked = True Then
                If rbt_date_range.Checked = True Then
                    .Connection = connection.conn
                    .CommandText = "select PREMIUM_RECEIPT.invoice_no,PREMIUM_RECEIPT.receipt_no,sum(PREMIUM_RECEIPT.receipt_amount) as receipt_amount,PREMIUM_RECEIPT.receipt_date from PREMIUM_RECEIPT inner join corporate ON PREMIUM_RECEIPT.corp_id=corporate.corp_id where corporate.agent_id<>'54' and PREMIUM_RECEIPT.receipt_date>='" & Format(dtp_date_from.Value.Date, "yyyy-MM-dd") & "' and PREMIUM_RECEIPT.receipt_date <='" & Format(dtp_date_to.Value.Date, "yyyy-MM-dd") & "' group by PREMIUM_RECEIPT.invoice_no,PREMIUM_RECEIPT.receipt_no,PREMIUM_RECEIPT.receipt_date"
                ElseIf rbt_debit.Checked = True Then
                    .Connection = connection.conn
                    .CommandText = "select PREMIUM_RECEIPT.invoice_no,PREMIUM_RECEIPT.receipt_no,sum(PREMIUM_RECEIPT.receipt_amount) as receipt_amount,PREMIUM_RECEIPT.receipt_date from PREMIUM_RECEIPT inner join corporate ON PREMIUM_RECEIPT.corp_id=corporate.corp_id  where corporate.agent_id<>'54' and  PREMIUM_RECEIPT.invoice_no='" & txt_debit_no.Text & "' group by PREMIUM_RECEIPT.invoice_no,PREMIUM_RECEIPT.receipt_no,PREMIUM_RECEIPT.receipt_date"
                Else
                    MsgBox("Please choose to process by date range or Debit", MsgBoxStyle.ApplicationModal, Nothing)
                End If
            Else
                MsgBox("PLease choose either Corporate or Family first")
                Exit Sub
            End If
        End With
        dr_receipt = cmd_receipt.ExecuteReader
        'cmd_receipt = Nothing        
        If dr_receipt.HasRows = False Then
            MsgBox("No Receipt data returned", MsgBoxStyle.ApplicationModal, Nothing)
        Else
            While dr_receipt.Read
                'check allocated amount (partially or not allocated)
                Dim cmd_allocate As New OdbcCommand
                With cmd_allocate
                    .Connection = connection.conn
                    .CommandText = "with a as (select invoice_no,class,isnull(net_premium,0)as net_premium,allocated,isnull(allocated_amt,0) as allocated_amt,levied,receipt_no from premium_invoice_details_sammary where allocated is null), b as (select invoice_no,class,allocated,sum(isnull(allocated_amt,0))as allocated_amt,sum(isnull(levied,0)) as levied from premium_invoice_details_sammary where allocated=1 group by invoice_no,class,allocated) select a.invoice_no,a.class,isnull(a.net_premium,0)as net_premium ,b.allocated,isnull(b.allocated_amt,0) as allocated_amt,isnull(b.levied,0) as levied from a left outer join b on a.invoice_no=b.invoice_no and a.class=b.class where isnull(b.allocated_amt,0)<a.net_premium and a.invoice_no='" & dr_receipt.Item(0) & "'"
                End With
                dr_allocate = cmd_allocate.ExecuteReader
                'cmd_allocate = Nothing

                If dr_allocate.HasRows = False Then
                    ''Fully allocated
                Else
                    While dr_allocate.Read
                        'levy
                        Dim cmd_pr_inv As New OdbcCommand
                        With cmd_pr_inv
                            .Connection = connection.conn
                            .CommandText = "select invoice_no,isnull(stamp_duty,0) ,isnull(tl,0),isnull(phcf,0) from PREMIUM_INVOICE where invoice_no='" & dr_receipt.Item(0) & "'"
                        End With
                        dr_pr_inv = cmd_pr_inv.ExecuteReader
                        'cmd_pr_inv = Nothing
                        dr_pr_inv.Read()

                        levied = dr_pr_inv.Item(1) + dr_pr_inv.Item(2) + dr_pr_inv.Item(3) ''calculate levy

                        'total receipt allocated
                        Dim cmd_t_allocate As New OdbcCommand
                        With cmd_t_allocate
                            .Connection = connection.conn
                            .CommandText = "select invoice_no,sum(isnull(allocated_amt,0))as allocated_amt,sum(isnull(levied,0)) as levied ,(allocated_amt+levied) as T_allocated_amt from premium_invoice_details_sammary where allocated=1 and invoice_no='" & dr_receipt.Item(0) & "' and receipt_no='" & dr_receipt.Item(1) & "' group by invoice_no"
                        End With
                        dr_t_allocate = cmd_t_allocate.ExecuteReader
                        'cmd_t_allocate = Nothing
                        dr_t_allocate.Read()

                        If dr_t_allocate.HasRows = True Then
                            t_allocate = dr_t_allocate.Item(3)
                        Else
                            t_allocate = 0
                        End If

                        'check if levy has been deducted
                        Dim cmd_levy As New OdbcCommand
                        With cmd_levy
                            .Connection = connection.conn
                            .CommandText = "select invoice_no,sum(isnull(allocated_amt,0))as allocated_amt,sum(isnull(levied,0)) as levied ,(allocated_amt+levied) as T_allocated_amt from premium_invoice_details_sammary where allocated=1 and invoice_no='" & dr_receipt.Item(0) & "' group by invoice_no"
                        End With
                        dr_levy = cmd_levy.ExecuteReader
                        'cmd_t_allocate = Nothing
                        dr_levy.Read()
                        If dr_levy.HasRows Then
                            levied = 0
                        End If

                        'check receipt amt>levied if true then allocate
                        If dr_receipt.Item(2) > levied Then
                            receipt_bal = dr_receipt.Item(2) - t_allocate - levied
                            unallocated_amt = dr_allocate.Item(2) - dr_allocate.Item(4)

                            If receipt_bal > unallocated_amt Then
                                all_amt = unallocated_amt
                            Else
                                all_amt = receipt_bal
                            End If

                            If all_amt > 0 Then
                                Dim cmd_insert_pids As New OdbcCommand
                                With cmd_insert_pids
                                    .Connection = connection.conn
                                    .CommandText = "INSERT INTO premium_invoice_details_sammary (id_key,invoice_no,class,allocated,allocated_amt,levied,receipt_no) select (select max(id_key)+1 as id_key from premium_invoice_details_sammary),invoice_no,class,1,'" & all_amt & "','" & levied & "','" & dr_receipt.Item(1) & "' from premium_invoice_details_sammary where invoice_no ='" & dr_receipt.Item(0) & "' and class='" & dr_allocate.Item(1) & "' and net_premium is not null;commit;"
                                End With
                                cmd_insert_pids.ExecuteNonQuery()
                                cmd_insert_pids = Nothing
                            End If
                        End If
                        cmd_pr_inv = Nothing
                        cmd_t_allocate = Nothing
                    End While
                End If
                cmd_allocate = Nothing
            End While
        End If
        MsgBox("Allocation Completed sucessfully", MsgBoxStyle.ApplicationModal, Nothing)
        cmd_receipt = Nothing
        'Catch exception1 As Exception
        '    Dim ex As Exception = exception1
        '    MessageBox.Show(ex.Message, "Error on Auto Allocation", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        '    'transaction.Rollback()
        'End Try
    End Sub

    Private Sub rbt_debit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt_debit.CheckedChanged
        txt_debit_no.Enabled = True
        dtp_date_from.Enabled = False
        dtp_date_to.Enabled = False
    End Sub

    Private Sub rbt_date_range_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt_date_range.CheckedChanged
        txt_debit_no.Enabled = False
        dtp_date_from.Enabled = True
        dtp_date_to.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
