'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Namespace Proyecto_Sistema_Bolpa

    Partial Public Class tblArticulo
        Public Property Id As Integer
        Public Property Codigo As String
        Public Property Nombre As String
        Public Property Familia As String
        Public Property SubFamilia As String
        Public Property Descripcion As String
        Public Property Peso As Decimal
        Public Property FechaCaducidad As Date
        Public Property Precio As Decimal
        Public Property Impuesto As Decimal
        Public Property Estado As String
    
        Public Overridable Property tblDetalleFactura As ICollection(Of tblDetalleFactura) = New HashSet(Of tblDetalleFactura)
        Public Overridable Property tblInventario As ICollection(Of tblInventario) = New HashSet(Of tblInventario)
    
    End Class

End Namespace
