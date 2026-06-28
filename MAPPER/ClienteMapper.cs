using System.Xml.Linq;
using ENTITY;

namespace MAPPER
{
  public class ClienteMapper
  {
    public static Cliente Map(XElement nodo)
    {
      return new Cliente
      {
        IdCliente = Convert.ToInt32(nodo.Attribute("id")?.Value),
        Nombre = nodo.Element("nombre")?.Value ?? string.Empty,
        Apellido = nodo.Element("apellido")?.Value ?? string.Empty,
        Dni = nodo.Element("dni")?.Value ?? string.Empty,
        Telefono = nodo.Element("telefono")?.Value ?? string.Empty,
        Email = nodo.Element("email")?.Value ?? string.Empty,
        EsJubilado = bool.Parse(nodo.Element("esJubilado")?.Value ?? "false")
      };
    }

    public static XElement ToXml(Cliente entidad)
    {
      return new XElement("Cliente",
        new XAttribute("id", entidad.IdCliente),
        new XElement("nombre", entidad.Nombre ?? string.Empty),
        new XElement("apellido", entidad.Apellido ?? string.Empty),
        new XElement("dni", entidad.Dni ?? string.Empty),
        new XElement("telefono", entidad.Telefono ?? string.Empty),
        new XElement("email", entidad.Email ?? string.Empty),
        new XElement("esJubilado", entidad.EsJubilado));
    }
  }
}
