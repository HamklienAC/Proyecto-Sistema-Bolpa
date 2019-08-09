Public Class frmInventario
	Private posicioncelda As Integer
	Public Sub New()
		' Esta llamada es exigida por el diseñador.
		InitializeComponent()
		Size = New Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
		dtpCaducidad.MinDate = Date.Now
		' Agregue cualquier inicialización después de la llamada a InitializeComponent().
	End Sub


	Private Sub BtnCrud_Click(sender As Object, e As EventArgs) Handles btnCrud.Click
		Try
			If VerficarDatos() AndAlso CorfimacionFechaCadudcidad() Then
				If btnCrud.Text = "Actualizar lote" Then
					'DatosArray()
					'devuelve todos los datos en un arry
					btnCrud.Text = "Agregar lote"
				Else

				End If
				LimpiarControles()
			End If
		Catch ex As Exception

		End Try
	End Sub

	Private Function CorfimacionFechaCadudcidad() As Boolean
		Try
			If FechaCaducidad = Today Then
				If MsgBox("La fecha de caducidad del lote es igual a la del presenten día, desea agregarlo de toda manera", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
					Return True
				Else
					Return False
				End If
			Else
				Return True
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
			Return False
		End Try
	End Function

	Private Sub CmsOpciones_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles cmsOpciones.ItemClicked
		Try
			Select Case e.ClickedItem.Name
				Case "ActualizarLoteToolStripMenuItem"
					If MsgBox("Desea actualizar los datos del invetario: " + tblInventario.CurrentRow.Cells(0).Value.ToString, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
						btnCrud.Text = "Actualizar lote"
						CargarDatos()
					End If
				Case "EliminarLoteToolStripMenuItem"
					If MsgBox("Desea eliminar el invetario: " + tblInventario.CurrentRow.Cells(0).Value.ToString, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
						'tblInventario.CurrentRow.Cells(0).Value.ToString() llave primaria del lote en el inventario
					End If
			End Select
		Catch ex As Exception

		End Try

	End Sub

	Private Sub TblProveedor_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblProveedor.CellClick
		Try
			'los numero que esta dentro de los parentesis corresponde al orden en la base de datos
			If MsgBox("Desea agregar el proveedor " + tblProveedor.CurrentRow.Cells(2).Value.ToString, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
				txtProveedor.Text = tblProveedor.CurrentRow.Cells(1).Value.ToString
			End If
		Catch ex As Exception
		End Try
	End Sub
	Private Sub TblArticulo_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblArticulo.CellClick
		Try
			'los numero que esta dentro de los parentesis corresponde al orden en la base de datos
			If MsgBox("Desea agregar el proveedor " + tblArticulo.CurrentRow.Cells(3).Value.ToString, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
				txtArticulo.Text = tblArticulo.CurrentRow.Cells(2).Value.ToString
			End If
		Catch ex As Exception
		End Try
	End Sub

	Private Sub CargarDatos()
		Try
			txtProveedor.Text = tblInventario.CurrentRow.Cells(0).Value.ToString
			txtArticulo.Text = tblInventario.CurrentRow.Cells(1).Value.ToString
			txtUnidades.Text = tblInventario.CurrentRow.Cells(2).Value.ToString
			txtMonto.Text = tblInventario.CurrentRow.Cells(3).Value.ToString
			dtpCaducidad.Text = tblInventario.CurrentRow.Cells(4).Value.ToString
			txtEstado.Text = tblInventario.CurrentRow.Cells(5).Value.ToString
		Catch ex As Exception

		End Try
	End Sub

	Private Sub LimpiarControles()
		txtArticulo.Clear()
		txtProveedor.Clear()
		txtMonto.Clear()
		txtEstado.Clear()
		dtpCaducidad.Text=today 
	End Sub

	Private Sub TxtArticulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtArticulo.KeyPress
		e.Handled = Not IsNumeric(e.KeyChar) AndAlso Not Char.IsSeparator(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar)
	End Sub

	Private Sub TxtProveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProveedor.KeyPress
		e.Handled = Not IsNumeric(e.KeyChar) AndAlso Not Char.IsSeparator(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar)
	End Sub

	Private Sub TxtUnidades_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUnidades.KeyPress
		FiltrarCaracteres(txtUnidades.Text, e)
	End Sub

	Private Sub TxtMonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMonto.KeyPress
		FiltrarCaracteres(txtMonto.Text, e)
	End Sub

	Private Sub FiltrarCaracteres(ByVal Cadena As String, e As KeyPressEventArgs)
		e.Handled = Not VerificarContenidoPuntos(Cadena, e) AndAlso Not IsNumeric(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar.Equals(",")
	End Sub

	Private Function VerificarContenidoPuntos(ByVal Cadena As String, e As KeyPressEventArgs) As Boolean
		Try
			If Cadena = Nothing AndAlso Char.IsPunctuation(e.KeyChar) Or Char.IsLetter(e.KeyChar) Then
				Return False
			Else
				Dim Verificacion As Double = Cadena + e.KeyChar + "1"
			End If
		Catch ex As Exception
			Return False
		End Try
		Return True
	End Function

	Private Function VerficarDatos() As Boolean
		Dim incorrectos As Integer = 0
		If Proveedor = Nothing Then
			EPError.SetError(txtProveedor, "No se ha asignado la cedula del proveedor correctactamente")
			incorrectos = +1
		End If
		If Articulo = Nothing Then
			EPError.SetError(txtArticulo, "No se ha asignado el identificador artículo correctactamente")
			incorrectos = +1
		End If
		If Unidades = 0 Then
			EPError.SetError(txtUnidades, "No se han asignado unidades correctactamente")
			incorrectos = +1
		End If
		If Monto = 0 Then
			EPError.SetError(txtMonto, "No se ha asignado un monto correctactamente")
			incorrectos = +1
		End If
		If Estado = Nothing Then
			EPError.SetError(txtEstado, "No se ha asignado un estado correctactamente")
			incorrectos = +1
		End If
		Return incorrectos = 0
	End Function



	Public ReadOnly Property Proveedor() As String
		Get
			Try
				Dim Num As Double = txtProveedor.Text
				Return txtProveedor.Text
			Catch ex As Exception
				Return ""
			End Try
		End Get
	End Property
	Public ReadOnly Property Articulo() As String
		Get
			Try
				Dim Num As Double = txtArticulo.Text
				Return txtArticulo.Text
			Catch ex As Exception
				Return ""
			End Try
			Return txtArticulo.Text
		End Get
	End Property
	Public ReadOnly Property Unidades() As Decimal
		Get
			Try
				Return txtUnidades.Text
			Catch ex As Exception
				Return 0
			End Try
		End Get
	End Property
	Public ReadOnly Property Monto() As Double
		Get
			Try
				Return txtMonto.Text
			Catch ex As Exception
				Return 0
			End Try

		End Get
	End Property
	Public ReadOnly Property FechaCaducidad() As String
		Get
			Return dtpCaducidad.Value.Date.ToString
		End Get
	End Property
	Public ReadOnly Property Estado() As String
		Get
			Return txtEstado.Text
		End Get
	End Property
	''' <summary>
	''' Retorna los datos del formulario en array de string
	''' </summary>
	''' <returns></returns>
	Public ReadOnly Property DatosArray() As String()
		Get
			Return {Proveedor, Articulo, Unidades, Monto, FechaCaducidad, Estado}
		End Get
	End Property

	Public ReadOnly Property TablaInventario() As DataGridView
		Get
			Return tblInventario
		End Get
	End Property
	Public ReadOnly Property TablaProveedor() As DataGridView
		Get
			Return tblProveedor
		End Get
	End Property
	Public ReadOnly Property TablaArticulo() As DataGridView
		Get
			Return tblArticulo
		End Get
	End Property

End Class