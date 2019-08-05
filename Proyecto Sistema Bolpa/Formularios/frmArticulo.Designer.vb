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
		Me.txtProveedor = New System.Windows.Forms.TextBox()
		Me.txtCodigo = New System.Windows.Forms.TextBox()
		Me.txtDescripcion = New System.Windows.Forms.TextBox()
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
		Me.tblNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.tblcodigoAr = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.tblpeso = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.tblPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.tblFamilia = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.tblSubFamilia = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.tblDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.cmsOpciones = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.ActualizarArtículoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.EliminarArtículoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.pbImagen = New System.Windows.Forms.PictureBox()
		Me.btnImagen = New System.Windows.Forms.Button()
		CType(Me.tblArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.cmsOpciones.SuspendLayout()
		CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
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
		Me.txtProveedor.AutoCompleteCustomSource.AddRange(New String() {"Cañas ", "Bagaces", "Cavacar"})
		Me.txtProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
		Me.txtProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
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
		Me.txtDescripcion.Location = New System.Drawing.Point(122, 196)
		Me.txtDescripcion.Name = "txtDescripcion"
		Me.txtDescripcion.Size = New System.Drawing.Size(200, 20)
		Me.txtDescripcion.TabIndex = 8
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
		Me.txtPrecio.Location = New System.Drawing.Point(122, 116)
		Me.txtPrecio.Name = "txtPrecio"
		Me.txtPrecio.Size = New System.Drawing.Size(200, 20)
		Me.txtPrecio.TabIndex = 5
		'
		'txtNuevaSubfamilia
		'
		Me.txtNuevaSubfamilia.Enabled = False
		Me.txtNuevaSubfamilia.Location = New System.Drawing.Point(122, 304)
		Me.txtNuevaSubfamilia.Name = "txtNuevaSubfamilia"
		Me.txtNuevaSubfamilia.Size = New System.Drawing.Size(200, 20)
		Me.txtNuevaSubfamilia.TabIndex = 11
		'
		'txtNuevaFamilia
		'
		Me.txtNuevaFamilia.Enabled = False
		Me.txtNuevaFamilia.Location = New System.Drawing.Point(122, 250)
		Me.txtNuevaFamilia.Name = "txtNuevaFamilia"
		Me.txtNuevaFamilia.Size = New System.Drawing.Size(200, 20)
		Me.txtNuevaFamilia.TabIndex = 8
		'
		'cbFamilia
		'
		Me.cbFamilia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
		Me.cbFamilia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.cbFamilia.FormattingEnabled = True
		Me.cbFamilia.Location = New System.Drawing.Point(122, 142)
		Me.cbFamilia.Name = "cbFamilia"
		Me.cbFamilia.Size = New System.Drawing.Size(200, 21)
		Me.cbFamilia.TabIndex = 6
		'
		'cbSubfamilia
		'
		Me.cbSubfamilia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
		Me.cbSubfamilia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.cbSubfamilia.FormattingEnabled = True
		Me.cbSubfamilia.Location = New System.Drawing.Point(122, 169)
		Me.cbSubfamilia.Name = "cbSubfamilia"
		Me.cbSubfamilia.Size = New System.Drawing.Size(200, 21)
		Me.cbSubfamilia.TabIndex = 7
		'
		'cbAgregarFam
		'
		Me.cbAgregarFam.AutoSize = True
		Me.cbAgregarFam.Location = New System.Drawing.Point(122, 227)
		Me.cbAgregarFam.Name = "cbAgregarFam"
		Me.cbAgregarFam.Size = New System.Drawing.Size(152, 17)
		Me.cbAgregarFam.TabIndex = 9
		Me.cbAgregarFam.Text = "Agregar una nueva familia "
		Me.cbAgregarFam.UseVisualStyleBackColor = True
		'
		'cbAgregarSub
		'
		Me.cbAgregarSub.AutoSize = True
		Me.cbAgregarSub.Location = New System.Drawing.Point(122, 281)
		Me.cbAgregarSub.Name = "cbAgregarSub"
		Me.cbAgregarSub.Size = New System.Drawing.Size(166, 17)
		Me.cbAgregarSub.TabIndex = 10
		Me.cbAgregarSub.Text = "Agregar una nueva subfamilia"
		Me.cbAgregarSub.UseVisualStyleBackColor = True
		'
		'btnAgregarProducto
		'
		Me.btnAgregarProducto.Location = New System.Drawing.Point(122, 330)
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
		Me.lblIdprovedor.Size = New System.Drawing.Size(106, 13)
		Me.lblIdprovedor.TabIndex = 16
		Me.lblIdprovedor.Text = "Codigo de proveedor"
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
		Me.tblArticulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.tblNombre, Me.tblcodigoAr, Me.tblpeso, Me.tblPrecio, Me.tblFamilia, Me.tblSubFamilia, Me.tblDescripcion})
		Me.tblArticulos.ContextMenuStrip = Me.cmsOpciones
		Me.tblArticulos.Location = New System.Drawing.Point(534, 12)
		Me.tblArticulos.Name = "tblArticulos"
		Me.tblArticulos.ReadOnly = True
		Me.tblArticulos.Size = New System.Drawing.Size(533, 377)
		Me.tblArticulos.TabIndex = 13
		'
		'tblNombre
		'
		Me.tblNombre.HeaderText = "Nombre"
		Me.tblNombre.Name = "tblNombre"
		Me.tblNombre.ReadOnly = True
		'
		'tblcodigoAr
		'
		Me.tblcodigoAr.HeaderText = "Codigo articulo"
		Me.tblcodigoAr.Name = "tblcodigoAr"
		Me.tblcodigoAr.ReadOnly = True
		'
		'tblpeso
		'
		Me.tblpeso.HeaderText = "peso"
		Me.tblpeso.Name = "tblpeso"
		Me.tblpeso.ReadOnly = True
		'
		'tblPrecio
		'
		Me.tblPrecio.HeaderText = "precio"
		Me.tblPrecio.Name = "tblPrecio"
		Me.tblPrecio.ReadOnly = True
		'
		'tblFamilia
		'
		Me.tblFamilia.HeaderText = "Familia"
		Me.tblFamilia.Name = "tblFamilia"
		Me.tblFamilia.ReadOnly = True
		'
		'tblSubFamilia
		'
		Me.tblSubFamilia.HeaderText = "Subfamilia"
		Me.tblSubFamilia.Name = "tblSubFamilia"
		Me.tblSubFamilia.ReadOnly = True
		'
		'tblDescripcion
		'
		Me.tblDescripcion.HeaderText = "Descripcion"
		Me.tblDescripcion.Name = "tblDescripcion"
		Me.tblDescripcion.ReadOnly = True
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
		'frmArticulo
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1079, 537)
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
		Me.Controls.Add(Me.txtDescripcion)
		Me.Controls.Add(Me.txtCodigo)
		Me.Controls.Add(Me.txtProveedor)
		Me.Controls.Add(Me.txtNombre)
		Me.Name = "frmArticulo"
		Me.Text = "FrmAgregarArticulo"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		CType(Me.tblArticulos, System.ComponentModel.ISupportInitialize).EndInit()
		Me.cmsOpciones.ResumeLayout(False)
		CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents txtNombre As TextBox
	Friend WithEvents txtProveedor As TextBox
	Friend WithEvents txtCodigo As TextBox
	Friend WithEvents txtDescripcion As TextBox
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
	Friend WithEvents tblNombre As DataGridViewTextBoxColumn
	Friend WithEvents tblcodigoAr As DataGridViewTextBoxColumn
	Friend WithEvents tblpeso As DataGridViewTextBoxColumn
	Friend WithEvents tblPrecio As DataGridViewTextBoxColumn
	Friend WithEvents tblFamilia As DataGridViewTextBoxColumn
	Friend WithEvents tblSubFamilia As DataGridViewTextBoxColumn
	Friend WithEvents tblDescripcion As DataGridViewTextBoxColumn
	Friend WithEvents pbImagen As PictureBox
	Friend WithEvents btnImagen As Button
End Class
