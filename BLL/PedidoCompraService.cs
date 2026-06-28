using DAL;
using ENTITY;

namespace BLL
{
  public class PedidoCompraService
  {
    private PedidoCompraDao pedidoDao = new PedidoCompraDao();
    private ProductoDao productoDao = new ProductoDao();
    private ProveedorDao proveedorDao = new ProveedorDao();

    // CU04: Generar pedido de reposicion - crea un pedido para los productos con stock critico
    public PedidoCompra GenerarPedidoReposicion(int idProveedor, List<PedidoProducto> items)
    {
      if (proveedorDao.GetProveedorById(idProveedor) == null)
        throw new Exception("Proveedor no encontrado.");
      if (items == null || items.Count == 0)
        throw new Exception("El pedido debe tener al menos un producto.");

      PedidoCompra pedido = new PedidoCompra
      {
        Fecha = DateTime.Now,
        IdProveedor = idProveedor,
        Estado = "Pendiente",
        Items = items
      };

      pedidoDao.CreatePedido(pedido);
      return pedido;
    }

    // CU05: Recepcionar mercaderia - actualiza cantidades recibidas y el stock
    public void RecepcionarMercaderia(int idPedido, List<PedidoProducto> cantidadesRecibidas, string observaciones)
    {
      PedidoCompra pedido = pedidoDao.GetPedidoById(idPedido);
      if (pedido == null) throw new Exception("Pedido no encontrado.");
      if (pedido.Estado == "Recibido") throw new Exception("El pedido ya fue recibido completamente.");

      bool hayDiferencias = false;
      foreach (PedidoProducto recibido in cantidadesRecibidas)
      {
        PedidoProducto itemPedido = pedido.Items.FirstOrDefault(i => i.IdProducto == recibido.IdProducto);
        if (itemPedido == null) continue;

        itemPedido.CantidadRecibida = recibido.CantidadRecibida;
        if (recibido.CantidadRecibida != itemPedido.CantidadPedida)
          hayDiferencias = true;

        // Actualizar stock del producto
        Producto producto = productoDao.GetProductoById(recibido.IdProducto);
        if (producto != null)
        {
          producto.Stock += recibido.CantidadRecibida;
          productoDao.UpdateProducto(producto);
        }
      }

      pedido.Estado = hayDiferencias ? "Parcial" : "Recibido";
      pedido.Observaciones = observaciones ?? string.Empty;
      pedidoDao.UpdatePedido(pedido);
    }

    public List<PedidoCompra> GetAllPedidos() => pedidoDao.GetAllPedidos();

    public List<PedidoCompra> GetPedidosPendientes()
    {
      return pedidoDao.GetAllPedidos().Where(p => p.Estado == "Pendiente" || p.Estado == "Parcial").ToList();
    }
  }
}
