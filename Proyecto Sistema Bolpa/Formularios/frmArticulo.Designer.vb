<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmArticulo
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
		Me.components = New System.ComponentModel.Container()
		Me.txtNombre = New System.Windows.Forms.TextBox()
		Me.txtCodigo = New System.Windows.Forms.TextBox()
		Me.txtPeso = New System.Windows.Forms.TextBox()
		Me.txtPrecio = New System.Windows.Forms.TextBox()
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
		Me.lblPrecio = New System.Windows.Forms.Label()
		Me.lblFamilia = New System.Windows.Forms.Label()
		Me.lblSubfamilia = New System.Windows.Forms.Label()
		Me.tblArticulos = New System.Windows.Forms.DataGridView()
		Me.cmsOpciones = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.ActualizarArtículoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.EliminarArtículoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.pbImagen = New System.Windows.Forms.PictureBox()
		Me.btnImagen = New System.Windows.Forms.Button()
		Me.cbDescripcion = New System.Windows.Forms.ComboBox()
		Me.EPError = New System.Windows.Forms.ErrorProvider(Me.components)
		Me.CbProveedor = New System.Windows.Forms.ComboBox()
		Me.EPErrorFamilia = New System.Windows.Forms.ErrorProvider(Me.components)
		Me.EPErrorSubfamila = New System.Windows.Forms.ErrorProvider(Me.components)
		Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		CType(Me.tblArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.cmsOpciones.SuspendLayout()
		CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.EPError, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.EPErrorFamilia, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.EPErrorSubfamila, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'txtNombre
		'
		Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtNombre.Location = New System.Drawing.Point(122, 12)
		Me.txtNombre.Name = "txtNombre"
		Me.txtNombre.Size = New System.Drawing.Size(200, 20)
		Me.txtNombre.TabIndex = 0
		'
		'txtCodigo
		'
		Me.txtCodigo.Location = New System.Drawing.Point(122, 65)
		Me.txtCodigo.Name = "txtCodigo"
		Me.txtCodigo.Size = New System.Drawing.Size(200, 20)
		Me.txtCodigo.TabIndex = 2
		'
		'txtPeso
		'
		Me.txtPeso.Location = New System.Drawing.Point(122, 91)
		Me.txtPeso.Name = "txtPeso"
		Me.txtPeso.Size = New System.Drawing.Size(200, 20)
		Me.txtPeso.TabIndex = 4
		'
		'txtPrecio
		'
		Me.txtPrecio.Location = New System.Drawing.Point(122, 117)
		Me.txtPrecio.Name = "txtPrecio"
		Me.txtPrecio.Size = New System.Drawing.Size(200, 20)
		Me.txtPrecio.TabIndex = 5
		'
		'txtNuevaSubfamilia
		'
		Me.txtNuevaSubfamilia.Enabled = False
		Me.txtNuevaSubfamilia.Location = New System.Drawing.Point(122, 296)
		Me.txtNuevaSubfamilia.Name = "txtNuevaSubfamilia"
		Me.txtNuevaSubfamilia.Size = New System.Drawing.Size(200, 20)
		Me.txtNuevaSubfamilia.TabIndex = 11
		'
		'txtNuevaFamilia
		'
		Me.txtNuevaFamilia.Enabled = False
		Me.txtNuevaFamilia.Location = New System.Drawing.Point(122, 247)
		Me.txtNuevaFamilia.Name = "txtNuevaFamilia"
		Me.txtNuevaFamilia.Size = New System.Drawing.Size(200, 20)
		Me.txtNuevaFamilia.TabIndex = 8
		'
		'cbFamilia
		'
		Me.cbFamilia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
		Me.cbFamilia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.cbFamilia.FormattingEnabled = True
		Me.cbFamilia.Location = New System.Drawing.Point(122, 143)
		Me.cbFamilia.Name = "cbFamilia"
		Me.cbFamilia.Size = New System.Drawing.Size(200, 21)
		Me.cbFamilia.TabIndex = 6
		'
		'cbSubfamilia
		'
		Me.cbSubfamilia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
		Me.cbSubfamilia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.cbSubfamilia.FormattingEnabled = True
		Me.cbSubfamilia.Location = New System.Drawing.Point(122, 170)
		Me.cbSubfamilia.Name = "cbSubfamilia"
		Me.cbSubfamilia.Size = New System.Drawing.Size(200, 21)
		Me.cbSubfamilia.TabIndex = 7
		'
		'cbAgregarFam
		'
		Me.cbAgregarFam.AutoSize = True
		Me.cbAgregarFam.Location = New System.Drawing.Point(122, 224)
		Me.cbAgregarFam.Name = "cbAgregarFam"
		Me.cbAgregarFam.Size = New System.Drawing.Size(152, 17)
		Me.cbAgregarFam.TabIndex = 9
		Me.cbAgregarFam.Text = "Agregar una nueva familia "
		Me.cbAgregarFam.UseVisualStyleBackColor = True
		'
		'cbAgregarSub
		'
		Me.cbAgregarSub.AutoSize = True
		Me.cbAgregarSub.Location = New System.Drawing.Point(122, 273)
		Me.cbAgregarSub.Name = "cbAgregarSub"
		Me.cbAgregarSub.Size = New System.Drawing.Size(166, 17)
		Me.cbAgregarSub.TabIndex = 10
		Me.cbAgregarSub.Text = "Agregar una nueva subfamilia"
		Me.cbAgregarSub.UseVisualStyleBackColor = True
		'
		'btnAgregarProducto
		'
		Me.btnAgregarProducto.Location = New System.Drawing.Point(122, 322)
		Me.btnAgregarProducto.Name = "btnAgregarProducto"
		Me.btnAgregarProducto.Size = New System.Drawing.Size(200, 39)
		Me.btnAgregarProducto.TabIndex = 12
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
		Me.lblIdprovedor.Location = New System.Drawing.Point(13, 45)
		Me.lblIdprovedor.Name = "lblIdprovedor"
		Me.lblIdprovedor.Size = New System.Drawing.Size(56, 13)
		Me.lblIdprovedor.TabIndex = 16
		Me.lblIdprovedor.Text = "Proveedor"
		'
		'lblCodigo
		'
		Me.lblCodigo.AutoSize = True
		Me.lblCodigo.Location = New System.Drawing.Point(13, 71)
		Me.lblCodigo.Name = "lblCodigo"
		Me.lblCodigo.Size = New System.Drawing.Size(96, 13)
		Me.lblCodigo.TabIndex = 17
		Me.lblCodigo.Text = "Código del artículo"
		'
		'lblDescripcion
		'
		Me.lblDescripcion.AutoSize = True
		Me.lblDescripcion.Location = New System.Drawing.Point(13, 203)
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
		'lblPrecio
		'
		Me.lblPrecio.AutoSize = True
		Me.lblPrecio.Location = New System.Drawing.Point(13, 123)
		Me.lblPrecio.Name = "lblPrecio"
		Me.lblPrecio.Size = New System.Drawing.Size(93, 13)
		Me.lblPrecio.TabIndex = 21
		Me.lblPrecio.Text = "Precio del artículo"
		'
		'lblFamilia
		'
		Me.lblFamilia.AutoSize = True
		Me.lblFamilia.Location = New System.Drawing.Point(13, 150)
		Me.lblFamilia.Name = "lblFamilia"
		Me.lblFamilia.Size = New System.Drawing.Size(39, 13)
		Me.lblFamilia.TabIndex = 22
		Me.lblFamilia.Text = "Familia"
		'
		'lblSubfamilia
		'
		Me.lblSubfamilia.AutoSize = True
		Me.lblSubfamilia.Location = New System.Drawing.Point(13, 178)
		Me.lblSubfamilia.Name = "lblSubfamilia"
		Me.lblSubfamilia.Size = New System.Drawing.Size(53, 13)
		Me.lblSubfamilia.TabIndex = 23
		Me.lblSubfamilia.Text = "Subfamila"
		'
		'tblArticulos
		'
		Me.tblArticulos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tblArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.tblArticulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
		Me.tblArticulos.ContextMenuStrip = Me.cmsOpciones
		Me.tblArticulos.Location = New System.Drawing.Point(534, 12)
		Me.tblArticulos.Name = "tblArticulos"
		Me.tblArticulos.ReadOnly = True
		Me.tblArticulos.Size = New System.Drawing.Size(533, 377)
		Me.tblArticulos.TabIndex = 13
		'
		'cmsOpciones
		'
		Me.cmsOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActualizarArtículoToolStripMenuItem, Me.EliminarArtículoToolStripMenuItem})
		Me.cmsOpciones.Name = "cmsOpciones"
		Me.cmsOpciones.Size = New System.Drawing.Size(164, 48)
		'
		'ActualizarArtículoToolStripMenuItem
		'
		Me.ActualizarArtículoToolStripMenuItem.Name = "ActualizarArtículoToolStripMenuItem"
		Me.ActualizarArtículoToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
		Me.ActualizarArtículoToolStripMenuItem.Text = "Actulizar artículo"
		'
		'EliminarArtículoToolStripMenuItem
		'
		Me.EliminarArtículoToolStripMenuItem.Name = "EliminarArtículoToolStripMenuItem"
		Me.EliminarArtículoToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
		Me.EliminarArtículoToolStripMenuItem.Text = "Eliminar artículo"
		'
		'pbImagen
		'
		Me.pbImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.pbImagen.Location = New System.Drawing.Point(328, 11)
		Me.pbImagen.Name = "pbImagen"
		Me.pbImagen.Size = New System.Drawing.Size(200, 125)
		Me.pbImagen.TabIndex = 24
		Me.pbImagen.TabStop = False
		'
		'btnImagen
		'
		Me.btnImagen.Location = New System.Drawing.Point(328, 142)
		Me.btnImagen.Name = "btnImagen"
		Me.btnImagen.Size = New System.Drawing.Size(200, 22)
		Me.btnImagen.TabIndex = 26
		Me.btnImagen.Text = "Seleccionar imagen"
		Me.btnImagen.UseVisualStyleBackColor = True
		'
		'cbDescripcion
		'
		Me.cbDescripcion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
		Me.cbDescripcion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.cbDescripcion.FormattingEnabled = True
		Me.cbDescripcion.Items.AddRange(New Object() {"Kilo", "Unidad"})
		Me.cbDescripcion.Location = New System.Drawing.Point(122, 197)
		Me.cbDescripcion.Name = "cbDescripcion"
		Me.cbDescripcion.Size = New System.Drawing.Size(200, 21)
		Me.cbDescripcion.TabIndex = 27
		'
		'EPError
		'
		Me.EPError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
		Me.EPError.ContainerControl = Me
		'
		'CbProveedor
		'
		Me.CbProveedor.FormattingEnabled = True
		Me.CbProveedor.Location = New System.Drawing.Point(122, 38)
		Me.CbProveedor.Name = "CbProveedor"
		Me.CbProveedor.Size = New System.Drawing.Size(200, 21)
		Me.CbProveedor.TabIndex = 28
		'
		'EPErrorFamilia
		'
		Me.EPErrorFamilia.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
		Me.EPErrorFamilia.ContainerControl = Me
		'
		'EPErrorSubfamila
		'
		Me.EPErrorSubfamila.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
		Me.EPErrorSubfamila.ContainerControl = Me
		'
		'Column1
		'
		Me.Column1.HeaderText = "Column1"
		Me.Column1.Name = "Column1"
		Me.Column1.ReadOnly = True
		'
		'frmArticulo
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1079, 537)
		Me.Controls.Add(Me.CbProveedor)
		Me.Controls.Add(Me.cbDescripcion)
		Me.Controls.Add(Me.btnImagen)
		Me.Controls.Add(Me.pbImagen)
		Me.Controls.Add(Me.tblArticulos)
		Me.Controls.Add(Me.lblSubfamilia)
		Me.Controls.Add(Me.lblFamilia)
		Me.Controls.Add(Me.lblPrecio)
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
		Me.Controls.Add(Me.txtPrecio)
		Me.Controls.Add(Me.txtPeso)
		Me.Controls.Add(Me.txtCodigo)
		Me.Controls.Add(Me.txtNombre)
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.Name = "frmArticulo"
		Me.Text = "FrmAgregarArticulo"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		CType(Me.tblArticulos, System.ComponentModel.ISupportInitialize).EndInit()
		Me.cmsOpciones.ResumeLayout(False)
		CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.EPError, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.EPErrorFamilia, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.EPErrorSubfamila, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents txtNombre As TextBox
	Friend WithEvents txtCodigo As TextBox
	Friend WithEvents txtPeso As TextBox
	Friend WithEvents txtPrecio As TextBox
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
	Friend WithEvents lblPrecio As Label
	Friend WithEvents lblFamilia As Label
	Friend WithEvents lblSubfamilia As Label
	Friend WithEvents tblArticulos As DataGridView
	Friend WithEvents cmsOpciones As ContextMenuStrip
	Friend WithEvents ActualizarArtículoToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents EliminarArtículoToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents pbImagen As PictureBox
	Friend WithEvents btnImagen As Button
	Friend WithEvents cbDescripcion As ComboBox
	Friend WithEvents EPError As ErrorProvider
	Friend WithEvents CbProveedor As ComboBox
	Friend WithEvents EPErrorFamilia As ErrorProvider
	Friend WithEvents EPErrorSubfamila As ErrorProvider
	Friend WithEvents Column1 As DataGridViewTextBoxColumn
End Class
