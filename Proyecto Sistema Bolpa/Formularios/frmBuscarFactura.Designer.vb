<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarFactura
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
		Me.tblFacturas = New System.Windows.Forms.DataGridView()
		Me.lblFiltro = New System.Windows.Forms.Label()
		Me.txtFiltro = New System.Windows.Forms.TextBox()
		Me.cmsOpciones = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.AnularFacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.CancelarFacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.cbTipoFactura = New System.Windows.Forms.CheckBox()
		CType(Me.tblFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.cmsOpciones.SuspendLayout()
		Me.SuspendLayout()
		'
		'tblFacturas
		'
		Me.tblFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.tblFacturas.ContextMenuStrip = Me.cmsOpciones
		Me.tblFacturas.Location = New System.Drawing.Point(12, 51)
		Me.tblFacturas.Name = "tblFacturas"
		Me.tblFacturas.Size = New System.Drawing.Size(776, 447)
		Me.tblFacturas.TabIndex = 0
		'
		'lblFiltro
		'
		Me.lblFiltro.AutoSize = True
		Me.lblFiltro.Location = New System.Drawing.Point(9, 9)
		Me.lblFiltro.Name = "lblFiltro"
		Me.lblFiltro.Size = New System.Drawing.Size(29, 13)
		Me.lblFiltro.TabIndex = 1
		Me.lblFiltro.Text = "Filtro"
		'
		'txtFiltro
		'
		Me.txtFiltro.Location = New System.Drawing.Point(12, 25)
		Me.txtFiltro.Name = "txtFiltro"
		Me.txtFiltro.Size = New System.Drawing.Size(776, 20)
		Me.txtFiltro.TabIndex = 2
		'
		'cmsOpciones
		'
		Me.cmsOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnularFacturaToolStripMenuItem, Me.CancelarFacturaToolStripMenuItem})
		Me.cmsOpciones.Name = "cmsOpciones"
		Me.cmsOpciones.Size = New System.Drawing.Size(161, 48)
		'
		'AnularFacturaToolStripMenuItem
		'
		Me.AnularFacturaToolStripMenuItem.Name = "AnularFacturaToolStripMenuItem"
		Me.AnularFacturaToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
		Me.AnularFacturaToolStripMenuItem.Text = "Anular factura"
		'
		'CancelarFacturaToolStripMenuItem
		'
		Me.CancelarFacturaToolStripMenuItem.Name = "CancelarFacturaToolStripMenuItem"
		Me.CancelarFacturaToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
		Me.CancelarFacturaToolStripMenuItem.Text = "Cancelar factura"
		'
		'cbTipoFactura
		'
		Me.cbTipoFactura.AutoSize = True
		Me.cbTipoFactura.Location = New System.Drawing.Point(644, 5)
		Me.cbTipoFactura.Name = "cbTipoFactura"
		Me.cbTipoFactura.Size = New System.Drawing.Size(144, 17)
		Me.cbTipoFactura.TabIndex = 3
		Me.cbTipoFactura.Text = "Facturas de proveedores"
		Me.cbTipoFactura.UseVisualStyleBackColor = True
		'
		'frmBuscarFactura
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 510)
		Me.Controls.Add(Me.cbTipoFactura)
		Me.Controls.Add(Me.txtFiltro)
		Me.Controls.Add(Me.lblFiltro)
		Me.Controls.Add(Me.tblFacturas)
		Me.Name = "frmBuscarFactura"
		Me.Text = "frmBuscarFactura"
		CType(Me.tblFacturas, System.ComponentModel.ISupportInitialize).EndInit()
		Me.cmsOpciones.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents tblFacturas As DataGridView
	Friend WithEvents lblFiltro As Label
	Friend WithEvents txtFiltro As TextBox
	Friend WithEvents cmsOpciones As ContextMenuStrip
	Friend WithEvents AnularFacturaToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents CancelarFacturaToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents cbTipoFactura As CheckBox
End Class
