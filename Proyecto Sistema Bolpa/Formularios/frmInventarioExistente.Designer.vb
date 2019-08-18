<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInventarioExistente
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
		Me.tblInventario = New System.Windows.Forms.DataGridView()
		Me.lblCodigo = New System.Windows.Forms.Label()
		Me.txtFiltro = New System.Windows.Forms.TextBox()
		CType(Me.tblInventario, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'tblInventario
		'
		Me.tblInventario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tblInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.tblInventario.Location = New System.Drawing.Point(13, 52)
		Me.tblInventario.Name = "tblInventario"
		Me.tblInventario.ReadOnly = True
		Me.tblInventario.Size = New System.Drawing.Size(775, 551)
		Me.tblInventario.TabIndex = 0
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
		Me.txtFiltro.Location = New System.Drawing.Point(12, 26)
		Me.txtFiltro.Name = "txtFiltro"
		Me.txtFiltro.Size = New System.Drawing.Size(776, 20)
		Me.txtFiltro.TabIndex = 3
		'
		'frmInventarioExistente
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 615)
		Me.Controls.Add(Me.txtFiltro)
		Me.Controls.Add(Me.lblCodigo)
		Me.Controls.Add(Me.tblInventario)
		Me.Name = "frmInventarioExistente"
		Me.Text = "frmInventarioExistente"
		CType(Me.tblInventario, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents tblInventario As DataGridView
	Friend WithEvents lblCodigo As Label
	Friend WithEvents txtFiltro As TextBox
End Class
