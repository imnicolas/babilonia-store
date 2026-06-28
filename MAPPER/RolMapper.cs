using System.Xml.Linq;
using ENTITY;

namespace MAPPER
{
  public class RolMapper
  {
    public static Rol Map(XElement nodo)
    {
      Rol rol = new Rol
      {
        Id = Convert.ToInt32(nodo.Attribute("id")?.Value),
        Nombre = nodo.Element("nombre")?.Value ?? string.Empty
      };

      XElement hijosNodo = nodo.Element("hijos");
      if (hijosNodo != null)
      {
        foreach (XElement hijo in hijosNodo.Elements("Permiso"))
        {
          rol.Agregar(new Permiso
          {
            Id = Convert.ToInt32(hijo.Attribute("id")?.Value),
            Nombre = hijo.Element("nombre")?.Value ?? string.Empty
          });
        }
      }

      return rol;
    }

    public static XElement ToXml(Rol entidad)
    {
      XElement hijosNodo = new XElement("hijos");
      foreach (ComponenteAcceso hijo in entidad.ObtenerHijos())
      {
        hijosNodo.Add(new XElement("Permiso",
          new XAttribute("id", hijo.Id),
          new XElement("nombre", hijo.Nombre)));
      }

      return new XElement("Rol",
        new XAttribute("id", entidad.Id),
        new XElement("nombre", entidad.Nombre ?? string.Empty),
        hijosNodo);
    }
  }
}
