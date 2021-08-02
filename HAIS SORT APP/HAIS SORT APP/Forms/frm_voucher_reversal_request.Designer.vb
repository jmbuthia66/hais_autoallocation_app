<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_voucher_reversal_request
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
        Me.dgv_vouchers = New System.Windows.Forms.DataGridView
        Me.dgv_voucher_app = New System.Windows.Forms.DataGridView
        Me.btn_add = New System.Windows.Forms.Button
        Me.btn_remove = New System.Windows.Forms.Button
        Me.dtp_date_from = New System.Windows.Forms.DateTimePicker
        Me.dtp_date_to = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btn_search = New System.Windows.Forms.Button
        Me.lbl_voucher_no = New System.Windows.Forms.Label
        Me.lbl_amount = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.dgv_vouchers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_voucher_app, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_vouchers
        '
        Me.dgv_vouchers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_vouchers.BackgroundColor = System.Drawing.Color.White
        Me.dgv_vouchers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_vouchers.Location = New System.Drawing.Point(7, 94)
        Me.dgv_vouchers.Name = "dgv_vouchers"
        Me.dgv_vouchers.Size = New System.Drawing.Size(299, 368)
        Me.dgv_vouchers.TabIndex = 0
        '
        'dgv_voucher_app
        '
        Me.dgv_voucher_app.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_voucher_app.BackgroundColor = System.Drawing.Color.White
        Me.dgv_voucher_app.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_voucher_app.Location = New System.Drawing.Point(421, 94)
        Me.dgv_voucher_app.Name = "dgv_voucher_app"
        Me.dgv_voucher_app.Size = New System.Drawing.Size(330, 368)
        Me.dgv_voucher_app.TabIndex = 1
        '
        'btn_add
        '
        Me.btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Location = New System.Drawing.Point(326, 209)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(75, 39)
        Me.btn_add.TabIndex = 2
        Me.btn_add.Text = ">"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_remove
        '
        Me.btn_remove.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_remove.Location = New System.Drawing.Point(326, 288)
        Me.btn_remove.Name = "btn_remove"
        Me.btn_remove.Size = New System.Drawing.Size(75, 36)
        Me.btn_remove.TabIndex = 6
        Me.btn_remove.Text = "<"
        Me.btn_remove.UseVisualStyleBackColor = True
        '
        'dtp_date_from
        '
        Me.dtp_date_from.Location = New System.Drawing.Point(44, 13)
        Me.dtp_date_from.Name = "dtp_date_from"
        Me.dtp_date_from.Size = New System.Drawing.Size(200, 20)
        Me.dtp_date_from.TabIndex = 7
        '
        'dtp_date_to
        '
        Me.dtp_date_to.Location = New System.Drawing.Point(44, 39)
        Me.dtp_date_to.Name = "dtp_date_to"
        Me.dtp_date_to.Size = New System.Drawing.Size(200, 20)
        Me.dtp_date_to.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "From:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "To:"
        '
        'btn_search
        '
        Me.btn_search.Location = New System.Drawing.Point(44, 66)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(75, 23)
        Me.btn_search.TabIndex = 11
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'lbl_voucher_no
        '
        Me.lbl_voucher_no.AutoSize = True
        Me.lbl_voucher_no.Location = New System.Drawing.Point(321, 13)
        Me.lbl_voucher_no.Name = "lbl_voucher_no"
        Me.lbl_voucher_no.Size = New System.Drawing.Size(64, 13)
        Me.lbl_voucher_no.TabIndex = 12
        Me.lbl_voucher_no.Text = "voucher_no"
        Me.lbl_voucher_no.Visible = False
        '
        'lbl_amount
        '
        Me.lbl_amount.AutoSize = True
        Me.lbl_amount.Location = New System.Drawing.Point(403, 13)
        Me.lbl_amount.Name = "lbl_amount"
        Me.lbl_amount.Size = New System.Drawing.Size(42, 13)
        Me.lbl_amount.TabIndex = 13
        Me.lbl_amount.Text = "amount"
        Me.lbl_amount.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(424, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Pending Approval"
        '
        'frm_voucher_reversal_request
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 480)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_amount)
        Me.Controls.Add(Me.lbl_voucher_no)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtp_date_to)
        Me.Controls.Add(Me.dtp_date_from)
        Me.Controls.Add(Me.btn_remove)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.dgv_voucher_app)
        Me.Controls.Add(Me.dgv_vouchers)
        Me.Name = "frm_voucher_reversal_request"
        Me.Text = "Voucher Reversal Request"
        CType(Me.dgv_vouchers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_voucher_app, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_remove As System.Windows.Forms.Button
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents dgv_voucher_app As System.Windows.Forms.DataGridView
    Friend WithEvents dgv_vouchers As System.Windows.Forms.DataGridView
    Friend WithEvents dtp_date_from As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_date_to As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_search As System.Windows.Forms.Button
    Friend WithEvents lbl_voucher_no As System.Windows.Forms.Label
    Friend WithEvents lbl_amount As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
