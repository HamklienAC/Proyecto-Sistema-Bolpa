Public Class FrmArticulo
	Public Sub New()
		' Esta llamada es exigida por el diseñador.
		InitializeComponent()
		Size = New Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
		' Agregue cualquier inicialización después de la llamada a InitializeComponent().
	End Sub

	Private Sub CbAgregarFam_CheckedChanged(sender As Object, e As EventArgs) Handles cbAgregarFam.CheckedChanged
		If cbAgregarFam.Checked Then
			cbFamilia.Enabled = False
			txtNuevaFamilia.Enabled = True
		Else
			cbFamilia.Enabled = True
			txtNuevaFamilia.Enabled = False
		End If
	End Sub

	Private Sub CbAgregarSub_CheckedChanged(sender As Object, e As EventArgs) Handles cbAgregarSub.CheckedChanged
		If cbAgregarSub.Checked Then
			cbSubfamilia.Enabled = False
			txtNuevaSubfamilia.Enabled = True
		Else
			cbSubfamilia.Enabled = True
			txtNuevaSubfamilia.Enabled = False
		End If
	End Sub

End Class