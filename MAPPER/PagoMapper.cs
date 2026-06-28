using System.Xml.Linq;
using ENTITY;

namespace MAPPER
{
  public class PagoMapper
  {
    public static Pago Map(XElement nodo)
    {
      return new Pago
      {
        IdPago = Convert.ToInt32(nodo.Attribute("id")?.Value),
        Fecha = Convert.ToDateTime(nodo.Element("fecha")?.Value),
        IdProveedor = Convert.ToInt32(nodo.Element("idProveedor")?.Value ?? "0"),
        Monto = Convert.ToDecimal(nodo.Element("monto")?.Value ?? "0"),
        MedioPago = nodo.Element("medioPago")?.Value ?? string.Empty,
        Descripcion = nodo.Element("descripcion")?.Value ?? string.Empty
      };
    }

    public static XElement ToXml(Pago entidad)
    {
      return new XElement("Pago",
        new XAttribute("id", entidad.IdPago),
        new XElement("fecha", entidad.Fecha.ToString("O")),
        new XElement("idProveedor", entidad.IdProveedor),
        new XElement("monto", entidad.Monto),
        new XElement("medioPago", entidad.MedioPago ?? string.Empty),
        new XElement("descripcion", entidad.Descripcion ?? string.Empty));
    }
  }
}
