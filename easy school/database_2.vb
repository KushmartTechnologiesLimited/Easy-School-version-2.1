Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class database
    Public connstring As String = "Server=127.0.0.1;Database=skull;Uid=school;Pwd=incorrect;"
    Dim conn As New MySqlConnection(connstring)
    Dim da As MySqlDataAdapter = New MySqlDataAdapter
    Dim ds As New DataSet
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
    Public Function add1(ByVal sql As String)
        Dim mh As New MySqlDataAdapter
        Try

            Dim cn As New MySqlCommand
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            cn.CommandText = (sql)
            cn.Connection = conn
            mh.SelectCommand = cn
            cn.ExecuteNonQuery()
            MsgBox("Success! ", MsgBoxStyle.Information, "success")
        Catch ex As Exception
            MsgBox("error ! ", MsgBoxStyle.Information, "failed")
            'Dim errorcode(2) As String
            'errorcode(0) = 133
            'errorcode(1) = ex.Message
            'Return errorcode
        End Try
    End Function
    Public Sub populateDDList(ByRef combo As ComboBox, ByVal sSql As String)

        Dim res As String = ""
        Dim red As DataTable 'SqlDataReader = Nothing
        Dim drow As DataRow
        red = executeSQL(sSql)
        combo.Items.Clear()
        ''  combo.Items.Add(New ListItem("Select", "Select"))
        '  If res = "SUCCESS" Then
        For Each drow In red.Rows
            combo.Items.Add(drow.Item(0).ToString.ToUpper)
        Next
        '  Else
        ' End If
    End Sub
    Public Sub poplist(ByRef list As ListBox, ByVal sSql As String)
        Dim res As String = ""
        Dim red As DataTable 'SqlDataReader = Nothing
        Dim drow As DataRow
        red = executeSQL(sSql)
        list.Items.Clear()
        ''   combo.Items.Add(New ListItem("Select", "Select"))
        ' If res = "SUCCESS" Then
        For Each drow In red.Rows
            list.Items.Add(drow.Item(0).ToString.ToUpper)
        Next
        ' Else
        '  End If
    End Sub
    Public Function select_dgview(ByVal sql As String, ByVal datagrid As DataGridView)
        ds.Clear()
        da.Dispose()
        da.SelectCommand = New MySqlCommand(sql, conn)
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            da.Fill(ds, "test")
            datagrid.DataSource = ds.Tables("test")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Public Function delete(ByVal sql As String)
        Dim sReturn As String = ""
        'Dim sr As SqlDataReader = Nothing
        Dim dt As DataTable = New DataTable
        Dim da As New MySqlDataAdapter
        conn = New MySqlConnection
        Try
            conn.ConnectionString = connstring
            conn.Open()
            Dim sComm As New MySqlCommand
            sComm.CommandText = sql
            sComm.Connection = conn
            da.SelectCommand = sComm
            da.Fill(dt)
            conn.Close()
            'sResult = "SUCCESS"
            MsgBox("Success!  " + vbCrLf + "Deleted ", MsgBoxStyle.Information, "success")
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
    Public Function update(ByVal sql As String)
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim da As MySqlCommand = New MySqlCommand(sql, conn)
            Dim reader As MySqlDataReader = da.ExecuteReader
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Public Function executeSQL(ByVal sSql As String) As Data.DataTable
        ', ByRef sResult As String
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
        Catch ex As Exception
            MsgBox("SERROR" & ": " & ex.Message)
            If (conn.State = Data.ConnectionState.Open) Then
                conn.Close()
            End If
        End Try
        conn = Nothing
        Return dt
    End Function



End Class
