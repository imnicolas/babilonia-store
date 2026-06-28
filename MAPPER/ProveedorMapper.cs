using System.Xml.Linq;
using ENTITY;

namespace MAPPER
{
  public class ProveedorMapper
  {
    public static Proveedor Map(XElement nodo)
    {
      return new Proveedor
      {
        IdProveedor = Convert.ToInt32(nodo.Attribute("id")?.Value),
        Nombre = nodo.Element("nombre")?.Value ?? string.Empty,
        Cuit = nodo.Element("cuit")?.Value ?? string.Empty,
        Telefono = nodo.Element("telefono")?.Value ?? string.Empty,
        Email = nodo.Element("email")?.Value ?? string.Empty,
        Deuda = Convert.ToDecimal(nodo.Element("deuda")?.Value ?? "0")
      };
    }

    public static XElement ToXml(Proveedor entidad)
    {
      return new XElement("Proveedor",
        new XAttribute("id", entidad.IdProveedor),
        new XElement("nombre", entidad.Nombre ?? string.Empty),
        new XElement("cuit", entidad.Cuit ?? string.Empty),
        new XElement("telefono", entidad.Telefono ?? string.Empty),
        new XElement("email", entidad.Email ?? string.Empty),
        new XElement("deuda", entidad.Deuda));
    }
  }
}
