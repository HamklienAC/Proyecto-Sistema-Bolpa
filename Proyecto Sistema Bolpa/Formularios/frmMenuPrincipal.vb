Public Class frmMenuPrincipal
    Private Sub FrmMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlMenuDesplegable.Width = 70
        'btnEmpleado_Click(sender, e) el elemento de menu que sale por defecto
    End Sub
    Private Sub BtnMenuDesplegable_Click(sender As Object, e As EventArgs) Handles btnMenuDesplegable.Click
        If pnlMenuDesplegable.Width.Equals(70) Then
            timMostrar.Enabled = True
        Else
            timOcultar.Enabled = True
        End If
    End Sub


    Private Sub AbrirFormulario(subFormulario As Form)
        If pnlFormulario.Controls.Count > 0 Then
            pnlFormulario.Controls.RemoveAt(0)
        End If
        subFormulario.TopLevel = False
        subFormulario.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        subFormulario.Dock = DockStyle.Fill
        pnlFormulario.Controls.Add(subFormulario)
        pnlFormulario.Tag = subFormulario
        subFormulario.Show()
    End Sub

    Private Sub TimMostar_Tick(sender As Object, e As EventArgs) Handles timMostrar.Tick
        If pnlMenuDesplegable.Width >= 190 Then
            timMostrar.Enabled = False
        Else
            pnlMenuDesplegable.Width = pnlMenuDesplegable.Width + 10
        End If
    End Sub

    Private Sub TimOcultar_Tick(sender As Object, e As EventArgs) Handles timOcultar.Tick
        If pnlMenuDesplegable.Width <= 70 Then
            timOcultar.Enabled = False
        Else
            pnlMenuDesplegable.Width = pnlMenuDesplegable.Width - 10
        End If
    End Sub
End Class