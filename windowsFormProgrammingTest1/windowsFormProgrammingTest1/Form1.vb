Public Class Form1

    Dim num1 As Integer = Nothing
    Dim num2 As Integer = Nothing

    Private Sub numInput1_TextChanged(sender As System.Object, e As System.EventArgs) Handles numInput1.TextChanged
        num1 = Integer.Parse(numInput1.Text)
    End Sub

    Private Sub numInput2_TextChanged(sender As System.Object, e As System.EventArgs) Handles numInput2.TextChanged
        num2 = Integer.Parse(numInput2.Text)
    End Sub

    Private Sub Operator_Btn_Click(sender As System.Object, e As System.EventArgs) Handles btnSubtract.Click, btnMultiply.Click, btnDivide.Click, btnAdd.Click
        If sender Is btnAdd Then MessageBox.Show(num1 + num2)
        If sender Is btnSubtract Then MessageBox.Show(num1 - num2)
        If sender Is btnDivide Then MessageBox.Show(num1 / num2)
        If sender Is btnMultiply Then MessageBox.Show(num1 * num2)
    End Sub
End Class
