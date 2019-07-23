Imports Proyecto_Sistema_Bolpa

Public Class clsFactura
    Private _codigo As String
    Private _numFactura As Integer
    Private _tipoFactura As String
    Private _cliente As clsCliente
    Private _cajero As clsEmpleado
    Private _fecha As String
    Private _hora As String
    Private _detalle As List(Of clsDetalleFactura)
    Private _estado As String

    Public Sub New(codigo As String, numFactura As Integer, tipoFactura As String, cliente As clsCliente, cajero As clsEmpleado, detalle As clsDetalleFactura, estado As String)
        Me._detalle = New List(Of clsDetalleFactura)
        Me.Codigo = codigo
        Me.NumFactura = numFactura
        Me.TipoFactura = tipoFactura
        Me.Cliente = cliente
        Me.Cajero = cajero
        Me._fecha = Today.ToString("d")
        Me._hora = Now.ToString("t")
        Me.AgregarDetalle = detalle
        Me.Estado = estado
    End Sub

    Public Property Codigo As String
        Get
            Return _codigo
        End Get
        Set(value As String)
            _codigo = value
        End Set
    End Property

    Public Property NumFactura As Integer
        Get
            Return _numFactura
        End Get
        Set(value As Integer)
            _numFactura = value
        End Set
    End Property

    Public Property TipoFactura As String
        Get
            Return _tipoFactura
        End Get
        Set(value As String)
            _tipoFactura = value
        End Set
    End Property

    Public Property Cliente As clsCliente
        Get
            Return _cliente
        End Get
        Set(value As clsCliente)
            _cliente = value
        End Set
    End Property

    Public Property Cajero As clsEmpleado
        Get
            Return _cajero
        End Get
        Set(value As clsEmpleado)
            _cajero = value
        End Set
    End Property

    Public ReadOnly Property Fecha As Date
        Get
            Return _fecha
        End Get
    End Property

    Public ReadOnly Property Hora As String
        Get
            Return _hora
        End Get
    End Property

    Public ReadOnly Property Detalle As List(Of clsDetalleFactura)
        Get
            Return _detalle
        End Get
    End Property

    Public WriteOnly Property AgregarDetalle As clsDetalleFactura
        Set(value As clsDetalleFactura)
            Me._detalle.Add(value)
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

    Public Function CalcularSubTotal() As Double
        Dim total As Double = 0
        For Each detalle As clsDetalleFactura In _detalle
            total += detalle.Monto
        Next
        Return total
    End Function

    Public Function CalcularIVA() As Double
        Return Me.CalcularSubTotal * 0.13
    End Function

    Public Function CalcularDescuento() As Double
        Return CalcularSubTotal() * (Cliente.Descuento * 100)
    End Function

    Public Function CalcularTotal() As Double
        Return (Me.CalcularTotal + Me.CalcularIVA) - CalcularDescuento()
    End Function

End Class
