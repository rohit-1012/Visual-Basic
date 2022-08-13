<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
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
        Me.displayTextbox = New System.Windows.Forms.TextBox()
        Me.one_Button = New System.Windows.Forms.Button()
        Me.four_Button = New System.Windows.Forms.Button()
        Me.seven_Button = New System.Windows.Forms.Button()
        Me.zero_Button = New System.Windows.Forms.Button()
        Me.two_Button = New System.Windows.Forms.Button()
        Me.five_Button = New System.Windows.Forms.Button()
        Me.eight_Button = New System.Windows.Forms.Button()
        Me.decimal_Button = New System.Windows.Forms.Button()
        Me.three_Button = New System.Windows.Forms.Button()
        Me.six_Button = New System.Windows.Forms.Button()
        Me.nine_Button = New System.Windows.Forms.Button()
        Me.equal_Button = New System.Windows.Forms.Button()
        Me.add_Button = New System.Windows.Forms.Button()
        Me.sub_Button = New System.Windows.Forms.Button()
        Me.divide_Button = New System.Windows.Forms.Button()
        Me.multiply_Button = New System.Windows.Forms.Button()
        Me.oneBy_Button = New System.Windows.Forms.Button()
        Me.sqrt_Button = New System.Windows.Forms.Button()
        Me.square_Button = New System.Windows.Forms.Button()
        Me.mod_Button = New System.Windows.Forms.Button()
        Me.clear_Button = New System.Windows.Forms.Button()
        Me.backspace_Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'displayTextbox
        '
        Me.displayTextbox.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.displayTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.displayTextbox.Location = New System.Drawing.Point(8, 12)
        Me.displayTextbox.Name = "displayTextbox"
        Me.displayTextbox.Size = New System.Drawing.Size(322, 62)
        Me.displayTextbox.TabIndex = 0
        '
        'one_Button
        '
        Me.one_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.one_Button.Location = New System.Drawing.Point(8, 123)
        Me.one_Button.Name = "one_Button"
        Me.one_Button.Size = New System.Drawing.Size(76, 41)
        Me.one_Button.TabIndex = 1
        Me.one_Button.Text = "1"
        Me.one_Button.UseVisualStyleBackColor = True
        '
        'four_Button
        '
        Me.four_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.four_Button.Location = New System.Drawing.Point(8, 166)
        Me.four_Button.Name = "four_Button"
        Me.four_Button.Size = New System.Drawing.Size(76, 41)
        Me.four_Button.TabIndex = 1
        Me.four_Button.Text = "4"
        Me.four_Button.UseVisualStyleBackColor = True
        '
        'seven_Button
        '
        Me.seven_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seven_Button.Location = New System.Drawing.Point(8, 209)
        Me.seven_Button.Name = "seven_Button"
        Me.seven_Button.Size = New System.Drawing.Size(76, 41)
        Me.seven_Button.TabIndex = 1
        Me.seven_Button.Text = "7"
        Me.seven_Button.UseVisualStyleBackColor = True
        '
        'zero_Button
        '
        Me.zero_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.zero_Button.Location = New System.Drawing.Point(8, 252)
        Me.zero_Button.Name = "zero_Button"
        Me.zero_Button.Size = New System.Drawing.Size(76, 41)
        Me.zero_Button.TabIndex = 1
        Me.zero_Button.Text = "0"
        Me.zero_Button.UseVisualStyleBackColor = True
        '
        'two_Button
        '
        Me.two_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.two_Button.Location = New System.Drawing.Point(90, 123)
        Me.two_Button.Name = "two_Button"
        Me.two_Button.Size = New System.Drawing.Size(76, 41)
        Me.two_Button.TabIndex = 1
        Me.two_Button.Text = "2"
        Me.two_Button.UseVisualStyleBackColor = True
        '
        'five_Button
        '
        Me.five_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.five_Button.Location = New System.Drawing.Point(90, 166)
        Me.five_Button.Name = "five_Button"
        Me.five_Button.Size = New System.Drawing.Size(76, 41)
        Me.five_Button.TabIndex = 1
        Me.five_Button.Text = "5"
        Me.five_Button.UseVisualStyleBackColor = True
        '
        'eight_Button
        '
        Me.eight_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eight_Button.Location = New System.Drawing.Point(90, 209)
        Me.eight_Button.Name = "eight_Button"
        Me.eight_Button.Size = New System.Drawing.Size(76, 41)
        Me.eight_Button.TabIndex = 1
        Me.eight_Button.Text = "8"
        Me.eight_Button.UseVisualStyleBackColor = True
        '
        'decimal_Button
        '
        Me.decimal_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decimal_Button.Location = New System.Drawing.Point(90, 252)
        Me.decimal_Button.Name = "decimal_Button"
        Me.decimal_Button.Size = New System.Drawing.Size(76, 41)
        Me.decimal_Button.TabIndex = 1
        Me.decimal_Button.Text = "."
        Me.decimal_Button.UseVisualStyleBackColor = True
        '
        'three_Button
        '
        Me.three_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.three_Button.Location = New System.Drawing.Point(172, 123)
        Me.three_Button.Name = "three_Button"
        Me.three_Button.Size = New System.Drawing.Size(76, 41)
        Me.three_Button.TabIndex = 1
        Me.three_Button.Text = "3"
        Me.three_Button.UseVisualStyleBackColor = True
        '
        'six_Button
        '
        Me.six_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.six_Button.Location = New System.Drawing.Point(172, 166)
        Me.six_Button.Name = "six_Button"
        Me.six_Button.Size = New System.Drawing.Size(76, 41)
        Me.six_Button.TabIndex = 1
        Me.six_Button.Text = "6"
        Me.six_Button.UseVisualStyleBackColor = True
        '
        'nine_Button
        '
        Me.nine_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nine_Button.Location = New System.Drawing.Point(172, 209)
        Me.nine_Button.Name = "nine_Button"
        Me.nine_Button.Size = New System.Drawing.Size(76, 41)
        Me.nine_Button.TabIndex = 1
        Me.nine_Button.Text = "9"
        Me.nine_Button.UseVisualStyleBackColor = True
        '
        'equal_Button
        '
        Me.equal_Button.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.equal_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.equal_Button.Location = New System.Drawing.Point(172, 252)
        Me.equal_Button.Name = "equal_Button"
        Me.equal_Button.Size = New System.Drawing.Size(76, 41)
        Me.equal_Button.TabIndex = 1
        Me.equal_Button.Text = "="
        Me.equal_Button.UseVisualStyleBackColor = False
        '
        'add_Button
        '
        Me.add_Button.BackColor = System.Drawing.Color.LightSeaGreen
        Me.add_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_Button.Location = New System.Drawing.Point(254, 123)
        Me.add_Button.Name = "add_Button"
        Me.add_Button.Size = New System.Drawing.Size(76, 41)
        Me.add_Button.TabIndex = 1
        Me.add_Button.Text = "+"
        Me.add_Button.UseVisualStyleBackColor = False
        '
        'sub_Button
        '
        Me.sub_Button.BackColor = System.Drawing.Color.LightSeaGreen
        Me.sub_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sub_Button.Location = New System.Drawing.Point(254, 166)
        Me.sub_Button.Name = "sub_Button"
        Me.sub_Button.Size = New System.Drawing.Size(76, 41)
        Me.sub_Button.TabIndex = 1
        Me.sub_Button.Text = "-"
        Me.sub_Button.UseVisualStyleBackColor = False
        '
        'divide_Button
        '
        Me.divide_Button.BackColor = System.Drawing.Color.LightSeaGreen
        Me.divide_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.divide_Button.Location = New System.Drawing.Point(254, 209)
        Me.divide_Button.Name = "divide_Button"
        Me.divide_Button.Size = New System.Drawing.Size(76, 41)
        Me.divide_Button.TabIndex = 1
        Me.divide_Button.Text = "/"
        Me.divide_Button.UseVisualStyleBackColor = False
        '
        'multiply_Button
        '
        Me.multiply_Button.BackColor = System.Drawing.Color.LightSeaGreen
        Me.multiply_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.multiply_Button.Location = New System.Drawing.Point(254, 252)
        Me.multiply_Button.Name = "multiply_Button"
        Me.multiply_Button.Size = New System.Drawing.Size(76, 41)
        Me.multiply_Button.TabIndex = 1
        Me.multiply_Button.Text = "*"
        Me.multiply_Button.UseVisualStyleBackColor = False
        '
        'oneBy_Button
        '
        Me.oneBy_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oneBy_Button.Location = New System.Drawing.Point(8, 80)
        Me.oneBy_Button.Name = "oneBy_Button"
        Me.oneBy_Button.Size = New System.Drawing.Size(76, 41)
        Me.oneBy_Button.TabIndex = 1
        Me.oneBy_Button.Text = "1/x"
        Me.oneBy_Button.UseVisualStyleBackColor = True
        '
        'sqrt_Button
        '
        Me.sqrt_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sqrt_Button.Location = New System.Drawing.Point(90, 80)
        Me.sqrt_Button.Name = "sqrt_Button"
        Me.sqrt_Button.Size = New System.Drawing.Size(76, 41)
        Me.sqrt_Button.TabIndex = 1
        Me.sqrt_Button.Text = "√x"
        Me.sqrt_Button.UseVisualStyleBackColor = True
        '
        'square_Button
        '
        Me.square_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.square_Button.Location = New System.Drawing.Point(172, 80)
        Me.square_Button.Name = "square_Button"
        Me.square_Button.Size = New System.Drawing.Size(76, 41)
        Me.square_Button.TabIndex = 1
        Me.square_Button.Text = "x² "
        Me.square_Button.UseVisualStyleBackColor = True
        '
        'mod_Button
        '
        Me.mod_Button.BackColor = System.Drawing.Color.LightSeaGreen
        Me.mod_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mod_Button.Location = New System.Drawing.Point(254, 80)
        Me.mod_Button.Name = "mod_Button"
        Me.mod_Button.Size = New System.Drawing.Size(76, 41)
        Me.mod_Button.TabIndex = 1
        Me.mod_Button.Text = "%"
        Me.mod_Button.UseVisualStyleBackColor = False
        '
        'clear_Button
        '
        Me.clear_Button.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.clear_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_Button.Location = New System.Drawing.Point(8, 295)
        Me.clear_Button.Name = "clear_Button"
        Me.clear_Button.Size = New System.Drawing.Size(158, 41)
        Me.clear_Button.TabIndex = 1
        Me.clear_Button.Text = "CLEAR"
        Me.clear_Button.UseVisualStyleBackColor = False
        '
        'backspace_Button
        '
        Me.backspace_Button.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.backspace_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backspace_Button.Location = New System.Drawing.Point(172, 295)
        Me.backspace_Button.Name = "backspace_Button"
        Me.backspace_Button.Size = New System.Drawing.Size(158, 41)
        Me.backspace_Button.TabIndex = 1
        Me.backspace_Button.Text = "⌫"
        Me.backspace_Button.UseVisualStyleBackColor = False
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(338, 342)
        Me.Controls.Add(Me.multiply_Button)
        Me.Controls.Add(Me.equal_Button)
        Me.Controls.Add(Me.backspace_Button)
        Me.Controls.Add(Me.decimal_Button)
        Me.Controls.Add(Me.clear_Button)
        Me.Controls.Add(Me.zero_Button)
        Me.Controls.Add(Me.divide_Button)
        Me.Controls.Add(Me.nine_Button)
        Me.Controls.Add(Me.eight_Button)
        Me.Controls.Add(Me.seven_Button)
        Me.Controls.Add(Me.sub_Button)
        Me.Controls.Add(Me.six_Button)
        Me.Controls.Add(Me.five_Button)
        Me.Controls.Add(Me.four_Button)
        Me.Controls.Add(Me.mod_Button)
        Me.Controls.Add(Me.square_Button)
        Me.Controls.Add(Me.add_Button)
        Me.Controls.Add(Me.sqrt_Button)
        Me.Controls.Add(Me.three_Button)
        Me.Controls.Add(Me.oneBy_Button)
        Me.Controls.Add(Me.two_Button)
        Me.Controls.Add(Me.one_Button)
        Me.Controls.Add(Me.displayTextbox)
        Me.Name = "Calculator"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents displayTextbox As System.Windows.Forms.TextBox
    Friend WithEvents one_Button As System.Windows.Forms.Button
    Friend WithEvents four_Button As System.Windows.Forms.Button
    Friend WithEvents seven_Button As System.Windows.Forms.Button
    Friend WithEvents zero_Button As System.Windows.Forms.Button
    Friend WithEvents two_Button As System.Windows.Forms.Button
    Friend WithEvents five_Button As System.Windows.Forms.Button
    Friend WithEvents eight_Button As System.Windows.Forms.Button
    Friend WithEvents decimal_Button As System.Windows.Forms.Button
    Friend WithEvents three_Button As System.Windows.Forms.Button
    Friend WithEvents six_Button As System.Windows.Forms.Button
    Friend WithEvents nine_Button As System.Windows.Forms.Button
    Friend WithEvents equal_Button As System.Windows.Forms.Button
    Friend WithEvents add_Button As System.Windows.Forms.Button
    Friend WithEvents sub_Button As System.Windows.Forms.Button
    Friend WithEvents divide_Button As System.Windows.Forms.Button
    Friend WithEvents multiply_Button As System.Windows.Forms.Button
    Friend WithEvents oneBy_Button As System.Windows.Forms.Button
    Friend WithEvents sqrt_Button As System.Windows.Forms.Button
    Friend WithEvents square_Button As System.Windows.Forms.Button
    Friend WithEvents mod_Button As System.Windows.Forms.Button
    Friend WithEvents clear_Button As System.Windows.Forms.Button
    Friend WithEvents backspace_Button As System.Windows.Forms.Button

End Class
