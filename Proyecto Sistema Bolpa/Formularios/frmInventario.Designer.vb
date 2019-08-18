<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInventario
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
		Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
		Me.tblInventario = New System.Windows.Forms.DataGridView()
		Me.cmsOpcionesInventario = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.ActualizarLoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.EliminarLoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.Splitter1 = New System.Windows.Forms.Splitter()
		Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
		Me.tblProveedor = New System.Windows.Forms.DataGridView()
		Me.tblArticulo = New System.Windows.Forms.DataGridView()
		Me.epError = New System.Windows.Forms.ErrorProvider(Me.components)
		Me.tblLote = New System.Windows.Forms.DataGridView()
		Me.txtProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.txtArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.txtUnidades = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.txtMonto = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.dtpCaducidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.txtEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.cmsOpcionesLote = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.EliminarFilaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.btnCrud = New System.Windows.Forms.Button()
		Me.Panel2 = New System.Windows.Forms.Panel()
		CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SplitContainer1.Panel1.SuspendLayout()
		Me.SplitContainer1.Panel2.SuspendLayout()
		Me.SplitContainer1.SuspendLayout()
		CType(Me.tblInventario, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.cmsOpcionesInventario.SuspendLayout()
		CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SplitContainer2.Panel1.SuspendLayout()
		Me.SplitContainer2.Panel2.SuspendLayout()
		Me.SplitContainer2.SuspendLayout()
		CType(Me.tblProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.tblArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.epError, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.tblLote, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.cmsOpcionesLote.SuspendLayout()
		Me.Panel2.SuspendLayout()
		Me.SuspendLayout()
		'
		'SplitContainer1
		'
		Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.SplitContainer1.Location = New System.Drawing.Point(488, 13)
		Me.SplitContainer1.Name = "SplitContainer1"
		'
		'SplitContainer1.Panel1
		'
		Me.SplitContainer1.Panel1.Controls.Add(Me.tblInventario)
		Me.SplitContainer1.Panel1.Controls.Add(Me.Splitter1)
		'
		'SplitContainer1.Panel2
		'
		Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
		Me.SplitContainer1.Size = New System.Drawing.Size(613, 545)
		Me.SplitContainer1.SplitterDistance = 201
		Me.SplitContainer1.TabIndex = 1
		'
		'tblInventario
		'
		Me.tblInventario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tblInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.tblInventario.ContextMenuStrip = Me.cmsOpcionesInventario
		Me.tblInventario.Location = New System.Drawing.Point(4, 3)
		Me.tblInventario.Name = "tblInventario"
		Me.tblInventario.ReadOnly = True
		Me.tblInventario.Size = New System.Drawing.Size(266, 536)
		Me.tblInventario.TabIndex = 2
		'
		'cmsOpcionesInventario
		'
		Me.cmsOpcionesInventario.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActualizarLoteToolStripMenuItem, Me.EliminarLoteToolStripMenuItem})
		Me.cmsOpcionesInventario.Name = "cmsOpciones"
		Me.cmsOpcionesInventario.Size = New System.Drawing.Size(150, 48)
		'
		'ActualizarLoteToolStripMenuItem
		'
		Me.ActualizarLoteToolStripMenuItem.Name = "ActualizarLoteToolStripMenuItem"
		Me.ActualizarLoteToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
		Me.ActualizarLoteToolStripMenuItem.Text = "Actualizar lote"
		'
		'EliminarLoteToolStripMenuItem
		'
		Me.EliminarLoteToolStripMenuItem.Name = "EliminarLoteToolStripMenuItem"
		Me.EliminarLoteToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
		Me.EliminarLoteToolStripMenuItem.Text = "Eliminar lote"
		'
		'Splitter1
		'
		Me.Splitter1.Location = New System.Drawing.Point(0, 0)
		Me.Splitter1.Name = "Splitter1"
		Me.Splitter1.Size = New System.Drawing.Size(3, 545)
		Me.Splitter1.TabIndex = 1
		Me.Splitter1.TabStop = False
		'
		'SplitContainer2
		'
		Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
		Me.SplitContainer2.Name = "SplitContainer2"
		'
		'SplitContainer2.Panel1
		'
		Me.SplitContainer2.Panel1.Controls.Add(Me.tblProveedor)
		'
		'SplitContainer2.Panel2
		'
		Me.SplitContainer2.Panel2.Controls.Add(Me.tblArticulo)
		Me.SplitContainer2.Size = New System.Drawing.Size(408, 545)
		Me.SplitContainer2.SplitterDistance = 204
		Me.SplitContainer2.TabIndex = 0
		'
		'tblProveedor
		'
		Me.tblProveedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tblProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.tblProveedor.Location = New System.Drawing.Point(3, 3)
		Me.tblProveedor.Name = "tblProveedor"
		Me.tblProveedor.ReadOnly = True
		Me.tblProveedor.Size = New System.Drawing.Size(296, 536)
		Me.tblProveedor.TabIndex = 0
		'
		'tblArticulo
		'
		Me.tblArticulo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tblArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.tblArticulo.Location = New System.Drawing.Point(3, 3)
		Me.tblArticulo.Name = "tblArticulo"
		Me.tblArticulo.ReadOnly = True
		Me.tblArticulo.Size = New System.Drawing.Size(278, 536)
		Me.tblArticulo.TabIndex = 0
		'
		'epError
		'
		Me.epError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
		Me.epError.ContainerControl = Me
		'
		'tblLote
		'
		Me.tblLote.AllowUserToAddRows = False
		Me.tblLote.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tblLote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.tblLote.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.txtProveedor, Me.txtArticulo, Me.txtUnidades, Me.txtMonto, Me.dtpCaducidad, Me.txtEstado})
		Me.tblLote.ContextMenuStrip = Me.cmsOpcionesLote
		Me.tblLote.Location = New System.Drawing.Point(4, 4)
		Me.tblLote.Name = "tblLote"
		Me.tblLote.Size = New System.Drawing.Size(467, 507)
		Me.tblLote.TabIndex = 0
		'
		'txtProveedor
		'
		Me.txtProveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		DataGridViewCellStyle5.NullValue = Nothing
		Me.txtProveedor.DefaultCellStyle = DataGridViewCellStyle5
		Me.txtProveedor.HeaderText = "Código del proveedor"
		Me.txtProveedor.Name = "txtProveedor"
		'
		'txtArticulo
		'
		Me.txtArticulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		DataGridViewCellStyle6.NullValue = Nothing
		Me.txtArticulo.DefaultCellStyle = DataGridViewCellStyle6
		Me.txtArticulo.HeaderText = "Código del artículo"
		Me.txtArticulo.Name = "txtArticulo"
		'
		'txtUnidades
		'
		Me.txtUnidades.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		DataGridViewCellStyle7.NullValue = Nothing
		Me.txtUnidades.DefaultCellStyle = DataGridViewCellStyle7
		Me.txtUnidades.HeaderText = "Unidades"
		Me.txtUnidades.Name = "txtUnidades"
		'
		'txtMonto
		'
		Me.txtMonto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		DataGridViewCellStyle8.NullValue = Nothing
		Me.txtMonto.DefaultCellStyle = DataGridViewCellStyle8
		Me.txtMonto.HeaderText = "Monto"
		Me.txtMonto.Name = "txtMonto"
		'
		'dtpCaducidad
		'
		Me.dtpCaducidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.dtpCaducidad.HeaderText = "Fecha de caducidad"
		Me.dtpCaducidad.Name = "dtpCaducidad"
		'
		'txtEstado
		'
		Me.txtEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.txtEstado.HeaderText = "Estado"
		Me.txtEstado.Name = "txtEstado"
		'
		'cmsOpcionesLote
		'
		Me.cmsOpcionesLote.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarFilaToolStripMenuItem})
		Me.cmsOpcionesLote.Name = "ContextMenuStrip1"
		Me.cmsOpcionesLote.Size = New System.Drawing.Size(137, 26)
		'
		'EliminarFilaToolStripMenuItem
		'
		Me.EliminarFilaToolStripMenuItem.Name = "EliminarFilaToolStripMenuItem"
		Me.EliminarFilaToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
		Me.EliminarFilaToolStripMenuItem.Text = "Eliminar fila"
		'
		'btnCrud
		'
		Me.btnCrud.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.btnCrud.Location = New System.Drawing.Point(16, 529)
		Me.btnCrud.Name = "btnCrud"
		Me.btnCrud.Size = New System.Drawing.Size(467, 23)
		Me.btnCrud.TabIndex = 6
		Me.btnCrud.Text = "Agregar lote"
		Me.btnCrud.UseVisualStyleBackColor = True
		'
		'Panel2
		'
		Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.Panel2.Controls.Add(Me.tblLote)
		Me.Panel2.Location = New System.Drawing.Point(12, 12)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(474, 517)
		Me.Panel2.TabIndex = 2
		'
		'frmInventario
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1117, 570)
		Me.Controls.Add(Me.btnCrud)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.SplitContainer1)
		Me.Name = "frmInventario"
		Me.Text = "frmInventario"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.SplitContainer1.Panel1.ResumeLayout(False)
		Me.SplitContainer1.Panel2.ResumeLayout(False)
		CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.SplitContainer1.ResumeLayout(False)
		CType(Me.tblInventario, System.ComponentModel.ISupportInitialize).EndInit()
		Me.cmsOpcionesInventario.ResumeLayout(False)
		Me.SplitContainer2.Panel1.ResumeLayout(False)
		Me.SplitContainer2.Panel2.ResumeLayout(False)
		CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.SplitContainer2.ResumeLayout(False)
		CType(Me.tblProveedor, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tblArticulo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.epError, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tblLote, System.ComponentModel.ISupportInitialize).EndInit()
		Me.cmsOpcionesLote.ResumeLayout(False)
		Me.Panel2.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents SplitContainer1 As SplitContainer
	Friend WithEvents tblProveedor As DataGridView
	Friend WithEvents tblArticulo As DataGridView
	Friend WithEvents Splitter1 As Splitter
	Friend WithEvents tblInventario As DataGridView
	Friend WithEvents SplitContainer2 As SplitContainer
	Friend WithEvents cmsOpcionesInventario As ContextMenuStrip
	Friend WithEvents ActualizarLoteToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents EliminarLoteToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents epError As ErrorProvider
	Friend WithEvents btnCrud As Button
	Friend WithEvents tblLote As DataGridView
	Friend WithEvents Panel2 As Panel
	Friend WithEvents txtProveedor As DataGridViewTextBoxColumn
	Friend WithEvents txtArticulo As DataGridViewTextBoxColumn
	Friend WithEvents txtUnidades As DataGridViewTextBoxColumn
	Friend WithEvents txtMonto As DataGridViewTextBoxColumn
	Friend WithEvents dtpCaducidad As DataGridViewTextBoxColumn
	Friend WithEvents txtEstado As DataGridViewTextBoxColumn
	Friend WithEvents cmsOpcionesLote As ContextMenuStrip
	Friend WithEvents EliminarFilaToolStripMenuItem As ToolStripMenuItem
End Class
