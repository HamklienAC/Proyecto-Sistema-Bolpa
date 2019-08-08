Public Class frmArticulo
	Private ReadOnly controlador As ControladorArticulo
	Public Sub New()
		' Esta llamada es exigida por el diseñador.
		InitializeComponent()
		controlador = New ControladorArticulo
		Size = New Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
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

	Private Sub CbAgregarFam_CheckedChanged(sender As Object, e As EventArgs) Handles cbAgregarFam.CheckedChanged
		Try
			EPErrorFamilia.Clear()
			EPErrorSubfamila.Clear()
			If cbAgregarFam.Checked Then
				CambiarEstado(1)
			Else
				CambiarEstado(2)
			End If
		Catch ex As Exception

		End Try
	End Sub
	Private Sub CbAgregarSub_CheckedChanged(sender As Object, e As EventArgs) Handles cbAgregarSub.CheckedChanged
		Try
			EPErrorSubfamila.Clear()
			If cbAgregarSub.Checked Then
				CambiarEstado(3)
			Else
				CambiarEstado(4)
			End If
		Catch ex As Exception

		End Try
	End Sub
	Private Sub CambiarEstado(ByVal Opc As Integer)
		Try
			Select Case Opc
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
		Catch ex As Exception

		End Try
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
	End Sub
	''' <summary>
	''' Método se encarga se verificar si la cifra tiene un punto
	''' </summary>
	''' <param name="Cadena"></param>
	''' <returns></returns>
	Private Function VerificarContenidoPuntos(ByVal Cadena As String, e As KeyPressEventArgs) As Boolean
		Try
			If Cadena = Nothing AndAlso Char.IsPunctuation(e.KeyChar) Or e.KeyChar.ToString.Equals("e") Then
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
		e.Handled = Not IsNumeric(e.KeyChar) AndAlso Not Char.IsSeparator(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar)
	End Sub
	Private Sub TxtNuevaFamilia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNuevaFamilia.KeyPress
		VerificarEntradadas(e)
	End Sub
	Private Sub TxtNuevaSubfamilia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNuevaSubfamilia.KeyPress
		VerificarEntradadas(e)
	End Sub
	Private Sub TxtProveedor_KeyPress(sender As Object, e As KeyPressEventArgs)
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
		Try
			If VerficarDatosTextbox() And VerificarDatosCombobox() Then
				If btnAgregarProducto.Text.Equals("Actualizar artículo") Then
					controlador.ActualizarArticulo()
					btnAgregarProducto.Text = " Agregar artículo"
				Else
					controlador.AgregarArticulo(DatosArray)
				End If
			Else
				MsgBox("Los datos ingresados son incorrectos", MsgBoxStyle.Critical)
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Private Sub BtnImagen_Click(sender As Object, e As EventArgs) Handles btnImagen.Click
		Dim dlg As New OpenFileDialog With {
			.Filter = "Imagenes JPG|*.jpg|Imagenes PNG|*.png|Imagenes GIF|*.gif"
		}
		If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
			pbImagen.SizeMode = PictureBoxSizeMode.StretchImage
			pbImagen.Image = Image.FromFile(dlg.FileName)
		End If
	End Sub

	Private Function VerficarDatosTextbox() As Boolean
		EPError.Clear()
		Dim incorrectos As Integer = 0
		If Nombre = Nothing Then
			EPError.SetError(txtNombre, "No se ha asignado un nombre al artículo")
			incorrectos = +1
		End If
		If CodigoArticulo = Nothing Then
			EPError.SetError(txtCodigo, "No se ha asignado un código al artículo")
			incorrectos = +1
		End If
		If Peso = 0 Then
			EPError.SetError(txtPeso, "No se ha asignado un peso al artículo")
			incorrectos = +1
		End If
		If Precio = 0 Then
			EPError.SetError(txtPrecio, "No se ha asignado un precio al artículo")
			incorrectos = +1
		End If
		Return incorrectos = 0
	End Function

	Private Function VerificarDatosCombobox() As Boolean
		Dim incorrectos As Integer = 0
		If CodigoProveedor = Nothing Then
			EPError.SetError(CbProveedor, "No se ha asignado un proveedor al artículo")
			incorrectos = +1
		End If
		If Descripcion = Nothing Then
			EPError.SetError(cbDescripcion, "No se ha asignado una descripción al artículo")
			incorrectos = +1
		End If
		If Familia = Nothing Then
			incorrectos = +1
			If cbAgregarFam.Checked Then
				EPErrorFamilia.SetError(txtNuevaFamilia, "No se ha asignado una familia al artículo")
			Else
				EPErrorFamilia.SetError(cbFamilia, "No se ha asignado una familia al artículo")
			End If
		End If
		If Subfamilia = Nothing Then
			incorrectos = +1
			If cbAgregarSub.Checked Then
				EPErrorSubfamila.SetError(txtNuevaSubfamilia, "No se ha asignado una subfamila al artículo")
			Else
				EPErrorSubfamila.SetError(cbSubfamilia, "No se ha asignado una subfamila al artículo")
			End If
		End If
		Return incorrectos = 0
	End Function

	Private Sub RellenarEspacios(ByVal fila As String)
		'controlador.CargarDatos(fila, DatosObjeto)
	End Sub

	Private Sub LimpiarControles()

	End Sub

	Public ReadOnly Property Nombre() As String
		Get
			Return txtNombre.Text
		End Get
	End Property
	Public ReadOnly Property CodigoProveedor() As String
		Get
			Return cbDescripcion.Text
		End Get
	End Property
	Public ReadOnly Property CodigoArticulo() As String
		Get
			Return txtCodigo.Text
		End Get
	End Property
	Public ReadOnly Property Peso() As Double
		Get
			Return If(txtPeso.Text = Nothing, 0, CDbl(txtPeso.Text))
		End Get
	End Property
	Public ReadOnly Property Precio() As Double
		Get
			Return If(txtPrecio.Text = Nothing, 0, CDbl(txtPrecio.Text))
		End Get
	End Property
	Public ReadOnly Property Familia() As String
		Get
			Return If(cbAgregarFam.Checked, txtNuevaFamilia.Text, cbFamilia.Text)
		End Get
	End Property
	Public ReadOnly Property Subfamilia() As String
		Get
			Return If(cbAgregarFam.Checked Or cbAgregarSub.Checked, txtNuevaSubfamilia.Text, cbSubfamilia.Text)
		End Get
	End Property
	Public ReadOnly Property Descripcion() As String
		Get
			Return cbDescripcion.Text
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
	''' </summary>cb
	''' <returns></returns>
	Public ReadOnly Property DatosObjeto() As Array
		Get
			Return {txtNombre, txtCodigo, txtPeso, txtPrecio, cbFamilia, cbSubfamilia, cbDescripcion}
		End Get
	End Property


End Class