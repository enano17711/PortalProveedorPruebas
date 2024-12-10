namespace PortalProveedor.Domain.Abstracciones;

public abstract class Entidad
{
    private readonly List<IEventoDeDominio> _eventosDeDominio = new List<IEventoDeDominio>(); 
    protected Entidad(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
    
    public IReadOnlyList<IEventoDeDominio> ObtenerEventosDeDominio()
    {
        return _eventosDeDominio.ToList();
    }

    public void LimpiarEventosDeDominio()
    {
        _eventosDeDominio.Clear();
    }

    public void AgregarEventoDeDominio(IEventoDeDominio eventoDeDominio)
    {
        _eventosDeDominio.Add(eventoDeDominio);
    }
}