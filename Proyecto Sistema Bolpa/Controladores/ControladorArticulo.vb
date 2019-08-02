Imports Proyecto_Sistema_Bolpa.Proyecto_Sistema_Bolpa
'Esto le sirve a Hamklien'

Public Class ControladorArticulo
	Dim articulo As clsArticulo

	Public Sub AgregarArticulo(datos() As String)
		Try
			articulo = New clsArticulo(0, datos(0), datos(1), datos(2), datos(3), datos(4), datos(5), datos(6), datos(7), datos(8))
			Using BD As New ProyectoBDEntities1
				Dim tblArticulo As New tblArticulo With {
				.Codigo = articulo.Codigo,
				.Nombre = articulo.Nombre,
				.Familia = articulo.Familia,
				.SubFamilia = articulo.SubFamilia,
				.Descripcion = articulo.Descripcion,
				.Peso = articulo.Peso,
				.Impuesto = articulo.CalcularIVA()}

				BD.tblArticulo.Add(tblArticulo)
				BD.SaveChanges()
			End Using
		Catch ex As Exception

		End Try
	End Sub

	Public Sub ActualizarArticulo()

	End Sub

	Public Sub EliminarArticulo(Codigo As String)

	End Sub

	Public Sub CargarFamilia(ByVal Combobox As ComboBox)

	End Sub
	Public Sub CargarSubfamilias(ByVal Combobox As ComboBox)

	End Sub
	Public Sub CargarTabla(ByVal Tabla As DataGridView)

	End Sub

	Public Sub CargarProveedores(ByVal TextBox As TextBox)

	End Sub

	Public Sub CargarDatos(ByVal Codigo As String, ByVal Objetos As Array)
		'{txtNombre, txtProveedor, txtCodigo, txtPeso, txtPrecio, cbFamilia, cbSubfamilia, txtDescripcion}
		Try
			Using BD As New ProyectoBDEntities1
				Dim datosArticulo = (From ArticuloBD In BD.tblArticulo Where ArticuloBD.Codigo = Codigo Select ArticuloBD).ToList
				If datosArticulo.Count > 0 Then
					Objetos(0) = datosArticulo.SingleOrDefault.Nombre
					Objetos(1) = datosArticulo.SingleOrDefault.Codigo
					Objetos(2) = datosArticulo.SingleOrDefault.Peso
					Objetos(3) = datosArticulo.SingleOrDefault.Precio
					Objetos(4) = datosArticulo.SingleOrDefault.Familia
					Objetos(5) = datosArticulo.SingleOrDefault.SubFamilia
					Objetos(6) = datosArticulo.SingleOrDefault.Descripcion
				End If
			End Using
		Catch ex As Exception

		End Try
	End Sub
End Class
