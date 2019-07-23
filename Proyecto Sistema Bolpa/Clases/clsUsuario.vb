Public Class clsUsuario
    Private _nomUsuario As String
    Private _contraseña As String
    Private _tipoUsuario As String

    Public Sub New(nomUsuario As String, contraseña As String, tipoUsuario As String)
        Me.NomUsuario = nomUsuario
        Me.Contraseña = contraseña
        Me.TipoUsuario = tipoUsuario
    End Sub

    Public Property NomUsuario As String
        Get
            Return _nomUsuario
        End Get
        Set(value As String)
            _nomUsuario = value
        End Set
    End Property

    Public Property Contraseña As String
        Get
            Return _contraseña
        End Get
        Set(value As String)
            _contraseña = value
        End Set
    End Property

    ''' <summary>
    ''' Atributo que sirve para limitar el acceso que tiene un empleado
    ''' </summary>
    ''' <returns></returns>
    Public Property TipoUsuario As String
        Get
            Return _tipoUsuario
        End Get
        Set(value As String)
            _tipoUsuario = value
        End Set
    End Property
End Class
