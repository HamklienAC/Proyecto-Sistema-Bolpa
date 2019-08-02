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

	Private Sub CargarTabla(ByVal Tabla As DataGridView)

	End Sub

	Public Sub CargarDatos(ByVal Codigo As String)
		Try
			Using BD As New ProyectoBDEntities1
				Dim Seleccion = (From Articulo In BD.tblArticulo Where Articulo.Codigo = Codigo Select Articulo).ToList
				If Seleccion.Count > 0 Then
					TxtNombre.Text = Seleccion.SingleOrDefault.Nombre
					TxtPriApellido.Text = Seleccion.SingleOrDefault.PrimerApellido
					TxtSegApellido.Text = Seleccion.SingleOrDefault.SegundoApellido
					TxtIdentificador.Text = Seleccion.SingleOrDefault.Identificador
					Me.DateTimePicker1.Text = Seleccion.SingleOrDefault.FechaNacimiento
				End If
			End Using
		Catch ex As Exception

		End Try
	End Sub
End Class
