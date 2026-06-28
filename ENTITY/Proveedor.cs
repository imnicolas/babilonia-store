namespace ENTITY
{
  public class Proveedor
  {
    public int IdProveedor { get; set; }
    public string Nombre { get; set; }
    public string Cuit { get; set; }
    public string Telefono { get; set; }
    public string Email { get; set; }
    public decimal Deuda { get; set; }

    public override string ToString() => $"{Nombre} (CUIT: {Cuit})";
  }
}
