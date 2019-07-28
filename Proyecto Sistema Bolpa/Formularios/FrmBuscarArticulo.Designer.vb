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
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.lblOpciones = New System.Windows.Forms.Label()
		Me.txtFiltro = New System.Windows.Forms.TextBox()
		Me.btnBuscar = New System.Windows.Forms.Button()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'DataGridView1
		'
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.Size = New System.Drawing.Size(701, 426)
		Me.DataGridView1.TabIndex = 1
		'
		'lblOpciones
		'
		Me.lblOpciones.AutoSize = True
		Me.lblOpciones.Location = New System.Drawing.Point(754, 12)
		Me.lblOpciones.Name = "lblOpciones"
		Me.lblOpciones.Size = New System.Drawing.Size(39, 13)
		Me.lblOpciones.TabIndex = 2
		Me.lblOpciones.Text = "Label1"
		'
		'txtFiltro
		'
		Me.txtFiltro.Location = New System.Drawing.Point(757, 46)
		Me.txtFiltro.Name = "txtFiltro"
		Me.txtFiltro.Size = New System.Drawing.Size(203, 20)
		Me.txtFiltro.TabIndex = 3
		'
		'btnBuscar
		'
		Me.btnBuscar.Location = New System.Drawing.Point(757, 86)
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
		Me.ClientSize = New System.Drawing.Size(974, 450)
		Me.Controls.Add(Me.btnBuscar)
		Me.Controls.Add(Me.txtFiltro)
		Me.Controls.Add(Me.lblOpciones)
		Me.Controls.Add(Me.DataGridView1)
		Me.Name = "FrmBuscarArticulo"
		Me.Text = "FrmBuscarArticulo"
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents lblOpciones As Label
	Friend WithEvents txtFiltro As TextBox
	Friend WithEvents btnBuscar As Button
End Class
