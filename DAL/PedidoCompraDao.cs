using DAL.ORM;
using ENTITY;

namespace DAL
{
  public class PedidoCompraDao
  {
    private PedidoCompraOrm orm = new PedidoCompraOrm();

    public List<PedidoCompra> GetAllPedidos()
    {
      try { return orm.ObtenerTodos(); }
      catch (Exception ex) { throw new Exception("Error al obtener pedidos: " + ex.Message); }
    }

    public PedidoCompra GetPedidoById(int id)
    {
      try { return orm.ObtenerPorId(id); }
      catch (Exception ex) { throw new Exception("Error al obtener pedido: " + ex.Message); }
    }

    public void CreatePedido(PedidoCompra pedido)
    {
      try { orm.Insertar(pedido); }
      catch (Exception ex) { throw new Exception("Error al crear pedido: " + ex.Message); }
    }

    public void UpdatePedido(PedidoCompra pedido)
    {
      try { orm.Actualizar(pedido); }
      catch (Exception ex) { throw new Exception("Error al actualizar pedido: " + ex.Message); }
    }
  }
}
