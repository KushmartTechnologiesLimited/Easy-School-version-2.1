Imports System.Text.RegularExpressions
Imports System.Net.Mail

Public Class validate
    Public Function digits(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        sender.MaxLength = 8
        Try
            If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Or (InStr(sender.text, ".") > 0 And e.KeyChar = Microsoft.VisualBasic.Chr(46)) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return vbNull
    End Function
    Public Function digits_phone(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        sender.MaxLength = 10
        Try
            If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Or (InStr(sender.text, ".") > 0 Or (InStr(sender.text, "+") > 0 And e.KeyChar = Microsoft.VisualBasic.Chr(43))) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return vbNull
    End Function
    Public Function alphasnumerical(ByVal texts As String)
        If Not Regex.Match(texts, "^[a-zA-Z0-9]*$", RegexOptions.IgnoreCase).Success Then
            MsgBox("Please enter alpha text only.")
            Return False
        End If
        Return True
    End Function
    Public Function alphas(ByVal texts As String)
        If Not Regex.Match(texts, "^[a-z]*$", RegexOptions.IgnoreCase).Success Then
            MsgBox("Please enter alpha text only.")
            Return False
        End If
        Return True
    End Function
    Public Function emails(ByVal sender As Object)
        Dim rEMail As New System.Text.RegularExpressions.Regex("^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$")
        If sender.Text.Length > 0 Then
            If Not rEMail.IsMatch(sender.Text) Then
                MessageBox.Show("invalid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                '' Timer1.Enabled = True
                sender.SelectAll()
            End If
        End If
    End Function


End Class
