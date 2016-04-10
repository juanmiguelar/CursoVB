Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim number As Integer = 1
        MsgBox(number)

        Dim numberD As Double = 123.123
        MsgBox(numberD)

        Dim txt As String = "Hola"
        MsgBox(txt)

        Dim today As Date = "09-04-16"
        MsgBox(today)

        today = "09-JAN-2016"
        MsgBox(today)
    End Sub
End Class
