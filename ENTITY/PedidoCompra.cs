namespace ENTITY
{
  public class PedidoCompra
  {
    public int IdPedido { get; set; }
    public DateTime Fecha { get; set; }
    public int IdProveedor { get; set; }
    public string Estado { get; set; } // Pendiente, Recibido, Parcial
    public string Observaciones { get; set; }
    public List<PedidoProducto> Items { get; set; } = new List<PedidoProducto>();
  }
}
