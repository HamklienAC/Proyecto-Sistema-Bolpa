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
		Try

		Catch ex As Exception

		End Try
	End Sub

	Public Sub EliminarArticulo(Codigo As String)
		Try

		Catch ex As Exception

		End Try
	End Sub


	Public Sub CargarTabla(ByVal Tabla As DataGridView)
		Try

		Catch ex As Exception

		End Try
	End Sub


	Public Sub CargarFamilia(ByVal Familia As ComboBox)
		Try

			EliminarFamilias(Familia)
		Catch ex As Exception

		End Try
	End Sub

	Public Sub CargarSubfamilias(ByVal Subfamilia As ComboBox)
		Try

			EliminarSubfamilia(Subfamilia)
		Catch ex As Exception

		End Try
	End Sub

	Public Sub CargarProveedor(ByVal Proveedor As ComboBox)
		Try

		Catch ex As Exception

		End Try
	End Sub

	''' <summary>
	''' Metodo se encarga de eliminar las familias repetidas que pueden tener el combobox familia
	''' </summary>
	''' <param name="Familia"></param>
	Private Sub EliminarFamilias(ByVal Familia As ComboBox)
		Try

		Catch ex As Exception

		End Try
	End Sub
	''' <summary>
	''' Metodo se encarga de eliminar las subfamilias repetidas que pueden tener el combobox familia
	''' </summary>
	''' <param name="Subfamilia"></param>
	Private Sub EliminarSubfamilia(ByVal Subfamilia As ComboBox)
		Try

		Catch ex As Exception

		End Try
	End Sub
End Class
