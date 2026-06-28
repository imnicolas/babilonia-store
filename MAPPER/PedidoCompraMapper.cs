using System.Xml.Linq;
using ENTITY;

namespace MAPPER
{
  public class PedidoCompraMapper
  {
    public static PedidoCompra Map(XElement nodo)
    {
      PedidoCompra pedido = new PedidoCompra
      {
        IdPedido = Convert.ToInt32(nodo.Attribute("id")?.Value),
        Fecha = Convert.ToDateTime(nodo.Element("fecha")?.Value),
        IdProveedor = Convert.ToInt32(nodo.Element("idProveedor")?.Value ?? "0"),
        Estado = nodo.Element("estado")?.Value ?? "Pendiente",
        Observaciones = nodo.Element("observaciones")?.Value ?? string.Empty,
        Items = new List<PedidoProducto>()
      };

      XElement itemsNodo = nodo.Element("items");
      if (itemsNodo != null)
      {
        foreach (XElement item in itemsNodo.Elements("Item"))
        {
          pedido.Items.Add(new PedidoProducto
          {
            IdProducto = Convert.ToInt32(item.Element("idProducto")?.Value ?? "0"),
            CantidadPedida = Convert.ToInt32(item.Element("cantidadPedida")?.Value ?? "0"),
            CantidadRecibida = Convert.ToInt32(item.Element("cantidadRecibida")?.Value ?? "0")
          });
        }
      }

      return pedido;
    }

    public static XElement ToXml(PedidoCompra entidad)
    {
      XElement itemsNodo = new XElement("items",
        entidad.Items.Select(i => new XElement("Item",
          new XElement("idProducto", i.IdProducto),
          new XElement("cantidadPedida", i.CantidadPedida),
          new XElement("cantidadRecibida", i.CantidadRecibida))));

      return new XElement("PedidoCompra",
        new XAttribute("id", entidad.IdPedido),
        new XElement("fecha", entidad.Fecha.ToString("O")),
        new XElement("idProveedor", entidad.IdProveedor),
        new XElement("estado", entidad.Estado ?? "Pendiente"),
        new XElement("observaciones", entidad.Observaciones ?? string.Empty),
        itemsNodo);
    }
  }
}
