Public Class frmFactura
	Public Sub New()
		' Esta llamada es exigida por el diseñador.
		InitializeComponent()
		Size = New Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
		cbTipoFomulario.SelectedIndex = 0
		'cbTipoFomulario.Visible = False
		'lblTipoFomulario.Visible = False
		' Agregue cualquier inicialización después de la llamada a InitializeComponent().
	End Sub

	Private Sub FomularioCaja()
		tblProductos.AllowUserToAddRows = False
		pInfomacionCliente.Visible = True
		pInformacionCaja.Visible = True
		txtCantidad.Visible = True
		MsgBox(txtIngresarCodigo.Location.ToString)
		EliminarArticulosDeLaCompraToolStripMenuItem.Text = "Eliminar artículo de la compra"
		EdicionColumnas(True)
	End Sub

	Private Sub FomularioBodega()
		tblProductos.AllowUserToAddRows = True
		pInfomacionCliente.Visible = False
		pInformacionCaja.Visible = False
		EliminarArticulosDeLaCompraToolStripMenuItem.Text = "Eliminar fila"
		txtCantidad.Visible = False
		txtIngresarCodigo.Visible = False
		EdicionColumnas(False)
	End Sub

	Private Sub EdicionColumnas(ByVal Estado As Boolean)
		Try
			For Columna = 0 To 4 Step 1
				tblProductos.Columns(Columna).ReadOnly = Estado
			Next
		Catch ex As Exception

		End Try
	End Sub

	Private Sub FomularioAdministracion()
		cbTipoFomulario.Visible = True
		lblTipoFomulario.Visible = True
	End Sub

	Private Sub CmsOpciones_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles cmsOpciones.ItemClicked
		Try
			Select Case e.ClickedItem.Name
				Case "EliminarArticulosDeLaCompraToolStripMenuItem"
					tblProductos.Rows.Remove(tblProductos.CurrentRow)
				Case "ModificarCantidad"

			End Select
		Catch ex As Exception
			MsgBox(ex.Message)
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

	Private Sub tblProductos_KeyUp(sender As Object, e As KeyEventArgs) Handles tblProductos.KeyUp
		If e.KeyData = Keys.Control + Keys.B Then
			Dim Inventario As New frmInventarioExistente
			Inventario.Show()
		End If
	End Sub

	Private Sub cbTipoFomulario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipoFomulario.SelectedIndexChanged
		If cbTipoFomulario.SelectedIndex = 0 Then
			cbProveedores.Visible = False
			FomularioCaja()
		ElseIf cbTipoFomulario.SelectedIndex = 1 Then
			cbProveedores.Visible = True
			FomularioBodega()
		End If
	End Sub

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