Public Class frmInventario
	Public Sub New()
		' Esta llamada es exigida por el diseñador.
		InitializeComponent()
		Size = New Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
		dtpCaducidad.MinDate = Date.Now
		' Agregue cualquier inicialización después de la llamada a InitializeComponent().
	End Sub



	Public ReadOnly Property Proveedor() As String
		Get
			Return txtProveedor.Text
		End Get
	End Property
	Public ReadOnly Property Articulo() As String
		Get
			Return txtArticulo.Text
		End Get
	End Property
	Public ReadOnly Property Unidades() As String
		Get
			Return txtUnidades.Text
		End Get
	End Property
	Public ReadOnly Property Monto() As String
		Get
			Return txtMonto.Text
		End Get
	End Property
	Public ReadOnly Property FechaCaducidad() As String
		Get
			Return dtpCaducidad.Text
		End Get
	End Property
	Public ReadOnly Property Estado() As String
		Get
			Return txtEstado.Text
		End Get
	End Property

	Public ReadOnly Property TablaInventario() As DataGridView
		Get
			Return tblInventario
		End Get
	End Property
	Public ReadOnly Property TablaProveedor() As DataGridView
		Get
			Return tblProveedor
		End Get
	End Property
	Public ReadOnly Property TablaArticulo() As DataGridView
		Get
			Return tblArticulo
		End Get
	End Property

	Private Sub BtnCrud_Click(sender As Object, e As EventArgs) Handles btnCrud.Click

	End Sub
End Class