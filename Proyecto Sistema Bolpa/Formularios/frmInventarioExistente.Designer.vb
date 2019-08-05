<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventarioExistente
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
		Me.tblFactura = New System.Windows.Forms.DataGridView()
		Me.cbCodigo = New System.Windows.Forms.ComboBox()
		Me.lblCodigo = New System.Windows.Forms.Label()
		CType(Me.tblFactura, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'tblFactura
		'
		Me.tblFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.tblFactura.Location = New System.Drawing.Point(13, 52)
		Me.tblFactura.Name = "tblFactura"
		Me.tblFactura.Size = New System.Drawing.Size(775, 551)
		Me.tblFactura.TabIndex = 0
		'
		'cbCodigo
		'
		Me.cbCodigo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cbCodigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
		Me.cbCodigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.cbCodigo.FormattingEnabled = True
		Me.cbCodigo.Location = New System.Drawing.Point(12, 25)
		Me.cbCodigo.Name = "cbCodigo"
		Me.cbCodigo.Size = New System.Drawing.Size(776, 21)
		Me.cbCodigo.TabIndex = 1
		'
		'lblCodigo
		'
		Me.lblCodigo.AutoSize = True
		Me.lblCodigo.Location = New System.Drawing.Point(12, 9)
		Me.lblCodigo.Name = "lblCodigo"
		Me.lblCodigo.Size = New System.Drawing.Size(88, 13)
		Me.lblCodigo.TabIndex = 2
		Me.lblCodigo.Text = "Ingrese el codigo"
		'
		'frmInventarioExistente
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 615)
		Me.Controls.Add(Me.lblCodigo)
		Me.Controls.Add(Me.cbCodigo)
		Me.Controls.Add(Me.tblFactura)
		Me.Name = "frmInventarioExistente"
		Me.Text = "frmInventarioExistente"
		CType(Me.tblFactura, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents tblFactura As DataGridView
	Friend WithEvents cbCodigo As ComboBox
	Friend WithEvents lblCodigo As Label
End Class
