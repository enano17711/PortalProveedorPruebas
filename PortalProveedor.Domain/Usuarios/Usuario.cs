using PortalProveedor.Domain.Abstracciones;

namespace PortalProveedor.Domain.Usuarios;

public sealed class Usuario : Entidad
{
    private Usuario(Guid id, Nombre nombre, Apellido apellido, Correo correo) : base(id)
    {
        Nombre = nombre;
        Apellido = apellido;
        Correo = correo;
    }

    public Nombre Nombre { get; private set; }
    public Apellido Apellido { get; private set; }
    public Correo Correo { get; private set; }

    public static Usuario Crear(Nombre nombre, Apellido apellido, Correo correo)
    {
        var usuario = new Usuario(Guid.NewGuid(), nombre, apellido, correo);
        return usuario;
    }
}