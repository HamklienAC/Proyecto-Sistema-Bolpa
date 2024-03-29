﻿Public MustInherit Class ClsPersona
    Private _cedula As String
    Private _nombre As String
    Private _primerApe As String
    Private _segundoApe As String
    Private _tipoPersona As String
    Private _fechaNac As Date
    Private _nacionalidad As String
    Private _telefono As String
    Private _direccion As String
    Private _email As String
    Private _fechaIngreso As Date

    Protected Sub New()
    End Sub

    ''' <summary>
    ''' Constructor usado para Personas Juridicas o Empresas
    ''' </summary>
    ''' <param name="cedula"></param>
    ''' <param name="nombre"></param>
    ''' <param name="fechaNac"></param>
    ''' <param name="nacionalidad"></param>
    ''' <param name="telefono"></param>
    ''' <param name="direccion"></param>
    ''' <param name="email"></param>
    ''' <param name="fechaIngreso"></param>
    Protected Sub New(cedula As String, nombre As String, fechaNac As Date, nacionalidad As String, telefono As String, direccion As String, email As String, fechaIngreso As Date)
        Me.Cedula = cedula
        Me.Nombre = nombre
        Me._tipoPersona = "Juridica"
        Me.FechaNac = fechaNac
        Me.Nacionalidad = nacionalidad
        Me.Telefono = telefono
        Me.Direccion = direccion
        Me.Email = email
        Me.FechaIngreso = fechaIngreso
    End Sub

    ''' <summary>
    ''' Constructor usado para Personas Fisicas
    ''' </summary>
    ''' <param name="cedula"></param>
    ''' <param name="nombre"></param>
    ''' <param name="primerApe"></param>
    ''' <param name="segundoApe"></param>
    ''' <param name="fechaNac"></param>
    ''' <param name="nacionalidad"></param>
    ''' <param name="telefono"></param>
    ''' <param name="direccion"></param>
    ''' <param name="email"></param>
    ''' <param name="fechaIngreso"></param>
    Protected Sub New(cedula As String, nombre As String, primerApe As String, segundoApe As String, fechaNac As Date, nacionalidad As String, telefono As String, direccion As String, email As String, fechaIngreso As Date)
        Me.Cedula = cedula
        Me.Nombre = nombre
        Me.PrimerApe = primerApe
        Me.SegundoApe = segundoApe
        Me._tipoPersona = "Fisica"
        Me.FechaNac = fechaNac
        Me.Nacionalidad = nacionalidad
        Me.Telefono = telefono
        Me.Direccion = direccion
        Me.Email = email
        Me.FechaIngreso = fechaIngreso
    End Sub

    Protected Property Cedula As String
        Get
            Return _cedula
        End Get
        Set(value As String)
            If value Is Nothing Then
                MsgBox("El campo de Cedula esta vacío")
            Else
                _cedula = value
            End If
        End Set
    End Property

    Protected Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            If value Is Nothing Then
                MsgBox("El campo de Nombre esta vacío")
            Else
                _nombre = value
            End If
        End Set
    End Property

    Protected Property PrimerApe As String
        Get
            Return _primerApe
        End Get
        Set(value As String)
            If value Is Nothing Then
                MsgBox("El campo de Primer Apellido esta vacío")
            Else
                _primerApe = value
            End If

        End Set
    End Property

    Protected Property SegundoApe As String
        Get
            Return _segundoApe
        End Get
        Set(valor As String)
            If valor Is Nothing Then
                MsgBox("El campo de Segundo Apellido esta vacío")
            Else
                _segundoApe = valor
            End If

        End Set
    End Property

    ''' <summary>
    ''' Atributo para diferenciar de una persona Fisica o Juridicas(Empresas)
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property Tipo As String
        Get
            Return _tipoPersona
        End Get
    End Property

    Protected Property FechaNac As Date
        Get
            Return _fechaNac
        End Get
        Set(valor As Date)
            _fechaNac = valor
        End Set
    End Property

    Protected Property Nacionalidad As String
        Get
            Return _nacionalidad
        End Get
        Set(valor As String)
            If valor Is Nothing Then
                MsgBox("El campo de Nacionalidad esta vacío")
            Else
                _nacionalidad = valor
            End If

        End Set
    End Property

    Protected Property Telefono As String
        Get
            Return _telefono
        End Get
        Set(valor As String)
            If IsNumeric(valor) Then
                _telefono = valor
            Else
                MsgBox("En el campo de Telefono solo se permiten números.")
            End If

        End Set
    End Property

    Protected Property Direccion As String
        Get
            Return _direccion
        End Get
        Set(valor As String)
            If valor Is Nothing Then
                MsgBox("El campo de Dirección esta vacío ")
            Else
                _direccion = valor
            End If

        End Set
    End Property

    Protected Property Email As String
        Get
            Return _email
        End Get
        Set(valor As String)
            If ValidarEMail(valor) Then
                _email = valor
            Else
                MsgBox("El correo es invalido")
            End If

        End Set
    End Property

    Protected Property FechaIngreso As Date
        Get
            Return _fechaIngreso
        End Get
        Set(valor As Date)
            _fechaIngreso = valor
        End Set
    End Property

    Public Function CalcularEdad() As Integer
        If Me.FechaNac.Month > Today.Month Then
            Return CInt(DateDiff(DateInterval.Year, FechaNac, Date.Today).ToString) - 1
        Else
            Return CInt(DateDiff(DateInterval.Year, FechaNac, Date.Today).ToString)
        End If
    End Function

    Public Overrides Function ToString() As String
        Return "Cedula: " + Me.Cedula + vbNewLine + "Nombre Completo: " + Me.Nombre + " " + Me.PrimerApe + " " + Me.SegundoApe + vbNewLine +
                "Nacionalidad: " + Me.Nacionalidad + " Telefono: " + Me.Telefono + " Direccion: " + Me.Direccion + " E-Mail: " + Me.Email
    End Function

    Private Function ValidarEMail(ByVal EMail As String) As Boolean
        If Not EMail.Contains("@") Then
            Return False
        End If

        Dim SeccionesEMail As String() = EMail.Split(CChar("@"))

        If SeccionesEMail.Length <> 2 Then
            Return False
        End If

        If Not SeccionesEMail(1).Contains(".") Or Not SeccionesEMail(1).Length >= 3 Then
            Return False
        End If

        Return True

    End Function
End Class
