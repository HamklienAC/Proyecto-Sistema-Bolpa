Imports System.ComponentModel

Public Class FrmFactura
	Private posicionCelda As String = String.Empty


	Public Sub New()
		' Esta llamada es exigida por el diseñador.
		InitializeComponent()
		Size = New Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
		SurroundingSub()
		' Agregue cualquier inicialización después de la llamada a InitializeComponent().
	End Sub

	Private Sub SurroundingSub()
		tblProductos.Rows.Add("Peras", "101", "508.3", "5")
		tblProductos.Rows.Add("Arroz tio pelon", "102", "1980", "5")
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		If tblProductos.CellBorderStyle = 4 Then
			tblProductos.CellBorderStyle = DataGridViewCellBorderStyle.Raised
			Label1.Text = DataGridViewCellBorderStyle.Raised.ToString
		ElseIf tblProductos.CellBorderStyle = 2 Then
			tblProductos.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal
			Label1.Text = DataGridViewCellBorderStyle.RaisedHorizontal.ToString
		ElseIf tblProductos.CellBorderStyle = 9 Then
			tblProductos.CellBorderStyle = DataGridViewCellBorderStyle.RaisedVertical
			Label1.Text = DataGridViewCellBorderStyle.RaisedVertical.ToString
		ElseIf tblProductos.CellBorderStyle = 6 Then
			tblProductos.CellBorderStyle = DataGridViewCellBorderStyle.Single
			Label1.Text = DataGridViewCellBorderStyle.Single.ToString
		ElseIf tblProductos.CellBorderStyle = 1 Then
			tblProductos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
			Label1.Text = DataGridViewCellBorderStyle.SingleHorizontal.ToString
		ElseIf tblProductos.CellBorderStyle = 8 Then
			tblProductos.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
			Label1.Text = DataGridViewCellBorderStyle.SingleVertical.ToString
		ElseIf tblProductos.CellBorderStyle = 5 Then
			tblProductos.CellBorderStyle = DataGridViewCellBorderStyle.Sunken
			Label1.Text = DataGridViewCellBorderStyle.Sunken.ToString
		ElseIf tblProductos.CellBorderStyle = 3 Then
			tblProductos.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal
			Label1.Text = DataGridViewCellBorderStyle.SunkenHorizontal.ToString
		ElseIf tblProductos.CellBorderStyle = 10 Then
			tblProductos.CellBorderStyle = DataGridViewCellBorderStyle.SunkenVertical
			Label1.Text = DataGridViewCellBorderStyle.SunkenVertical.ToString
		ElseIf tblProductos.CellBorderStyle = 7 Then
			tblProductos.CellBorderStyle = DataGridViewCellBorderStyle.None
			Label1.Text = DataGridViewCellBorderStyle.None.ToString
		End If
	End Sub

	Private Sub TblProductos_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles tblProductos.CellMouseClick
		'If e.Button = MouseButtons.Right AndAlso e.ColumnIndex < 0 OrElse e.RowIndex < 0 Then
		'	posicionCelda = tblProductos(e.ColumnIndex, e.RowIndex).Value.ToString()
		'	MenuDesplegable.Show(MousePosition)
		'End If
	End Sub

	Private Sub MenuDesplegable_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuDesplegable.ItemClicked
		Try
			Select Case e.ClickedItem.Name
				Case "EliminarArticulosDeLaCompraToolStripMenuItem"
					Dim row As DataGridViewRow = tblProductos.CurrentRow
					tblProductos.Rows.Remove(row)
				Case "ModificarCantidad"

			End Select
		Catch ex As Exception

		End Try
	End Sub

End Class