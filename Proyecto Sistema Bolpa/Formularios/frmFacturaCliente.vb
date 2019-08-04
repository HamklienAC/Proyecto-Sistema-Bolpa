Public Class frmFacturaCliente

	Public Sub New()
		' Esta llamada es exigida por el diseñador.
		InitializeComponent()
		Size = New Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
		AjustarCeldas()
		SurroundingSub()
		Nah()

		' Agregue cualquier inicialización después de la llamada a InitializeComponent().
	End Sub

	Private Sub AjustarCeldas()
		Dim Tamano As Integer = tblProductos.Width / 4
		CProducto.Width = Tamano
		CCodigo.Width = Tamano
		CCantidad.Width = Tamano
		CPrecio.Width = Tamano

	End Sub
	Private Sub Nah()
		txtIngresarCodigo.AutoCompleteCustomSource.Add("Arroz")
		'txtIngresarCodigo.AutoCompleteSource = "Papaya"
		'txtIngresarCodigo.AutoCompleteSource = "Leche dos pinos"
	End Sub

	Private Sub SurroundingSub()
		tblProductos.Rows.Add("Peras", "101", "508.3", "5")
		tblProductos.Rows.Add("Arroz tio pelon", "102", "1980", "5")
	End Sub

	Private Sub CmsOpciones_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles cmsOpciones.ItemClicked
		Try
			Select Case e.ClickedItem.Name
				Case "EliminarArticulosDeLaCompraToolStripMenuItem"
					Dim row As DataGridViewRow = tblProductos.CurrentRow
					tblProductos.Rows.Remove(row)
				Case "ModificarCantidad"

			End Select
		Catch ex As Exception

		End Try
	End Sub

	Private Sub TxtIngresarCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIngresarCodigo.KeyPress

	End Sub

	Private Sub TxtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
		e.Handled = Not VerificarContenidoPuntos(txtCantidad.Text, e) AndAlso Not IsNumeric(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar.Equals(",")
	End Sub

	Private Sub TxtIngresarCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIngresarCodigo.KeyDown
		If e.KeyData = Keys.Enter Then
			txtCantidad.Focus()
		End If
	End Sub

	Private Sub TxtCantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCantidad.KeyDown
		If e.KeyData = Keys.Enter Then
			txtIngresarCodigo.Focus()
		End If
	End Sub

	Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
		Dim Inventario As New frmInventarioExistente
		Inventario.Show()
	End Sub

	Private Function VerificarContenidoPuntos(ByVal Cadena As String, e As KeyPressEventArgs) As Boolean
		Try
			If Cadena = Nothing AndAlso Char.IsPunctuation(e.KeyChar) Then
				Return False
			Else
				Dim Verificacion As Double = Cadena + e.KeyChar + "1"
			End If
		Catch ex As Exception
			Return False
		End Try
		Return True
	End Function

	Public ReadOnly Property Cantidad As Decimal
		Get
			If txtCantidad.Text = Nothing Then
				Return 1
			Else
				Return txtCantidad.Text
			End If
		End Get
	End Property
End Class