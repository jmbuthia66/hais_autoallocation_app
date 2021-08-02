<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_receipt_allocation
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
        Me.btn_load_receipts = New System.Windows.Forms.Button
        Me.dgv_receipts = New System.Windows.Forms.DataGridView
        Me.dtp_date_from = New System.Windows.Forms.DateTimePicker
        Me.dtp_date_to = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txt_debit_no = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.rbt_debit = New System.Windows.Forms.RadioButton
        Me.rbt_date_range = New System.Windows.Forms.RadioButton
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.btn_allocate = New System.Windows.Forms.Button
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rbn_corporate = New System.Windows.Forms.RadioButton
        Me.rbn_family = New System.Windows.Forms.RadioButton
        CType(Me.dgv_receipts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_load_receipts
        '
        Me.btn_load_receipts.Location = New System.Drawing.Point(18, 147)
        Me.btn_load_receipts.Name = "btn_load_receipts"
        Me.btn_load_receipts.Size = New System.Drawing.Size(148, 28)
        Me.btn_load_receipts.TabIndex = 0
        Me.btn_load_receipts.Text = "Load Receipts"
        Me.btn_load_receipts.UseVisualStyleBackColor = True
        '
        'dgv_receipts
        '
        Me.dgv_receipts.AllowUserToAddRows = False
        Me.dgv_receipts.AllowUserToDeleteRows = False
        Me.dgv_receipts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_receipts.BackgroundColor = System.Drawing.Color.White
        Me.dgv_receipts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_receipts.Location = New System.Drawing.Point(6, 181)
        Me.dgv_receipts.Name = "dgv_receipts"
        Me.dgv_receipts.ReadOnly = True
        Me.dgv_receipts.Size = New System.Drawing.Size(1045, 237)
        Me.dgv_receipts.TabIndex = 1
        '
        'dtp_date_from
        '
        Me.dtp_date_from.Enabled = False
        Me.dtp_date_from.Location = New System.Drawing.Point(154, 51)
        Me.dtp_date_from.Name = "dtp_date_from"
        Me.dtp_date_from.Size = New System.Drawing.Size(200, 20)
        Me.dtp_date_from.TabIndex = 2
        '
        'dtp_date_to
        '
        Me.dtp_date_to.Enabled = False
        Me.dtp_date_to.Location = New System.Drawing.Point(413, 50)
        Me.dtp_date_to.Name = "dtp_date_to"
        Me.dtp_date_to.Size = New System.Drawing.Size(200, 20)
        Me.dtp_date_to.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(115, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "From:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(382, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "To:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_debit_no)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.rbt_debit)
        Me.GroupBox1.Controls.Add(Me.rbt_date_range)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtp_date_from)
        Me.GroupBox1.Controls.Add(Me.dtp_date_to)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(909, 87)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Receipt by:"
        '
        'txt_debit_no
        '
        Me.txt_debit_no.Enabled = False
        Me.txt_debit_no.Location = New System.Drawing.Point(155, 21)
        Me.txt_debit_no.Name = "txt_debit_no"
        Me.txt_debit_no.Size = New System.Drawing.Size(149, 20)
        Me.txt_debit_no.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(99, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Debit No:"
        '
        'rbt_debit
        '
        Me.rbt_debit.AutoSize = True
        Me.rbt_debit.Location = New System.Drawing.Point(12, 24)
        Me.rbt_debit.Name = "rbt_debit"
        Me.rbt_debit.Size = New System.Drawing.Size(50, 17)
        Me.rbt_debit.TabIndex = 7
        Me.rbt_debit.TabStop = True
        Me.rbt_debit.Text = "Debit"
        Me.rbt_debit.UseVisualStyleBackColor = True
        '
        'rbt_date_range
        '
        Me.rbt_date_range.AutoSize = True
        Me.rbt_date_range.Location = New System.Drawing.Point(12, 51)
        Me.rbt_date_range.Name = "rbt_date_range"
        Me.rbt_date_range.Size = New System.Drawing.Size(83, 17)
        Me.rbt_date_range.TabIndex = 6
        Me.rbt_date_range.TabStop = True
        Me.rbt_date_range.Text = "Date Range"
        Me.rbt_date_range.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(2, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1068, 450)
        Me.TabControl1.TabIndex = 7
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.btn_allocate)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.btn_load_receipts)
        Me.TabPage1.Controls.Add(Me.dgv_receipts)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1060, 424)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btn_allocate
        '
        Me.btn_allocate.Location = New System.Drawing.Point(172, 147)
        Me.btn_allocate.Name = "btn_allocate"
        Me.btn_allocate.Size = New System.Drawing.Size(111, 28)
        Me.btn_allocate.TabIndex = 7
        Me.btn_allocate.Text = "Allocate"
        Me.btn_allocate.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1037, 417)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbn_family)
        Me.GroupBox2.Controls.Add(Me.rbn_corporate)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(195, 38)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'rbn_corporate
        '
        Me.rbn_corporate.AutoSize = True
        Me.rbn_corporate.Location = New System.Drawing.Point(11, 12)
        Me.rbn_corporate.Name = "rbn_corporate"
        Me.rbn_corporate.Size = New System.Drawing.Size(71, 17)
        Me.rbn_corporate.TabIndex = 13
        Me.rbn_corporate.TabStop = True
        Me.rbn_corporate.Text = "Corporate"
        Me.rbn_corporate.UseVisualStyleBackColor = True
        '
        'rbn_family
        '
        Me.rbn_family.AutoSize = True
        Me.rbn_family.Location = New System.Drawing.Point(96, 13)
        Me.rbn_family.Name = "rbn_family"
        Me.rbn_family.Size = New System.Drawing.Size(54, 17)
        Me.rbn_family.TabIndex = 14
        Me.rbn_family.TabStop = True
        Me.rbn_family.Text = "Family"
        Me.rbn_family.UseVisualStyleBackColor = True
        '
        'frm_receipt_allocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1069, 466)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frm_receipt_allocation"
        Me.Text = "Receipt Auto Allocation"
        CType(Me.dgv_receipts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_load_receipts As System.Windows.Forms.Button
    Friend WithEvents dgv_receipts As System.Windows.Forms.DataGridView
    Friend WithEvents dtp_date_from As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_date_to As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btn_allocate As System.Windows.Forms.Button
    Friend WithEvents rbt_debit As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_date_range As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_debit_no As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbn_family As System.Windows.Forms.RadioButton
    Friend WithEvents rbn_corporate As System.Windows.Forms.RadioButton

End Class
