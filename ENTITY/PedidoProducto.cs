namespace ENTITY
{
  // Item de la relacion PedidoCompra-Producto, embebido dentro de PedidoCompra
  public class PedidoProducto
  {
    public int IdProducto { get; set; }
    public int CantidadPedida { get; set; }
    public int CantidadRecibida { get; set; }
  }
}
