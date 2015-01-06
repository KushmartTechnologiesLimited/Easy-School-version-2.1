Public Class bill_student
    Dim data As New database
    Dim cls As New List(Of String)
    Dim yr, term As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sql1, sql2, sql3
        Dim lev, admn As String
        Dim charge As Integer
        Dim allstudents As DataTable
        Dim sd As Integer


        'sql2 = "SELECT  sum( amount)'Amount'  FROM rates WHERE T_id in(SELECT ID FROM type WHERE category='termly') and `L_id`='" & lev & "'"
        'sql3 = "SELECT  sum( amount)'Amount'  FROM rates WHERE T_id in(SELECT ID FROM type WHERE category='termly') and `L_id`='" & lev & "'"
        If (MsgBox("Bill Students is Not Revesible" + vbCrLf + "Do you want to Continue ?", vbYesNo, "confirmation")) = vbYes Then
            allstudents = data.executeSQL("SELECT admno,` names`,class_code FROM `students` WHERE admno not in (SELECT  `admno` FROM `bill` WHERE `status`=0) and `status`=1 ")
            For Each row As DataRow In allstudents.Rows 'reads throug list of names
                admn = row.Item(0).ToString
                lev = row.Item(2).ToString
                Dim amout As DataTable
                If term = "term 1" Then
                    sql1 = "SELECT  ifnull(sum( amount),0)'Amount'  FROM rates WHERE T_id in(SELECT ID FROM type WHERE category='termly' or `category`='yearly' ) and `L_id`='" & lev & "'"
                Else

                    sql1 = "SELECT  ifnull(sum( amount),0)'Amount'  FROM rates WHERE T_id in(SELECT ID FROM type WHERE category='termly') and `L_id`='" & lev & "'"

                End If
                amout = data.executeSQL(sql1)
                For Each dro As DataRow In amout.Rows ' reads fees
                    charge = dro.Item(0)
                    data.add1("INSERT INTO `schoolfees`.`bill` (`id`, `year`, `term`,`class_Id`, `admno`, `amount`, `status`, `date`) VALUES (NULL, '" & yr & "', '" & term & "','" & lev & "', '" & admn & "', '" & charge & "', '0', CURRENT_TIMESTAMP);")
                Next
                sd = sd + 1
            Next
            Dim sd1 As Integer
            Dim admn1, cash, bill_id, sql11 As String
            Dim std, tras As DataTable
            Dim charge1 As Integer
            std = data.executeSQL("SELECT  admno ,  amount ,  id FROM  bill WHERE  status =0")
            For Each row As DataRow In std.Rows 'reads throug list of names
                admn1 = row.Item(0).ToString
                cash = row.Item(1).ToString
                bill_id = row.Item(2).ToString
                sql11 = "SELECT `Balance`  FROM `fees accounting` WHERE `Status`=0 and `admno`='" & admn1 & "'"
                tras = data.executeSQL(sql11)
                For Each dro As DataRow In tras.Rows ' reads fees
                    charge1 = dro.Item(0)
                Next
                Dim nn As String
                nn = "INSERT INTO schoolfees.`fees accounting` (admno, Details, method, acc_Name, acc_No, Tran_No, Amount, payable, Balance, Status, Datestamp) VALUES ('" & admn1 & "', 'Students billing', 'bill tranfers', 'bills', '', '" & bill_id & "', '" & cash & "', '" & charge1 & "', '" & (cash + charge1) & "', '0', CURRENT_TIMESTAMP);"
                data.add1("UPDATE `fees accounting` SET `Status`=1 WHERE `admno`='" & admn1 & "'")
                data.add1(nn)
                data.add1("UPDATE `bill` SET `status`=1 WHERE `admno`='" & admn1 & "'")
                sd1 = sd1 + 1
            Next
            MsgBox("success" + vbCrLf & sd & " students billed")
        End If


    End Sub
    Sub transfer()
        Dim sd1 As Integer
        Dim admn1, cash, bill_id, sql11 As String
        Dim std, tras As DataTable
        Dim charge1 As Integer
        std = data.executeSQL("SELECT  admno ,  amount ,  id FROM  bill WHERE  status =0")
        For Each row As DataRow In std.Rows 'reads throug list of names
            admn1 = row.Item(0).ToString
            cash = row.Item(1).ToString
            bill_id = row.Item(2).ToString
            sql11 = "SELECT `Balance`  FROM `fees accounting` WHERE `Status`=0 and `admno`='" & admn1 & "'"
            tras = data.executeSQL(sql11)
            For Each dro As DataRow In tras.Rows ' reads fees
                charge1 = dro.Item(0)
                data.add1("INSERT INTO schoolfees.fees accounting ( admno, Details, method, acc_Name, acc_No, Tran_No, Amount, payable, Balance, Status, Datestamp) VALUES ( '" & admn1 & "', '', 'bill tranfers', 'bills', '', '" & bill_id & "', '" & cash & "', '" & charge1 & "', '" & (cash + charge1) & "', '0', CURRENT_TIMESTAMP);")
                data.add1("UPDATE `fees accounting` SET `Status`=1 WHERE `admno`='" & admn1 & "'")
                data.add1("UPDATE `bill` SET `status`=1 WHERE `admno`='" & admn1 & "'")
            Next

            sd1 = sd1 + 1
        Next
    End Sub
    Private Sub bill_student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'collect_fees.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim red As DataTable
        red = data.executeSQL("SELECT admno,` names`,class_code FROM `students` WHERE `status`=1 ")
        DataGridView1.DataSource = red
        DataGridView1.Columns(2).Visible = False
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim dat As String
        dat = (DateTimePicker1.Value.Month)
        yr = (DateTimePicker1.Value.Year)
        If dat >= 1 And dat <= 4 Then
            term = "term 1"
        ElseIf dat >= 5 And dat <= 8 Then
            term = "term 2"
        ElseIf dat >= 9 And dat <= 12 Then
            term = "term 3"
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim sd1 As Integer
        Dim admn1, cash, bill_id, sql11 As String
        Dim std, tras As DataTable
        Dim charge1 As Integer
        std = data.executeSQL("SELECT  admno ,  amount ,  id FROM  bill WHERE  status =0")
        For Each row As DataRow In std.Rows 'reads throug list of names
            admn1 = row.Item(0).ToString
            cash = row.Item(1).ToString
            bill_id = row.Item(2).ToString
            sql11 = "SELECT `Balance`  FROM `fees accounting` WHERE `Status`=0 and `admno`='" & admn1 & "'"
            tras = data.executeSQL(sql11)
            For Each dro As DataRow In tras.Rows ' reads fees
                charge1 = dro.Item(0)
            Next
            Dim nn As String
            nn = "INSERT INTO schoolfees.`fees accounting` (admno, Details, method, acc_Name, acc_No, Tran_No, Amount, payable, Balance, Status, Datestamp) VALUES ('" & admn1 & "', '', 'bill tranfers', 'bills', '', '" & bill_id & "', '" & cash & "', '" & charge1 & "', '" & (cash + charge1) & "', '0', CURRENT_TIMESTAMP);"
            data.add1("UPDATE `fees accounting` SET `Status`=1 WHERE `admno`='" & admn1 & "'")
            data.add1(nn)
            data.add1("UPDATE `bill` SET `status`=1 WHERE `admno`='" & admn1 & "'")
            sd1 = sd1 + 1
        Next
        MsgBox("success" + vbCrLf & sd1 & " students billed")
    End Sub
End Class