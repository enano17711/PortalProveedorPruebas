namespace PortalProveedor.Domain.Proveedores;

public record Dinero(decimal Cantidad, Moneda Moneda)
{
    //↓↓↓ solo por fines de prueba se sobrecargó el operador "+",
    //otra manera es darle un nombre como cualquier método ↓↓↓
    public static Dinero operator +(Dinero primero, Dinero segundo)
    {
        if (primero.Moneda != segundo.Moneda)
        {
            throw new InvalidOperationException("Las monedas deben ser iguales");
        }

        return new Dinero(primero.Cantidad + segundo.Cantidad, primero.Moneda);
    }

    public static Dinero Cero => new Dinero(0, Moneda.Ninguno);
}