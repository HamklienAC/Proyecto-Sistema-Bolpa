Public Class frmBuscarFactura
	Public Sub New()
		' Esta llamada es exigida por el diseñador.
		InitializeComponent()
		' Agregue cualquier inicialización después de la llamada a InitializeComponent().
	End Sub

	Private Sub VerificarPermiso()

	End Sub


	Private Sub cmsOpciones_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles cmsOpciones.ItemClicked
		Try
			Select Case e.ClickedItem.Name
				Case "AnularFacturaToolStripMenuItem"
					If MsgBox("¿Desea anular la factura " + tblFacturas.CurrentRow.Cells(0).Value.ToString + " ?", MsgBoxStyle.YesNo Or MsgBoxStyle.Critical, "Factura") = MsgBoxResult.Yes Then

					End If
				Case "CancelarFacturaToolStripMenuItem"
					If MsgBox("¿Desea cancelar la factura " + tblFacturas.CurrentRow.Cells(0).Value.ToString + " ?", MsgBoxStyle.YesNo Or MsgBoxStyle.Information, "Factura") = MsgBoxResult.Yes Then

					End If
			End Select
		Catch ex As Exception

		End Try
	End Sub

	Private Sub TxtFiltro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFiltro.KeyPress
		e.Handled = Not IsNumeric(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar.ToString.Equals("-")
	End Sub

	Private Sub cbTipoFactura_CheckedChanged(sender As Object, e As EventArgs) Handles cbTipoFactura.CheckedChanged
		If cbTipoFactura.CheckState Then
			AnularFacturaToolStripMenuItem.Enabled = False
		Else
			AnularFacturaToolStripMenuItem.Enabled = True
		End If
	End Sub

	Private Sub txtFiltro_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFiltro.KeyDown
		If e.KeyData = Keys.Enter Then
			If IsNumeric(txtFiltro.Text) OrElse IsDate(txtFiltro.Text) Then
				If cbTipoFactura.Checked Then
					'Cargar factura de proveedores 
				Else
					'Cargar factura de clientes 
				End If
			Else
				MsgBox("Solo se permiten codigos numerales o fechas")
			End If
		End If
	End Sub
End Class