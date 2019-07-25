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
		Me.txtNuevaSubfamilia = New System.Windows.Forms.TextBox()
		Me.txtNuevaFamilia = New System.Windows.Forms.TextBox()
		Me.cbFamilia = New System.Windows.Forms.ComboBox()
		Me.cbSubfamilia = New System.Windows.Forms.ComboBox()
		Me.cbAgregarFam = New System.Windows.Forms.CheckBox()
		Me.cbAgregarSub = New System.Windows.Forms.CheckBox()
		Me.SuspendLayout()
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(13, 13)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(199, 20)
		Me.TextBox1.TabIndex = 0
		'
		'TextBox2
		'
		Me.TextBox2.Location = New System.Drawing.Point(13, 39)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(199, 20)
		Me.TextBox2.TabIndex = 1
		'
		'TextBox3
		'
		Me.TextBox3.Location = New System.Drawing.Point(12, 65)
		Me.TextBox3.Name = "TextBox3"
		Me.TextBox3.Size = New System.Drawing.Size(200, 20)
		Me.TextBox3.TabIndex = 2
		'
		'TextBox4
		'
		Me.TextBox4.Location = New System.Drawing.Point(12, 91)
		Me.TextBox4.Name = "TextBox4"
		Me.TextBox4.Size = New System.Drawing.Size(200, 20)
		Me.TextBox4.TabIndex = 3
		'
		'TextBox5
		'
		Me.TextBox5.Location = New System.Drawing.Point(12, 117)
		Me.TextBox5.Name = "TextBox5"
		Me.TextBox5.Size = New System.Drawing.Size(200, 20)
		Me.TextBox5.TabIndex = 4
		'
		'TextBox6
		'
		Me.TextBox6.Location = New System.Drawing.Point(12, 170)
		Me.TextBox6.Name = "TextBox6"
		Me.TextBox6.Size = New System.Drawing.Size(200, 20)
		Me.TextBox6.TabIndex = 5
		'
		'DateTimePicker1
		'
		Me.DateTimePicker1.Location = New System.Drawing.Point(12, 144)
		Me.DateTimePicker1.Name = "DateTimePicker1"
		Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
		Me.DateTimePicker1.TabIndex = 6
		'
		'txtNuevaSubfamilia
		'
		Me.txtNuevaSubfamilia.Enabled = False
		Me.txtNuevaSubfamilia.Location = New System.Drawing.Point(13, 326)
		Me.txtNuevaSubfamilia.Name = "txtNuevaSubfamilia"
		Me.txtNuevaSubfamilia.Size = New System.Drawing.Size(201, 20)
		Me.txtNuevaSubfamilia.TabIndex = 7
		'
		'txtNuevaFamilia
		'
		Me.txtNuevaFamilia.Enabled = False
		Me.txtNuevaFamilia.Location = New System.Drawing.Point(13, 273)
		Me.txtNuevaFamilia.Name = "txtNuevaFamilia"
		Me.txtNuevaFamilia.Size = New System.Drawing.Size(200, 20)
		Me.txtNuevaFamilia.TabIndex = 8
		'
		'cbFamilia
		'
		Me.cbFamilia.FormattingEnabled = True
		Me.cbFamilia.Location = New System.Drawing.Point(12, 196)
		Me.cbFamilia.Name = "cbFamilia"
		Me.cbFamilia.Size = New System.Drawing.Size(200, 21)
		Me.cbFamilia.TabIndex = 9
		'
		'cbSubfamilia
		'
		Me.cbSubfamilia.FormattingEnabled = True
		Me.cbSubfamilia.Location = New System.Drawing.Point(13, 223)
		Me.cbSubfamilia.Name = "cbSubfamilia"
		Me.cbSubfamilia.Size = New System.Drawing.Size(199, 21)
		Me.cbSubfamilia.TabIndex = 10
		'
		'cbAgregarFam
		'
		Me.cbAgregarFam.AutoSize = True
		Me.cbAgregarFam.Location = New System.Drawing.Point(13, 250)
		Me.cbAgregarFam.Name = "cbAgregarFam"
		Me.cbAgregarFam.Size = New System.Drawing.Size(152, 17)
		Me.cbAgregarFam.TabIndex = 12
		Me.cbAgregarFam.Text = "Agregar una nueva familia "
		Me.cbAgregarFam.UseVisualStyleBackColor = True
		'
		'cbAgregarSub
		'
		Me.cbAgregarSub.AutoSize = True
		Me.cbAgregarSub.Location = New System.Drawing.Point(13, 303)
		Me.cbAgregarSub.Name = "cbAgregarSub"
		Me.cbAgregarSub.Size = New System.Drawing.Size(166, 17)
		Me.cbAgregarSub.TabIndex = 13
		Me.cbAgregarSub.Text = "Agregar una nueva subfamilia"
		Me.cbAgregarSub.UseVisualStyleBackColor = True
		'
		'FrmArticulo
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(843, 643)
		Me.Controls.Add(Me.cbAgregarSub)
		Me.Controls.Add(Me.cbAgregarFam)
		Me.Controls.Add(Me.cbSubfamilia)
		Me.Controls.Add(Me.cbFamilia)
		Me.Controls.Add(Me.txtNuevaFamilia)
		Me.Controls.Add(Me.txtNuevaSubfamilia)
		Me.Controls.Add(Me.DateTimePicker1)
		Me.Controls.Add(Me.TextBox6)
		Me.Controls.Add(Me.TextBox5)
		Me.Controls.Add(Me.TextBox4)
		Me.Controls.Add(Me.TextBox3)
		Me.Controls.Add(Me.TextBox2)
		Me.Controls.Add(Me.TextBox1)
		Me.Name = "FrmArticulo"
		Me.Text = "FrmArticulo"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
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
	Friend WithEvents txtNuevaSubfamilia As TextBox
	Friend WithEvents txtNuevaFamilia As TextBox
	Friend WithEvents cbFamilia As ComboBox
	Friend WithEvents cbSubfamilia As ComboBox
	Friend WithEvents cbAgregarFam As CheckBox
	Friend WithEvents cbAgregarSub As CheckBox
End Class
