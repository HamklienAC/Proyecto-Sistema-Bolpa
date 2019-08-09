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
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.btnCrud = New System.Windows.Forms.Button()
		Me.lblEstado = New System.Windows.Forms.Label()
		Me.lblCaducidad = New System.Windows.Forms.Label()
		Me.lblMonto = New System.Windows.Forms.Label()
		Me.lblUnidades = New System.Windows.Forms.Label()
		Me.lblCodigoArticulo = New System.Windows.Forms.Label()
		Me.lblCodigoProveedor = New System.Windows.Forms.Label()
		Me.dtpCaducidad = New System.Windows.Forms.DateTimePicker()
		Me.txtEstado = New System.Windows.Forms.TextBox()
		Me.txtMonto = New System.Windows.Forms.TextBox()
		Me.txtUnidades = New System.Windows.Forms.TextBox()
		Me.txtArticulo = New System.Windows.Forms.TextBox()
		Me.txtProveedor = New System.Windows.Forms.TextBox()
		Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
		Me.tblInventario = New System.Windows.Forms.DataGridView()
		Me.cmsOpciones = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.ActualizarLoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.EliminarLoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.Splitter1 = New System.Windows.Forms.Splitter()
		Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
		Me.tblProveedor = New System.Windows.Forms.DataGridView()
		Me.tblArticulo = New System.Windows.Forms.DataGridView()
		Me.EPError = New System.Windows.Forms.ErrorProvider(Me.components)
		Me.Panel1.SuspendLayout()
		CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SplitContainer1.Panel1.SuspendLayout()
		Me.SplitContainer1.Panel2.SuspendLayout()
		Me.SplitContainer1.SuspendLayout()
		CType(Me.tblInventario, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.cmsOpciones.SuspendLayout()
		CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SplitContainer2.Panel1.SuspendLayout()
		Me.SplitContainer2.Panel2.SuspendLayout()
		Me.SplitContainer2.SuspendLayout()
		CType(Me.tblProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.tblArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.EPError, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Panel1.Controls.Add(Me.btnCrud)
		Me.Panel1.Controls.Add(Me.lblEstado)
		Me.Panel1.Controls.Add(Me.lblCaducidad)
		Me.Panel1.Controls.Add(Me.lblMonto)
		Me.Panel1.Controls.Add(Me.lblUnidades)
		Me.Panel1.Controls.Add(Me.lblCodigoArticulo)
		Me.Panel1.Controls.Add(Me.lblCodigoProveedor)
		Me.Panel1.Controls.Add(Me.dtpCaducidad)
		Me.Panel1.Controls.Add(Me.txtEstado)
		Me.Panel1.Controls.Add(Me.txtMonto)
		Me.Panel1.Controls.Add(Me.txtUnidades)
		Me.Panel1.Controls.Add(Me.txtArticulo)
		Me.Panel1.Controls.Add(Me.txtProveedor)
		Me.Panel1.Location = New System.Drawing.Point(12, 13)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(329, 545)
		Me.Panel1.TabIndex = 0
		'
		'btnCrud
		'
		Me.btnCrud.Location = New System.Drawing.Point(6, 202)
		Me.btnCrud.Name = "btnCrud"
		Me.btnCrud.Size = New System.Drawing.Size(313, 23)
		Me.btnCrud.TabIndex = 6
		Me.btnCrud.Text = "Agregar lote"
		Me.btnCrud.UseVisualStyleBackColor = True
		'
		'lblEstado
		'
		Me.lblEstado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lblEstado.AutoSize = True
		Me.lblEstado.Location = New System.Drawing.Point(3, 161)
		Me.lblEstado.Name = "lblEstado"
		Me.lblEstado.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblEstado.Size = New System.Drawing.Size(40, 13)
		Me.lblEstado.TabIndex = 11
		Me.lblEstado.Text = "Estado"
		'
		'lblCaducidad
		'
		Me.lblCaducidad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lblCaducidad.AutoSize = True
		Me.lblCaducidad.Location = New System.Drawing.Point(3, 135)
		Me.lblCaducidad.Name = "lblCaducidad"
		Me.lblCaducidad.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCaducidad.Size = New System.Drawing.Size(105, 13)
		Me.lblCaducidad.TabIndex = 10
		Me.lblCaducidad.Text = "Fecha de caducidad"
		'
		'lblMonto
		'
		Me.lblMonto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lblMonto.AutoSize = True
		Me.lblMonto.Location = New System.Drawing.Point(3, 109)
		Me.lblMonto.Name = "lblMonto"
		Me.lblMonto.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblMonto.Size = New System.Drawing.Size(37, 13)
		Me.lblMonto.TabIndex = 9
		Me.lblMonto.Text = "Monto"
		'
		'lblUnidades
		'
		Me.lblUnidades.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lblUnidades.AutoSize = True
		Me.lblUnidades.Location = New System.Drawing.Point(3, 83)
		Me.lblUnidades.Name = "lblUnidades"
		Me.lblUnidades.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblUnidades.Size = New System.Drawing.Size(52, 13)
		Me.lblUnidades.TabIndex = 8
		Me.lblUnidades.Text = "Unidades"
		'
		'lblCodigoArticulo
		'
		Me.lblCodigoArticulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lblCodigoArticulo.AutoSize = True
		Me.lblCodigoArticulo.Location = New System.Drawing.Point(3, 57)
		Me.lblCodigoArticulo.Name = "lblCodigoArticulo"
		Me.lblCodigoArticulo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCodigoArticulo.Size = New System.Drawing.Size(96, 13)
		Me.lblCodigoArticulo.TabIndex = 7
		Me.lblCodigoArticulo.Text = "Código del artículo"
		'
		'lblCodigoProveedor
		'
		Me.lblCodigoProveedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lblCodigoProveedor.AutoSize = True
		Me.lblCodigoProveedor.Location = New System.Drawing.Point(3, 31)
		Me.lblCodigoProveedor.Name = "lblCodigoProveedor"
		Me.lblCodigoProveedor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCodigoProveedor.Size = New System.Drawing.Size(108, 13)
		Me.lblCodigoProveedor.TabIndex = 6
		Me.lblCodigoProveedor.Text = "Código del proveedor"
		'
		'dtpCaducidad
		'
		Me.dtpCaducidad.Location = New System.Drawing.Point(117, 128)
		Me.dtpCaducidad.Name = "dtpCaducidad"
		Me.dtpCaducidad.Size = New System.Drawing.Size(202, 20)
		Me.dtpCaducidad.TabIndex = 4
		'
		'txtEstado
		'
		Me.txtEstado.Location = New System.Drawing.Point(117, 154)
		Me.txtEstado.Name = "txtEstado"
		Me.txtEstado.Size = New System.Drawing.Size(202, 20)
		Me.txtEstado.TabIndex = 5
		'
		'txtMonto
		'
		Me.txtMonto.Location = New System.Drawing.Point(117, 102)
		Me.txtMonto.Name = "txtMonto"
		Me.txtMonto.Size = New System.Drawing.Size(202, 20)
		Me.txtMonto.TabIndex = 3
		'
		'txtUnidades
		'
		Me.txtUnidades.Location = New System.Drawing.Point(117, 76)
		Me.txtUnidades.Name = "txtUnidades"
		Me.txtUnidades.Size = New System.Drawing.Size(202, 20)
		Me.txtUnidades.TabIndex = 2
		'
		'txtArticulo
		'
		Me.txtArticulo.Location = New System.Drawing.Point(117, 50)
		Me.txtArticulo.Name = "txtArticulo"
		Me.txtArticulo.Size = New System.Drawing.Size(202, 20)
		Me.txtArticulo.TabIndex = 1
		'
		'txtProveedor
		'
		Me.txtProveedor.Location = New System.Drawing.Point(117, 24)
		Me.txtProveedor.Name = "txtProveedor"
		Me.txtProveedor.Size = New System.Drawing.Size(202, 20)
		Me.txtProveedor.TabIndex = 0
		'
		'SplitContainer1
		'
		Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.SplitContainer1.Location = New System.Drawing.Point(347, 13)
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
		Me.SplitContainer1.Size = New System.Drawing.Size(754, 545)
		Me.SplitContainer1.SplitterDistance = 249
		Me.SplitContainer1.TabIndex = 1
		'
		'tblInventario
		'
		Me.tblInventario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tblInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.tblInventario.ContextMenuStrip = Me.cmsOpciones
		Me.tblInventario.Location = New System.Drawing.Point(4, 3)
		Me.tblInventario.Name = "tblInventario"
		Me.tblInventario.ReadOnly = True
		Me.tblInventario.Size = New System.Drawing.Size(243, 539)
		Me.tblInventario.TabIndex = 2
		'
		'cmsOpciones
		'
		Me.cmsOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActualizarLoteToolStripMenuItem, Me.EliminarLoteToolStripMenuItem})
		Me.cmsOpciones.Name = "cmsOpciones"
		Me.cmsOpciones.Size = New System.Drawing.Size(150, 48)
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
		Me.SplitContainer2.Size = New System.Drawing.Size(501, 545)
		Me.SplitContainer2.SplitterDistance = 166
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
		Me.tblProveedor.Size = New System.Drawing.Size(160, 539)
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
		Me.tblArticulo.Size = New System.Drawing.Size(325, 539)
		Me.tblArticulo.TabIndex = 0
		'
		'EPError
		'
		Me.EPError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
		Me.EPError.ContainerControl = Me
		'
		'frmInventario
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1117, 570)
		Me.Controls.Add(Me.SplitContainer1)
		Me.Controls.Add(Me.Panel1)
		Me.Name = "frmInventario"
		Me.Text = "frmInventario"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.SplitContainer1.Panel1.ResumeLayout(False)
		Me.SplitContainer1.Panel2.ResumeLayout(False)
		CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.SplitContainer1.ResumeLayout(False)
		CType(Me.tblInventario, System.ComponentModel.ISupportInitialize).EndInit()
		Me.cmsOpciones.ResumeLayout(False)
		Me.SplitContainer2.Panel1.ResumeLayout(False)
		Me.SplitContainer2.Panel2.ResumeLayout(False)
		CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.SplitContainer2.ResumeLayout(False)
		CType(Me.tblProveedor, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tblArticulo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.EPError, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents SplitContainer1 As SplitContainer
	Friend WithEvents tblProveedor As DataGridView
	Friend WithEvents tblArticulo As DataGridView
	Friend WithEvents Splitter1 As Splitter
	Friend WithEvents Panel1 As Panel
	Friend WithEvents tblInventario As DataGridView
	Friend WithEvents SplitContainer2 As SplitContainer
	Friend WithEvents btnCrud As Button
	Friend WithEvents lblEstado As Label
	Friend WithEvents lblCaducidad As Label
	Friend WithEvents lblMonto As Label
	Friend WithEvents lblUnidades As Label
	Friend WithEvents lblCodigoArticulo As Label
	Friend WithEvents lblCodigoProveedor As Label
	Friend WithEvents dtpCaducidad As DateTimePicker
	Friend WithEvents txtEstado As TextBox
	Friend WithEvents txtMonto As TextBox
	Friend WithEvents txtUnidades As TextBox
	Friend WithEvents txtArticulo As TextBox
	Friend WithEvents txtProveedor As TextBox
	Friend WithEvents cmsOpciones As ContextMenuStrip
	Friend WithEvents ActualizarLoteToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents EliminarLoteToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents EPError As ErrorProvider
End Class
