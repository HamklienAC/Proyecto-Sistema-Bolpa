Public Class clsArticulo
    Private _id As Integer
    Private _Codigo As String
    Private _nombre As String
    Private _descripcion As String
    Private _Familia As String
    Private _SubFamilia As String
    Private _peso As Double
    Private _fechaCaducidad As Date
    Private _precio As Double
    Private _estado As String

    Public Sub New(id As Integer, codigo As String, nombre As String, descripcion As String, familia As String, subFamilia As String, peso As Double, fechaCaducidad As Date, precio As Double, estado As String)
        Me.Id = id
        Me.Codigo = codigo
        Me.Nombre = nombre
        Me.Descripcion = descripcion
        Me.Familia = familia
        Me.SubFamilia = subFamilia
        Me.Peso = peso
        Me.FechaCaducidad = fechaCaducidad
        Me.Precio = precio
        Me.Estado = estado
    End Sub

    ''' <summary>
    ''' Atributo relacionado como llave primaria en la BD y identifica los articulos de una misma familia y subFamilia
    ''' </summary>
    ''' <returns></returns>Pes
    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Codigo As String
        Get
            Return _Codigo
        End Get
        Set(value As String)
            _Codigo = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property

    Public Property Familia As String
        Get
            Return _Familia
        End Get
        Set(value As String)
            _Familia = value
        End Set
    End Property

    Public Property SubFamilia As String
        Get
            Return _SubFamilia
        End Get
        Set(value As String)
            _SubFamilia = value
        End Set
    End Property

    Public Property Peso As Double
        Get
            Return _peso
        End Get
        Set(value As Double)
            _peso = value
        End Set
    End Property

    Public Property FechaCaducidad As Date
        Get
            Return _fechaCaducidad
        End Get
        Set(value As Date)
            _fechaCaducidad = value
        End Set
    End Property

    Public Property Precio As Double
        Get
            Return _precio
        End Get
        Set(value As Double)
            _precio = value
        End Set
    End Property

    Public Property Estado As String
        Get
            Return _estado
        End Get
        Set(value As String)
            _estado = value
        End Set
    End Property

    Public Function CalcularIVA() As Double
        Return Me.Precio * 0.13
    End Function

End Class
