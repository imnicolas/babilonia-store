using System.Xml.Linq;
using ENTITY;

namespace MAPPER
{
  public class CuponMapper
  {
    public static CuponFidelizacion Map(XElement nodo)
    {
      return new CuponFidelizacion
      {
        IdCupon = Convert.ToInt32(nodo.Attribute("id")?.Value),
        IdCliente = Convert.ToInt32(nodo.Element("idCliente")?.Value ?? "0"),
        Descripcion = nodo.Element("descripcion")?.Value ?? string.Empty,
        Descuento = Convert.ToDecimal(nodo.Element("descuento")?.Value ?? "0"),
        FechaEmision = Convert.ToDateTime(nodo.Element("fechaEmision")?.Value),
        FechaVencimiento = Convert.ToDateTime(nodo.Element("fechaVencimiento")?.Value)
      };
    }

    public static XElement ToXml(CuponFidelizacion entidad)
    {
      return new XElement("CuponFidelizacion",
        new XAttribute("id", entidad.IdCupon),
        new XElement("idCliente", entidad.IdCliente),
        new XElement("descripcion", entidad.Descripcion ?? string.Empty),
        new XElement("descuento", entidad.Descuento),
        new XElement("fechaEmision", entidad.FechaEmision.ToString("O")),
        new XElement("fechaVencimiento", entidad.FechaVencimiento.ToString("O")));
    }
  }
}
