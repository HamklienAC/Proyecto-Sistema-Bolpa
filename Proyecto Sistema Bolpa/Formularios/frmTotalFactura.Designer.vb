<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTotalFactura
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
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.lblMontoDescuento = New System.Windows.Forms.Label()
		Me.lblDescuento = New System.Windows.Forms.Label()
		Me.lblMontoVuelto = New System.Windows.Forms.Label()
		Me.lblMontoTotal = New System.Windows.Forms.Label()
		Me.lblMontoIVA = New System.Windows.Forms.Label()
		Me.lblMontoSubtotal = New System.Windows.Forms.Label()
		Me.lblVuelto = New System.Windows.Forms.Label()
		Me.lblMonto = New System.Windows.Forms.Label()
		Me.txtEfectivo = New System.Windows.Forms.TextBox()
		Me.lblTotal = New System.Windows.Forms.Label()
		Me.lblIVA = New System.Windows.Forms.Label()
		Me.lblSubtotal = New System.Windows.Forms.Label()
		Me.gbTipoFactura = New System.Windows.Forms.GroupBox()
		Me.rbCredito = New System.Windows.Forms.RadioButton()
		Me.rbContado = New System.Windows.Forms.RadioButton()
		Me.Panel1.SuspendLayout()
		Me.gbTipoFactura.SuspendLayout()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.Controls.Add(Me.lblMontoDescuento)
		Me.Panel1.Controls.Add(Me.lblDescuento)
		Me.Panel1.Controls.Add(Me.lblMontoVuelto)
		Me.Panel1.Controls.Add(Me.lblMontoTotal)
		Me.Panel1.Controls.Add(Me.lblMontoIVA)
		Me.Panel1.Controls.Add(Me.lblMontoSubtotal)
		Me.Panel1.Controls.Add(Me.lblVuelto)
		Me.Panel1.Controls.Add(Me.lblMonto)
		Me.Panel1.Controls.Add(Me.txtEfectivo)
		Me.Panel1.Controls.Add(Me.lblTotal)
		Me.Panel1.Controls.Add(Me.lblIVA)
		Me.Panel1.Controls.Add(Me.lblSubtotal)
		Me.Panel1.Controls.Add(Me.gbTipoFactura)
		Me.Panel1.Location = New System.Drawing.Point(218, 12)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(376, 578)
		Me.Panel1.TabIndex = 0
		'
		'lblMontoDescuento
		'
		Me.lblMontoDescuento.AutoSize = True
		Me.lblMontoDescuento.Location = New System.Drawing.Point(65, 289)
		Me.lblMontoDescuento.Name = "lblMontoDescuento"
		Me.lblMontoDescuento.Size = New System.Drawing.Size(59, 13)
		Me.lblMontoDescuento.TabIndex = 12
		Me.lblMontoDescuento.Text = "Descuento"
		'
		'lblDescuento
		'
		Me.lblDescuento.AutoSize = True
		Me.lblDescuento.Location = New System.Drawing.Point(6, 289)
		Me.lblDescuento.Name = "lblDescuento"
		Me.lblDescuento.Size = New System.Drawing.Size(59, 13)
		Me.lblDescuento.TabIndex = 11
		Me.lblDescuento.Text = "Descuento"
		'
		'lblMontoVuelto
		'
		Me.lblMontoVuelto.AutoSize = True
		Me.lblMontoVuelto.Location = New System.Drawing.Point(65, 386)
		Me.lblMontoVuelto.Name = "lblMontoVuelto"
		Me.lblMontoVuelto.Size = New System.Drawing.Size(37, 13)
		Me.lblMontoVuelto.TabIndex = 10
		Me.lblMontoVuelto.Text = "Vuelto"
		'
		'lblMontoTotal
		'
		Me.lblMontoTotal.AutoSize = True
		Me.lblMontoTotal.Location = New System.Drawing.Point(65, 315)
		Me.lblMontoTotal.Name = "lblMontoTotal"
		Me.lblMontoTotal.Size = New System.Drawing.Size(31, 13)
		Me.lblMontoTotal.TabIndex = 9
		Me.lblMontoTotal.Text = "Total"
		'
		'lblMontoIVA
		'
		Me.lblMontoIVA.AutoSize = True
		Me.lblMontoIVA.Location = New System.Drawing.Point(65, 261)
		Me.lblMontoIVA.Name = "lblMontoIVA"
		Me.lblMontoIVA.Size = New System.Drawing.Size(24, 13)
		Me.lblMontoIVA.TabIndex = 8
		Me.lblMontoIVA.Text = "IVA"
		'
		'lblMontoSubtotal
		'
		Me.lblMontoSubtotal.AutoSize = True
		Me.lblMontoSubtotal.Location = New System.Drawing.Point(65, 225)
		Me.lblMontoSubtotal.Name = "lblMontoSubtotal"
		Me.lblMontoSubtotal.Size = New System.Drawing.Size(46, 13)
		Me.lblMontoSubtotal.TabIndex = 7
		Me.lblMontoSubtotal.Text = "Subtotal"
		'
		'lblVuelto
		'
		Me.lblVuelto.AutoSize = True
		Me.lblVuelto.Location = New System.Drawing.Point(6, 386)
		Me.lblVuelto.Name = "lblVuelto"
		Me.lblVuelto.Size = New System.Drawing.Size(37, 13)
		Me.lblVuelto.TabIndex = 6
		Me.lblVuelto.Text = "Vuelto"
		'
		'lblMonto
		'
		Me.lblMonto.AutoSize = True
		Me.lblMonto.Location = New System.Drawing.Point(6, 353)
		Me.lblMonto.Name = "lblMonto"
		Me.lblMonto.Size = New System.Drawing.Size(46, 13)
		Me.lblMonto.TabIndex = 5
		Me.lblMonto.Text = "Efectivo"
		'
		'txtEfectivo
		'
		Me.txtEfectivo.Location = New System.Drawing.Point(68, 353)
		Me.txtEfectivo.Name = "txtEfectivo"
		Me.txtEfectivo.Size = New System.Drawing.Size(100, 20)
		Me.txtEfectivo.TabIndex = 4
		'
		'lblTotal
		'
		Me.lblTotal.AutoSize = True
		Me.lblTotal.Location = New System.Drawing.Point(6, 315)
		Me.lblTotal.Name = "lblTotal"
		Me.lblTotal.Size = New System.Drawing.Size(31, 13)
		Me.lblTotal.TabIndex = 3
		Me.lblTotal.Text = "Total"
		'
		'lblIVA
		'
		Me.lblIVA.AutoSize = True
		Me.lblIVA.Location = New System.Drawing.Point(6, 261)
		Me.lblIVA.Name = "lblIVA"
		Me.lblIVA.Size = New System.Drawing.Size(24, 13)
		Me.lblIVA.TabIndex = 2
		Me.lblIVA.Text = "IVA"
		'
		'lblSubtotal
		'
		Me.lblSubtotal.AutoSize = True
		Me.lblSubtotal.Location = New System.Drawing.Point(6, 225)
		Me.lblSubtotal.Name = "lblSubtotal"
		Me.lblSubtotal.Size = New System.Drawing.Size(46, 13)
		Me.lblSubtotal.TabIndex = 1
		Me.lblSubtotal.Text = "Subtotal"
		'
		'gbTipoFactura
		'
		Me.gbTipoFactura.Controls.Add(Me.rbCredito)
		Me.gbTipoFactura.Controls.Add(Me.rbContado)
		Me.gbTipoFactura.Location = New System.Drawing.Point(3, 66)
		Me.gbTipoFactura.Name = "gbTipoFactura"
		Me.gbTipoFactura.Size = New System.Drawing.Size(370, 135)
		Me.gbTipoFactura.TabIndex = 0
		Me.gbTipoFactura.TabStop = False
		Me.gbTipoFactura.Text = "Tipo de factura"
		'
		'rbCredito
		'
		Me.rbCredito.AutoSize = True
		Me.rbCredito.Location = New System.Drawing.Point(6, 82)
		Me.rbCredito.Name = "rbCredito"
		Me.rbCredito.Size = New System.Drawing.Size(58, 17)
		Me.rbCredito.TabIndex = 1
		Me.rbCredito.TabStop = True
		Me.rbCredito.Text = "Crédito"
		Me.rbCredito.UseVisualStyleBackColor = True
		'
		'rbContado
		'
		Me.rbContado.AutoSize = True
		Me.rbContado.Location = New System.Drawing.Point(6, 40)
		Me.rbContado.Name = "rbContado"
		Me.rbContado.Size = New System.Drawing.Size(65, 17)
		Me.rbContado.TabIndex = 0
		Me.rbContado.TabStop = True
		Me.rbContado.Text = "Contado"
		Me.rbContado.UseVisualStyleBackColor = True
		'
		'frmTotalFactura
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 602)
		Me.Controls.Add(Me.Panel1)
		Me.Name = "frmTotalFactura"
		Me.Text = "frmTotalFactura"
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.gbTipoFactura.ResumeLayout(False)
		Me.gbTipoFactura.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Panel1 As Panel
	Friend WithEvents gbTipoFactura As GroupBox
	Friend WithEvents rbCredito As RadioButton
	Friend WithEvents rbContado As RadioButton
	Friend WithEvents lblVuelto As Label
	Friend WithEvents lblMonto As Label
	Friend WithEvents txtEfectivo As TextBox
	Friend WithEvents lblTotal As Label
	Friend WithEvents lblIVA As Label
	Friend WithEvents lblSubtotal As Label
	Friend WithEvents lblMontoVuelto As Label
	Friend WithEvents lblMontoTotal As Label
	Friend WithEvents lblMontoIVA As Label
	Friend WithEvents lblMontoSubtotal As Label
	Friend WithEvents lblDescuento As Label
	Friend WithEvents lblMontoDescuento As Label
End Class
