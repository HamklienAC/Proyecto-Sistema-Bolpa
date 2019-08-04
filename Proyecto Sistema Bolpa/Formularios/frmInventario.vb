Public Class frmInventario
	Public Sub New()
		' Esta llamada es exigida por el diseñador.
		InitializeComponent()
		Size = New Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
		dtpCaducidad.MinDate = Date.Now
		' Agregue cualquier inicialización después de la llamada a InitializeComponent().
	End Sub

	Private Sub CargarTablas()

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
	Public ReadOnly Property Unidades() As Decimal
		Get
			Dim numero As Integer
			Return If(Integer.TryParse(txtUnidades.Text, numero), txtUnidades.Text + ",0", txtUnidades.Text)
		End Get
	End Property
	Public ReadOnly Property Monto() As Double
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
		MsgBox(Unidades)
	End Sub

	Private Sub CmsOpciones_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles cmsOpciones.ItemClicked
		Select Case e.ClickedItem.Name
			Case "ActualizarLoteToolStripMenuItem"
				MsgBox("Actulizar")
			Case "EliminarLoteToolStripMenuItem"
				MsgBox("Eliminar")
		End Select
	End Sub

	Private Sub TblProveedor_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles tblProveedor.CellMouseDoubleClick

	End Sub

	Private Sub TblArticulo_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles tblArticulo.CellMouseDoubleClick

	End Sub

End Class