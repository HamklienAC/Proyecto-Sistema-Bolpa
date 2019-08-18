Public Class frmInventarioExistente
	'Private ReadOnly tablaInfomacion As New DataTable
	Public Sub New()
		' Esta llamada es exigida por el diseñador.
		InitializeComponent()
		' Agregue cualquier inicialización después de la llamada a InitializeComponent().
	End Sub

	Private Sub txtFiltro_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFiltro.KeyDown
		If e.KeyData = Keys.Enter Then
			Try
				'tablaInfomacion.DefaultView.RowFilter = $"Columna1 LIKE '{txtFiltro.Text}%'"
			Catch ex As Exception

			End Try

		End If
	End Sub

	Private Sub TxtFiltro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFiltro.KeyPress
		e.Handled = Not Char.IsLetterOrDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar)
	End Sub
End Class