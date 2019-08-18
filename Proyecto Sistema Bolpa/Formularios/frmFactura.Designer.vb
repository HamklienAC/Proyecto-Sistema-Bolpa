<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFactura
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
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.txtIngresarCodigo = New System.Windows.Forms.TextBox()
		Me.tblProductos = New System.Windows.Forms.DataGridView()
		Me.tblTxtProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.tblTxtCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.tblTxtCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.tblTxtPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.cmsOpciones = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.EliminarArticulosDeLaCompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.lblTotal = New System.Windows.Forms.Label()
		Me.lblIngreseProducto = New System.Windows.Forms.Label()
		Me.lblCantidad = New System.Windows.Forms.Label()
		Me.txtCantidad = New System.Windows.Forms.TextBox()
		Me.pInfomacionCliente = New System.Windows.Forms.Panel()
		Me.lblCliente = New System.Windows.Forms.Label()
		Me.cbProveedores = New System.Windows.Forms.ComboBox()
		Me.lblTipoFomulario = New System.Windows.Forms.Label()
		Me.cbTipoFomulario = New System.Windows.Forms.ComboBox()
		Me.pInformacionCaja = New System.Windows.Forms.Panel()
		Me.lblMontoTotal = New System.Windows.Forms.Label()
		Me.lblProveedor = New System.Windows.Forms.Label()
		Me.cbArticulos = New System.Windows.Forms.ComboBox()
		CType(Me.tblProductos, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.cmsOpciones.SuspendLayout()
		Me.pInfomacionCliente.SuspendLayout()
		Me.pInformacionCaja.SuspendLayout()
		Me.SuspendLayout()
		'
		'txtIngresarCodigo
		'
		Me.txtIngresarCodigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
		Me.txtIngresarCodigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
		Me.txtIngresarCodigo.Location = New System.Drawing.Point(12, 25)
		Me.txtIngresarCodigo.MaximumSize = New System.Drawing.Size(4, 200)
		Me.txtIngresarCodigo.Name = "txtIngresarCodigo"
		Me.txtIngresarCodigo.Size = New System.Drawing.Size(0, 20)
		Me.txtIngresarCodigo.TabIndex = 3
		'
		'tblProductos
		'
		Me.tblProductos.AllowUserToAddRows = False
		Me.tblProductos.AllowUserToOrderColumns = True
		Me.tblProductos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tblProductos.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.tblProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
		Me.tblProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.tblProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.tblTxtProducto, Me.tblTxtCodigo, Me.tblTxtCantidad, Me.tblTxtPrecio})
		Me.tblProductos.ContextMenuStrip = Me.cmsOpciones
		Me.tblProductos.Location = New System.Drawing.Point(12, 91)
		Me.tblProductos.Name = "tblProductos"
		Me.tblProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
		Me.tblProductos.Size = New System.Drawing.Size(641, 534)
		Me.tblProductos.TabIndex = 2
		'
		'tblTxtProducto
		'
		Me.tblTxtProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
		DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
		Me.tblTxtProducto.DefaultCellStyle = DataGridViewCellStyle1
		Me.tblTxtProducto.HeaderText = "Producto"
		Me.tblTxtProducto.Name = "tblTxtProducto"
		Me.tblTxtProducto.ReadOnly = True
		'
		'tblTxtCodigo
		'
		Me.tblTxtCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight
		DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
		Me.tblTxtCodigo.DefaultCellStyle = DataGridViewCellStyle2
		Me.tblTxtCodigo.HeaderText = "Codigo"
		Me.tblTxtCodigo.Name = "tblTxtCodigo"
		Me.tblTxtCodigo.ReadOnly = True
		'
		'tblTxtCantidad
		'
		Me.tblTxtCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		DataGridViewCellStyle3.Format = "N0"
		DataGridViewCellStyle3.NullValue = Nothing
		DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlLight
		DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
		Me.tblTxtCantidad.DefaultCellStyle = DataGridViewCellStyle3
		Me.tblTxtCantidad.HeaderText = "Cantidad"
		Me.tblTxtCantidad.Name = "tblTxtCantidad"
		'
		'tblTxtPrecio
		'
		Me.tblTxtPrecio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLight
		DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
		Me.tblTxtPrecio.DefaultCellStyle = DataGridViewCellStyle4
		Me.tblTxtPrecio.HeaderText = "Precio"
		Me.tblTxtPrecio.Name = "tblTxtPrecio"
		Me.tblTxtPrecio.ReadOnly = True
		'
		'cmsOpciones
		'
		Me.cmsOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarArticulosDeLaCompraToolStripMenuItem})
		Me.cmsOpciones.Name = "ContextMenuStrip1"
		Me.cmsOpciones.Size = New System.Drawing.Size(233, 26)
		'
		'EliminarArticulosDeLaCompraToolStripMenuItem
		'
		Me.EliminarArticulosDeLaCompraToolStripMenuItem.Name = "EliminarArticulosDeLaCompraToolStripMenuItem"
		Me.EliminarArticulosDeLaCompraToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
		Me.EliminarArticulosDeLaCompraToolStripMenuItem.Text = "Eliminar articulo de la compra"
		'
		'lblTotal
		'
		Me.lblTotal.AutoSize = True
		Me.lblTotal.Location = New System.Drawing.Point(3, 544)
		Me.lblTotal.Name = "lblTotal"
		Me.lblTotal.Size = New System.Drawing.Size(34, 13)
		Me.lblTotal.TabIndex = 9
		Me.lblTotal.Text = "Total:"
		'
		'lblIngreseProducto
		'
		Me.lblIngreseProducto.AutoSize = True
		Me.lblIngreseProducto.Location = New System.Drawing.Point(12, 9)
		Me.lblIngreseProducto.Name = "lblIngreseProducto"
		Me.lblIngreseProducto.Size = New System.Drawing.Size(101, 13)
		Me.lblIngreseProducto.TabIndex = 11
		Me.lblIngreseProducto.Text = "Ingrese el producto "
		'
		'lblCantidad
		'
		Me.lblCantidad.AutoSize = True
		Me.lblCantidad.Location = New System.Drawing.Point(474, 9)
		Me.lblCantidad.Name = "lblCantidad"
		Me.lblCantidad.Size = New System.Drawing.Size(52, 13)
		Me.lblCantidad.TabIndex = 12
		Me.lblCantidad.Text = "Cantidad "
		'
		'txtCantidad
		'
		Me.txtCantidad.Location = New System.Drawing.Point(477, 25)
		Me.txtCantidad.Name = "txtCantidad"
		Me.txtCantidad.Size = New System.Drawing.Size(176, 20)
		Me.txtCantidad.TabIndex = 13
		'
		'pInfomacionCliente
		'
		Me.pInfomacionCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.pInfomacionCliente.Controls.Add(Me.lblCliente)
		Me.pInfomacionCliente.Location = New System.Drawing.Point(12, 631)
		Me.pInfomacionCliente.Name = "pInfomacionCliente"
		Me.pInfomacionCliente.Size = New System.Drawing.Size(641, 74)
		Me.pInfomacionCliente.TabIndex = 15
		'
		'lblCliente
		'
		Me.lblCliente.AutoSize = True
		Me.lblCliente.Location = New System.Drawing.Point(4, 4)
		Me.lblCliente.Name = "lblCliente"
		Me.lblCliente.Size = New System.Drawing.Size(91, 13)
		Me.lblCliente.TabIndex = 0
		Me.lblCliente.Text = "NombreCompleto "
		'
		'cbProveedores
		'
		Me.cbProveedores.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
		Me.cbProveedores.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.cbProveedores.FormattingEnabled = True
		Me.cbProveedores.Location = New System.Drawing.Point(12, 64)
		Me.cbProveedores.Name = "cbProveedores"
		Me.cbProveedores.Size = New System.Drawing.Size(641, 21)
		Me.cbProveedores.TabIndex = 16
		'
		'lblTipoFomulario
		'
		Me.lblTipoFomulario.AutoSize = True
		Me.lblTipoFomulario.Location = New System.Drawing.Point(659, 9)
		Me.lblTipoFomulario.Name = "lblTipoFomulario"
		Me.lblTipoFomulario.Size = New System.Drawing.Size(68, 13)
		Me.lblTipoFomulario.TabIndex = 17
		Me.lblTipoFomulario.Text = "Tipo de vista"
		Me.lblTipoFomulario.UseMnemonic = False
		'
		'cbTipoFomulario
		'
		Me.cbTipoFomulario.FormattingEnabled = True
		Me.cbTipoFomulario.Items.AddRange(New Object() {"Factura de cliente", "Factura de proveedor"})
		Me.cbTipoFomulario.Location = New System.Drawing.Point(662, 24)
		Me.cbTipoFomulario.Name = "cbTipoFomulario"
		Me.cbTipoFomulario.Size = New System.Drawing.Size(121, 21)
		Me.cbTipoFomulario.TabIndex = 18
		'
		'pInformacionCaja
		'
		Me.pInformacionCaja.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pInformacionCaja.Controls.Add(Me.lblMontoTotal)
		Me.pInformacionCaja.Controls.Add(Me.lblTotal)
		Me.pInformacionCaja.Location = New System.Drawing.Point(662, 91)
		Me.pInformacionCaja.Name = "pInformacionCaja"
		Me.pInformacionCaja.Size = New System.Drawing.Size(200, 614)
		Me.pInformacionCaja.TabIndex = 19
		'
		'lblMontoTotal
		'
		Me.lblMontoTotal.AutoSize = True
		Me.lblMontoTotal.Location = New System.Drawing.Point(43, 544)
		Me.lblMontoTotal.Name = "lblMontoTotal"
		Me.lblMontoTotal.Size = New System.Drawing.Size(13, 13)
		Me.lblMontoTotal.TabIndex = 10
		Me.lblMontoTotal.Text = "0"
		'
		'lblProveedor
		'
		Me.lblProveedor.AutoSize = True
		Me.lblProveedor.Location = New System.Drawing.Point(9, 48)
		Me.lblProveedor.Name = "lblProveedor"
		Me.lblProveedor.Size = New System.Drawing.Size(56, 13)
		Me.lblProveedor.TabIndex = 20
		Me.lblProveedor.Text = "Proveedor"
		'
		'cbArticulos
		'
		Me.cbArticulos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
		Me.cbArticulos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.cbArticulos.FormattingEnabled = True
		Me.cbArticulos.Location = New System.Drawing.Point(15, 24)
		Me.cbArticulos.Name = "cbArticulos"
		Me.cbArticulos.Size = New System.Drawing.Size(456, 21)
		Me.cbArticulos.TabIndex = 21
		'
		'frmFactura
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(874, 713)
		Me.Controls.Add(Me.cbArticulos)
		Me.Controls.Add(Me.lblProveedor)
		Me.Controls.Add(Me.pInformacionCaja)
		Me.Controls.Add(Me.cbTipoFomulario)
		Me.Controls.Add(Me.lblTipoFomulario)
		Me.Controls.Add(Me.cbProveedores)
		Me.Controls.Add(Me.pInfomacionCliente)
		Me.Controls.Add(Me.txtCantidad)
		Me.Controls.Add(Me.lblCantidad)
		Me.Controls.Add(Me.lblIngreseProducto)
		Me.Controls.Add(Me.txtIngresarCodigo)
		Me.Controls.Add(Me.tblProductos)
		Me.Name = "frmFactura"
		Me.Text = "frmFacturaCliente"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		CType(Me.tblProductos, System.ComponentModel.ISupportInitialize).EndInit()
		Me.cmsOpciones.ResumeLayout(False)
		Me.pInfomacionCliente.ResumeLayout(False)
		Me.pInfomacionCliente.PerformLayout()
		Me.pInformacionCaja.ResumeLayout(False)
		Me.pInformacionCaja.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents txtIngresarCodigo As TextBox
	Friend WithEvents tblProductos As DataGridView
	Friend WithEvents lblTotal As Label
	Friend WithEvents cmsOpciones As ContextMenuStrip
	Friend WithEvents EliminarArticulosDeLaCompraToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents lblIngreseProducto As Label
	Friend WithEvents lblCantidad As Label
	Friend WithEvents txtCantidad As TextBox
	Friend WithEvents pInfomacionCliente As Panel
	Friend WithEvents cbProveedores As ComboBox
	Friend WithEvents lblTipoFomulario As Label
	Friend WithEvents cbTipoFomulario As ComboBox
	Friend WithEvents pInformacionCaja As Panel
	Friend WithEvents lblCliente As Label
	Friend WithEvents tblTxtProducto As DataGridViewTextBoxColumn
	Friend WithEvents tblTxtCodigo As DataGridViewTextBoxColumn
	Friend WithEvents tblTxtCantidad As DataGridViewTextBoxColumn
	Friend WithEvents tblTxtPrecio As DataGridViewTextBoxColumn
	Friend WithEvents lblProveedor As Label
	Friend WithEvents cbArticulos As ComboBox
	Friend WithEvents lblMontoTotal As Label
End Class
