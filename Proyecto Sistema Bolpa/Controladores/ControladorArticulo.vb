Public Class ControladorArticulo
	Dim articulo As clsArticulo

	Public Sub AgregarArticulo(datos() As String)
		articulo = New clsArticulo(0, datos(0), datos(1), datos(2), datos(3), datos(4), datos(5), datos(6), datos(7), datos(8))

		Using BD As New Proyecto_Sistema_Bolpa.ProyectoBD
			Dim tblArticulo As New Proyecto_Sistema_Bolpa.tblArticulo With {
			.Codigo = articulo.Codigo,
			.Nombre = articulo.Nombre,
			.Familia = articulo.Familia,
			.SubFamilia = articulo.SubFamilia,
			.Descripcion = articulo.Descripcion,
			.Peso = articulo.Peso,
			.FechaCaducidad = articulo.FechaCaducidad,
			.Impuesto = articulo.CalcularIVA(),
			.Estado = articulo.Estado}

			BD.tblArticulo.Add(tblArticulo)
			BD.SaveChanges()
		End Using

	End Sub


	Private Sub CargarTabla(Tabla As DataGridView)
		Using BD As New Proyecto_Sistema_Bolpa.ProyectoBD

		End Using
	End Sub

End Class
