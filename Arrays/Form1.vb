Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 3 = cantidad de espacios
        Dim array(3) As String
        array(0) = "Hello"
        array(1) = "Code"
        array(2) = ":D"

        MsgBox(array(0) + " " + array(1) + " " + array(2))

        Dim array2() As Integer
        array2 = New Integer() {1, 2, 3}

        MsgBox(array2(0).ToString + " " + array2(1).ToString + " " + array2(2).ToString)

        ' Redimensionar array y preservar algunos datos
        ReDim Preserve array2(2)
        MsgBox(array2(0).ToString + " " + array2(1).ToString)

        ' Redimensionar array y sin preservar datos
        ReDim array2(2)
        MsgBox(array2(0).ToString + " " + array2(1).ToString)

        ' Arreglo multidimensional
        Dim matrix(,) As Integer = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}}
        MsgBox(matrix(1, 2).ToString)
    End Sub
End Class
