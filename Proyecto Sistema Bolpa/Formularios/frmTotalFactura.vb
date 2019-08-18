Public Class frmTotalFactura
	Public Sub New()

		' Esta llamada es exigida por el diseñador.
		InitializeComponent()
		' Agregue cualquier inicialización después de la llamada a InitializeComponent().

	End Sub

	Private Sub TxtEfectivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEfectivo.KeyPress
		Try
			If IsNumeric(e.KeyChar) Then
				e.Handled = False
				lblMontoVuelto.Text = Int(lblMontoTotal.Text - Int(txtEfectivo.Text + e.KeyChar))
			ElseIf Char.IsControl(e.KeyChar) Then
				e.Handled = False
				Dim Largo As Integer = txtEfectivo.TextLength - 1
				If Largo > 0 Then
					lblMontoVuelto.Text = Int(lblMontoTotal.Text - Int(txtEfectivo.Text.Substring(0, Largo)))
				Else
					lblMontoVuelto.Text = "-" + lblMontoTotal.Text
				End If

			Else
				e.Handled = True
			End If
		Catch ex As Exception

		End Try

	End Sub

	Public Sub CalcularMonto(ByVal ListaProducto As DataGridView)
		Try
			Dim Monto As Decimal = 0
			For Fila = 0 To ListaProducto.RowCount Step 1
				Monto += CDec(ListaProducto.Rows(Fila).Cells(2).Value.ToString) * CDec(ListaProducto.Rows(Fila).Cells(3).Value.ToString)
			Next
			lblMontoIVA.Text = Monto * 13%
			lblMontoSubtotal.Text = Monto - 13%
			lblMontoTotal.Text = Monto
		Catch ex As Exception

		End Try
	End Sub

	Private Sub txtEfectivo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEfectivo.KeyDown
		If e.KeyData = Keys.Enter Then

		End If
	End Sub

	Public ReadOnly Property SubTotal() As Decimal
		Get
			Return lblMontoSubtotal.Text
		End Get
	End Property

	Public ReadOnly Property IVA() As Decimal
		Get
			Return lblMontoIVA.Text
		End Get
	End Property

	Public ReadOnly Property Total() As Decimal
		Get
			Return lblMontoTotal.Text
		End Get
	End Property

	Public ReadOnly Property Efectivo As Decimal
		Get
			Return txtEfectivo.Text
		End Get
	End Property

	Public ReadOnly Property TipoFactura() As String
		Get
			Return If(rbContado.Checked, rbContado.Text, rbCredito.Text)
		End Get
	End Property
End Class