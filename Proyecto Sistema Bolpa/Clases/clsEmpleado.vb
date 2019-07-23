Imports Proyecto_Sistema_Bolpa

Public Class clsEmpleado
    Inherits ClsPersona

    Private _salario As Double
    Private _usuario As clsUsuario

    Public Sub New()
    End Sub

    Public Sub New(cedula As String, nombre As String, primerApe As String, segundoApe As String, fechaNac As Date,
                   nacionalidad As String, telefono As String, direccion As String, email As String, fechaIngreso As Date,
                   salario As Double, usuario As clsUsuario)
        MyBase.New(cedula, nombre, primerApe, segundoApe, fechaNac, nacionalidad, telefono, direccion, email, fechaIngreso)
        Me.Salario = salario
        Me.Usuario = usuario
    End Sub

    Public Property Salario As Double
        Get
            Return _salario
        End Get
        Set(valor As Double)
            _salario = valor
        End Set
    End Property

    Public Property Usuario As clsUsuario
        Get
            Return _usuario
        End Get
        Set(value As clsUsuario)
            _usuario = value
        End Set
    End Property

    'Metodos para usuario tipo Cajero
    'AgregarCliente
    'RealizarFacturaCliente
    'RealizarReporteClientes
    'RealizarReporteTributacion

    'Metodos para Administrador de Bodega
    'RealizarFacturaProveedor
    'HacerInventarios
    'RegistrarProductos
    'RegistrarProveedor
    'RealizarReportesMovimientoInventario

    'Metodos para Administrador o Gerente
    'Todos los metedos anteriores
    'AnularFactura
    'Crear,Eliminar,ModificarUsuarios o Empleados

    ''Estos Metodos van proporcionalmente en los controladores de cada tipo de usuario.

    Public Overrides Function ToString() As String
        Return vbTab + "Empleado" + vbNewLine + MyBase.ToString() + " Salario: " + CStr(Me.Salario) + vbNewLine +
            "User: " + Me.Usuario.NomUsuario + " Pass: " + Me.Usuario.Contraseña + " Tipo: " + Me.Usuario.TipoUsuario
    End Function
End Class
