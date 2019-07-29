Public Class FrmActualizarArticulo
	Private Sub TblArticulos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblArticulos.CellDoubleClick
		Try
			Dim valor = tblArticulos.CurrentRow.Cells(0).Value.ToString
		Catch ex As Exception
			'Ejemplo
		End Try

	End Sub

End Class
