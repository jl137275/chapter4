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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRunner2 = New System.Windows.Forms.TextBox()
        Me.txtRunner1 = New System.Windows.Forms.TextBox()
        Me.txtRunner3 = New System.Windows.Forms.TextBox()
        Me.txtFinishTime2 = New System.Windows.Forms.TextBox()
        Me.txtFinishTime1 = New System.Windows.Forms.TextBox()
        Me.txtFinishTime3 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl2ndPlace = New System.Windows.Forms.Label()
        Me.lbl3rdPlace = New System.Windows.Forms.Label()
        Me.lbl1stPlace = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCalculateResults = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(414, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter the three runners' names and finishing times"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(158, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(295, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 26)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Finishing Time" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(in seconds)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Runner 1:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Runner 2:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Runner 3:"
        '
        'txtRunner2
        '
        Me.txtRunner2.Location = New System.Drawing.Point(121, 133)
        Me.txtRunner2.Name = "txtRunner2"
        Me.txtRunner2.Size = New System.Drawing.Size(100, 20)
        Me.txtRunner2.TabIndex = 6
        '
        'txtRunner1
        '
        Me.txtRunner1.Location = New System.Drawing.Point(121, 98)
        Me.txtRunner1.Name = "txtRunner1"
        Me.txtRunner1.Size = New System.Drawing.Size(100, 20)
        Me.txtRunner1.TabIndex = 7
        '
        'txtRunner3
        '
        Me.txtRunner3.Location = New System.Drawing.Point(121, 168)
        Me.txtRunner3.Name = "txtRunner3"
        Me.txtRunner3.Size = New System.Drawing.Size(100, 20)
        Me.txtRunner3.TabIndex = 8
        '
        'txtFinishTime2
        '
        Me.txtFinishTime2.Location = New System.Drawing.Point(269, 133)
        Me.txtFinishTime2.Name = "txtFinishTime2"
        Me.txtFinishTime2.Size = New System.Drawing.Size(100, 20)
        Me.txtFinishTime2.TabIndex = 9
        '
        'txtFinishTime1
        '
        Me.txtFinishTime1.Location = New System.Drawing.Point(269, 98)
        Me.txtFinishTime1.Name = "txtFinishTime1"
        Me.txtFinishTime1.Size = New System.Drawing.Size(100, 20)
        Me.txtFinishTime1.TabIndex = 10
        '
        'txtFinishTime3
        '
        Me.txtFinishTime3.Location = New System.Drawing.Point(269, 168)
        Me.txtFinishTime3.Name = "txtFinishTime3"
        Me.txtFinishTime3.Size = New System.Drawing.Size(100, 20)
        Me.txtFinishTime3.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl2ndPlace)
        Me.GroupBox1.Controls.Add(Me.lbl3rdPlace)
        Me.GroupBox1.Controls.Add(Me.lbl1stPlace)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(42, 204)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(327, 130)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Race Results"
        '
        'lbl2ndPlace
        '
        Me.lbl2ndPlace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl2ndPlace.Location = New System.Drawing.Point(157, 49)
        Me.lbl2ndPlace.Name = "lbl2ndPlace"
        Me.lbl2ndPlace.Size = New System.Drawing.Size(100, 23)
        Me.lbl2ndPlace.TabIndex = 5
        '
        'lbl3rdPlace
        '
        Me.lbl3rdPlace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl3rdPlace.Location = New System.Drawing.Point(157, 86)
        Me.lbl3rdPlace.Name = "lbl3rdPlace"
        Me.lbl3rdPlace.Size = New System.Drawing.Size(100, 23)
        Me.lbl3rdPlace.TabIndex = 4
        '
        'lbl1stPlace
        '
        Me.lbl1stPlace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl1stPlace.Location = New System.Drawing.Point(157, 16)
        Me.lbl1stPlace.Name = "lbl1stPlace"
        Me.lbl1stPlace.Size = New System.Drawing.Size(100, 25)
        Me.lbl1stPlace.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(54, 87)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "3rd Place:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(54, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "2nd Place:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(54, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "1st Place:"
        '
        'btnCalculateResults
        '
        Me.btnCalculateResults.Location = New System.Drawing.Point(42, 358)
        Me.btnCalculateResults.Name = "btnCalculateResults"
        Me.btnCalculateResults.Size = New System.Drawing.Size(75, 34)
        Me.btnCalculateResults.TabIndex = 13
        Me.btnCalculateResults.Text = "Calculate Results"
        Me.btnCalculateResults.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(170, 358)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 34)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(298, 358)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 34)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 399)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculateResults)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtFinishTime3)
        Me.Controls.Add(Me.txtFinishTime1)
        Me.Controls.Add(Me.txtFinishTime2)
        Me.Controls.Add(Me.txtRunner3)
        Me.Controls.Add(Me.txtRunner1)
        Me.Controls.Add(Me.txtRunner2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Race Results"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtRunner2 As System.Windows.Forms.TextBox
    Friend WithEvents txtRunner1 As System.Windows.Forms.TextBox
    Friend WithEvents txtRunner3 As System.Windows.Forms.TextBox
    Friend WithEvents txtFinishTime2 As System.Windows.Forms.TextBox
    Friend WithEvents txtFinishTime1 As System.Windows.Forms.TextBox
    Friend WithEvents txtFinishTime3 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl2ndPlace As System.Windows.Forms.Label
    Friend WithEvents lbl3rdPlace As System.Windows.Forms.Label
    Friend WithEvents lbl1stPlace As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnCalculateResults As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
