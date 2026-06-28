using System.Xml.Linq;
using ENTITY;

namespace MAPPER
{
  public class PermisoMapper
  {
    public static Permiso Map(XElement nodo)
    {
      return new Permiso
      {
        Id = Convert.ToInt32(nodo.Attribute("id")?.Value),
        Nombre = nodo.Element("nombre")?.Value ?? string.Empty
      };
    }

    public static XElement ToXml(Permiso entidad)
    {
      return new XElement("Permiso",
        new XAttribute("id", entidad.Id),
        new XElement("nombre", entidad.Nombre ?? string.Empty));
    }
  }
}
