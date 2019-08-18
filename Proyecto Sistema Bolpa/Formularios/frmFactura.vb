Public Class frmFactura
	Private montoTotal, _descuento, _IVA, _Efectivo As Decimal

	Public Sub New()
		' Esta llamada es exigida por el diseñador.
		InitializeComponent()
		Size = New Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
		cbTipoFomulario.SelectedIndex = 0
		'cbTipoFomulario.Visible = False
		'lblTipoFomulario.Visible = False
		' Agregue cualquier inicialización después de la llamada a InitializeComponent().
	End Sub

	Private Sub VerificarPermiso()

	End Sub
	Private Sub FomularioAdministracion()
		cbTipoFomulario.Visible = True
		lblTipoFomulario.Visible = True
	End Sub
	Private Sub FomularioCaja()
		cbTipoFomulario.Location = New Point(cbTipoFomulario.Location.X, txtCantidad.Location.Y)
		lblTipoFomulario.Location = New Point(lblTipoFomulario.Location.X, lblCantidad.Location.Y)
		VisibilidadControles(True, "Eliminar artículo de la compra")
	End Sub
	Private Sub FomularioBodega()
		cbTipoFomulario.Location = New Point(cbTipoFomulario.Location.X, cbProveedores.Location.Y)
		lblTipoFomulario.Location = New Point(lblTipoFomulario.Location.X, lblProveedor.Location.Y)
		VisibilidadControles(False, "Eliminar fila")

	End Sub
	Private Sub VisibilidadControles(ByVal Valor As Boolean, ByVal Mensaje As String)
		lblIngreseProducto.Visible = Valor
		lblProveedor.Visible = Not Valor
		cbArticulos.Visible = Valor
		lblCantidad.Visible = Valor
		tblProductos.AllowUserToAddRows = Not Valor
		pInfomacionCliente.Visible = Valor
		pInformacionCaja.Visible = Valor
		EliminarArticulosDeLaCompraToolStripMenuItem.Text = Mensaje
		txtCantidad.Visible = Valor
		txtIngresarCodigo.Visible = Valor
		EdicionColumnas(Valor)
	End Sub
	''' <summary>
	''' Metodo que habilita o desbilita la edición de las columnas
	''' </summary>
	''' <param name="Estado"></param>
	Private Sub EdicionColumnas(ByVal Estado As Boolean)
		Try
			For Columna = 0 To 4 Step 1
				tblProductos.Columns(Columna).ReadOnly = Estado
			Next
		Catch ex As Exception

		End Try
	End Sub
	Private Sub CmsOpciones_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles cmsOpciones.ItemClicked
		Try
			Select Case e.ClickedItem.Name
				Case "EliminarArticulosDeLaCompraToolStripMenuItem"
					tblProductos.Rows.Remove(tblProductos.CurrentRow)
			End Select
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Private Sub TxtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
		e.Handled = Not VerificarContenidoPuntos(txtCantidad.Text, e) AndAlso Not IsNumeric(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar.Equals(",")
	End Sub
	Private Sub cbArticulos_KeyDown(sender As Object, e As KeyEventArgs) Handles cbArticulos.KeyDown
		If e.KeyData = Keys.Enter Then
			txtCantidad.Focus()
		End If
	End Sub
	Private Sub TxtCantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCantidad.KeyDown
		If e.KeyData = Keys.Enter Then
			SumarArticuloRepetido()
			SumarMontoFactura()
			txtIngresarCodigo.Focus()
		End If
	End Sub
	Private Sub SumarArticuloRepetido()
		Try
			For Fila = 0 To tblProductos.RowCount Step 1
				If tblProductos.Rows(Fila).Cells(0).Value.ToString = cbArticulos.Text Then
					tblProductos.Rows(Fila).Cells(2).Value += Cantidad
					Exit For
				End If
			Next
		Catch ex As Exception

		End Try
	End Sub
	Private Sub SumarMontoFactura()
		Try
			Dim total As Decimal
			For Fila = 0 To tblProductos.RowCount Step 1
				total += CDec(tblProductos.Rows(Fila).Cells(2).Value.ToString) * CDec(tblProductos.Rows(Fila).Cells(3).Value.ToString)
			Next
			lblMontoTotal.Text = total
		Catch ex As Exception

		End Try
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
	''' <summary>
	''' Teclas de acceso rapído 
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub tblProductos_KeyUp(sender As Object, e As KeyEventArgs) Handles tblProductos.KeyUp
		If e.KeyData = Keys.Control + Keys.B Then
			Dim Inventario As New frmInventarioExistente
			Inventario.Show()
		ElseIf e.KeyData = Keys.Control + Keys.X Then
			If MsgBox("¿Desea cancelar la factura?", MsgBoxStyle.YesNo Or MsgBoxStyle.Critical, "Factura") = MsgBoxResult.Yes Then
				tblProductos.Rows.Clear()
			End If
		ElseIf e.KeyData = Keys.Control + Keys.A Then
			Dim frmFactura As New frmTotalFactura
			frmFactura.CalcularMonto(tblProductos)
			frmTotalFactura.Show()
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
			Return If(txtCantidad.Text = Nothing, 1, txtCantidad.Text)
		End Get
	End Property
	Public ReadOnly Property Proveedor As ComboBox
		Get
			Return cbProveedores
		End Get
	End Property
	Public ReadOnly Property Total() As Decimal
		Get
			Return lblTotal.Text
		End Get
	End Property
	Public Property IVA() As Decimal
		Get
			Return IVA
		End Get
		Set(ByVal Monto As Decimal)
			_IVA = Monto
		End Set
	End Property
	''' <summary>
	''' Metodo de acceso para saber con cuando pago la entidad
	''' </summary>
	''' <returns></returns>
	Public Property PagoEfectivo() As Integer
		Get
			Return _Efectivo
		End Get
		Set(ByVal Monto As Integer)
			_Efectivo = Monto
		End Set
	End Property
	Public Property Descuento() As Decimal
		Get
			Return _descuento
		End Get
		Set(ByVal Monto As Decimal)
			_descuento = Monto
		End Set
	End Property
	''' <summary>
	''' Metodo retorna un list of de arrays de tipo String
	''' </summary>
	''' <returns></returns>
	Public ReadOnly Property DatosArray() As IList(Of String())
		Get
			Try
				Dim Datos As New List(Of String())
				For Fila = 0 To tblProductos.RowCount Step 1
					Datos.Add({tblProductos.Rows(Fila).Cells(0).Value.ToString, tblProductos.Rows(Fila).Cells(1).Value.ToString, tblProductos.Rows(Fila).Cells(2).Value.ToString, tblProductos.Rows(Fila).Cells(3).Value.ToString})
				Next
				Return Datos
			Catch ex As Exception
				Return Nothing
			End Try
		End Get
	End Property

End Class