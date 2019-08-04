Public Class frmInicioSesion
    Private Sub FrmInicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub TxtUsuario_Enter(sender As Object, e As EventArgs) Handles txtUsuario.Enter
        If (Me.txtUsuario.Text.Equals("Usuario")) Then
            Me.txtUsuario.Text = ""
        End If
    End Sub

    Private Sub TxtContrasena_Enter(sender As Object, e As EventArgs) Handles txtContrasena.Enter
        If (Me.txtContrasena.Text.Equals("Contraseña")) Then
            Me.txtContrasena.Text = ""
            Me.txtContrasena.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub TxtUsuario_Leave(sender As Object, e As EventArgs) Handles txtUsuario.Leave
        If (Me.txtUsuario.Text.Equals("")) Then
            Me.txtUsuario.Text = "Usuario"
        End If
    End Sub

    Private Sub TxtContrasena_Leave(sender As Object, e As EventArgs) Handles txtContrasena.Leave
        If (Me.txtContrasena.Text.Equals("")) Then
            Me.txtContrasena.Text = "Contraseña"
            Me.txtContrasena.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim menu As New frmMenuPrincipal
        Me.Visible = False
        menu.Show()
    End Sub


End Class