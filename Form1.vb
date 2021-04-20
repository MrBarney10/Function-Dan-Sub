Public Class Form1
    Private Sub btnSubmit1_Click(sender As Object, e As EventArgs) Handles btnsubmit1.Click
        lblText1.Text = "Hello"
    End Sub

    Private Sub btnSubmit2_Click(sender As Object, e As EventArgs) Handles btnSubmit2.Click
        Dim strText As String
        strText = txtBox1.Text
        lblText2.Text = strText
    End Sub

    Private Function btnSubmit3_Click(sender As Object, e As EventArgs) Handles btnSubmit3.Click
        lblText3.Text = "Hello"
        Return lblText3
    End Function

    Private Function btnSubmit4_Click(sender As Object, e As EventArgs) Handles btnSubmit4.Click
        Dim strText2 As String
        strText2 = txtBox2.Text
        lblText4.Text = strText2
        Return lblText4
    End Function
End Class