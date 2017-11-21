Public Class Form1

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        If txtDecimalInteger.Text = 1 Then
            lblRomanNumeral.Text = "I"
        ElseIf txtDecimalInteger.Text = 2 Then
            lblRomanNumeral.Text = "II"
        ElseIf txtDecimalInteger.Text = 3 Then
            lblRomanNumeral.Text = "III"
        ElseIf txtDecimalInteger.Text = 4 Then
            lblRomanNumeral.Text = "IV"
        ElseIf txtDecimalInteger.Text = 5 Then
            lblRomanNumeral.Text = "V"
        ElseIf txtDecimalInteger.Text = 6 Then
            lblRomanNumeral.Text = "VI"
        ElseIf txtDecimalInteger.Text = 7 Then
            lblRomanNumeral.Text = "VII"
        ElseIf txtDecimalInteger.Text = 8 Then
            lblRomanNumeral.Text = "VIII"
        ElseIf txtDecimalInteger.Text = 9 Then
            lblRomanNumeral.Text = "IX"
        ElseIf txtDecimalInteger.Text = 10 Then
            lblRomanNumeral.Text = "X"
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
