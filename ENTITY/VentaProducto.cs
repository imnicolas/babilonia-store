namespace ENTITY
{
  // Item de la relacion Venta-Producto, embebido dentro de Venta
  public class VentaProducto
  {
    public int IdProducto { get; set; }
    public int Cantidad { get; set; }
    public decimal PrecioUnitario { get; set; }
  }
}
