namespace ENTITY
{
  public class Producto
  {
    public int IdProducto { get; set; }
    public string Modelo { get; set; }
    public int Talle { get; set; }
    public string Color { get; set; }
    public decimal Precio { get; set; }
    public int Stock { get; set; }
    public int StockMinimo { get; set; }

    public override string ToString() => $"{Modelo} T{Talle} {Color} - Stock: {Stock}";
  }
}
