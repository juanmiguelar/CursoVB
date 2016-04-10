Public Class Form1
    Private Sub btnSaludar_Click(sender As Object, e As EventArgs) Handles btnSaludar.Click
        Dim num1 As Integer = txtnum1.Text
        Dim num2 As Integer = txtnum2.Text
        Dim result As Integer = num1 + num2
        MsgBox(result.ToString)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
