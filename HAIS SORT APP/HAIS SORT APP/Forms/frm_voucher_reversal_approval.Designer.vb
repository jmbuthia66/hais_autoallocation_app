<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_voucher_reversal_approval
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label
        Me.lbl_voucher_no = New System.Windows.Forms.Label
        Me.btn_filter = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtp_date_to = New System.Windows.Forms.DateTimePicker
        Me.dtp_date_from = New System.Windows.Forms.DateTimePicker
        Me.btn_remove = New System.Windows.Forms.Button
        Me.btn_approve = New System.Windows.Forms.Button
        Me.dgv_approved = New System.Windows.Forms.DataGridView
        Me.dgv_pending = New System.Windows.Forms.DataGridView
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        CType(Me.dgv_approved, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_pending, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(424, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Approved"
        '
        'lbl_voucher_no
        '
        Me.lbl_voucher_no.AutoSize = True
        Me.lbl_voucher_no.Location = New System.Drawing.Point(321, 9)
        Me.lbl_voucher_no.Name = "lbl_voucher_no"
        Me.lbl_voucher_no.Size = New System.Drawing.Size(64, 13)
        Me.lbl_voucher_no.TabIndex = 24
        Me.lbl_voucher_no.Text = "voucher_no"
        Me.lbl_voucher_no.Visible = False
        '
        'btn_filter
        '
        Me.btn_filter.Location = New System.Drawing.Point(572, 56)
        Me.btn_filter.Name = "btn_filter"
        Me.btn_filter.Size = New System.Drawing.Size(86, 23)
        Me.btn_filter.TabIndex = 23
        Me.btn_filter.Text = "Filter By Date"
        Me.btn_filter.UseVisualStyleBackColor = True
        Me.btn_filter.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(541, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "To:"
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(537, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "From:"
        Me.Label1.Visible = False
        '
        'dtp_date_to
        '
        Me.dtp_date_to.Location = New System.Drawing.Point(572, 29)
        Me.dtp_date_to.Name = "dtp_date_to"
        Me.dtp_date_to.Size = New System.Drawing.Size(200, 20)
        Me.dtp_date_to.TabIndex = 20
        Me.dtp_date_to.Visible = False
        '
        'dtp_date_from
        '
        Me.dtp_date_from.Location = New System.Drawing.Point(572, 3)
        Me.dtp_date_from.Name = "dtp_date_from"
        Me.dtp_date_from.Size = New System.Drawing.Size(200, 20)
        Me.dtp_date_from.TabIndex = 19
        Me.dtp_date_from.Visible = False
        '
        'btn_remove
        '
        Me.btn_remove.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_remove.Location = New System.Drawing.Point(326, 296)
        Me.btn_remove.Name = "btn_remove"
        Me.btn_remove.Size = New System.Drawing.Size(75, 36)
        Me.btn_remove.TabIndex = 18
        Me.btn_remove.Text = "<"
        Me.btn_remove.UseVisualStyleBackColor = True
        Me.btn_remove.Visible = False
        '
        'btn_approve
        '
        Me.btn_approve.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_approve.Location = New System.Drawing.Point(326, 217)
        Me.btn_approve.Name = "btn_approve"
        Me.btn_approve.Size = New System.Drawing.Size(75, 39)
        Me.btn_approve.TabIndex = 17
        Me.btn_approve.Text = ">"
        Me.btn_approve.UseVisualStyleBackColor = True
        '
        'dgv_approved
        '
        Me.dgv_approved.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_approved.BackgroundColor = System.Drawing.Color.White
        Me.dgv_approved.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_approved.Location = New System.Drawing.Point(421, 102)
        Me.dgv_approved.Name = "dgv_approved"
        Me.dgv_approved.Size = New System.Drawing.Size(330, 368)
        Me.dgv_approved.TabIndex = 16
        '
        'dgv_pending
        '
        Me.dgv_pending.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_pending.BackgroundColor = System.Drawing.Color.White
        Me.dgv_pending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pending.Location = New System.Drawing.Point(7, 102)
        Me.dgv_pending.Name = "dgv_pending"
        Me.dgv_pending.Size = New System.Drawing.Size(299, 368)
        Me.dgv_pending.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(141, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Pending Approval"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(23, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(293, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "PLEASE NOTE THE PROCESS IS IRREVERSIBLE"
        '
        'frm_voucher_reversal_approval
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 480)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_voucher_no)
        Me.Controls.Add(Me.btn_filter)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtp_date_to)
        Me.Controls.Add(Me.dtp_date_from)
        Me.Controls.Add(Me.btn_remove)
        Me.Controls.Add(Me.btn_approve)
        Me.Controls.Add(Me.dgv_approved)
        Me.Controls.Add(Me.dgv_pending)
        Me.Name = "frm_voucher_reversal_approval"
        Me.Text = "Voucher Reversal Approval"
        CType(Me.dgv_approved, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_pending, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_voucher_no As System.Windows.Forms.Label
    Friend WithEvents btn_filter As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtp_date_to As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_date_from As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_remove As System.Windows.Forms.Button
    Friend WithEvents btn_approve As System.Windows.Forms.Button
    Friend WithEvents dgv_approved As System.Windows.Forms.DataGridView
    Friend WithEvents dgv_pending As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
