Public Class Form1


    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If txtPassword.Text = "cubs suck" Then
            MessageBox.Show("Hello")
        Else
            MessageBox.Show("Try again")
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPassword.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
