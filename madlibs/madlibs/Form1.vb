Public Class Form1

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim strInput As String

        If strInput = listColor.SelectedIndex = -1 Then
            MessageBox.Show("Select a Color.")
        ElseIf listEst.SelectedIndex = -1 Then

        End If
        strInput = "The " & listColor.SelectedItem.ToString() & " Dragon is the " & listEst.SelectedItem.ToString() &
            " Dragon of all. It has " & listNumber.SelectedItem.ToString() & " " & listBodyPart.SelectedItem.ToString() & ", and a " & listAnimal.SelectedItem.ToString() & " shaped like a " & listNoun.SelectedItem.ToString() &
            ". It loves to eat " & listPluralNoun.SelectedItem.ToString() & ", although it will feast on nearly anything"


        MessageBox.Show(strInput)
    End Sub
End Class
