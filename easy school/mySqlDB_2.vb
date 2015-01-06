Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports MySql.Data
Imports MySql.Data.MySqlClient


Public Class mySqlDB
    'MySQL
    Public connString As String = "Server=127.0.0.1;Database=sms;Uid=root;Pwd=;"
    Public conn As MySqlConnection
    Public SUCCESS As String = "SUCCESS"
    Public SERROR As String = "ERROR"

    Public Function executeSQL(ByVal sSql As String, ByRef sResult As String) As Data.DataTable
        Dim sReturn As String = ""
        'Dim sr As SqlDataReader = Nothing
        Dim dt As DataTable = New DataTable
        Dim da As New mySqlDataAdapter
        conn = New MySqlConnection
        Try
            conn.ConnectionString = connString
            conn.Open()
            Dim sComm As New MySqlCommand
            sComm.CommandText = sSql
            sComm.Connection = conn
            da.SelectCommand = sComm
            da.Fill(dt)
            conn.Close()
            sResult = SUCCESS
        Catch ex As Exception
            sResult = SERROR & ": " & ex.Message
            If (conn.State = Data.ConnectionState.Open) Then
                conn.Close()
            End If
        End Try
        conn = Nothing
        Return dt
    End Function
    Public Function executeDMLSQL(ByVal sSql As String, ByRef sResult As String) As Integer
        Dim sReturn As String = ""
        Dim irows As Integer = 0
        conn = New MySqlConnection
        Try
            conn.ConnectionString = connString
            conn.Open()
            Dim sComm As New MySqlCommand
            sComm.CommandText = sSql
            sComm.Connection = conn
            irows = sComm.ExecuteNonQuery()
            conn.Close()
            sResult = SUCCESS
        Catch ex As Exception
            sResult = SERROR & ": " & ex.Message
            If (conn.State = Data.ConnectionState.Open) Then
                conn.Close()
            End If
        End Try
        conn = Nothing
        Return irows
    End Function
    Public Function executeSQL_dset(ByVal sSql As String, ByRef sResult As String) As Data.DataSet
        Dim sReturn As String = ""
        'Dim sr As SqlDataReader = Nothing
        'Dim dt As DataTable = New DataTable
        Dim dt As DataSet = New DataSet
        Dim da As New MySqlDataAdapter
        conn = New MySqlConnection
        Try
            conn.ConnectionString = connString
            conn.Open()
            Dim sComm As New MySqlCommand
            sComm.CommandText = sSql
            sComm.Connection = conn
            da.SelectCommand = sComm
            da.Fill(dt)
            conn.Close()
            sResult = SUCCESS
        Catch ex As Exception
            sResult = SERROR & ": " & ex.Message
            If (conn.State = Data.ConnectionState.Open) Then
                conn.Close()
            End If
        End Try
        conn = Nothing
        Return dt
    End Function

    Public Function getAllMonth(ByVal sdate As String) As String
        Dim sSql As String = ""
        'Dim dDate As Date = date.(sdate,"dd/MM/yyyy")
        'dDate.Month = sdate.Substring(3, 2)

        Dim inumDays As Integer = Date.DaysInMonth(sdate.Substring(6, 4), sdate.Substring(3, 2)) 'dDate.AddMonths(1).AddDays(-1).Day
        Dim dd As Integer
        For dd = 1 To inumDays
            sSql &= ", max(case when day(att_date)=" & dd & " then att_flag else '' end) as '" & dd & "' "
        Next

        Return sSql
    End Function
    Public Function add(ByRef ssql As String)
        Dim sReturn As String = ""
        'Dim sr As SqlDataReader = Nothing
        Dim dt As DataTable = New DataTable
        Dim da As New MySqlDataAdapter
        conn = New MySqlConnection
        Try
            conn.ConnectionString = connstring
            conn.Open()
            Dim sComm As New MySqlCommand
            sComm.CommandText = sSql
            sComm.Connection = conn
            da.SelectCommand = sComm
            da.Fill(dt)
            conn.Close()
            'sResult = "SUCCESS"
            MsgBox("Success! ", MsgBoxStyle.Information, "success")
        Catch ex As Exception
            'sResult = "SERROR" & ": " & ex.Message
            MsgBox("error ! " & ex.Message & "  :  " & ex.Source, MsgBoxStyle.Information, "failed")
            If (conn.State = Data.ConnectionState.Open) Then
                conn.Close()
            End If
        End Try
        conn = Nothing
        Return dt
    End Function
End Class
