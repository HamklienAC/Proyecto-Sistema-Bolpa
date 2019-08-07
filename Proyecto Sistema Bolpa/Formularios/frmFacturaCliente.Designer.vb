<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFacturaCliente
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
		Me.CProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.CCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.CCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.CPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.cmsOpciones = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.EliminarArticulosDeLaCompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.lblSubtotal = New System.Windows.Forms.Label()
		Me.lblIVA = New System.Windows.Forms.Label()
		Me.lblTotal = New System.Windows.Forms.Label()
		Me.btnBuscar = New System.Windows.Forms.Button()
		Me.lblIngreseProducto = New System.Windows.Forms.Label()
		Me.lblCantidad = New System.Windows.Forms.Label()
		Me.txtCantidad = New System.Windows.Forms.TextBox()
		CType(Me.tblProductos, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.cmsOpciones.SuspendLayout()
		Me.SuspendLayout()
		'
		'txtIngresarCodigo
		'
		Me.txtIngresarCodigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
		Me.txtIngresarCodigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
		Me.txtIngresarCodigo.Location = New System.Drawing.Point(12, 25)
		Me.txtIngresarCodigo.Name = "txtIngresarCodigo"
		Me.txtIngresarCodigo.Size = New System.Drawing.Size(462, 20)
		Me.txtIngresarCodigo.TabIndex = 3
		'
		'tblProductos
		'
		Me.tblProductos.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.tblProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
		Me.tblProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.tblProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CProducto, Me.CCodigo, Me.CCantidad, Me.CPrecio})
		Me.tblProductos.ContextMenuStrip = Me.cmsOpciones
		Me.tblProductos.Location = New System.Drawing.Point(12, 51)
		Me.tblProductos.Name = "tblProductos"
		Me.tblProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
		Me.tblProductos.Size = New System.Drawing.Size(644, 601)
		Me.tblProductos.TabIndex = 2
		'
		'CProducto
		'
		DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
		DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
		Me.CProducto.DefaultCellStyle = DataGridViewCellStyle1
		Me.CProducto.HeaderText = "Producto"
		Me.CProducto.Name = "CProducto"
		Me.CProducto.ReadOnly = True
		Me.CProducto.Width = 75
		'
		'CCodigo
		'
		DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight
		DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
		Me.CCodigo.DefaultCellStyle = DataGridViewCellStyle2
		Me.CCodigo.HeaderText = "Codigo"
		Me.CCodigo.Name = "CCodigo"
		Me.CCodigo.ReadOnly = True
		Me.CCodigo.Width = 65
		'
		'CCantidad
		'
		DataGridViewCellStyle3.Format = "N0"
		DataGridViewCellStyle3.NullValue = Nothing
		DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlLight
		DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
		Me.CCantidad.DefaultCellStyle = DataGridViewCellStyle3
		Me.CCantidad.HeaderText = "Cantidad"
		Me.CCantidad.Name = "CCantidad"
		Me.CCantidad.Width = 74
		'
		'CPrecio
		'
		DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLight
		DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
		Me.CPrecio.DefaultCellStyle = DataGridViewCellStyle4
		Me.CPrecio.HeaderText = "Precio"
		Me.CPrecio.Name = "CPrecio"
		Me.CPrecio.ReadOnly = True
		Me.CPrecio.Width = 62
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
		'lblSubtotal
		'
		Me.lblSubtotal.AutoSize = True
		Me.lblSubtotal.Location = New System.Drawing.Point(662, 456)
		Me.lblSubtotal.Name = "lblSubtotal"
		Me.lblSubtotal.Size = New System.Drawing.Size(49, 13)
		Me.lblSubtotal.TabIndex = 7
		Me.lblSubtotal.Text = "Subtotal:"
		'
		'lblIVA
		'
		Me.lblIVA.AutoSize = True
		Me.lblIVA.Location = New System.Drawing.Point(662, 490)
		Me.lblIVA.Name = "lblIVA"
		Me.lblIVA.Size = New System.Drawing.Size(27, 13)
		Me.lblIVA.TabIndex = 8
		Me.lblIVA.Text = "IVA:"
		'
		'lblTotal
		'
		Me.lblTotal.AutoSize = True
		Me.lblTotal.Location = New System.Drawing.Point(662, 523)
		Me.lblTotal.Name = "lblTotal"
		Me.lblTotal.Size = New System.Drawing.Size(34, 13)
		Me.lblTotal.TabIndex = 9
		Me.lblTotal.Text = "Total:"
		'
		'btnBuscar
		'
		Me.btnBuscar.Location = New System.Drawing.Point(662, 22)
		Me.btnBuscar.Name = "btnBuscar"
		Me.btnBuscar.Size = New System.Drawing.Size(76, 23)
		Me.btnBuscar.TabIndex = 10
		Me.btnBuscar.Text = "Buscar"
		Me.btnBuscar.UseVisualStyleBackColor = True
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
		Me.lblCantidad.Location = New System.Drawing.Point(477, 9)
		Me.lblCantidad.Name = "lblCantidad"
		Me.lblCantidad.Size = New System.Drawing.Size(52, 13)
		Me.lblCantidad.TabIndex = 12
		Me.lblCantidad.Text = "Cantidad "
		'
		'txtCantidad
		'
		Me.txtCantidad.Location = New System.Drawing.Point(480, 25)
		Me.txtCantidad.Name = "txtCantidad"
		Me.txtCantidad.Size = New System.Drawing.Size(176, 20)
		Me.txtCantidad.TabIndex = 13
		'
		'frmFacturaCliente
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(953, 625)
		Me.Controls.Add(Me.txtCantidad)
		Me.Controls.Add(Me.lblCantidad)
		Me.Controls.Add(Me.lblIngreseProducto)
		Me.Controls.Add(Me.btnBuscar)
		Me.Controls.Add(Me.lblTotal)
		Me.Controls.Add(Me.lblIVA)
		Me.Controls.Add(Me.lblSubtotal)
		Me.Controls.Add(Me.txtIngresarCodigo)
		Me.Controls.Add(Me.tblProductos)
		Me.Name = "frmFacturaCliente"
		Me.Text = "frmFacturaCliente"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		CType(Me.tblProductos, System.ComponentModel.ISupportInitialize).EndInit()
		Me.cmsOpciones.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents txtIngresarCodigo As TextBox
	Friend WithEvents tblProductos As DataGridView
	Friend WithEvents lblSubtotal As Label
	Friend WithEvents lblIVA As Label
	Friend WithEvents lblTotal As Label
	Friend WithEvents cmsOpciones As ContextMenuStrip
	Friend WithEvents EliminarArticulosDeLaCompraToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents btnBuscar As Button
	Friend WithEvents lblIngreseProducto As Label
	Friend WithEvents lblCantidad As Label
	Friend WithEvents txtCantidad As TextBox
	Friend WithEvents CProducto As DataGridViewTextBoxColumn
	Friend WithEvents CCodigo As DataGridViewTextBoxColumn
	Friend WithEvents CCantidad As DataGridViewTextBoxColumn
	Friend WithEvents CPrecio As DataGridViewTextBoxColumn
End Class
