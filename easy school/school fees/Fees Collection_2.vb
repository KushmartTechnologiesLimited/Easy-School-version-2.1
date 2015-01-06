Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class Fees_Collection

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Hide()
    End Sub

    Private Sub Fees_Collection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler PrintDocument1.PrintPage, AddressOf Me.printDocument1_PrintPage


        ' Specify a PrintDocument instance for the PrintPreviewDialog component. 
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Label11.Hide()
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim i As String
        Dim ds As DataSet


        i = Environment.MachineName.ToString

        con.ConnectionString = "Data Source= " & i & "\SQLEXPRESS;Initial Catalog=school;Persist Security Info=True;User ID=Gms;Password=madhavaN"
        'class
        Dim dt As DataTable
        Dim dr As SqlDataReader

        Try
            con.Open()
            cmd.Connection = con
            da = New SqlDataAdapter("select class from class", con)
            cmd.CommandText = "select class from class"
            ds = New DataSet()
            da.Fill(ds, "class")
            dt = ds.Tables("class")
            cmd.ExecuteNonQuery()
            dr = cmd.ExecuteReader()
            While dr.Read()
                ComboBox1.Items.Add(dr.GetValue(0))
            End While

        Catch ex As Exception
            MsgBox("" & ex.Message & " : " & ex.Source)
        End Try
        con.Close()



        'fees
        Try
            con.Open()
            cmd.Connection = con
            da = New SqlDataAdapter("select fees from fees", con)
            cmd.CommandText = "select fees from fees"
            ds = New DataSet()
            da.Fill(ds, "fees")
            dt = ds.Tables("fees")
            cmd.ExecuteNonQuery()
            dr = cmd.ExecuteReader()
            While dr.Read()
                ComboBox2.Items.Add(dr.GetValue(0))
            End While

        Catch ex As Exception
            MsgBox("" & ex.Message & " : " & ex.Source)
        End Try
        con.Close()
        'auto

        Dim daa As New SqlDataAdapter
        Dim s As Integer
        Dim drr As SqlDataReader



        Try
            con.Open()
            cmd.Connection = con
            daa = New SqlDataAdapter("select id from feescollection", con)
            cmd.CommandText = "select id from feescollection"
            cmd.ExecuteNonQuery()
            drr = cmd.ExecuteReader()
            While drr.Read()
                s = drr.Item("id") + 1
            End While

        Catch ex As Exception
            MsgBox("" & ex.Message & " : " & ex.Source)
        End Try
        con.Close()
        Label6.Text = s





        Dim conn As New OleDbConnection
        Dim comm As New OleDbCommand
        Dim dss As DataSet
        Dim drrr As OleDbDataReader
        Dim daaa As OleDbDataAdapter


        Dim path1 As String
        path1 = Application.StartupPath
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & path1 & "\licience.accdb;Persist Security Info=False;")

        Try
            conn.Open()
            comm.Connection = conn
            daaa = New OleDbDataAdapter("select address1 from licience", conn)
            comm.CommandText = "select address1 from licience"
            dss = New DataSet()
            daaa.Fill(dss, "licience")

            drrr = comm.ExecuteReader()
            While drrr.Read()
                Label9.Text = drrr.GetValue(0)
            End While
            conn.Close()
        Catch ex As Exception
            'MsgBox("Connection not created" & ex.Message)
        End Try
        Try
            conn.Open()
            comm.Connection = conn
            daaa = New OleDbDataAdapter("select address2 from licience", conn)
            comm.CommandText = "select address2 from licience"
            dss = New DataSet()
            daaa.Fill(dss, "licience")

            drrr = comm.ExecuteReader()
            While drrr.Read()
                Label10.Text = drrr.GetValue(0)
            End While
            conn.Close()
        Catch ex As Exception
            'MsgBox("Connection not created" & ex.Message)
        End Try
        Try
            conn.Open()
            comm.Connection = conn
            daaa = New OleDbDataAdapter("select * from licience", conn)
            comm.CommandText = "select * from licience"
            dss = New DataSet()
            daaa.Fill(dss, "licience")

            drrr = comm.ExecuteReader()
            While drrr.Read()
                Label11.Text = drrr.GetValue(0)
            End While
            conn.Close()
        Catch ex As Exception
            'MsgBox("Connection not created" & ex.Message)
        End Try
        Label9.Hide()
        Label10.Hide()
    End Sub

    Private Sub ComboBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox1.KeyDown
        If e.KeyData = Keys.Enter Then
            ComboBox3.Focus()
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim da As New SqlDataAdapter
            Dim ds As DataSet
            Dim dt As DataTable
            Dim dr As SqlDataReader
            Dim i As String
            i = Environment.MachineName.ToString

            con.ConnectionString = "Data Source= " & i & "\SQLEXPRESS;Initial Catalog=school;Persist Security Info=True;User ID=Gms;Password=madhavaN"


            'Section()
            Try
                con.Open()
                cmd.Connection = con
                da = New SqlDataAdapter("select section from section where class='" & ComboBox1.Text & "'", con)
                cmd.CommandText = "select section from section where class='" & ComboBox1.Text & "'"
                ds = New DataSet()
                da.Fill(ds, "section")
                dt = ds.Tables("section")
                cmd.ExecuteNonQuery()
                dr = cmd.ExecuteReader()
                While dr.Read()
                    ComboBox3.Items.Add(dr.GetValue(0))
                End While

            Catch ex As Exception
                MsgBox("" & ex.Message & " : " & ex.Source)
            End Try
            con.Close()




        End If
    End Sub

    Private Sub ComboBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox2.KeyDown
        If e.KeyData = Keys.Enter Then
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim da As New SqlDataAdapter
            Dim i As String
            Dim ds As DataSet


            i = Environment.MachineName.ToString

            con.ConnectionString = "Data Source= " & i & "\SQLEXPRESS;Initial Catalog=school;Persist Security Info=True;User ID=Gms;Password=madhavaN"
            'class
            Dim dt As DataTable
            Dim dr As SqlDataReader

            Try
                con.Open()
                cmd.Connection = con
                da = New SqlDataAdapter("select amount from feesassign where fees='" & ComboBox2.Text & "' and class='" & ComboBox1.Text & "'", con)
                cmd.CommandText = "select amount from feesassign where fees='" & ComboBox2.Text & "' and class='" & ComboBox1.Text & "' "
                ds = New DataSet()
                da.Fill(ds, "feesassign")
                dt = ds.Tables("feesassign")
                cmd.ExecuteNonQuery()
                dr = cmd.ExecuteReader()
                While dr.Read()
                    TextBox1.Text = dr.GetValue(0)
                End While

            Catch ex As Exception
                MsgBox("" & ex.Message & " : " & ex.Source)
            End Try
            con.Close()
            TextBox1.Focus()
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim i As String
        Dim daa As New SqlDataAdapter
        Dim s As Integer
        Dim drr As SqlDataReader


        i = Environment.MachineName.ToString


        con.ConnectionString = "Data Source= " & i & "\SQLEXPRESS;Initial Catalog=school;Persist Security Info=True;User ID=Gms;Password=madhavaN"

        Try
            con.Open()
            cmd.Connection = con
            daa = New SqlDataAdapter("select id from feescollection", con)
            cmd.CommandText = "select id from feescollection"
            cmd.ExecuteNonQuery()
            drr = cmd.ExecuteReader()
            While drr.Read()
                s = drr.Item("id") + 1
            End While

        Catch ex As Exception
            MsgBox("" & ex.Message & " : " & ex.Source)
        End Try
        con.Close()
        Label6.Text = s
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim con As New SqlConnection
        Dim com As New SqlCommand
        Dim i As String

        i = Environment.MachineName.ToString

        Try
            con.ConnectionString = "Data Source= " & i & "\SQLEXPRESS;Initial Catalog=school;Persist Security Info=True;User ID=Gms;Password=madhavaN"
            con.Open()
            If ComboBox1.Text = "" And ComboBox2.Text = "" And ComboBox3.Text = "" And ComboBox4.Text = "" Then
                MsgBox("Please enter required fiels")
            Else
                com.Connection = con
                com = New SqlCommand("insert into feescollection(class,section,fees,amount,studentname,date,id)values('" & ComboBox1.Text & "','" & ComboBox3.Text & "','" & ComboBox2.Text & "','" & TextBox1.Text & "','" & ComboBox4.Text & "','" & Today.Date & "','" & Label6.Text & "')", con)
                com.ExecuteNonQuery()
                MsgBox("Added sucessfully")
            End If
        Catch ex As Exception
            MsgBox("" & ex.Message)
        End Try
        con.Close()



        Dim cmd As New SqlCommand
        Dim daa As New SqlDataAdapter
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet

        Try
            con.Open()
            cmd.Connection = con
            da = New SqlDataAdapter("select* from feescollection where id='" & Label6.Text & "'", con)
            cmd.CommandText = "select * from feescollection where id='" & Label6.Text & "'"
            ds = New DataSet()
            da.Fill(ds, "feescollection")
            DataGridView1.DataSource = ds.Tables("feescollection")
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("" & ex.Message)
        End Try
        con.Close()
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Select Case keyData
            Case Keys.F2
                Button2.PerformClick()
            Case Keys.F5
                Button6.PerformClick()
            Case Keys.Escape
                Button7.PerformClick()
            Case Else
                'donothing
        End Select

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub TextBox2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ComboBox3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox3.KeyDown
        If e.KeyData = Keys.Enter Then
            ComboBox2.Focus()
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim da As New SqlDataAdapter
            Dim ds As DataSet
            Dim dt As DataTable
            Dim dr As SqlDataReader
            Dim i As String
            i = Environment.MachineName.ToString

            con.ConnectionString = "Data Source= " & i & "\SQLEXPRESS;Initial Catalog=school;Persist Security Info=True;User ID=Gms;Password=madhavaN"


            'student
            Try
                con.Open()
                cmd.Connection = con
                da = New SqlDataAdapter("select studentname from addmission where class='" & ComboBox1.Text & "' and section='" & ComboBox3.Text & "' ", con)
                cmd.CommandText = "select studentname from addmission where class='" & ComboBox1.Text & "' and section='" & ComboBox3.Text & "'"
                ds = New DataSet()
                da.Fill(ds, "addmission")
                dt = ds.Tables("addmission")
                cmd.ExecuteNonQuery()
                dr = cmd.ExecuteReader()
                While dr.Read()
                    ComboBox4.Items.Add(dr.GetValue(0))
                End While

            Catch ex As Exception
                MsgBox("" & ex.Message & " : " & ex.Source)
            End Try
            con.Close()

        End If
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyData = Keys.Enter Then
            ComboBox4.Focus()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.PrintPreviewDialog1.ShowDialog()


    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim f As Font = New Font("Vanada", 10)
        Dim s As Font = New Font("Vanada", 20)
        Dim z As Font = New Font("Vanada", 15)
        Dim br As SolidBrush = New SolidBrush(Color.Black)
        Dim p As Pen = New Pen(Color.Black)
        Dim wt As Integer = 780
        Dim ht As Integer = 900
        Dim l As Pen
        l = New Pen(Color.Black, 0.025F)

        e.Graphics.DrawRectangle(l, 40.0F, 50.5F, wt, ht) ' border of the table
        e.Graphics.DrawRectangle(l, 40.0F, 50.5F, 780, 150)
        e.Graphics.DrawRectangle(l, 40.0F, 50.5F, 500, 150)
        e.Graphics.DrawString(" " & Label11.Text & " ", s, br, 60, 60)
        e.Graphics.DrawString(" " & Label9.Text & "", z, br, 60, 110)
        e.Graphics.DrawString("  " & Label10.Text & "  ", z, br, 60, 130)
        e.Graphics.DrawString(" Date : ", f, br, 550, 60)
        e.Graphics.DrawString(" " & Today.Date & " ", f, br, 650, 60)
        e.Graphics.DrawString(" Bill No : ", f, br, 550, 160)
        e.Graphics.DrawString(" " & Label6.Text & " ", f, br, 650, 160)
        e.Graphics.DrawString(" Class : ", f, br, 60, 220)
        e.Graphics.DrawString(" " & ComboBox1.Text & " ", f, br, 250, 220)
        e.Graphics.DrawString(" Student Name : ", f, br, 60, 270)
        e.Graphics.DrawString(" " & ComboBox4.Text & " ", f, br, 250, 270)
        e.Graphics.DrawString(" Section : ", f, br, 550, 220)
        e.Graphics.DrawString(" " & ComboBox3.Text & " ", f, br, 650, 220)
        e.Graphics.DrawRectangle(l, 40.0F, 300.5F, 780, 50)
        e.Graphics.DrawRectangle(l, 40.0F, 300.5F, 650, 50)
        e.Graphics.DrawString(" Fees  ", f, br, 240, 320)
        e.Graphics.DrawString(" " & ComboBox2.Text & "", f, br, 60, 420)
        e.Graphics.DrawString(" Amount ", f, br, 750, 320)
        e.Graphics.DrawString(" " & TextBox1.Text & " ", f, br, 750, 420)
        e.Graphics.DrawRectangle(l, 40.0F, 300.5F, 650, 600)
        e.Graphics.DrawRectangle(l, 40.0F, 900.5F, 780, 150)
        e.Graphics.DrawString(" Signature ", f, br, 50, 1020)
        e.Graphics.DrawString(" Seal ", f, br, 750, 1020)
        e.Graphics.DrawRectangle(l, 40.0F, 900.5F, 650, 50)
        e.Graphics.DrawString(" Total ", f, br, 550, 910)
        e.Graphics.DrawString(" " & TextBox1.Text & " ", f, br, 750, 910)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If PrintDialog1.ShowDialog() = DialogResult.OK Then

            PrintDocument1.Print()

        End If
    End Sub

    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Load

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub
End Class