using System.Xml.Linq;
using ENTITY;

namespace MAPPER
{
  public class UsuarioMapper
  {
    public static Usuario Map(XElement nodo, List<Rol> todosRoles, List<Permiso> todosPermisos)
    {
      Usuario usuario = new Usuario
      {
        Id = Convert.ToInt32(nodo.Attribute("id")?.Value),
        Legajo = nodo.Element("legajo")?.Value ?? string.Empty,
        Email = nodo.Element("email")?.Value ?? string.Empty,
        ContraseñaHash = nodo.Element("contraseñaHash")?.Value ?? string.Empty,
        IdRol = Convert.ToInt32(nodo.Element("idRol")?.Value ?? "0"),
        Bloqueado = bool.Parse(nodo.Element("bloqueado")?.Value ?? "false"),
        IntentosFallidos = Convert.ToInt32(nodo.Element("intentosFallidos")?.Value ?? "0"),
        RequiereCambioContraseña = bool.Parse(nodo.Element("requiereCambioContraseña")?.Value ?? "false"),
        FechaUltimoCambioContraseña = string.IsNullOrEmpty(nodo.Element("fechaUltimoCambioContraseña")?.Value)
          ? null
          : Convert.ToDateTime(nodo.Element("fechaUltimoCambioContraseña")?.Value),
        Permisos = new List<ComponenteAcceso>(),
        HistorialContraseñas = new List<string>()
      };

      XElement historialNodo = nodo.Element("historialContraseñas");
      if (historialNodo != null)
      {
        foreach (XElement hash in historialNodo.Elements("hash"))
          usuario.HistorialContraseñas.Add(hash.Value);
      }

      XElement permisosNodo = nodo.Element("permisos");
      if (permisosNodo != null)
      {
        foreach (XElement comp in permisosNodo.Elements())
        {
          int idRef = Convert.ToInt32(comp.Attribute("id")?.Value);
          if (comp.Name.LocalName == "ReferenciaRol")
          {
            Rol rolReal = todosRoles.FirstOrDefault(r => r.Id == idRef);
            if (rolReal != null) usuario.Permisos.Add(rolReal);
          }
          else if (comp.Name.LocalName == "ReferenciaPermiso")
          {
            Permiso permisoReal = todosPermisos.FirstOrDefault(p => p.Id == idRef);
            if (permisoReal != null) usuario.Permisos.Add(permisoReal);
          }
        }
      }

      return usuario;
    }

    public static XElement ToXml(Usuario entidad)
    {
      XElement permisosNodo = new XElement("permisos");
      if (entidad.Permisos != null)
      {
        foreach (ComponenteAcceso comp in entidad.Permisos)
        {
          if (comp is Rol r)
            permisosNodo.Add(new XElement("ReferenciaRol", new XAttribute("id", r.Id)));
          else if (comp is Permiso p)
            permisosNodo.Add(new XElement("ReferenciaPermiso", new XAttribute("id", p.Id)));
        }
      }

      XElement historialNodo = new XElement("historialContraseñas",
        entidad.HistorialContraseñas.Select(h => new XElement("hash", h)));

      return new XElement("Usuario",
        new XAttribute("id", entidad.Id),
        new XElement("legajo", entidad.Legajo ?? string.Empty),
        new XElement("email", entidad.Email ?? string.Empty),
        new XElement("contraseñaHash", entidad.ContraseñaHash ?? string.Empty),
        new XElement("idRol", entidad.IdRol),
        new XElement("bloqueado", entidad.Bloqueado),
        new XElement("intentosFallidos", entidad.IntentosFallidos),
        new XElement("requiereCambioContraseña", entidad.RequiereCambioContraseña),
        new XElement("fechaUltimoCambioContraseña",
          entidad.FechaUltimoCambioContraseña.HasValue
            ? entidad.FechaUltimoCambioContraseña.Value.ToString("O")
            : string.Empty),
        historialNodo,
        permisosNodo);
    }
  }
}
