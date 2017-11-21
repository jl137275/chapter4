<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdCheesburger = New System.Windows.Forms.RadioButton()
        Me.rdHotdog = New System.Windows.Forms.RadioButton()
        Me.rdPattyMelt = New System.Windows.Forms.RadioButton()
        Me.rdChickenSandwich = New System.Windows.Forms.RadioButton()
        Me.chkKetchup = New System.Windows.Forms.CheckBox()
        Me.chkMustard = New System.Windows.Forms.CheckBox()
        Me.chkPickles = New System.Windows.Forms.CheckBox()
        Me.chkOnions = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rdFries = New System.Windows.Forms.RadioButton()
        Me.rdOnionRings = New System.Windows.Forms.RadioButton()
        Me.rdMashedPotatoes = New System.Windows.Forms.RadioButton()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdChickenSandwich)
        Me.GroupBox1.Controls.Add(Me.rdPattyMelt)
        Me.GroupBox1.Controls.Add(Me.rdHotdog)
        Me.GroupBox1.Controls.Add(Me.rdCheesburger)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 200)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Your Meal"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkOnions)
        Me.GroupBox2.Controls.Add(Me.chkPickles)
        Me.GroupBox2.Controls.Add(Me.chkMustard)
        Me.GroupBox2.Controls.Add(Me.chkKetchup)
        Me.GroupBox2.Location = New System.Drawing.Point(409, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 200)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select Toppings"
        '
        'rdCheesburger
        '
        Me.rdCheesburger.AutoSize = True
        Me.rdCheesburger.Location = New System.Drawing.Point(17, 37)
        Me.rdCheesburger.Name = "rdCheesburger"
        Me.rdCheesburger.Size = New System.Drawing.Size(91, 17)
        Me.rdCheesburger.TabIndex = 0
        Me.rdCheesburger.TabStop = True
        Me.rdCheesburger.Text = "Cheeseburger"
        Me.rdCheesburger.UseVisualStyleBackColor = True
        '
        'rdHotdog
        '
        Me.rdHotdog.AutoSize = True
        Me.rdHotdog.Location = New System.Drawing.Point(17, 81)
        Me.rdHotdog.Name = "rdHotdog"
        Me.rdHotdog.Size = New System.Drawing.Size(60, 17)
        Me.rdHotdog.TabIndex = 1
        Me.rdHotdog.TabStop = True
        Me.rdHotdog.Text = "Hotdog"
        Me.rdHotdog.UseVisualStyleBackColor = True
        '
        'rdPattyMelt
        '
        Me.rdPattyMelt.AutoSize = True
        Me.rdPattyMelt.Location = New System.Drawing.Point(17, 129)
        Me.rdPattyMelt.Name = "rdPattyMelt"
        Me.rdPattyMelt.Size = New System.Drawing.Size(72, 17)
        Me.rdPattyMelt.TabIndex = 2
        Me.rdPattyMelt.TabStop = True
        Me.rdPattyMelt.Text = "Patty Melt"
        Me.rdPattyMelt.UseVisualStyleBackColor = True
        '
        'rdChickenSandwich
        '
        Me.rdChickenSandwich.AutoSize = True
        Me.rdChickenSandwich.Location = New System.Drawing.Point(17, 167)
        Me.rdChickenSandwich.Name = "rdChickenSandwich"
        Me.rdChickenSandwich.Size = New System.Drawing.Size(114, 17)
        Me.rdChickenSandwich.TabIndex = 3
        Me.rdChickenSandwich.TabStop = True
        Me.rdChickenSandwich.Text = "Chicken Sandwich"
        Me.rdChickenSandwich.UseVisualStyleBackColor = True
        '
        'chkKetchup
        '
        Me.chkKetchup.AutoSize = True
        Me.chkKetchup.Location = New System.Drawing.Point(24, 37)
        Me.chkKetchup.Name = "chkKetchup"
        Me.chkKetchup.Size = New System.Drawing.Size(66, 17)
        Me.chkKetchup.TabIndex = 0
        Me.chkKetchup.Text = "Ketchup"
        Me.chkKetchup.UseVisualStyleBackColor = True
        '
        'chkMustard
        '
        Me.chkMustard.AutoSize = True
        Me.chkMustard.Location = New System.Drawing.Point(24, 81)
        Me.chkMustard.Name = "chkMustard"
        Me.chkMustard.Size = New System.Drawing.Size(64, 17)
        Me.chkMustard.TabIndex = 1
        Me.chkMustard.Text = "Mustard"
        Me.chkMustard.UseVisualStyleBackColor = True
        '
        'chkPickles
        '
        Me.chkPickles.AutoSize = True
        Me.chkPickles.Location = New System.Drawing.Point(24, 129)
        Me.chkPickles.Name = "chkPickles"
        Me.chkPickles.Size = New System.Drawing.Size(60, 17)
        Me.chkPickles.TabIndex = 2
        Me.chkPickles.Text = "Pickles"
        Me.chkPickles.UseVisualStyleBackColor = True
        '
        'chkOnions
        '
        Me.chkOnions.AutoSize = True
        Me.chkOnions.Location = New System.Drawing.Point(24, 168)
        Me.chkOnions.Name = "chkOnions"
        Me.chkOnions.Size = New System.Drawing.Size(59, 17)
        Me.chkOnions.TabIndex = 3
        Me.chkOnions.Text = "Onions"
        Me.chkOnions.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdMashedPotatoes)
        Me.GroupBox3.Controls.Add(Me.rdOnionRings)
        Me.GroupBox3.Controls.Add(Me.rdFries)
        Me.GroupBox3.Location = New System.Drawing.Point(422, 233)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Side Order"
        '
        'rdFries
        '
        Me.rdFries.AutoSize = True
        Me.rdFries.Location = New System.Drawing.Point(3, 16)
        Me.rdFries.Name = "rdFries"
        Me.rdFries.Size = New System.Drawing.Size(47, 17)
        Me.rdFries.TabIndex = 0
        Me.rdFries.TabStop = True
        Me.rdFries.Text = "Fries"
        Me.rdFries.UseVisualStyleBackColor = True
        '
        'rdOnionRings
        '
        Me.rdOnionRings.AutoSize = True
        Me.rdOnionRings.Location = New System.Drawing.Point(6, 42)
        Me.rdOnionRings.Name = "rdOnionRings"
        Me.rdOnionRings.Size = New System.Drawing.Size(83, 17)
        Me.rdOnionRings.TabIndex = 1
        Me.rdOnionRings.TabStop = True
        Me.rdOnionRings.Text = "Onion Rings"
        Me.rdOnionRings.UseVisualStyleBackColor = True
        '
        'rdMashedPotatoes
        '
        Me.rdMashedPotatoes.AutoSize = True
        Me.rdMashedPotatoes.Location = New System.Drawing.Point(6, 65)
        Me.rdMashedPotatoes.Name = "rdMashedPotatoes"
        Me.rdMashedPotatoes.Size = New System.Drawing.Size(108, 17)
        Me.rdMashedPotatoes.TabIndex = 2
        Me.rdMashedPotatoes.TabStop = True
        Me.rdMashedPotatoes.Text = "Mashed Potatoes"
        Me.rdMashedPotatoes.UseVisualStyleBackColor = True
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(14, 310)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 3
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(111, 310)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(29, 215)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(209, 43)
        Me.lblResult.TabIndex = 4
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(29, 269)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(216, 23)
        Me.lblTotal.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 345)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Class Selection"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdChickenSandwich As System.Windows.Forms.RadioButton
    Friend WithEvents rdPattyMelt As System.Windows.Forms.RadioButton
    Friend WithEvents rdHotdog As System.Windows.Forms.RadioButton
    Friend WithEvents rdCheesburger As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkOnions As System.Windows.Forms.CheckBox
    Friend WithEvents chkPickles As System.Windows.Forms.CheckBox
    Friend WithEvents chkMustard As System.Windows.Forms.CheckBox
    Friend WithEvents chkKetchup As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rdMashedPotatoes As System.Windows.Forms.RadioButton
    Friend WithEvents rdOnionRings As System.Windows.Forms.RadioButton
    Friend WithEvents rdFries As System.Windows.Forms.RadioButton
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label

End Class
