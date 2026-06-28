namespace ENTITY
{
  public class CuponFidelizacion
  {
    public int IdCupon { get; set; }
    public int IdCliente { get; set; }
    public string Descripcion { get; set; }
    public decimal Descuento { get; set; }
    public DateTime FechaEmision { get; set; }
    public DateTime FechaVencimiento { get; set; }

    public override string ToString() => $"Cupon {IdCupon} - {Descuento}% hasta {FechaVencimiento:dd/MM/yyyy}";
  }
}
