Public Class profile
    Dim data As New database

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        On Error Resume Next
        Dim red, fred, mred As DataTable
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox7.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox9.Text = ""
        TextBox8.Text = ""
        TextBox28.Text = ""
        TextBox27.Text = ""
        TextBox11.Text = ""
        TextBox10.Text = ""
        TextBox13.Text = ""
        TextBox12.Text = ""
        'TextBox15.Text = .Item(4)
        TextBox14.Text = ""
        TextBox17.Text = ""
        TextBox16.Text = ""
        TextBox25.Text = ""
        TextBox24.Text = ""
        TextBox23.Text = ""
        TextBox22.Text = ""
        'TextBox15.Text = .Item(4)
        TextBox20.Text = ""
        TextBox19.Text = ""
        TextBox18.Text = ""

        red = data.executeSQL("SELECT  `admno`, ` names`, `gender`, `DOB`, `Birthno`  , (SELECT  class.description FROM class WHERE class.code=`class_code`),(SELECT  stream.name FROM stream WHERE stream.code=str_code ),  `adm_date` ,  `status` FROM  `students` WHERE admno= '" & TextBox26.Text & "'")
        For Each fd As DataRow In red.Rows
            With fd
                TextBox1.Text = .Item(0)
                TextBox2.Text = .Item(1)
                TextBox7.Text = .Item(2)
                TextBox3.Text = .Item(3)
                TextBox4.Text = .Item(4)
                TextBox9.Text = .Item(5)
                TextBox8.Text = .Item(6)
                TextBox28.Text = .Item(7)
                If .Item(8) = 1 Then
                    TextBox27.Text = "Active"
                    TextBox27.ForeColor = Color.Green
                ElseIf .Item(8) = 0 Then
                    TextBox27.Text = "De Active"
                    TextBox27.ForeColor = Color.Red
                Else
                    TextBox27.Text = ""
                    TextBox27.BackColor = Color.Orange
                End If

            End With
        Next
        mred = data.executeSQL("SELECT `f_id_no`, `names`, `tel`, `email`, `work`, `employer`, `resident_id` FROM `father` WHERE `f_id_no` in (SELECT `f_id_no` FROM `parents` WHERE`admno`='" & TextBox26.Text & "')")
        For Each fdm As DataRow In mred.Rows

            With fdm
                TextBox25.Text = .Item(1)
                TextBox24.Text = .Item(0)
                TextBox23.Text = .Item(2)
                TextBox22.Text = .Item(3)
                'TextBox15.Text = .Item(4)
                TextBox20.Text = .Item(4)
                TextBox19.Text = .Item(5)
                TextBox18.Text = .Item(6)
            End With
        Next
        fred = data.executeSQL("SELECT `Id_No`, `names`, `tel`, `email`, `work`, `employer`, `resident_id` FROM `mother` WHERE `Id_No` in (SELECT `id_no` FROM `parents` WHERE`admno`='" & TextBox26.Text & "')")
        For Each fdm1 As DataRow In fred.Rows

            With fdm1
                TextBox11.Text = .Item(1)
                TextBox10.Text = .Item(0)
                TextBox13.Text = .Item(2)
                TextBox12.Text = .Item(3)
                'TextBox15.Text = .Item(4)
                TextBox14.Text = .Item(4)
                TextBox17.Text = .Item(5)
                TextBox16.Text = .Item(6)
            End With
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm1 As New mdparent
        frm1.table = "mother"
        frm1.id = TextBox10.Text
        frm1.ShowDialog()
        Dim fred As New DataTable
        fred = data.executeSQL("SELECT `Id_No`, `names`, `tel`, `email`, `work`, `employer`, `resident_id` FROM `mother` WHERE `Id_No` in (SELECT `id_no` FROM `parents` WHERE`admno`='" & TextBox26.Text & "')")
        For Each fdm1 As DataRow In fred.Rows

            With fdm1
                TextBox11.Text = .Item(1)
                TextBox10.Text = .Item(0)
                TextBox13.Text = .Item(2)
                TextBox12.Text = .Item(3)
                'TextBox15.Text = .Item(4)
                TextBox14.Text = .Item(4)
                TextBox17.Text = .Item(5)
                TextBox16.Text = .Item(6)
            End With
        Next
    End Sub

   
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm As New mdparent
        Dim mred As DataTable
        frm.table = "father"
        frm.id = TextBox24.Text
        frm.ShowDialog()
        mred = data.executeSQL("SELECT `f_id_no`, `names`, `tel`, `email`, `work`, `employer`, `resident_id` FROM `father` WHERE `f_id_no` in (SELECT `f_id_no` FROM `parents` WHERE`admno`='" & TextBox26.Text & "')")
        For Each fdm As DataRow In mred.Rows

            With fdm
                TextBox25.Text = .Item(1)
                TextBox24.Text = .Item(0)
                TextBox23.Text = .Item(2)
                TextBox22.Text = .Item(3)
                'TextBox15.Text = .Item(4)
                TextBox20.Text = .Item(4)
                TextBox19.Text = .Item(5)
                TextBox18.Text = .Item(6)
            End With
        Next

    End Sub
  
    Private Sub profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button9.PerformClick()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim edi As New edit_students
        edi.TextBox1.Text = TextBox1.Text
        edi.ShowDialog()
        Button9.PerformClick()
    End Sub

    Private Sub TextBox26_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox26.KeyPress
        Dim val As New validate
        val.digits(sender, e)
    End Sub

    Private Sub TextBox26_TextChanged(sender As Object, e As EventArgs) Handles TextBox26.TextChanged

    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub
End Class