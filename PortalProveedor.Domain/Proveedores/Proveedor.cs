using PortalProveedor.Domain.Abstracciones;

namespace PortalProveedor.Domain.Proveedores;

public sealed class Proveedor : Entidad
{
    public Proveedor(Guid id, string nombre, string apellido, string email, string telefono, Direccion direccion,
        Dinero comision, List<TipoProductos> tipoProductos) : base(id)
    {
        Nombre = nombre;
        Apellido = apellido;
        Email = email;
        Telefono = telefono;
        Direccion = direccion;
        Comision = comision;
        TipoProductos = tipoProductos;
    }

    public string Nombre { get; private set; }
    public string Apellido { get; private set; }
    public string Email { get; private set; }
    public string Telefono { get; private set; }
    public Direccion Direccion { get; private set; }
    public Dinero Comision { get; private set; }
    public DateTime FechaPago { get; private set; }
    public List<TipoProductos> TipoProductos { get; private set; } = new List<TipoProductos>();
}