Public Class frmMain
    Dim empleado1 As clsCliente = New clsCliente("116270881", "Erick", "Marin", "Serrano", New Date(1995, 10, 25),
                                               "Costarricense", "89768876", "Cañas", "e@gmail.com", New Date(2019, 7, 15))
    Dim empleado2 As clsEmpleado = New clsEmpleado("116270881", "Erick", "Marin", "Serrano", New Date(1995, 10, 25),
                                               "Costarricense", "89768876", "Cañas", "e@gmail.com", New Date(2019, 7, 15),
                                               120000, New clsUsuario("user", "123", "cajero"))
    Dim articulo1 As clsArticulo = New clsArticulo(1, "265950", "Bavaria", "Cerveza Alemana", "Bebidas Alcolicas", "Cerveza", 12, New Date(2020, 5, 17), 1300, "EXC")
    Dim articulo2 As clsArticulo = New clsArticulo(2, "234950", "Imperial", "La Cerveza de los Ticos", "Bebidas Alcolicas", "Cerveza", 12, New Date(2020, 5, 17), 1300, "EXC")
    Dim articulo3 As clsArticulo = New clsArticulo(3, "234950", "Imperial", "La Cerveza de los Ticos", "Bebidas Alcolicas", "Cerveza", 12, New Date(2020, 5, 17), 1300, "EXC")
    Dim bodega As clsBodega
    Dim detalle As clsDetalleFactura = New clsDetalleFactura(1, articulo1, 10)

    Private Sub Btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        'lblEdad.Text = empleado1.ToString
        'bodega = New clsBodega()
        'bodega.AgregarArticulo = articulo1
        'bodega.AgregarArticulo = articulo2
        'bodega.AgregarArticulo = articulo3
        'lblEdad.Text = bodega.ContarArticulos(InputBox("Ingrese el codigo del Articulo", "Articulo"))
        empleado1.AgregarFactura(New clsFactura("sed344", 1, empleado1, empleado2, detalle))
        empleado1.AgregarFactura(New clsFactura("sed344", 1, empleado1, empleado2, detalle))
        empleado1.AgregarFactura(New clsFactura("sed344", 1, empleado1, empleado2, detalle))
        empleado1.DefinirDescuento(empleado1.ContarFacturas(New Date(2010, 10, 25), Now))
        lblEdad.Text = empleado1.Descuento


    End Sub
End Class
