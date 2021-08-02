<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Me.components = New System.ComponentModel.Container
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.UNDERWRITINToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RECEIPTAUTOALLOCATIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CLAIMSToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.VoucherReversalRequestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VoucherReversalApproveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReinsuranceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CAREToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ICTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PAYMENTDETAILSUPDATEToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UNDERWRITTINGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MemberListingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CLAIMSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CAREToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ICTToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.lbl_username = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.EditMenu, Me.ReportsToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(40, 20)
        Me.FileMenu.Text = "&FILE"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(97, 22)
        Me.ExitToolStripMenuItem.Text = "E&XIT"
        '
        'EditMenu
        '
        Me.EditMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator7, Me.UNDERWRITINToolStripMenuItem, Me.CLAIMSToolStripMenuItem1, Me.CAREToolStripMenuItem, Me.ICTToolStripMenuItem})
        Me.EditMenu.Name = "EditMenu"
        Me.EditMenu.Size = New System.Drawing.Size(52, 20)
        Me.EditMenu.Text = "&TASKS"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(149, 6)
        '
        'UNDERWRITINToolStripMenuItem
        '
        Me.UNDERWRITINToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RECEIPTAUTOALLOCATIONToolStripMenuItem})
        Me.UNDERWRITINToolStripMenuItem.Name = "UNDERWRITINToolStripMenuItem"
        Me.UNDERWRITINToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UNDERWRITINToolStripMenuItem.Text = "Underwriting"
        '
        'RECEIPTAUTOALLOCATIONToolStripMenuItem
        '
        Me.RECEIPTAUTOALLOCATIONToolStripMenuItem.Name = "RECEIPTAUTOALLOCATIONToolStripMenuItem"
        Me.RECEIPTAUTOALLOCATIONToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.RECEIPTAUTOALLOCATIONToolStripMenuItem.Text = "Receipt Auto Allocation"
        '
        'CLAIMSToolStripMenuItem1
        '
        Me.CLAIMSToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VoucherReversalRequestToolStripMenuItem, Me.VoucherReversalApproveToolStripMenuItem, Me.ReinsuranceToolStripMenuItem})
        Me.CLAIMSToolStripMenuItem1.Name = "CLAIMSToolStripMenuItem1"
        Me.CLAIMSToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.CLAIMSToolStripMenuItem1.Text = "Claims"
        '
        'VoucherReversalRequestToolStripMenuItem
        '
        Me.VoucherReversalRequestToolStripMenuItem.Name = "VoucherReversalRequestToolStripMenuItem"
        Me.VoucherReversalRequestToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.VoucherReversalRequestToolStripMenuItem.Text = "Voucher Reversal Request"
        '
        'VoucherReversalApproveToolStripMenuItem
        '
        Me.VoucherReversalApproveToolStripMenuItem.Name = "VoucherReversalApproveToolStripMenuItem"
        Me.VoucherReversalApproveToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.VoucherReversalApproveToolStripMenuItem.Text = "Voucher Reversal Approve"
        '
        'ReinsuranceToolStripMenuItem
        '
        Me.ReinsuranceToolStripMenuItem.Name = "ReinsuranceToolStripMenuItem"
        Me.ReinsuranceToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.ReinsuranceToolStripMenuItem.Text = "Re-insurance"
        '
        'CAREToolStripMenuItem
        '
        Me.CAREToolStripMenuItem.Name = "CAREToolStripMenuItem"
        Me.CAREToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CAREToolStripMenuItem.Text = "Care"
        '
        'ICTToolStripMenuItem
        '
        Me.ICTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PAYMENTDETAILSUPDATEToolStripMenuItem1})
        Me.ICTToolStripMenuItem.Name = "ICTToolStripMenuItem"
        Me.ICTToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ICTToolStripMenuItem.Text = "ICT"
        '
        'PAYMENTDETAILSUPDATEToolStripMenuItem1
        '
        Me.PAYMENTDETAILSUPDATEToolStripMenuItem1.Name = "PAYMENTDETAILSUPDATEToolStripMenuItem1"
        Me.PAYMENTDETAILSUPDATEToolStripMenuItem1.Size = New System.Drawing.Size(219, 22)
        Me.PAYMENTDETAILSUPDATEToolStripMenuItem1.Text = "PAYMENT DETAILS UPDATE"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UNDERWRITTINGToolStripMenuItem, Me.CLAIMSToolStripMenuItem, Me.CAREToolStripMenuItem1, Me.ICTToolStripMenuItem1})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ReportsToolStripMenuItem.Text = "&REPORT"
        '
        'UNDERWRITTINGToolStripMenuItem
        '
        Me.UNDERWRITTINGToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MemberListingToolStripMenuItem})
        Me.UNDERWRITTINGToolStripMenuItem.Name = "UNDERWRITTINGToolStripMenuItem"
        Me.UNDERWRITTINGToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UNDERWRITTINGToolStripMenuItem.Text = "Underwriting"
        '
        'MemberListingToolStripMenuItem
        '
        Me.MemberListingToolStripMenuItem.Name = "MemberListingToolStripMenuItem"
        Me.MemberListingToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.MemberListingToolStripMenuItem.Text = "Member Listing"
        '
        'CLAIMSToolStripMenuItem
        '
        Me.CLAIMSToolStripMenuItem.Name = "CLAIMSToolStripMenuItem"
        Me.CLAIMSToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CLAIMSToolStripMenuItem.Text = "Claims"
        '
        'CAREToolStripMenuItem1
        '
        Me.CAREToolStripMenuItem1.Name = "CAREToolStripMenuItem1"
        Me.CAREToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.CAREToolStripMenuItem1.Text = "Care"
        '
        'ICTToolStripMenuItem1
        '
        Me.ICTToolStripMenuItem1.Name = "ICTToolStripMenuItem1"
        Me.ICTToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ICTToolStripMenuItem1.Text = "ICT"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel, Me.lbl_username})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(632, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(95, 17)
        Me.ToolStripStatusLabel.Text = "Logged on user: "
        '
        'lbl_username
        '
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(36, 17)
        Me.lbl_username.Text = "NULL"
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "main"
        Me.Text = "MADISON HEALTHCARE "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents EditMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UNDERWRITTINGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CLAIMSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UNDERWRITINToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CLAIMSToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CAREToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CAREToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ICTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PAYMENTDETAILSUPDATEToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RECEIPTAUTOALLOCATIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ICTToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MemberListingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VoucherReversalApproveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VoucherReversalRequestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbl_username As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ReinsuranceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
