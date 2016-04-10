Public Class Form1

    Dim num1 As Integer
    Dim num2 As Integer
    Dim result As Boolean


    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click
        Me.obtener()
        result = (num1 = num2)
        MsgBox(result.ToString)
    End Sub

    Private Sub btnMayorQue_Click(sender As Object, e As EventArgs) Handles btnMayorQue.Click
        Me.obtener()
        result = (num1 < num2)
        MsgBox(result.ToString)
    End Sub

    Private Sub btnMenorQue_Click(sender As Object, e As EventArgs) Handles btnMenorQue.Click
        Me.obtener()
        result = (num1 > num2)
        MsgBox(result.ToString)
    End Sub

    Private Sub btnMayorIgual_Click(sender As Object, e As EventArgs) Handles btnMayorIgual.Click
        Me.obtener()
        result = (num1 <= num2)
        MsgBox(result.ToString)
    End Sub

    Private Sub btnMenorIgual_Click(sender As Object, e As EventArgs) Handles btnMenorIgual.Click
        Me.obtener()
        result = (num1 >= num2)
        MsgBox(result.ToString)
    End Sub

    Private Sub btnDiferente_Click(sender As Object, e As EventArgs) Handles btnDiferente.Click
        Me.obtener()
        result = (num1 <> num2)
        MsgBox(result.ToString)
    End Sub

    Private Sub obtener()
        Me.num1 = txtnum1.Text
        Me.num2 = txtnum2.Text
    End Sub
End Class
