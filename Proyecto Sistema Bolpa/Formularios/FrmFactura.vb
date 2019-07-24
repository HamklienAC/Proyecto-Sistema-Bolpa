Public Class FrmFactura
	Public Sub New()
		' Esta llamada es exigida por el diseñador.
		InitializeComponent()
		Size = New Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
		' Agregue cualquier inicialización después de la llamada a InitializeComponent().
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


End Class