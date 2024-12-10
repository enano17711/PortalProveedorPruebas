using PortalProveedor.Domain.Abstracciones;

namespace PortalProveedor.Domain.Usuarios.Eventos;

public sealed record UsuarioCreadoEventoDeDominio(Guid UsuarioId) : IEventoDeDominio;