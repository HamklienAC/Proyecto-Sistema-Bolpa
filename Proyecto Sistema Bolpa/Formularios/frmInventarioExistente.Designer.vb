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
		Me.lblCodigo = New System.Windows.Forms.Label()
		Me.txtFiltro = New System.Windows.Forms.TextBox()
		CType(Me.tblFactura, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'tblFactura
		'
		Me.tblFactura.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tblFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.tblFactura.Location = New System.Drawing.Point(13, 52)
		Me.tblFactura.Name = "tblFactura"
		Me.tblFactura.Size = New System.Drawing.Size(775, 551)
		Me.tblFactura.TabIndex = 0
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
		'txtFiltro
		'
		Me.txtFiltro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.txtFiltro.Location = New System.Drawing.Point(15, 26)
		Me.txtFiltro.MaximumSize = New System.Drawing.Size(0, 200)
		Me.txtFiltro.Name = "txtFiltro"
		Me.txtFiltro.Size = New System.Drawing.Size(773, 20)
		Me.txtFiltro.TabIndex = 3
		'
		'frmInventarioExistente
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 615)
		Me.Controls.Add(Me.txtFiltro)
		Me.Controls.Add(Me.lblCodigo)
		Me.Controls.Add(Me.tblFactura)
		Me.Name = "frmInventarioExistente"
		Me.Text = "frmInventarioExistente"
		CType(Me.tblFactura, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents tblFactura As DataGridView
	Friend WithEvents lblCodigo As Label
	Friend WithEvents txtFiltro As TextBox
End Class
