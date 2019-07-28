<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscarArticulo
	Inherits System.Windows.Forms.Form

	'Form reemplaza a Dispose para limpiar la lista de componentes.
	<System.Diagnostics.DebuggerNonUserCode()> _
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
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.tblProductos = New System.Windows.Forms.DataGridView()
		Me.MenuFlotante = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.EliminarArticuloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ModificarArtículoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.lblOpciones = New System.Windows.Forms.Label()
		Me.txtFiltro = New System.Windows.Forms.TextBox()
		Me.btnBuscar = New System.Windows.Forms.Button()
		CType(Me.tblProductos, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.MenuFlotante.SuspendLayout()
		Me.SuspendLayout()
		'
		'tblProductos
		'
		Me.tblProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.tblProductos.ContextMenuStrip = Me.MenuFlotante
		Me.tblProductos.Location = New System.Drawing.Point(12, 51)
		Me.tblProductos.Name = "tblProductos"
		Me.tblProductos.Size = New System.Drawing.Size(712, 452)
		Me.tblProductos.TabIndex = 1
		'
		'MenuFlotante
		'
		Me.MenuFlotante.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarArticuloToolStripMenuItem, Me.ModificarArtículoToolStripMenuItem})
		Me.MenuFlotante.Name = "ContextMenuStrip1"
		Me.MenuFlotante.Size = New System.Drawing.Size(171, 48)
		'
		'EliminarArticuloToolStripMenuItem
		'
		Me.EliminarArticuloToolStripMenuItem.Name = "EliminarArticuloToolStripMenuItem"
		Me.EliminarArticuloToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
		Me.EliminarArticuloToolStripMenuItem.Text = "Eliminar Artículo"
		'
		'ModificarArtículoToolStripMenuItem
		'
		Me.ModificarArtículoToolStripMenuItem.Name = "ModificarArtículoToolStripMenuItem"
		Me.ModificarArtículoToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
		Me.ModificarArtículoToolStripMenuItem.Text = "Modificar Artículo"
		'
		'lblOpciones
		'
		Me.lblOpciones.AutoSize = True
		Me.lblOpciones.Location = New System.Drawing.Point(12, 9)
		Me.lblOpciones.Name = "lblOpciones"
		Me.lblOpciones.Size = New System.Drawing.Size(39, 13)
		Me.lblOpciones.TabIndex = 2
		Me.lblOpciones.Text = "Label1"
		'
		'txtFiltro
		'
		Me.txtFiltro.Location = New System.Drawing.Point(12, 25)
		Me.txtFiltro.Name = "txtFiltro"
		Me.txtFiltro.Size = New System.Drawing.Size(631, 20)
		Me.txtFiltro.TabIndex = 3
		'
		'btnBuscar
		'
		Me.btnBuscar.Location = New System.Drawing.Point(649, 22)
		Me.btnBuscar.Name = "btnBuscar"
		Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
		Me.btnBuscar.TabIndex = 4
		Me.btnBuscar.Text = "Buscar"
		Me.btnBuscar.UseVisualStyleBackColor = True
		'
		'FrmBuscarArticulo
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(736, 515)
		Me.Controls.Add(Me.btnBuscar)
		Me.Controls.Add(Me.txtFiltro)
		Me.Controls.Add(Me.lblOpciones)
		Me.Controls.Add(Me.tblProductos)
		Me.Name = "FrmBuscarArticulo"
		Me.Text = "FrmBuscarArticulo"
		CType(Me.tblProductos, System.ComponentModel.ISupportInitialize).EndInit()
		Me.MenuFlotante.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents tblProductos As DataGridView
	Friend WithEvents lblOpciones As Label
	Friend WithEvents txtFiltro As TextBox
	Friend WithEvents btnBuscar As Button
	Friend WithEvents MenuFlotante As ContextMenuStrip
	Friend WithEvents EliminarArticuloToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ModificarArtículoToolStripMenuItem As ToolStripMenuItem
End Class
