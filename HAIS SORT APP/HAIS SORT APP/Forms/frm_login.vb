Imports System.DirectoryServices
Public Class frm_login
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_OK.Click
        AuthenticateAgainstAD()

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub
    Public Sub AuthenticateAgainstAD()
        Try
            Dim username As String = txt_username.Text
            Dim password As String = txt_password.Text
            Dim userOk As Boolean = False
            Dim realName As String = String.Empty

            Using directoryEntry As DirectoryEntry = New DirectoryEntry("LDAP://192.168.0.4/DC=madison,DC=co,DC=ke", username, password)

                Using searcher As DirectorySearcher = New DirectorySearcher(directoryEntry)
                    searcher.Filter = "(samaccountname=" & username & ")"
                    searcher.PropertiesToLoad.Add("displayname")
                    Dim adsSearchResult As SearchResult = searcher.FindOne()

                    If adsSearchResult IsNot Nothing Then

                        If adsSearchResult.Properties("displayname").Count = 1 Then
                            realName = CStr(adsSearchResult.Properties("displayname")(0))
                        End If

                        userOk = True

                        main.Show()
                        main.lbl_username.Text = txt_username.Text
                        Me.Hide()
                    End If
                End Using
            End Using

        Catch exc As Exception
            Dim ex As Exception = exc
            MessageBox.Show(ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try
    End Sub

End Class
