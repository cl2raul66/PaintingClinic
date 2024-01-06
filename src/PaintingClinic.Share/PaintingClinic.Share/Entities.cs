namespace PaintingClinic.Share;

public class Usuario
{
    public int IDUsuario { get; set; }
    public string Nombre { get; set; }
    public string Contraseña { get; set; }
    public string Email { get; set; }
    public RolUsuario Rol { get; set; }
}

public class Contacto
{
    public int IDContacto { get; set; }
    public string Nombre { get; set; }
    public string Calle { get; set; }
    public string Ciudad { get; set; }
    public string Estado { get; set; }
    public string Teléfono { get; set; }
    public string Email { get; set; }
    public TipoContacto Tipo { get; set; }
}

public class Pedido
{
    public int IDPedido { get; set; }
    public int IDContacto { get; set; }
    public DateTime FechaPedido { get; set; }
    public DateTime FechaEntrega { get; set; }
    public EstadoPedido EstadoPedido { get; set; }
    public List<DetallePedido> DetallesPedido { get; set; }
    public decimal TotalPedido { get; set; }
}

public class DetallePedido
{
    public int IDProducto { get; set; }
    public int Cantidad { get; set; }
    public decimal PrecioUnitario { get; set; }
}

public class Producto
{
    public int IDProducto { get; set; }
    public string NombreProducto { get; set; }
    public string DescripciónProducto { get; set; }
    public decimal PrecioProducto { get; set; }
    public int CantidadInventario { get; set; }
}

public class Ingreso
{
    public int IDIngreso { get; set; }
    public int IDPedido { get; set; }
    public int IDUsuario { get; set; }
    public DateTime FechaIngreso { get; set; }
    public decimal MontoIngreso { get; set; }
    public string DescripciónIngreso { get; set; }
}

public class Gasto
{
    public int IDGasto { get; set; }
    public int IDUsuario { get; set; }
    public DateTime FechaGasto { get; set; }
    public decimal MontoGasto { get; set; }
    public string DescripciónGasto { get; set; }
}

public class Informe
{
    public int IDInforme { get; set; }
    public int IDUsuario { get; set; }
    public DateTime FechaInforme { get; set; }
    public TipoInforme TipoInforme { get; set; }
    public string DatosInforme { get; set; }
}