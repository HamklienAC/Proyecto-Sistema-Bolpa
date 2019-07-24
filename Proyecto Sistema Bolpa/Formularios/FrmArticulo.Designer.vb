<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmArticulo
	Inherits System.Windows.Forms.Form

	'Form reemplaza a Dispose para limpiar la lista de componentes.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Requerido por el Diseñador de Windows Forms
	Private components As System.ComponentModel.IContainer

	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar usando el Diseñador de Windows Forms.  
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.TextBox3 = New System.Windows.Forms.TextBox()
		Me.TextBox4 = New System.Windows.Forms.TextBox()
		Me.TextBox5 = New System.Windows.Forms.TextBox()
		Me.TextBox6 = New System.Windows.Forms.TextBox()
		Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
		Me.TextBox7 = New System.Windows.Forms.TextBox()
		Me.TextBox8 = New System.Windows.Forms.TextBox()
		Me.ComboBox1 = New System.Windows.Forms.ComboBox()
		Me.ComboBox2 = New System.Windows.Forms.ComboBox()
		Me.RadioButton1 = New System.Windows.Forms.RadioButton()
		Me.SuspendLayout()
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(13, 13)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(183, 20)
		Me.TextBox1.TabIndex = 0
		'
		'TextBox2
		'
		Me.TextBox2.Location = New System.Drawing.Point(13, 39)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(183, 20)
		Me.TextBox2.TabIndex = 1
		'
		'TextBox3
		'
		Me.TextBox3.Location = New System.Drawing.Point(12, 65)
		Me.TextBox3.Name = "TextBox3"
		Me.TextBox3.Size = New System.Drawing.Size(183, 20)
		Me.TextBox3.TabIndex = 2
		'
		'TextBox4
		'
		Me.TextBox4.Location = New System.Drawing.Point(12, 91)
		Me.TextBox4.Name = "TextBox4"
		Me.TextBox4.Size = New System.Drawing.Size(183, 20)
		Me.TextBox4.TabIndex = 3
		'
		'TextBox5
		'
		Me.TextBox5.Location = New System.Drawing.Point(12, 117)
		Me.TextBox5.Name = "TextBox5"
		Me.TextBox5.Size = New System.Drawing.Size(183, 20)
		Me.TextBox5.TabIndex = 4
		'
		'TextBox6
		'
		Me.TextBox6.Location = New System.Drawing.Point(12, 170)
		Me.TextBox6.Name = "TextBox6"
		Me.TextBox6.Size = New System.Drawing.Size(183, 20)
		Me.TextBox6.TabIndex = 5
		'
		'DateTimePicker1
		'
		Me.DateTimePicker1.Location = New System.Drawing.Point(12, 144)
		Me.DateTimePicker1.Name = "DateTimePicker1"
		Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
		Me.DateTimePicker1.TabIndex = 6
		'
		'TextBox7
		'
		Me.TextBox7.Location = New System.Drawing.Point(13, 306)
		Me.TextBox7.Name = "TextBox7"
		Me.TextBox7.Size = New System.Drawing.Size(183, 20)
		Me.TextBox7.TabIndex = 7
		'
		'TextBox8
		'
		Me.TextBox8.Location = New System.Drawing.Point(12, 280)
		Me.TextBox8.Name = "TextBox8"
		Me.TextBox8.Size = New System.Drawing.Size(183, 20)
		Me.TextBox8.TabIndex = 8
		'
		'ComboBox1
		'
		Me.ComboBox1.FormattingEnabled = True
		Me.ComboBox1.Location = New System.Drawing.Point(12, 196)
		Me.ComboBox1.Name = "ComboBox1"
		Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
		Me.ComboBox1.TabIndex = 9
		'
		'ComboBox2
		'
		Me.ComboBox2.FormattingEnabled = True
		Me.ComboBox2.Location = New System.Drawing.Point(13, 223)
		Me.ComboBox2.Name = "ComboBox2"
		Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
		Me.ComboBox2.TabIndex = 10
		'
		'RadioButton1
		'
		Me.RadioButton1.AutoSize = True
		Me.RadioButton1.Location = New System.Drawing.Point(13, 257)
		Me.RadioButton1.Name = "RadioButton1"
		Me.RadioButton1.Size = New System.Drawing.Size(90, 17)
		Me.RadioButton1.TabIndex = 11
		Me.RadioButton1.TabStop = True
		Me.RadioButton1.Text = "RadioButton1"
		Me.RadioButton1.UseVisualStyleBackColor = True
		'
		'FrmArticulo
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1151, 643)
		Me.Controls.Add(Me.RadioButton1)
		Me.Controls.Add(Me.ComboBox2)
		Me.Controls.Add(Me.ComboBox1)
		Me.Controls.Add(Me.TextBox8)
		Me.Controls.Add(Me.TextBox7)
		Me.Controls.Add(Me.DateTimePicker1)
		Me.Controls.Add(Me.TextBox6)
		Me.Controls.Add(Me.TextBox5)
		Me.Controls.Add(Me.TextBox4)
		Me.Controls.Add(Me.TextBox3)
		Me.Controls.Add(Me.TextBox2)
		Me.Controls.Add(Me.TextBox1)
		Me.Name = "FrmArticulo"
		Me.Text = "FrmArticulo"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents TextBox3 As TextBox
	Friend WithEvents TextBox4 As TextBox
	Friend WithEvents TextBox5 As TextBox
	Friend WithEvents TextBox6 As TextBox
	Friend WithEvents DateTimePicker1 As DateTimePicker
	Friend WithEvents TextBox7 As TextBox
	Friend WithEvents TextBox8 As TextBox
	Friend WithEvents ComboBox1 As ComboBox
	Friend WithEvents ComboBox2 As ComboBox
	Friend WithEvents RadioButton1 As RadioButton
End Class
