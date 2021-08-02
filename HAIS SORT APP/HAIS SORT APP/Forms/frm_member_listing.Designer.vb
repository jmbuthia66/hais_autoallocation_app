<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_member_listing
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
        Me.cbo_corporate = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btn_cancel = New System.Windows.Forms.Button
        Me.lbl_corp_id = New System.Windows.Forms.Label
        Me.dgv_member_listing = New System.Windows.Forms.DataGridView
        Me.btn_export = New System.Windows.Forms.Button
        CType(Me.dgv_member_listing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbo_corporate
        '
        Me.cbo_corporate.FormattingEnabled = True
        Me.cbo_corporate.Location = New System.Drawing.Point(75, 17)
        Me.cbo_corporate.Name = "cbo_corporate"
        Me.cbo_corporate.Size = New System.Drawing.Size(609, 21)
        Me.cbo_corporate.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Corporate:"
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(199, 444)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 3
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'lbl_corp_id
        '
        Me.lbl_corp_id.AutoSize = True
        Me.lbl_corp_id.Location = New System.Drawing.Point(771, 22)
        Me.lbl_corp_id.Name = "lbl_corp_id"
        Me.lbl_corp_id.Size = New System.Drawing.Size(42, 13)
        Me.lbl_corp_id.TabIndex = 4
        Me.lbl_corp_id.Text = "corp_id"
        Me.lbl_corp_id.Visible = False
        '
        'dgv_member_listing
        '
        Me.dgv_member_listing.AllowUserToAddRows = False
        Me.dgv_member_listing.AllowUserToDeleteRows = False
        Me.dgv_member_listing.AllowUserToOrderColumns = True
        Me.dgv_member_listing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_member_listing.BackgroundColor = System.Drawing.Color.White
        Me.dgv_member_listing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_member_listing.Location = New System.Drawing.Point(12, 101)
        Me.dgv_member_listing.Name = "dgv_member_listing"
        Me.dgv_member_listing.ReadOnly = True
        Me.dgv_member_listing.Size = New System.Drawing.Size(1037, 326)
        Me.dgv_member_listing.TabIndex = 5
        '
        'btn_export
        '
        Me.btn_export.Location = New System.Drawing.Point(103, 444)
        Me.btn_export.Name = "btn_export"
        Me.btn_export.Size = New System.Drawing.Size(75, 23)
        Me.btn_export.TabIndex = 6
        Me.btn_export.Text = "Export"
        Me.btn_export.UseVisualStyleBackColor = True
        '
        'frm_member_listing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1061, 479)
        Me.Controls.Add(Me.btn_export)
        Me.Controls.Add(Me.dgv_member_listing)
        Me.Controls.Add(Me.lbl_corp_id)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbo_corporate)
        Me.Name = "frm_member_listing"
        Me.Text = "Member Listing"
        CType(Me.dgv_member_listing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbo_corporate As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents lbl_corp_id As System.Windows.Forms.Label
    Friend WithEvents dgv_member_listing As System.Windows.Forms.DataGridView
    Friend WithEvents btn_export As System.Windows.Forms.Button
End Class
