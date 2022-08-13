Public Class Calculator

    Dim num1 As Double = Nothing
    Dim num2 As Double = Nothing
    Dim oper As String = Nothing

    Private Sub Btn_Num_Click(sender As System.Object, e As System.EventArgs) Handles zero_Button.Click, two_Button.Click, three_Button.Click, six_Button.Click, seven_Button.Click, one_Button.Click, nine_Button.Click, four_Button.Click, five_Button.Click, eight_Button.Click, decimal_Button.Click
        If sender Is one_Button Then displayTextbox.Text = displayTextbox.Text + "1"
        If sender Is two_Button Then displayTextbox.Text = displayTextbox.Text + "2"
        If sender Is three_Button Then displayTextbox.Text = displayTextbox.Text + "3"
        If sender Is four_Button Then displayTextbox.Text = displayTextbox.Text + "4"
        If sender Is five_Button Then displayTextbox.Text = displayTextbox.Text + "5"
        If sender Is six_Button Then displayTextbox.Text = displayTextbox.Text + "6"
        If sender Is seven_Button Then displayTextbox.Text = displayTextbox.Text + "7"
        If sender Is eight_Button Then displayTextbox.Text = displayTextbox.Text + "8"
        If sender Is nine_Button Then displayTextbox.Text = displayTextbox.Text + "9"
        If sender Is zero_Button Then displayTextbox.Text = displayTextbox.Text + "0"
        If sender Is decimal_Button Then displayTextbox.Text = displayTextbox.Text + "."
    End Sub

    Private Sub Oper_Click(sender As System.Object, e As System.EventArgs) Handles sub_Button.Click, multiply_Button.Click, mod_Button.Click, divide_Button.Click, add_Button.Click
        If sender Is add_Button Then oper = "+"
        If sender Is sub_Button Then oper = "-"
        If sender Is divide_Button Then oper = "/"
        If sender Is multiply_Button Then oper = "*"
        If sender Is mod_Button Then oper = "%"
        num1 = displayTextbox.Text
        displayTextbox.Text = ""
    End Sub

    Private Sub equal_Button_Click(sender As System.Object, e As System.EventArgs) Handles equal_Button.Click
        num2 = displayTextbox.Text
        Select Case oper
            Case "+"
                displayTextbox.Text = num1 + num2
            Case "-"
                displayTextbox.Text = num1 - num2
            Case "/"
                displayTextbox.Text = num1 / num2
            Case "*"
                displayTextbox.Text = num1 * num2
            Case "%"
                displayTextbox.Text = num1 Mod num2
        End Select
    End Sub

    Private Sub square_Button_Click(sender As System.Object, e As System.EventArgs) Handles square_Button.Click
        displayTextbox.Text = displayTextbox.Text ^ 2
    End Sub

    Private Sub sqrt_Button_Click(sender As System.Object, e As System.EventArgs) Handles sqrt_Button.Click
        displayTextbox.Text = Math.Sqrt(displayTextbox.Text)
    End Sub

    Private Sub oneBy_Button_Click(sender As System.Object, e As System.EventArgs) Handles oneBy_Button.Click
        displayTextbox.Text = 1 / displayTextbox.Text
    End Sub

    Private Sub backspace_Button_Click(sender As System.Object, e As System.EventArgs) Handles backspace_Button.Click
        If displayTextbox.Text.Length > 0 Then
            displayTextbox.Text = displayTextbox.Text.Remove(displayTextbox.Text.Length - 1, 1)
        End If
    End Sub

    Private Sub clear_Button_Click(sender As System.Object, e As System.EventArgs) Handles clear_Button.Click
        displayTextbox.Clear()
    End Sub
End Class
