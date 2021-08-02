Imports System
Imports System.Data
Imports System.Data.Odbc 
Imports System.Windows.Forms 

Module connection
    Public conn As OdbcConnection
    Public connectionstring As String
    Private data As DataTable
    Private da As OdbcDataAdapter 
    Public Sub connect()
        Try
            'developer
            'connection.connectionstring = "Dsn=jb;uid=dba;pwd=Hais_15"
            'Live
            connection.connectionstring = "Dsn=madison;uid=dba;pwd=Hais_15"
            connection.conn = New OdbcConnection(connection.connectionstring)
            connection.conn.Open()
        Catch exception1 As Exception
            Dim ex As Exception = exception1
            MessageBox.Show(ex.Message, "Connection", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try
    End Sub
End Module
