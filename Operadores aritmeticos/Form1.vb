Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim num1, num2, operation As Integer
        num1 = 2
        num2 = 5
        operation = num1 + num2

        MsgBox(operation.ToString)
    End Sub
End Class
