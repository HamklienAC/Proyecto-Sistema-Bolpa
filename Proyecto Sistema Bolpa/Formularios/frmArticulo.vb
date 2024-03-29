﻿Public Class frmArticulo
	Public Sub New()
		' Esta llamada es exigida por el diseñador.
		InitializeComponent()
		Size = New Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
		tblArticulo.Visible = False
		Tamano()
		' Agregue cualquier inicialización después de la llamada a InitializeComponent().
	End Sub

	Private Sub Tamano()
		Try
			txtNombre.Width = Int(Width * 0.33)
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try

	End Sub

	Private Sub CbAgregarFam_CheckedChanged(sender As Object, e As EventArgs) Handles cbAgregarFam.CheckedChanged
		If cbAgregarFam.Checked Then
			CambiarEstado(1)
		Else
			CambiarEstado(2)
		End If
	End Sub
	Private Sub CbAgregarSub_CheckedChanged(sender As Object, e As EventArgs) Handles cbAgregarSub.CheckedChanged
		If cbAgregarSub.Checked Then
			CambiarEstado(3)
		Else
			CambiarEstado(4)
		End If
	End Sub
	Private Sub CambiarEstado(ByVal Opc As Integer)
		Select Case (Opc)
			Case 1
				cbFamilia.Enabled = False
				txtNuevaFamilia.Enabled = True
				txtNuevaSubfamilia.Enabled = True
				cbSubfamilia.Enabled = False
				cbAgregarSub.Enabled = False
			Case 2
				cbFamilia.Enabled = True
				txtNuevaFamilia.Enabled = False
				txtNuevaSubfamilia.Enabled = False
				cbSubfamilia.Enabled = True
				cbAgregarSub.Enabled = True
			Case 3
				cbSubfamilia.Enabled = False
				txtNuevaSubfamilia.Enabled = True
				cbAgregarSub.Enabled = True
				cbAgregarFam.Enabled = False
			Case 4
				cbAgregarFam.Enabled = True
				cbSubfamilia.Enabled = True
				txtNuevaSubfamilia.Enabled = False
				cbAgregarSub.Enabled = True
		End Select
	End Sub

	Private Sub TxtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
		VerificarContenidosTXTPP(e, txtPrecio.Text)
	End Sub
	Private Sub TxtPeso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPeso.KeyPress
		VerificarContenidosTXTPP(e, txtPeso.Text)
	End Sub

	''' <summary>
	''' Metodo se encarga de verificar que solo sean numeros, puntos y controles
	''' </summary>
	''' <param name="e"></param>
	''' <param name="Valor"></param>
	Private Sub VerificarContenidosTXTPP(e As KeyPressEventArgs, ByVal Valor As String)
		e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) AndAlso Not VerificarContenidoPuntos(Valor)

	End Sub

	''' <summary>
	''' Método se encarga se verificar si la cifra tiene un punto
	''' </summary>
	''' <param name="Cadena"></param>
	''' <returns></returns>
	Private Function VerificarContenidoPuntos(ByVal Cadena As String) As Boolean
		Try
			Dim Verificacion As Double = Cadena
		Catch ex As Exception
			Return False
		End Try
		Return True
	End Function

	Private Sub TxtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
		VerificarEntradadas(e)
	End Sub
	Private Sub TxtCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigo.KeyPress
		VerificarEntradadas(e)
	End Sub
	Private Sub TxtNuevaFamilia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNuevaFamilia.KeyPress
		VerificarEntradadas(e)
	End Sub
	Private Sub TxtNuevaSubfamilia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNuevaSubfamilia.KeyPress
		VerificarEntradadas(e)
	End Sub
	Private Sub TxtDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescripcion.KeyPress
		VerificarEntradadas(e)
	End Sub
	Private Sub TxtProveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProveedor.KeyPress
		VerificarEntradadas(e)
	End Sub
	''' <summary>
	''' Método se encarga de filtar de tal manera que solo permita caracteres y separadores
	''' </summary>
	''' <param name="e"></param>
	Private Sub VerificarEntradadas(e As KeyPressEventArgs)
		If Not Char.IsPunctuation(e.KeyChar) OrElse Char.IsSeparator(e.KeyChar) Then
			e.Handled = False
		Else
			e.Handled = True
		End If
	End Sub

	Private Sub cmsOpciones_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles cmsOpciones.ItemClicked
		Try
			Select Case e.ClickedItem.Name
				Case "EliminarArticulosDeLaCompraToolStripMenuItem"
					Dim row As DataGridViewRow = tblArticulo.CurrentRow
					tblArticulo.Rows.Remove(row)
				Case "ModificarCantidad"

			End Select
		Catch ex As Exception

		End Try
	End Sub

	Public ReadOnly Property Nombre() As String
		Get
			Return txtNombre.Text
		End Get
	End Property
	Public ReadOnly Property CodigoProveedor() As String
		Get
			Return txtProveedor.Text
		End Get
	End Property
	Public ReadOnly Property CodigoArticulo() As String
		Get
			Return txtCodigo.Text
		End Get
	End Property
	Public ReadOnly Property Peso() As Double
		Get
			Return txtPeso.Text
		End Get
	End Property
	Public ReadOnly Property Precio() As Double
		Get
			Return txtPrecio.Text
		End Get
	End Property
	Public ReadOnly Property Familia() As String
		Get
			If cbAgregarFam.Enabled Then
				Return cbAgregarFam.Text
			Else
				Return cbFamilia.Text
			End If
		End Get
	End Property
	Public ReadOnly Property Subfamilia() As String
		Get
			If cbAgregarSub.Enabled Then
				Return cbAgregarSub.Text
			Else
				Return cbSubfamilia.Text
			End If
		End Get
	End Property
	Public ReadOnly Property Descripcion() As String
		Get
			Return txtDescripcion.Text
		End Get
	End Property

	Public ReadOnly Property DatosArticulo() As Array
		Get

		End Get
	End Property
End Class