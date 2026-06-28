using System.Xml.Linq;
using ENTITY;

namespace MAPPER
{
  public class ProductoMapper
  {
    public static Producto Map(XElement nodo)
    {
      return new Producto
      {
        IdProducto = Convert.ToInt32(nodo.Attribute("id")?.Value),
        Modelo = nodo.Element("modelo")?.Value ?? string.Empty,
        Talle = Convert.ToInt32(nodo.Element("talle")?.Value ?? "0"),
        Color = nodo.Element("color")?.Value ?? string.Empty,
        Precio = Convert.ToDecimal(nodo.Element("precio")?.Value ?? "0"),
        Stock = Convert.ToInt32(nodo.Element("stock")?.Value ?? "0"),
        StockMinimo = Convert.ToInt32(nodo.Element("stockMinimo")?.Value ?? "0")
      };
    }

    public static XElement ToXml(Producto entidad)
    {
      return new XElement("Producto",
        new XAttribute("id", entidad.IdProducto),
        new XElement("modelo", entidad.Modelo ?? string.Empty),
        new XElement("talle", entidad.Talle),
        new XElement("color", entidad.Color ?? string.Empty),
        new XElement("precio", entidad.Precio),
        new XElement("stock", entidad.Stock),
        new XElement("stockMinimo", entidad.StockMinimo));
    }
  }
}
