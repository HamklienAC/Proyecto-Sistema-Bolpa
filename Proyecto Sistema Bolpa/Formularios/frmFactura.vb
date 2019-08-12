Public Class frmFactura
	Private ReadOnly Caducidad As New DateTimePicker
	Dim Area As Rectangle
	Public Sub New()
		' Esta llamada es exigida por el diseñador.
		InitializeComponent()
		Size = New Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
		'Cadudcidad.
		tblProductos.Controls.Add(Caducidad)
		Caducidad.Visible = False
		Caducidad.Format = DateTimePickerFormat.Long
		AddHandler Caducidad.TextChanged, AddressOf FechaCaducidad
		' Agregue cualquier inicialización después de la llamada a InitializeComponent().
	End Sub

	Private Sub FomularioCaja()

	End Sub

	Private Sub FomularioBodega()

	End Sub

	Private Sub FomularioAdministracion()

	End Sub

	Private Sub TblProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblProductos.CellClick
		Try
			Select Case tblProductos.Columns(e.ColumnIndex).Name
				Case "dtpCaducidad"
					Area = tblProductos.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, True)
					Caducidad.Size = New Size(Area.Size)
					Caducidad.Location = New Point(Area.Location.X, Area.Location.Y)
					Caducidad.Visible = True
			End Select
		Catch ex As Exception

		End Try
	End Sub

	Private Sub TblProductos_ColumnWidthChanged(sender As Object, e As DataGridViewColumnEventArgs) Handles tblProductos.ColumnWidthChanged
		Caducidad.Visible = False
	End Sub

	Private Sub TblProductos_Scroll(sender As Object, e As ScrollEventArgs) Handles tblProductos.Scroll
		Caducidad.Visible = False
	End Sub

	Private Sub FechaCaducidad(sender As Object, e As EventArgs)
		tblProductos.CurrentCell.Value = Caducidad.Value.ToShortDateString
	End Sub

	Private Sub CmsOpciones_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles cmsOpciones.ItemClicked
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

	Private Sub TxtIngresarCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIngresarCodigo.KeyPress

	End Sub

	Private Sub TxtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
		e.Handled = Not VerificarContenidoPuntos(txtCantidad.Text, e) AndAlso Not IsNumeric(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar.Equals(",")
	End Sub

	Private Sub TxtIngresarCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIngresarCodigo.KeyDown
		If e.KeyData = Keys.Enter Then
			txtCantidad.Focus()
		End If
	End Sub

	Private Sub TxtCantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCantidad.KeyDown
		If e.KeyData = Keys.Enter Then
			txtIngresarCodigo.Focus()
		End If
	End Sub

	Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
		Dim Inventario As New frmInventarioExistente
		Inventario.Show()
	End Sub

	Private Function VerificarContenidoPuntos(ByVal Cadena As String, e As KeyPressEventArgs) As Boolean
		Try
			If Cadena = Nothing AndAlso Char.IsPunctuation(e.KeyChar) Then
				Return False
			Else
				Dim Verificacion As Double = Cadena + e.KeyChar + "1"
			End If
		Catch ex As Exception
			Return False
		End Try
		Return True
	End Function

	Private Sub tblProductos_KeyUp(sender As Object, e As KeyEventArgs) Handles tblProductos.KeyUp
		If e.KeyData = Keys.Control + Keys.B Then
			Dim Inventario As New frmInventarioExistente
			Inventario.Show()
		End If
	End Sub

	Public ReadOnly Property Cantidad As Decimal
		Get
			If txtCantidad.Text = Nothing Then
				Return 1
			Else
				Return txtCantidad.Text
			End If
		End Get
	End Property

End Class