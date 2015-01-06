Public Class mdparent
    Public table, id As String
    Dim data As New database
    Private Structure strparents
        Public idm As String
        Public names As String
        Public tel As String
        Public email As String
        Public work As String
        Public employer As String
        Public resident As String
    End Structure
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("are you sure you want to edit this detais", MsgBoxStyle.Information + vbYesNo, "confirm") = MsgBoxResult.Yes Then
            updatedetails()
            MsgBox("results updated", , "confirmed")
        Else
            Exit Sub
        End If

    End Sub
    Sub updatedetails()
        Dim das As strparents
        das.idm = TextBox13.Text
        das.names = TextBox7.Text
        das.tel = TextBox11.Text
        das.email = TextBox21.Text
        das.work = TextBox8.Text
        das.employer = TextBox9.Text
        das.resident = TextBox12.Text

        Dim fsql, msql As String
        With das
            If table = "father" Then
                fsql = "UPDATE `father` SET `names`='" & .names & "',`tel`='" & .tel & "',`email`='" & .email & "',`work`='" & .work & "',`employer`='" & .employer & "',`Resident_id`='" & .resident & "' WHERE `f_Id_No`=" & .idm
                data.executeSQL(fsql)
            ElseIf table = "mother" Then
                msql = "UPDATE `mother` SET `names`='" & .names & "',`tel`='" & .tel & "',`email`='" & .email & "',`work`='" & .work & "',`employer`='" & .employer & "',`Resident_id`='" & .resident & "' WHERE `Id_No`=" & .idm
                data.executeSQL(msql)
            End If
        End With
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub


    Private Sub mdparent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = Me.table.ToUpper & "'S DETAILS"
        selectcase(table)

    End Sub
    Sub selectcase(ByVal tabl As String)
        Dim vsql As String
        Select Case tabl
            Case Is = "mother"
                vsql = "SELECT `mother`.`Id_No`, `mother`.`names`, `mother`.`tel`, `mother`.`email`, `mother`.`work`, `mother`.`employer`, `mother`.`Resident_id` FROM `mother` WHERE  `mother`.`id_no`=" & id
                father(vsql)
            Case Is = "father"
                vsql = "SELECT `father`.`f_Id_No`, `father`.`names`, `father`.`tel`, `father`.`email`, `father`.`work`, `father`.`employer`, `father`.`Resident_id`  FROM `father` WHERE  `father`.`f_id_no`= " & id
                father(vsql)
        End Select

    End Sub
    Sub father(ByVal admno As String)
        Dim red As Data.DataTable
        Dim drow As DataRow
        Dim pss As New strparents
        red = data.executeSQL(admno)
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
    End Sub
End Class