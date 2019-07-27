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
		Me.txtNombre = New System.Windows.Forms.TextBox()
		Me.txtProveedor = New System.Windows.Forms.TextBox()
		Me.txtCodigo = New System.Windows.Forms.TextBox()
		Me.txtDescripcion = New System.Windows.Forms.TextBox()
		Me.txtPeso = New System.Windows.Forms.TextBox()
		Me.txtPrecio = New System.Windows.Forms.TextBox()
		Me.dtpCaducidad = New System.Windows.Forms.DateTimePicker()
		Me.txtNuevaSubfamilia = New System.Windows.Forms.TextBox()
		Me.txtNuevaFamilia = New System.Windows.Forms.TextBox()
		Me.cbFamilia = New System.Windows.Forms.ComboBox()
		Me.cbSubfamilia = New System.Windows.Forms.ComboBox()
		Me.cbAgregarFam = New System.Windows.Forms.CheckBox()
		Me.cbAgregarSub = New System.Windows.Forms.CheckBox()
		Me.btnAgregarProducto = New System.Windows.Forms.Button()
		Me.lblNombre = New System.Windows.Forms.Label()
		Me.lblIdprovedor = New System.Windows.Forms.Label()
		Me.lblCodigo = New System.Windows.Forms.Label()
		Me.lblDescripcion = New System.Windows.Forms.Label()
		Me.lblPeso = New System.Windows.Forms.Label()
		Me.lblCaducidad = New System.Windows.Forms.Label()
		Me.lblPrecio = New System.Windows.Forms.Label()
		Me.lblFamilia = New System.Windows.Forms.Label()
		Me.lblSubfamilia = New System.Windows.Forms.Label()
		Me.btnBuscarProveedor = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'txtNombre
		'
		Me.txtNombre.Location = New System.Drawing.Point(122, 12)
		Me.txtNombre.Name = "txtNombre"
		Me.txtNombre.Size = New System.Drawing.Size(200, 20)
		Me.txtNombre.TabIndex = 0
		'
		'txtProveedor
		'
		Me.txtProveedor.Location = New System.Drawing.Point(122, 38)
		Me.txtProveedor.Name = "txtProveedor"
		Me.txtProveedor.Size = New System.Drawing.Size(200, 20)
		Me.txtProveedor.TabIndex = 1
		'
		'txtCodigo
		'
		Me.txtCodigo.Location = New System.Drawing.Point(122, 64)
		Me.txtCodigo.Name = "txtCodigo"
		Me.txtCodigo.Size = New System.Drawing.Size(200, 20)
		Me.txtCodigo.TabIndex = 2
		'
		'txtDescripcion
		'
		Me.txtDescripcion.Location = New System.Drawing.Point(122, 222)
		Me.txtDescripcion.Name = "txtDescripcion"
		Me.txtDescripcion.Size = New System.Drawing.Size(200, 20)
		Me.txtDescripcion.TabIndex = 3
		'
		'txtPeso
		'
		Me.txtPeso.Location = New System.Drawing.Point(122, 90)
		Me.txtPeso.Name = "txtPeso"
		Me.txtPeso.Size = New System.Drawing.Size(200, 20)
		Me.txtPeso.TabIndex = 4
		'
		'txtPrecio
		'
		Me.txtPrecio.Location = New System.Drawing.Point(122, 142)
		Me.txtPrecio.Name = "txtPrecio"
		Me.txtPrecio.Size = New System.Drawing.Size(200, 20)
		Me.txtPrecio.TabIndex = 5
		'
		'dtpCaducidad
		'
		Me.dtpCaducidad.Location = New System.Drawing.Point(122, 116)
		Me.dtpCaducidad.MinDate = New Date(1755, 7, 17, 0, 0, 0, 0)
		Me.dtpCaducidad.Name = "dtpCaducidad"
		Me.dtpCaducidad.Size = New System.Drawing.Size(200, 20)
		Me.dtpCaducidad.TabIndex = 6
		'
		'txtNuevaSubfamilia
		'
		Me.txtNuevaSubfamilia.Enabled = False
		Me.txtNuevaSubfamilia.Location = New System.Drawing.Point(122, 325)
		Me.txtNuevaSubfamilia.Name = "txtNuevaSubfamilia"
		Me.txtNuevaSubfamilia.Size = New System.Drawing.Size(201, 20)
		Me.txtNuevaSubfamilia.TabIndex = 7
		'
		'txtNuevaFamilia
		'
		Me.txtNuevaFamilia.Enabled = False
		Me.txtNuevaFamilia.Location = New System.Drawing.Point(122, 271)
		Me.txtNuevaFamilia.Name = "txtNuevaFamilia"
		Me.txtNuevaFamilia.Size = New System.Drawing.Size(200, 20)
		Me.txtNuevaFamilia.TabIndex = 8
		'
		'cbFamilia
		'
		Me.cbFamilia.FormattingEnabled = True
		Me.cbFamilia.Location = New System.Drawing.Point(122, 168)
		Me.cbFamilia.Name = "cbFamilia"
		Me.cbFamilia.Size = New System.Drawing.Size(200, 21)
		Me.cbFamilia.TabIndex = 9
		'
		'cbSubfamilia
		'
		Me.cbSubfamilia.FormattingEnabled = True
		Me.cbSubfamilia.Location = New System.Drawing.Point(122, 195)
		Me.cbSubfamilia.Name = "cbSubfamilia"
		Me.cbSubfamilia.Size = New System.Drawing.Size(199, 21)
		Me.cbSubfamilia.TabIndex = 10
		'
		'cbAgregarFam
		'
		Me.cbAgregarFam.AutoSize = True
		Me.cbAgregarFam.Location = New System.Drawing.Point(122, 248)
		Me.cbAgregarFam.Name = "cbAgregarFam"
		Me.cbAgregarFam.Size = New System.Drawing.Size(152, 17)
		Me.cbAgregarFam.TabIndex = 12
		Me.cbAgregarFam.Text = "Agregar una nueva familia "
		Me.cbAgregarFam.UseVisualStyleBackColor = True
		'
		'cbAgregarSub
		'
		Me.cbAgregarSub.AutoSize = True
		Me.cbAgregarSub.Location = New System.Drawing.Point(122, 302)
		Me.cbAgregarSub.Name = "cbAgregarSub"
		Me.cbAgregarSub.Size = New System.Drawing.Size(166, 17)
		Me.cbAgregarSub.TabIndex = 13
		Me.cbAgregarSub.Text = "Agregar una nueva subfamilia"
		Me.cbAgregarSub.UseVisualStyleBackColor = True
		'
		'btnAgregarProducto
		'
		Me.btnAgregarProducto.Location = New System.Drawing.Point(122, 351)
		Me.btnAgregarProducto.Name = "btnAgregarProducto"
		Me.btnAgregarProducto.Size = New System.Drawing.Size(201, 39)
		Me.btnAgregarProducto.TabIndex = 14
		Me.btnAgregarProducto.Text = "Agregar producto"
		Me.btnAgregarProducto.UseVisualStyleBackColor = True
		'
		'lblNombre
		'
		Me.lblNombre.AutoSize = True
		Me.lblNombre.Location = New System.Drawing.Point(13, 19)
		Me.lblNombre.Name = "lblNombre"
		Me.lblNombre.Size = New System.Drawing.Size(103, 13)
		Me.lblNombre.TabIndex = 15
		Me.lblNombre.Text = "Nombre del artículo "
		'
		'lblIdprovedor
		'
		Me.lblIdprovedor.AutoSize = True
		Me.lblIdprovedor.Location = New System.Drawing.Point(12, 45)
		Me.lblIdprovedor.Name = "lblIdprovedor"
		Me.lblIdprovedor.Size = New System.Drawing.Size(106, 13)
		Me.lblIdprovedor.TabIndex = 16
		Me.lblIdprovedor.Text = "Codigo de proveedor"
		'
		'lblCodigo
		'
		Me.lblCodigo.AutoSize = True
		Me.lblCodigo.Location = New System.Drawing.Point(12, 71)
		Me.lblCodigo.Name = "lblCodigo"
		Me.lblCodigo.Size = New System.Drawing.Size(96, 13)
		Me.lblCodigo.TabIndex = 17
		Me.lblCodigo.Text = "Código del artículo"
		'
		'lblDescripcion
		'
		Me.lblDescripcion.AutoSize = True
		Me.lblDescripcion.Location = New System.Drawing.Point(13, 229)
		Me.lblDescripcion.Name = "lblDescripcion"
		Me.lblDescripcion.Size = New System.Drawing.Size(63, 13)
		Me.lblDescripcion.TabIndex = 18
		Me.lblDescripcion.Text = "Descripción"
		'
		'lblPeso
		'
		Me.lblPeso.AutoSize = True
		Me.lblPeso.Location = New System.Drawing.Point(13, 97)
		Me.lblPeso.Name = "lblPeso"
		Me.lblPeso.Size = New System.Drawing.Size(87, 13)
		Me.lblPeso.TabIndex = 19
		Me.lblPeso.Text = "Peso del artículo"
		'
		'lblCaducidad
		'
		Me.lblCaducidad.AutoSize = True
		Me.lblCaducidad.Location = New System.Drawing.Point(13, 125)
		Me.lblCaducidad.Name = "lblCaducidad"
		Me.lblCaducidad.Size = New System.Drawing.Size(105, 13)
		Me.lblCaducidad.TabIndex = 20
		Me.lblCaducidad.Text = "Fecha de caducidad"
		'
		'lblPrecio
		'
		Me.lblPrecio.AutoSize = True
		Me.lblPrecio.Location = New System.Drawing.Point(13, 151)
		Me.lblPrecio.Name = "lblPrecio"
		Me.lblPrecio.Size = New System.Drawing.Size(93, 13)
		Me.lblPrecio.TabIndex = 21
		Me.lblPrecio.Text = "Precio del artículo"
		'
		'lblFamilia
		'
		Me.lblFamilia.AutoSize = True
		Me.lblFamilia.Location = New System.Drawing.Point(13, 176)
		Me.lblFamilia.Name = "lblFamilia"
		Me.lblFamilia.Size = New System.Drawing.Size(39, 13)
		Me.lblFamilia.TabIndex = 22
		Me.lblFamilia.Text = "Familia"
		'
		'lblSubfamilia
		'
		Me.lblSubfamilia.AutoSize = True
		Me.lblSubfamilia.Location = New System.Drawing.Point(13, 204)
		Me.lblSubfamilia.Name = "lblSubfamilia"
		Me.lblSubfamilia.Size = New System.Drawing.Size(53, 13)
		Me.lblSubfamilia.TabIndex = 23
		Me.lblSubfamilia.Text = "Subfamila"
		'
		'btnBuscarProveedor
		'
		Me.btnBuscarProveedor.Location = New System.Drawing.Point(328, 35)
		Me.btnBuscarProveedor.Name = "btnBuscarProveedor"
		Me.btnBuscarProveedor.Size = New System.Drawing.Size(62, 23)
		Me.btnBuscarProveedor.TabIndex = 24
		Me.btnBuscarProveedor.Text = "Buscar"
		Me.btnBuscarProveedor.UseVisualStyleBackColor = True
		'
		'FrmArticulo
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(843, 619)
		Me.Controls.Add(Me.btnBuscarProveedor)
		Me.Controls.Add(Me.lblSubfamilia)
		Me.Controls.Add(Me.lblFamilia)
		Me.Controls.Add(Me.lblPrecio)
		Me.Controls.Add(Me.lblCaducidad)
		Me.Controls.Add(Me.lblPeso)
		Me.Controls.Add(Me.lblDescripcion)
		Me.Controls.Add(Me.lblCodigo)
		Me.Controls.Add(Me.lblIdprovedor)
		Me.Controls.Add(Me.lblNombre)
		Me.Controls.Add(Me.btnAgregarProducto)
		Me.Controls.Add(Me.cbAgregarSub)
		Me.Controls.Add(Me.cbAgregarFam)
		Me.Controls.Add(Me.cbSubfamilia)
		Me.Controls.Add(Me.cbFamilia)
		Me.Controls.Add(Me.txtNuevaFamilia)
		Me.Controls.Add(Me.txtNuevaSubfamilia)
		Me.Controls.Add(Me.dtpCaducidad)
		Me.Controls.Add(Me.txtPrecio)
		Me.Controls.Add(Me.txtPeso)
		Me.Controls.Add(Me.txtDescripcion)
		Me.Controls.Add(Me.txtCodigo)
		Me.Controls.Add(Me.txtProveedor)
		Me.Controls.Add(Me.txtNombre)
		Me.Name = "FrmArticulo"
		Me.Text = "FrmArticulo"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents txtNombre As TextBox
	Friend WithEvents txtProveedor As TextBox
	Friend WithEvents txtCodigo As TextBox
	Friend WithEvents txtDescripcion As TextBox
	Friend WithEvents txtPeso As TextBox
	Friend WithEvents txtPrecio As TextBox
	Friend WithEvents dtpCaducidad As DateTimePicker
	Friend WithEvents txtNuevaSubfamilia As TextBox
	Friend WithEvents txtNuevaFamilia As TextBox
	Friend WithEvents cbFamilia As ComboBox
	Friend WithEvents cbSubfamilia As ComboBox
	Friend WithEvents cbAgregarFam As CheckBox
	Friend WithEvents cbAgregarSub As CheckBox
	Friend WithEvents btnAgregarProducto As Button
	Friend WithEvents lblNombre As Label
	Friend WithEvents lblIdprovedor As Label
	Friend WithEvents lblCodigo As Label
	Friend WithEvents lblDescripcion As Label
	Friend WithEvents lblPeso As Label
	Friend WithEvents lblCaducidad As Label
	Friend WithEvents lblPrecio As Label
	Friend WithEvents lblFamilia As Label
	Friend WithEvents lblSubfamilia As Label
	Friend WithEvents btnBuscarProveedor As Button
End Class
