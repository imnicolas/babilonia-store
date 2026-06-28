using System.Xml.Linq;
using ENTITY;

namespace MAPPER
{
  public class BitacoraMapper
  {
    public static EventoBitacora Map(XElement nodo)
    {
      return new EventoBitacora
      {
        Id = Convert.ToInt32(nodo.Attribute("id")?.Value),
        TipoEvento = nodo.Element("tipoEvento")?.Value ?? string.Empty,
        FechaHora = Convert.ToDateTime(nodo.Element("fechaHora")?.Value),
        Legajo = nodo.Element("legajo")?.Value ?? string.Empty,
        Descripcion = nodo.Element("descripcion")?.Value ?? string.Empty,
        Resultado = nodo.Element("resultado")?.Value ?? string.Empty
      };
    }

    public static XElement ToXml(EventoBitacora entidad)
    {
      return new XElement("EventoBitacora",
        new XAttribute("id", entidad.Id),
        new XElement("tipoEvento", entidad.TipoEvento ?? string.Empty),
        new XElement("fechaHora", entidad.FechaHora.ToString("O")),
        new XElement("legajo", entidad.Legajo ?? string.Empty),
        new XElement("descripcion", entidad.Descripcion ?? string.Empty),
        new XElement("resultado", entidad.Resultado ?? string.Empty));
    }
  }
}
