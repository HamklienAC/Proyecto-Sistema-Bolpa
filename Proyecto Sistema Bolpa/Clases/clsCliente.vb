Public Class clsCliente
    Inherits ClsPersona

    Private _facturas As List(Of clsFactura)
    Private _descuento As Integer

    Public Sub New()
    End Sub

    Public Sub New(cedula As String, nombre As String, fechaNac As Date, nacionalidad As String, telefono As String, direccion As String, email As String, fechaIngreso As Date)
        MyBase.New(cedula, nombre, fechaNac, nacionalidad, telefono, direccion, email, fechaIngreso)
        Me._facturas = New List(Of clsFactura)
    End Sub

    Public Sub New(cedula As String, nombre As String, primerApe As String, segundoApe As String, fechaNac As Date, nacionalidad As String, telefono As String, direccion As String, email As String, fechaIngreso As Date)
        MyBase.New(cedula, nombre, primerApe, segundoApe, fechaNac, nacionalidad, telefono, direccion, email, fechaIngreso)
        Me._facturas = New List(Of clsFactura)
    End Sub

    Public ReadOnly Property Facturas As List(Of clsFactura)
        Get
            Return _facturas
        End Get
    End Property

    Public Property Descuento As Integer
        Get
            Return _descuento
        End Get
        Set(value As Integer)
            _descuento = value
        End Set
    End Property

    Public Sub AgregarFactura(value As clsFactura)
        Me._facturas.Add(value)
    End Sub

    Public Function ContarFacturas(fechaInicial As Date, fechaFinal As Date) As Integer
        Dim i As Integer
        For Each factura As clsFactura In Me.Facturas
            If (factura.Fecha.CompareTo(fechaInicial) >= 0 AndAlso factura.Fecha.CompareTo(fechaFinal) <= 0) Then
                i += 1
            End If
        Next
        Return i
    End Function

    Public Sub DefinirDescuento(cantFacturas As Integer)
        If cantFacturas >= (10 * 5) Then
            Me.Descuento = 10
            Exit Sub
        Else
            For i = 1 To 9
                If (i * 5) <= cantFacturas AndAlso cantFacturas < (i * 5) + 5 Then
                    Me.Descuento = i
                    Exit Sub
                End If
            Next
        End If
        Me.Descuento = 0
    End Sub

End Class
