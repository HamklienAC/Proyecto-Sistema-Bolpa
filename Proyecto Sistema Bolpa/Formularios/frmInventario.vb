Public Class frmInventario
	Private posicioncelda As Integer
	Public Sub New()
		' Esta llamada es exigida por el diseñador.
		InitializeComponent()
		Size = New Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
		dtpCaducidad.MinDate = Date.Now
		CargarTablas()
		' Agregue cualquier inicialización después de la llamada a InitializeComponent().
	End Sub

	Private Sub CargarTablas()
		'tblInventario.Rows.Add("101")
		'tblInventario.Rows.Add("102")
		'tblInventario.Rows.Add("103")
		'tblInventario.Rows.Add("104")
		'tblInventario.Rows.Add("105")
	End Sub

	Private Sub BtnCrud_Click(sender As Object, e As EventArgs) Handles btnCrud.Click
		MsgBox(Unidades)
	End Sub

	Private Sub CmsOpciones_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles cmsOpciones.ItemClicked
		Try
			Select Case e.ClickedItem.Name
				Case "ActualizarLoteToolStripMenuItem"
					MsgBox(tblInventario.CurrentRow.Cells(0).Value.ToString)
				Case "EliminarLoteToolStripMenuItem"
					MsgBox("Eliminar")
			End Select
		Catch ex As Exception

		End Try

	End Sub

	Private Sub TblProveedor_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles tblProveedor.CellMouseDoubleClick

	End Sub

	Private Sub TblArticulo_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles tblArticulo.CellMouseDoubleClick
	End Sub

	Private Sub TxtArticulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtArticulo.KeyPress
		VerificarEntradadas(e)
	End Sub

	Private Sub TxtProveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProveedor.KeyPress
		VerificarEntradadas(e)
	End Sub

	Private Sub TxtEstado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEstado.KeyPress
		VerificarEntradadas(e)
	End Sub

	Private Sub VerificarEntradadas(e As KeyPressEventArgs)
		e.Handled = Char.IsPunctuation(e.KeyChar) AndAlso Not Char.IsSeparator(e.KeyChar)
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


	Public ReadOnly Property Proveedor() As String
		Get
			Return txtProveedor.Text
		End Get
	End Property
	Public ReadOnly Property Articulo() As String
		Get
			Return txtArticulo.Text
		End Get
	End Property
	Public ReadOnly Property Unidades() As Decimal
		Get
			Dim numero As Integer
			Return If(Integer.TryParse(txtUnidades.Text, numero), txtUnidades.Text + ",0", txtUnidades.Text)
		End Get
	End Property
	Public ReadOnly Property Monto() As Double
		Get
			Return txtMonto.Text
		End Get
	End Property
	Public ReadOnly Property FechaCaducidad() As String
		Get
			Return dtpCaducidad.Text
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