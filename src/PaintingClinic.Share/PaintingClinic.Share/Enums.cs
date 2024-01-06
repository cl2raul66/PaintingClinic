namespace PaintingClinic.Share;

public enum RolUsuario
{
    Desconocido,
    Repartidor,
    Operador,
    Supervisor,
    Administrador
}

public enum EstadoPedido
{
    Desconocido,
    Creado,
    EnProceso,
    Completado,
    Entregado
}

public enum TipoContacto
{
    Desconocido,
    Cliente,
    Proveedor
}

public enum TipoInforme
{
    Desconocido,
    // Aquí puedes agregar los tipos de informes que los supervisores y administradores pueden generar.
}