<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmActualizarArticulo
	Inherits FrmAgregarArticulo

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
		Me.tblArticulos = New System.Windows.Forms.DataGridView()
		Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		CType(Me.tblArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'tblArticulos
		'
		Me.tblArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.tblArticulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
		Me.tblArticulos.Location = New System.Drawing.Point(14, 413)
		Me.tblArticulos.Name = "tblArticulos"
		Me.tblArticulos.ReadOnly = True
		Me.tblArticulos.Size = New System.Drawing.Size(1015, 174)
		Me.tblArticulos.TabIndex = 25
		'
		'Column1
		'
		Me.Column1.HeaderText = "Column1"
		Me.Column1.Name = "Column1"
		Me.Column1.ReadOnly = True
		'
		'FrmActualizarArticulo
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.ClientSize = New System.Drawing.Size(1904, 599)
		Me.Controls.Add(Me.tblArticulos)
		Me.Location = New System.Drawing.Point(0, 0)
		Me.Name = "FrmActualizarArticulo"
		Me.Text = "FrmModificarArticulo"
		Me.Controls.SetChildIndex(Me.tblArticulos, 0)
		CType(Me.tblArticulos, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents tblArticulos As DataGridView
	Friend WithEvents Column1 As DataGridViewTextBoxColumn
End Class
