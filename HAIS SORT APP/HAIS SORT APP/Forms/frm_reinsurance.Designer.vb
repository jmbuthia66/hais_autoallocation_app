<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_reinsurance
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
        Me.btn_run = New System.Windows.Forms.Button
        Me.dgv_re_claimed_unclaimed = New System.Windows.Forms.DataGridView
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.btn_export = New System.Windows.Forms.Button
        CType(Me.dgv_re_claimed_unclaimed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_run
        '
        Me.btn_run.Location = New System.Drawing.Point(6, 15)
        Me.btn_run.Name = "btn_run"
        Me.btn_run.Size = New System.Drawing.Size(75, 23)
        Me.btn_run.TabIndex = 0
        Me.btn_run.Text = "RUN"
        Me.btn_run.UseVisualStyleBackColor = True
        '
        'dgv_re_claimed_unclaimed
        '
        Me.dgv_re_claimed_unclaimed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_re_claimed_unclaimed.BackgroundColor = System.Drawing.Color.White
        Me.dgv_re_claimed_unclaimed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_re_claimed_unclaimed.Location = New System.Drawing.Point(6, 44)
        Me.dgv_re_claimed_unclaimed.Name = "dgv_re_claimed_unclaimed"
        Me.dgv_re_claimed_unclaimed.Size = New System.Drawing.Size(822, 378)
        Me.dgv_re_claimed_unclaimed.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(13, 13)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(842, 454)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btn_export)
        Me.TabPage1.Controls.Add(Me.btn_run)
        Me.TabPage1.Controls.Add(Me.dgv_re_claimed_unclaimed)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(834, 428)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Claimed & Unclaimed Re-insurance"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(834, 428)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Process Unclaimed Re-insurance"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btn_export
        '
        Me.btn_export.Location = New System.Drawing.Point(99, 15)
        Me.btn_export.Name = "btn_export"
        Me.btn_export.Size = New System.Drawing.Size(75, 23)
        Me.btn_export.TabIndex = 7
        Me.btn_export.Text = "EXPORT"
        Me.btn_export.UseVisualStyleBackColor = True
        '
        'frm_reinsurance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 479)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frm_reinsurance"
        Me.Text = "Re-insurance"
        CType(Me.dgv_re_claimed_unclaimed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_run As System.Windows.Forms.Button
    Friend WithEvents dgv_re_claimed_unclaimed As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btn_export As System.Windows.Forms.Button
End Class
