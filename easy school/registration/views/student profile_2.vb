Public Class student_profile
    Dim data As New database
    Dim sql1, sql2, sql3, sql4, sql5 As String
    'sql1  students data
    'sql2  mothers data
    'sql3  fathers data
    'sqld  class data
    'sql5 paretnts sql
    '*******************************************
    '   *_______________________________________________*
    Private Structure strparents
        Public idm As String
        Public names As String
        Public tel As String
        Public email As String
        Public work As String
        Public employer As String
        Public resident As String
    End Structure

    Private Sub loadd(ByVal admno As String)
        TextBox17.Text = ""
        TextBox16.Text = ""
        TextBox19.Text = ""
        TextBox18.Text = ""
        sql1 = "SELECT `admno`,`names`, `gender`, `Birthno`,  `pic`, `status` FROM `students` where `admno`= " & admno
        Dim red As Data.DataTable
        Dim drow As DataRow
        Dim pss As New strparents
        red = data.executeSQL(sql1)
        For Each drow In red.Rows
            TextBox17.Text = drow.Item(0).ToString.ToUpper
            TextBox16.Text = drow.Item(1).ToString.ToUpper
            TextBox19.Text = drow.Item(3).ToString.ToUpper
            TextBox18.Text = drow.Item(4).ToString.ToUpper
            Dim sta As Integer
            sta = drow.Item(5)
            ' TextBox17.Text = drow.Item(5).ToString.ToUpper adm date
            '   TextBox17.Text = drow.Item(6).ToString.ToUpper  pic
            If sta = 1 Then
                With Label1
                    .Text = "ACTIVE"
                    .BackColor = Color.Green
                End With
                Button8.Text = "Delete"
            Else
                With Label1
                    .Text = "DEACTIVE"
                    .BackColor = Color.Red
                End With
                Button8.Text = "Activate"
            End If
        Next
    End Sub  'students information
    Sub mother(ByVal admno As String)
        Dim red As Data.DataTable
        Dim drow As DataRow
        Dim pss As New strparents
        red = data.executeSQL("SELECT `mother`.`Id_No`, `mother`.`names`, `mother`.`tel`, `mother`.`email`, `mother`.`work`, `mother`.`employer`, `mother`.`Resident_id`,`parents`.`admno`  FROM `mother`,`parents` WHERE  `mother`.`id_no`= `parents`.`id_no` and `parents`.`admno`=" & admno)
        For Each drow In red.Rows

            pss.idm = drow.Item(0).ToString.ToUpper.ToUpper
            pss.names = drow.Item(1).ToString.ToUpper
            pss.tel = drow.Item(2).ToString.ToUpper
            pss.email = drow.Item(3).ToString.ToUpper
            pss.work = drow.Item(4).ToString.ToUpper
            pss.employer = drow.Item(5).ToString.ToUpper
            pss.resident = drow.Item(6).ToString.ToUpper

        Next
        With pss
            TextBox7.Text = .names
            TextBox13.Text = .idm
            TextBox11.Text = .tel
            TextBox21.Text = .email
            TextBox8.Text = .work
            TextBox9.Text = .employer
            TextBox12.Text = .resident

        End With
    End Sub  'mothers details
    Sub father(ByVal admno As String)
        Dim red As Data.DataTable
        Dim drow As DataRow
        Dim pss As New strparents
        red = data.executeSQL("SELECT `father`.`f_Id_No`, `father`.`names`, `father`.`tel`, `father`.`email`, `father`.`work`, `father`.`employer`, `father`.`Resident_id`,`parents`.`admno`  FROM `father`,`parents` WHERE  `father`.`f_id_no`= `parents`.`f_id_no` and `parents`.`admno`=" & admno)
        For Each drow In red.Rows
            pss.idm = drow.Item(0).ToString.ToUpper.ToUpper
            pss.names = drow.Item(1).ToString.ToUpper
            pss.tel = drow.Item(2).ToString.ToUpper
            pss.email = drow.Item(3).ToString.ToUpper
            pss.work = drow.Item(4).ToString.ToUpper
            pss.employer = drow.Item(5).ToString.ToUpper
            pss.resident = drow.Item(6).ToString.ToUpper
        Next
        With pss
            TextBox10.Text = .names
            TextBox1.Text = .idm
            TextBox4.Text = .tel
            TextBox2.Text = .email
            TextBox6.Text = .work
            TextBox5.Text = .employer
            TextBox3.Text = .resident

        End With
    End Sub   'fathers details

    Sub alldata(ByVal admno As String)
        loadd(admno)
        father(admno)
        mother(admno)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        alldata(TextBox14.Text)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim frm1 As New mdparent
        frm1.table = "mother"
        frm1.id = TextBox13.Text
        frm1.ShowDialog()
        Button11.PerformClick()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim frm As New mdparent
        frm.table = "father"
        frm.id = TextBox1.Text
        frm.ShowDialog()
        Button11.PerformClick()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class