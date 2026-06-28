using System.Xml.Linq;
using ENTITY;

namespace MAPPER
{
  public class VentaMapper
  {
    public static Venta Map(XElement nodo)
    {
      Venta venta = new Venta
      {
        IdVenta = Convert.ToInt32(nodo.Attribute("id")?.Value),
        Fecha = Convert.ToDateTime(nodo.Element("fecha")?.Value),
        IdCliente = Convert.ToInt32(nodo.Element("idCliente")?.Value ?? "0"),
        Total = Convert.ToDecimal(nodo.Element("total")?.Value ?? "0"),
        MedioPago = nodo.Element("medioPago")?.Value ?? string.Empty,
        TieneDescuentoJubilacion = bool.Parse(nodo.Element("tieneDescuentoJubilacion")?.Value ?? "false"),
        Items = new List<VentaProducto>()
      };

      XElement itemsNodo = nodo.Element("items");
      if (itemsNodo != null)
      {
        foreach (XElement item in itemsNodo.Elements("Item"))
        {
          venta.Items.Add(new VentaProducto
          {
            IdProducto = Convert.ToInt32(item.Element("idProducto")?.Value ?? "0"),
            Cantidad = Convert.ToInt32(item.Element("cantidad")?.Value ?? "0"),
            PrecioUnitario = Convert.ToDecimal(item.Element("precioUnitario")?.Value ?? "0")
          });
        }
      }

      return venta;
    }

    public static XElement ToXml(Venta entidad)
    {
      XElement itemsNodo = new XElement("items",
        entidad.Items.Select(i => new XElement("Item",
          new XElement("idProducto", i.IdProducto),
          new XElement("cantidad", i.Cantidad),
          new XElement("precioUnitario", i.PrecioUnitario))));

      return new XElement("Venta",
        new XAttribute("id", entidad.IdVenta),
        new XElement("fecha", entidad.Fecha.ToString("O")),
        new XElement("idCliente", entidad.IdCliente),
        new XElement("total", entidad.Total),
        new XElement("medioPago", entidad.MedioPago ?? string.Empty),
        new XElement("tieneDescuentoJubilacion", entidad.TieneDescuentoJubilacion),
        itemsNodo);
    }
  }
}
