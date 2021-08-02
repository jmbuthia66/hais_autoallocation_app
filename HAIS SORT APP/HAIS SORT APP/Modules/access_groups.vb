Imports System
Imports System.Data
Imports System.Data.Odbc
Imports System.Windows.Forms
Module access_groups
    Public user_Access_underwriting_Results As Boolean = False
    Public user_Access_claims_Results As Boolean = False
    Public user_Access_finance_Results As Boolean = False
    Dim dr_underwriting, dr_claims, dr_finance As OdbcDataReader
    Public Function user_access() As Object
        connection.connect()

        ''underwriting
        Dim cmd_underwriting As New OdbcCommand
        With cmd_underwriting
            .Connection = connection.conn
            .CommandText = "SELECT users.user_name,t_user_group.user_group FROM users INNER JOIN user_groups ON users.user_name = user_groups.user_name INNER JOIN t_user_group ON user_groups.user_group = t_user_group.code where users.user_name='" & main.lbl_username.Text & "' and t_user_group.user_group like'%Underwriters%' "
        End With
        dr_underwriting = cmd_underwriting.ExecuteReader
        If dr_underwriting.HasRows = True Then
            If dr_underwriting.HasRows = True Then
                access_groups.user_Access_underwriting_Results = True
            Else
                access_groups.user_Access_underwriting_Results = False
                Return access_groups.user_Access_underwriting_Results
            End If
        End If

        ''claims
        Dim cmd_claims As New OdbcCommand
        With cmd_claims
            .Connection = connection.conn
            .CommandText = "SELECT users.user_name,t_user_group.user_group FROM users INNER JOIN user_groups ON users.user_name = user_groups.user_name INNER JOIN t_user_group ON user_groups.user_group = t_user_group.code where users.user_name='" & main.lbl_username.Text & "' and t_user_group.user_group like'%claim%'"
        End With
        dr_claims = cmd_claims.ExecuteReader
        If dr_claims.HasRows = True Then
            If dr_claims.HasRows = True Then
                access_groups.user_Access_claims_Results = True
            Else
                access_groups.user_Access_claims_Results = False
                Return access_groups.user_Access_claims_Results
            End If
        End If

        ''Finance
        Dim cmd_finance As New OdbcCommand
        With cmd_finance
            .Connection = connection.conn
            .CommandText = "SELECT users.user_name,t_user_group.user_group FROM users INNER JOIN user_groups ON users.user_name = user_groups.user_name INNER JOIN t_user_group ON user_groups.user_group = t_user_group.code where users.user_name='" & main.lbl_username.Text & "' and t_user_group.user_group like'%finance%'"

        End With
        dr_finance = cmd_finance.ExecuteReader
        If dr_finance.HasRows = True Then
            If dr_finance.HasRows = True Then
                access_groups.user_Access_finance_Results = True
            Else
                access_groups.user_Access_claims_Results = False
                Return access_groups.user_Access_claims_Results
            End If
        End If

    End Function
End Module
