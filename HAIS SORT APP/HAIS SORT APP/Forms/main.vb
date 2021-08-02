Imports System.Windows.Forms 

Public Class main
    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub
 

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer
    Private Sub PaymentDetailsUpdateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_payment_details_update.Show()
    End Sub

    Private Sub ReceiptAutoAlocationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_receipt_allocation.Show()
    End Sub

    Private Sub PAYMENTDETAILSUPDATEToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PAYMENTDETAILSUPDATEToolStripMenuItem1.Click
        'access_groups.user_access()
        'If Not access_groups.user_Access_claims_Results Then
        '    Interaction.MsgBox("Access Denied", MsgBoxStyle.ApplicationModal, Nothing)
        'Else
        frm_payment_details_update.Show()
        'End If

    End Sub

    Private Sub RECEIPTAUTOALLOCATIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RECEIPTAUTOALLOCATIONToolStripMenuItem.Click
        access_groups.user_access()
        If Not access_groups.user_Access_underwriting_Results Then
            Interaction.MsgBox("Access Denied", MsgBoxStyle.ApplicationModal, Nothing)
        Else
            frm_receipt_allocation.Show()
        End If
    End Sub

    Private Sub MemberListingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MemberListingToolStripMenuItem.Click
        frm_member_listing.Show()
    End Sub

    Private Sub VoucherReversalApproveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VoucherReversalApproveToolStripMenuItem.Click
        access_groups.user_access()
        If Not access_groups.user_Access_finance_Results Then
            Interaction.MsgBox("Access Denied", MsgBoxStyle.ApplicationModal, Nothing)
        Else
            frm_voucher_reversal_approval.Show()
        End If
    End Sub

    Private Sub VoucherReversalRequestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VoucherReversalRequestToolStripMenuItem.Click
        access_groups.user_access()
        If Not access_groups.user_Access_claims_Results Then
            Interaction.MsgBox("Access Denied", MsgBoxStyle.ApplicationModal, Nothing)
        Else
            frm_voucher_reversal_request.Show()
        End If

    End Sub

    Private Sub main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    
    Private Sub ReinsuranceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReinsuranceToolStripMenuItem.Click
        frm_reinsurance.Show()
    End Sub
End Class
