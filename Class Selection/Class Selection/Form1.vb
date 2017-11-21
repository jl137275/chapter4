Public Class Form1


    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim dblCheeseburger As Double = 6.99
        Dim dblHotdog As Double = 5.99
        Dim dblPattyMelt As Double = 7.5
        Dim dblChickenSandwich As Double = 7.5
        Dim dblKetchup As Double = 0.5
        Dim dblMustard As Double = 0.5
        Dim dblPickles As Double = 0.5
        Dim dblOnions As Double = 0.5
        Dim dblFries As Double = 1.99
        Dim dblOnionRings As Double = 2.99
        Dim dblMashedPotatoes As Double = 2.99
        Dim total As Double
        If rdCheesburger.Checked = True Then
            lblResult.Text = "You selected Cheese Burger"
            total = dblCheeseburger + total
        ElseIf rdHotdog.Checked = True Then
            lblResult.Text = "You selected Hotdog"
            total = dblHotdog + total
        ElseIf rdPattyMelt.Checked = True Then
            lblResult.Text = "You selected Patty Melt"
            total = dblPattyMelt + total
        ElseIf rdChickenSandwich.Checked = True Then
            lblResult.Text = "You selected Chicken Sandwich"
            total = dblChickenSandwich + total
        End If

        If chkKetchup.Checked = True Then
            lblResult.Text &= ", and Ketchup"
            total = dblKetchup + total
        End If
        If chkMustard.Checked = True Then
            lblResult.Text &= ", and Mustard"
            total = dblMustard + total
        End If
        If chkPickles.Checked = True Then
            lblResult.Text &= ", and Pickeles"
            total = dblPickles + total
        End If
        If chkOnions.Checked = True Then
            lblResult.Text &= ", and Onions"
            total = dblOnions + total
        End If
        If rdFries.Checked = True Then
            lblResult.Text &= ", and a side of Fries"
            total = dblFries + total
        ElseIf rdOnionRings.Checked = True Then
            lblResult.Text &= ", and a side of Onion Rings"
            total = dblOnionRings + total
        ElseIf rdMashedPotatoes.Checked = True Then
            lblResult.Text &= ", and a side of Mashed Potatoes"
            total = dblMashedPotatoes + total
        End If
        lblTotal.Text = total.ToString("c")
    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
