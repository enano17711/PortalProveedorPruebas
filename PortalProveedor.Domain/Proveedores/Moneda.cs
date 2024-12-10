namespace PortalProveedor.Domain.Proveedores;

public record Moneda
{
    internal static readonly Moneda Ninguno = new Moneda("");
    public static readonly Moneda Bs = new Moneda("BS");
    public static readonly Moneda Usd = new Moneda("USD");

    private Moneda(string codigo) => Codigo = codigo;

    public string Codigo { get; init; }

    public static Moneda DelCodigo(string codigo)
    {
        return Todos.FirstOrDefault(m => m.Codigo == codigo) ??
               throw new ApplicationException("El codigo de la moneda es invalido.");
    }

    public static readonly IReadOnlyCollection<Moneda> Todos = new[]
    {
        Bs,
        Usd
    };
}