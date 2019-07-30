Imports Proyecto_Sistema_Bolpa

Public Class clsProveedor
    Inherits ClsPersona

    Private _sitioWeb As String
    Private _estado As Boolean
    Private _contenedor As clsBodega

    Public Sub New()
    End Sub

    Public Sub New(cedula As String, nombre As String, fechaNac As Date, nacionalidad As String, telefono As String, direccion As String, email As String, fechaIngreso As Date,
                   sitioWeb As String, estado As Boolean, contenedor As clsBodega)
        MyBase.New(cedula, nombre, fechaNac, nacionalidad, telefono, direccion, email, fechaIngreso)
        Me.SitioWeb = sitioWeb
        Me.Estado = estado
        Me.Contenedor = contenedor
    End Sub

    Public Sub New(cedula As String, nombre As String, primerApe As String, segundoApe As String, fechaNac As Date, nacionalidad As String, telefono As String, direccion As String, email As String, fechaIngreso As Date)
        MyBase.New(cedula, nombre, primerApe, segundoApe, fechaNac, nacionalidad, telefono, direccion, email, fechaIngreso)
    End Sub

    Public Property SitioWeb As String
        Get
            Return _sitioWeb
        End Get
        Set(value As String)
            If value Is Nothing Then
                MsgBox("El campo Sitio Web esta vacío")
            Else
                _sitioWeb = value
            End If

        End Set
    End Property

    Public Property Estado As Boolean
        Get
            Return _estado
        End Get
        Set(value As Boolean)
            _estado = value
        End Set
    End Property

    Public Property Contenedor As clsBodega
        Get
            Return _contenedor
        End Get
        Set(value As clsBodega)
            _contenedor = value
        End Set
    End Property
End Class
