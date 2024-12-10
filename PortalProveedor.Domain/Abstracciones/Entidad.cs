namespace PortalProveedor.Domain.Abstracciones;

public abstract class Entidad
{
    protected Entidad(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
}