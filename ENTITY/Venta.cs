namespace ENTITY
{
  public class Venta
  {
    public int IdVenta { get; set; }
    public DateTime Fecha { get; set; }
    public int IdCliente { get; set; }
    public decimal Total { get; set; }
    public string MedioPago { get; set; }
    public bool TieneDescuentoJubilacion { get; set; }
    public List<VentaProducto> Items { get; set; } = new List<VentaProducto>();
  }
}
