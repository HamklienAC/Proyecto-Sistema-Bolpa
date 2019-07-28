<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmFacturaCliente
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
		Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.txtIngresarCodigo = New System.Windows.Forms.TextBox()
		Me.tblProductos = New System.Windows.Forms.DataGridView()
		Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.MenuDesplegable = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.EliminarArticulosDeLaCompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.lblSubtotal = New System.Windows.Forms.Label()
		Me.lblIVA = New System.Windows.Forms.Label()
		Me.lblTotal = New System.Windows.Forms.Label()
		Me.btnBuscar = New System.Windows.Forms.Button()
		Me.lblIngreseProducto = New System.Windows.Forms.Label()
		CType(Me.tblProductos, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.MenuDesplegable.SuspendLayout()
		Me.SuspendLayout()
		'
		'txtIngresarCodigo
		'
		Me.txtIngresarCodigo.Location = New System.Drawing.Point(696, 33)
		Me.txtIngresarCodigo.Name = "txtIngresarCodigo"
		Me.txtIngresarCodigo.Size = New System.Drawing.Size(283, 20)
		Me.txtIngresarCodigo.TabIndex = 3
		'
		'tblProductos
		'
		Me.tblProductos.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.tblProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
		Me.tblProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.tblProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Producto, Me.Codigo, Me.Cantidad, Me.Precio})
		Me.tblProductos.ContextMenuStrip = Me.MenuDesplegable
		Me.tblProductos.Location = New System.Drawing.Point(12, 12)
		Me.tblProductos.Name = "tblProductos"
		Me.tblProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
		Me.tblProductos.Size = New System.Drawing.Size(644, 601)
		Me.tblProductos.TabIndex = 2
		'
		'Producto
		'
		DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
		DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
		DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlLight
		DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
		Me.Producto.DefaultCellStyle = DataGridViewCellStyle5
		Me.Producto.HeaderText = "Producto"
		Me.Producto.Name = "Producto"
		Me.Producto.ReadOnly = True
		Me.Producto.Width = 150
		'
		'Codigo
		'
		DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlLight
		DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
		Me.Codigo.DefaultCellStyle = DataGridViewCellStyle6
		Me.Codigo.HeaderText = "Codigo"
		Me.Codigo.Name = "Codigo"
		Me.Codigo.ReadOnly = True
		Me.Codigo.Width = 150
		'
		'Cantidad
		'
		DataGridViewCellStyle7.Format = "N0"
		DataGridViewCellStyle7.NullValue = Nothing
		DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ControlLight
		DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
		Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle7
		Me.Cantidad.HeaderText = "Cantidad"
		Me.Cantidad.Name = "Cantidad"
		Me.Cantidad.Width = 150
		'
		'Precio
		'
		DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ControlLight
		DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
		Me.Precio.DefaultCellStyle = DataGridViewCellStyle8
		Me.Precio.HeaderText = "Precio"
		Me.Precio.Name = "Precio"
		Me.Precio.ReadOnly = True
		Me.Precio.Width = 150
		'
		'MenuDesplegable
		'
		Me.MenuDesplegable.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarArticulosDeLaCompraToolStripMenuItem})
		Me.MenuDesplegable.Name = "ContextMenuStrip1"
		Me.MenuDesplegable.Size = New System.Drawing.Size(233, 26)
		'
		'EliminarArticulosDeLaCompraToolStripMenuItem
		'
		Me.EliminarArticulosDeLaCompraToolStripMenuItem.Name = "EliminarArticulosDeLaCompraToolStripMenuItem"
		Me.EliminarArticulosDeLaCompraToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
		Me.EliminarArticulosDeLaCompraToolStripMenuItem.Text = "Eliminar articulo de la compra"
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(749, 457)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(283, 23)
		Me.Button1.TabIndex = 4
		Me.Button1.Text = "Button1"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(746, 506)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(39, 13)
		Me.Label1.TabIndex = 5
		Me.Label1.Text = "Label1"
		'
		'lblSubtotal
		'
		Me.lblSubtotal.AutoSize = True
		Me.lblSubtotal.Location = New System.Drawing.Point(702, 160)
		Me.lblSubtotal.Name = "lblSubtotal"
		Me.lblSubtotal.Size = New System.Drawing.Size(46, 13)
		Me.lblSubtotal.TabIndex = 7
		Me.lblSubtotal.Text = "Subtotal"
		'
		'lblIVA
		'
		Me.lblIVA.AutoSize = True
		Me.lblIVA.Location = New System.Drawing.Point(702, 194)
		Me.lblIVA.Name = "lblIVA"
		Me.lblIVA.Size = New System.Drawing.Size(24, 13)
		Me.lblIVA.TabIndex = 8
		Me.lblIVA.Text = "IVA"
		'
		'lblTotal
		'
		Me.lblTotal.AutoSize = True
		Me.lblTotal.Location = New System.Drawing.Point(702, 227)
		Me.lblTotal.Name = "lblTotal"
		Me.lblTotal.Size = New System.Drawing.Size(31, 13)
		Me.lblTotal.TabIndex = 9
		Me.lblTotal.Text = "Total"
		'
		'btnBuscar
		'
		Me.btnBuscar.Location = New System.Drawing.Point(985, 31)
		Me.btnBuscar.Name = "btnBuscar"
		Me.btnBuscar.Size = New System.Drawing.Size(76, 23)
		Me.btnBuscar.TabIndex = 10
		Me.btnBuscar.Text = "Buscar"
		Me.btnBuscar.UseVisualStyleBackColor = True
		'
		'lblIngreseProducto
		'
		Me.lblIngreseProducto.AutoSize = True
		Me.lblIngreseProducto.Location = New System.Drawing.Point(693, 12)
		Me.lblIngreseProducto.Name = "lblIngreseProducto"
		Me.lblIngreseProducto.Size = New System.Drawing.Size(101, 13)
		Me.lblIngreseProducto.TabIndex = 11
		Me.lblIngreseProducto.Text = "Ingrese el producto "
		'
		'FrmFactura
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1169, 625)
		Me.Controls.Add(Me.lblIngreseProducto)
		Me.Controls.Add(Me.btnBuscar)
		Me.Controls.Add(Me.lblTotal)
		Me.Controls.Add(Me.lblIVA)
		Me.Controls.Add(Me.lblSubtotal)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.txtIngresarCodigo)
		Me.Controls.Add(Me.tblProductos)
		Me.Name = "FrmFactura"
		Me.Text = "FrmFactura"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		CType(Me.tblProductos, System.ComponentModel.ISupportInitialize).EndInit()
		Me.MenuDesplegable.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents txtIngresarCodigo As TextBox
	Friend WithEvents tblProductos As DataGridView
	Friend WithEvents Button1 As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents lblSubtotal As Label
	Friend WithEvents lblIVA As Label
	Friend WithEvents lblTotal As Label
	Friend WithEvents Producto As DataGridViewTextBoxColumn
	Friend WithEvents Codigo As DataGridViewTextBoxColumn
	Friend WithEvents Cantidad As DataGridViewTextBoxColumn
	Friend WithEvents Precio As DataGridViewTextBoxColumn
	Friend WithEvents MenuDesplegable As ContextMenuStrip
	Friend WithEvents EliminarArticulosDeLaCompraToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents btnBuscar As Button
	Friend WithEvents lblIngreseProducto As Label
End Class
