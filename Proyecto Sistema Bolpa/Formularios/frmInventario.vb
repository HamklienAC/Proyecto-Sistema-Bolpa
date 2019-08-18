Public Class frmInventario
	Private Caducidad As DateTimePicker
	Private Area As Rectangle

	Public Sub New()
		' Esta llamada es exigida por el diseñador.
		InitializeComponent()
		Size = New Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
		CrearDatetimepicker()
		' Agregue cualquier inicialización después de la llamada a InitializeComponent().
	End Sub

	Private Sub CrearDatetimepicker()
		Caducidad = New DateTimePicker With {
			.MinDate = Today
		}
		tblLote.Controls.Add(Caducidad)
		Caducidad.Visible = False
		Caducidad.Format = DateTimePickerFormat.Short
		AddHandler Caducidad.TextChanged, AddressOf EvniarFechaCaducidad
	End Sub
	Private Sub TblLote_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblLote.CellClick
		Try
			Select Case tblLote.Columns(e.ColumnIndex).Name
				Case "dtpCaducidad"
					Area = tblLote.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, True)
					Caducidad.Size = New Size(Area.Size)
					Caducidad.Location = New Point(Area.Location.X, Area.Location.Y)
					Caducidad.Visible = True
			End Select
		Catch ex As Exception

		End Try
	End Sub
	Private Sub TblLote_ColumnWidthChanged(sender As Object, e As DataGridViewColumnEventArgs) Handles tblLote.ColumnWidthChanged
		Caducidad.Visible = False
	End Sub
	Private Sub TblLote_Scroll(sender As Object, e As ScrollEventArgs) Handles tblLote.Scroll
		Caducidad.Visible = False
	End Sub
	Private Sub EvniarFechaCaducidad(sender As Object, e As EventArgs)
		tblLote.CurrentCell.Value = Caducidad.Text
	End Sub
	Private Sub BtnCrud_Click(sender As Object, e As EventArgs) Handles btnCrud.Click
		Try
			If VerificarDatosCompletos() Then

			Else
				MsgBox("Los datos a ingresar son incorrectos", MsgBoxStyle.Critical)
			End If

		Catch ex As Exception

		End Try
	End Sub
	Private Sub CmsOpciones_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles cmsOpcionesInventario.ItemClicked
		Try
			Select Case e.ClickedItem.Name
				Case "ActualizarLoteToolStripMenuItem"
					If MsgBox("Desea actualizar los datos del invetario: " + tblInventario.CurrentRow.Cells(0).Value.ToString, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
						AgregarLoteActualizar()
						btnCrud.Text = "Actualizar lote"
					End If
				Case "EliminarLoteToolStripMenuItem"
					If MsgBox("¿Desea eliminar el lote " + tblInventario.CurrentRow.Cells(0).Value.ToString + " del inventario?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
						'tblInventario.CurrentRow.Cells(0).Value.ToString() llave primaria del lote en el inventario
					End If
			End Select
		Catch ex As Exception
		End Try
	End Sub

	Private Sub AgregarLoteActualizar()
		Try
			tblLote.Rows.Add()
			For Columna = 0 To 5 Step 1
				tblLote.Rows(tblLote.RowCount - 1).Cells(Columna).Value = tblInventario.CurrentRow.Cells(Columna).Value
			Next
		Catch ex As Exception

		End Try
	End Sub
	Private Sub TblProveedor_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblProveedor.CellClick
		Try
			'los numero que esta dentro de los parentesis corresponde al orden en la base de datos
			If MsgBox("Desea agregar el proveedor " + tblProveedor.CurrentRow.Cells(0).Value.ToString, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
				tblLote.CurrentRow.Cells(1).Value = tblProveedor.CurrentRow.Cells(0).Value.ToString
			End If
		Catch ex As Exception
		End Try
	End Sub
	Private Sub TblArticulo_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblArticulo.CellClick
		Try
			'los numero que esta dentro de los parentesis corresponde al orden en la base de datos
			If MsgBox("Desea agregar el artículo " + tblArticulo.CurrentRow.Cells(0).Value.ToString, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
				tblLote.CurrentRow.Cells(0).Value = tblArticulo.CurrentRow.Cells(1).Value.ToString
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Private Sub tblLote_CellValidated(sender As Object, e As DataGridViewCellEventArgs) Handles tblLote.CellValidated
		Try
			Select Case e.ColumnIndex
				Case 0, 1, 2, 3
					If Not IsNumeric(tblLote.CurrentRow.Cells(e.ColumnIndex).Value.ToString) Then
						tblLote.CurrentRow.Cells(e.ColumnIndex).ErrorText = "Se necesita un campo obligatorio "
					Else
						tblLote.CurrentCell.ErrorText = ""
					End If
			End Select
		Catch ex As Exception

		End Try
	End Sub
	Private Function VerificarDatosCompletos() As Boolean
		Try
			For Fila = 0 To tblLote.RowCount Step 1
				For Columna = 0 To 5 Step 1
					If tblLote.Rows(Fila).Cells(Columna).Value = Nothing Then
						Return False
					End If
				Next
			Next
		Catch ex As Exception
			Return False
		End Try
		Return True
	End Function
	Private Sub TblLote_KeyDown(sender As Object, e As KeyEventArgs) Handles tblLote.KeyDown
		If e.KeyData = Keys.Control + Keys.N Then
			tblLote.Rows.Add()
		End If
	End Sub
	Private Sub cmsOpcionesLote_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles cmsOpcionesLote.ItemClicked
		Try
			If e.ClickedItem.Name = "EliminarFilaToolStripMenuItem" Then
				tblLote.Rows.Remove(tblLote.CurrentRow)
			End If
		Catch ex As Exception

		End Try
	End Sub

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
	Public ReadOnly Property TablaLote() As DataGridView
		Get
			Return tblLote
		End Get
	End Property
	''' <summary>
	''' Devuelve un list of de arrays de tipo String
	''' </summary>
	''' <returns></returns>
	Public ReadOnly Property ArrayDatos() As List(Of String())
		Get
			Try
				Dim Datos As New List(Of String())
				For Fila = 0 To tblLote.RowCount Step 1
					Datos.Add({tblLote.Rows(Fila).Cells(0).Value.ToString, tblLote.Rows(Fila).Cells(1).Value.ToString, tblLote.Rows(Fila).Cells(2).Value.ToString, tblLote.Rows(Fila).Cells(3).Value.ToString, tblLote.Rows(Fila).Cells(4).Value.ToString, tblLote.Rows(Fila).Cells(5).Value.ToString})
				Next
				Return Datos
			Catch ex As Exception
				Return Nothing
			End Try
		End Get
	End Property

End Class