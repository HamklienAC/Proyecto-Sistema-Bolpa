<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarArticulo
	Inherits Proyecto_Sistema_Bolpa.FrmAgregarArticulo

	'Form invalida a Dispose para limpiar la lista de componentes.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing AndAlso components IsNot Nothing Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	'Requerido por el Diseñador de Windows Forms
	Private components As System.ComponentModel.IContainer

	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar usando el Diseñador de Windows Forms.  
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.tblProductos = New System.Windows.Forms.DataGridView()
		CType(Me.tblProductos, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'tblProductos
		'
		Me.tblProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.tblProductos.Location = New System.Drawing.Point(20, 411)
		Me.tblProductos.Name = "tblProductos"
		Me.tblProductos.Size = New System.Drawing.Size(1109, 235)
		Me.tblProductos.TabIndex = 25
		'
		'ModificarArticulo
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.ClientSize = New System.Drawing.Size(1904, 1041)
		Me.Controls.Add(Me.tblProductos)
		Me.Location = New System.Drawing.Point(0, 0)
		Me.Name = "ModificarArticulo"
		Me.Text = "ModificarArticulo"
		Me.Controls.SetChildIndex(Me.tblProductos, 0)
		CType(Me.tblProductos, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents tblProductos As DataGridView
End Class
