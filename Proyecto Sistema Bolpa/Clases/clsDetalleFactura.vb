Imports Proyecto_Sistema_Bolpa

Public Class clsDetalleFactura
    Private _id As Integer
    Private _articulo As clsArticulo
    Private _cantidad As Integer
    Private _monto As Double

    Public Sub New(id As Integer, articulo As clsArticulo, cantidad As Integer)
        Me.Id = id
        Me.Articulo = articulo
        Me.Cantidad = cantidad
        Me.Monto = CalcularMonto()
    End Sub

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Articulo As clsArticulo
        Get
            Return _articulo
        End Get
        Set(value As clsArticulo)
            _articulo = value
        End Set
    End Property

    Public Property Cantidad As Integer
        Get
            Return _cantidad
        End Get
        Set(value As Integer)
            _cantidad = value
        End Set
    End Property

    Public Property Monto As Double
        Get
            Return _monto
        End Get
        Set(value As Double)
            _monto = value
        End Set
    End Property

    Private Function CalcularMonto() As Double
        Return Cantidad * (Articulo.Precio + Articulo.CalcularIVA)
    End Function

End Class
