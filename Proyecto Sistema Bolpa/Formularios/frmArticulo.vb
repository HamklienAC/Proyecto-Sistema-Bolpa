Public Class frmArticulo
	Private ReadOnly controlador As ControladorArticulo
	Public Sub New()
		' Esta llamada es exigida por el diseñador.
		InitializeComponent()
		controlador = New ControladorArticulo
		Size = New Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
		AgregarArticulos()
		CargarFamilia()
		CargarSubfamilia()
		CargarTabla()
		' Agregue cualquier inicialización después de la llamada a InitializeComponent().
	End Sub

	Private Sub CargarFamilia()
		controlador.CargarFamilia(cbFamilia)
	End Sub
	Private Sub CargarSubfamilia()
		controlador.CargarSubfamilias(cbSubfamilia)
	End Sub
	Private Sub CargarTabla()
		controlador.CargarTabla(tblArticulos)
	End Sub
	Private Sub AgregarArticulos()
		'{CodigoArticulo, Nombre, Descripcion, Familia, Subfamilia, Peso, Precio}
		tblArticulos.Rows.Add("Aguacate", "101", "500", "800", "Plantas", "Frutas", "Rico en calorias")
		tblArticulos.Rows.Add("Aguacate", "102", "500", "800", "Plantas", "Frutas", "Rico en calorias")
		tblArticulos.Rows.Add("Aguacate", "103", "500", "800", "Plantas", "Frutas", "Rico en calorias")
		tblArticulos.Rows.Add("Aguacate", "104", "500", "800", "Plantas", "Frutas", "Rico en calorias")
	End Sub

	Private Sub CbAgregarFam_CheckedChanged(sender As Object, e As EventArgs) Handles cbAgregarFam.CheckedChanged
		If cbAgregarFam.Checked Then
			CambiarEstado(1)
		Else
			CambiarEstado(2)
		End If
	End Sub
	Private Sub CbAgregarSub_CheckedChanged(sender As Object, e As EventArgs) Handles cbAgregarSub.CheckedChanged
		If cbAgregarSub.Checked Then
			CambiarEstado(3)
		Else
			CambiarEstado(4)
		End If
	End Sub
	Private Sub CambiarEstado(ByVal Opc As Integer)
		Select Case (Opc)
			Case 1
				cbFamilia.Enabled = False
				txtNuevaFamilia.Enabled = True
				txtNuevaSubfamilia.Enabled = True
				cbSubfamilia.Enabled = False
				cbAgregarSub.Enabled = False
			Case 2
				cbFamilia.Enabled = True
				txtNuevaFamilia.Enabled = False
				txtNuevaSubfamilia.Enabled = False
				cbSubfamilia.Enabled = True
				cbAgregarSub.Enabled = True
			Case 3
				cbSubfamilia.Enabled = False
				txtNuevaSubfamilia.Enabled = True
				cbAgregarSub.Enabled = True
				cbAgregarFam.Enabled = False
			Case 4
				cbAgregarFam.Enabled = True
				cbSubfamilia.Enabled = True
				txtNuevaSubfamilia.Enabled = False
				cbAgregarSub.Enabled = True
		End Select
	End Sub

	Private Sub TxtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
		VerificarContenidosTXTPP(e, txtPrecio.Text)
	End Sub
	Private Sub TxtPeso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPeso.KeyPress
		VerificarContenidosTXTPP(e, txtPeso.Text)
	End Sub
	''' <summary>
	''' Metodo se encarga de verificar que solo sean numeros, puntos y controles
	''' </summary>
	''' <param name="e"></param>
	''' <param name="Valor"></param>
	Private Sub VerificarContenidosTXTPP(e As KeyPressEventArgs, ByVal Valor As String)
		e.Handled = Not VerificarContenidoPuntos(Valor, e) AndAlso Not IsNumeric(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar.Equals(",")

		'e.Handled = Not VerificarContenidoPuntos(Valor) AndAlso Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
	End Sub
	''' <summary>
	''' Método se encarga se verificar si la cifra tiene un punto
	''' </summary>
	''' <param name="Cadena"></param>
	''' <returns></returns>
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

	Private Sub TxtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
		VerificarEntradadas(e)
	End Sub
	Private Sub TxtCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigo.KeyPress
		VerificarEntradadas(e)
	End Sub
	Private Sub TxtNuevaFamilia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNuevaFamilia.KeyPress
		VerificarEntradadas(e)
	End Sub
	Private Sub TxtNuevaSubfamilia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNuevaSubfamilia.KeyPress
		VerificarEntradadas(e)
	End Sub
	Private Sub TxtDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescripcion.KeyPress
		VerificarEntradadas(e)
	End Sub
	Private Sub TxtProveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProveedor.KeyPress
		VerificarEntradadas(e)
	End Sub
	''' <summary>
	''' Método se encarga de filtar de tal manera que solo permita caracteres y separadores
	''' </summary>
	''' <param name="e"></param>
	Private Sub VerificarEntradadas(e As KeyPressEventArgs)
		e.Handled = Char.IsPunctuation(e.KeyChar) AndAlso Not Char.IsSeparator(e.KeyChar)
	End Sub

	Private Sub CmsOpciones_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles cmsOpciones.ItemClicked
		Try
			Select Case e.ClickedItem.Name
				Case "ActualizarArtículoToolStripMenuItem"
					If MsgBox("Desea actualizar los datos del artíclo: " + tblArticulos.CurrentRow.Cells(0).Value.ToString + ", código: " + tblArticulos.CurrentRow.Cells(1).Value.ToString, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
						btnAgregarProducto.Text = "Actualizar artículo"
						RellenarEspacios(tblArticulos.CurrentRow.Cells(1).Value.ToString)
					End If
				Case "EliminarArtículoToolStripMenuItem"
					If MsgBox("Desea eliminar el artíclo: " + tblArticulos.CurrentRow.Cells(0).Value.ToString + ", código: " + tblArticulos.CurrentRow.Cells(1).Value.ToString, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
						controlador.EliminarArticulo(tblArticulos.CurrentRow.Cells(1).Value.ToString)
					End If
			End Select
		Catch ex As Exception

		End Try
	End Sub
	Private Sub BtnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
		If btnAgregarProducto.Text.Equals("Actualizar artículo") Then
			controlador.ActualizarArticulo()
			btnAgregarProducto.Text = " Agregar artículo"
		Else
			controlador.AgregarArticulo(DatosArray)
		End If
	End Sub
	Private Sub RellenarEspacios(ByVal fila As String)
		controlador.CargarDatos(fila, DatosObjeto)
	End Sub

	Public ReadOnly Property Nombre() As String
		Get
			Return txtNombre.Text
		End Get
	End Property
	Public ReadOnly Property CodigoProveedor() As String
		Get
			Return txtProveedor.Text
		End Get
	End Property
	Public ReadOnly Property CodigoArticulo() As String
		Get
			Return txtCodigo.Text
		End Get
	End Property
	Public ReadOnly Property Peso() As Double
		Get
			Return txtPeso.Text
		End Get
	End Property
	Public ReadOnly Property Precio() As Double
		Get
			Return txtPrecio.Text
		End Get
	End Property
	Public ReadOnly Property Familia() As String
		Get
			If cbAgregarFam.Enabled Then
				Return cbAgregarFam.Text
			Else
				Return cbFamilia.SelectedItem.ToString
			End If
		End Get
	End Property
	Public ReadOnly Property Subfamilia() As String
		Get
			If cbAgregarSub.Enabled Then
				Return cbAgregarSub.Text
			Else
				Return cbSubfamilia.SelectedItem.ToString
			End If
		End Get
	End Property
	Public ReadOnly Property Descripcion() As String
		Get
			Return txtDescripcion.Text
		End Get
	End Property
	''' <summary>
	''' Retorna una array de string con los datos del articulo
	''' </summary>
	''' <returns></returns>
	Public ReadOnly Property DatosArray() As String()
		Get
			Return {CodigoArticulo, Nombre, Descripcion, Familia, Subfamilia, Peso, Precio}
		End Get
	End Property
	''' <summary>
	''' Devuelve los los objetos en los cuales se digita la informacion
	''' </summary>
	''' <returns></returns>
	Public ReadOnly Property DatosObjeto() As Array
		Get
			Return {txtNombre, txtCodigo, txtPeso, txtPrecio, cbFamilia, cbSubfamilia, txtDescripcion}
		End Get
	End Property


End Class