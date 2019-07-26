Public Class FrmArticulo
	Public Sub New()
		' Esta llamada es exigida por el diseñador.
		InitializeComponent()
		Size = New Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
		' Agregue cualquier inicialización después de la llamada a InitializeComponent().
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

End Class