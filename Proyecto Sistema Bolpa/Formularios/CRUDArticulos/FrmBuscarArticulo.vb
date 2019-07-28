Public Class FrmBuscarArticulo

	Private Sub MenuFlotante_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuFlotante.ItemClicked
		Try
			Select Case e.ClickedItem.Name
				Case "EliminarArticuloToolStripMenuItem"
					If MsgBox("¿Desea eliminar este artículo del inventario?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
						Dim row As DataGridViewRow = tblProductos.CurrentRow
						tblProductos.Rows.Remove(row)
					End If
				Case "ModificarArtículoToolStripMenuItem"

			End Select
		Catch ex As Exception

		End Try
	End Sub

	''' <summary>
	''' Buscar en la tabla con los productos que cumplan con las caracteristicas
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub TxtFiltro_Enter(sender As Object, e As EventArgs) Handles txtFiltro.Enter

	End Sub

	Private Sub TxtFiltro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFiltro.KeyPress
		If Not Char.IsPunctuation(e.KeyChar) Then
			e.Handled = False
		Else
			e.Handled = True
		End If
	End Sub
End Class