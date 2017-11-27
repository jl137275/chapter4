Public Class Form1


    Private Sub btnCalculateResults_Click(sender As Object, e As EventArgs) Handles btnCalculateResults.Click
        Dim dblTime1, dblTime2, dblTime3 As Double

        dblTime1 = txtFinishTime1.Text
        dblTime2 = txtFinishTime2.Text
        dblTime1 = txtFinishTime3.Text

        If dblTime1 < dblTime2 And dblTime1 < dblTime3 Then
            lbl1stPlace.Text = txtRunner1.Text
            If dblTime2 < dblTime3 Then
                lbl2ndPlace.Text = txtRunner2.Text
            ElseIf dblTime3 < dblTime2 Then
                lbl2ndPlace.Text = txtRunner3.Text
                lbl3rdPlace.Text = txtRunner2.Text

            End If
        End If
        If dblTime2 < dblTime1 And dblTime2 < dblTime3 Then
            lbl1stPlace.Text = txtRunner2.Text
            If dblTime1 < dblTime3 Then
                lbl2ndPlace.Text = txtRunner1.Text
                lbl3rdPlace.Text = txtRunner3.Text
            End If
        End If





    End Sub
End Class

