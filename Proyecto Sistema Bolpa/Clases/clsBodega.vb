Imports Proyecto_Sistema_Bolpa

Public Class clsBodega
    Private _articulos As List(Of clsArticulo)

    Public Sub New()
        Me._articulos = New List(Of clsArticulo)
    End Sub

    Public Sub New(Articulo As clsArticulo)
        Me._articulos = New List(Of clsArticulo)
        Me.AgregarArticulo = Articulo
    End Sub

    Public ReadOnly Property Articulos As List(Of clsArticulo)
        Get
            Return _articulos
        End Get
    End Property

    Public WriteOnly Property AgregarArticulo As clsArticulo
        Set(value As clsArticulo)
            Me._articulos.Add(value)
        End Set
    End Property

    Public Function ContarArticulos(codigo As String) As Integer
        Dim i As Integer
        For Each articulo As clsArticulo In Me.Articulos
            If codigo = articulo.Codigo Then
                i += 1
            End If
        Next
        Return i
    End Function

    Public Sub CambiarEstado(id As Integer, estado As String)
        For Each articulo As clsArticulo In Me.Articulos
            If id = articulo.Id Then
                articulo.Estado = estado
            End If
        Next
    End Sub

End Class
