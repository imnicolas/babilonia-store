using System.Xml.Linq;
using ENTITY;
using MAPPER;

namespace DAL.ORM
{
  public class UsuarioOrm : OrmXmlBase<Usuario>
  {
    private RolOrm rolOrm = new RolOrm();
    private PermisoOrm permisoOrm = new PermisoOrm();

    protected override string NombreArchivo => "usuarios.xml";
    protected override string NombreElemento => "Usuario";

    public override List<Usuario> ObtenerTodos()
    {
      lock (CandadoPersistencia)
      {
        string ruta = Path.Combine(XmlDataPathUtil.GetDataPath(), NombreArchivo);
        if (!File.Exists(ruta)) return new List<Usuario>();

        List<Rol> roles = rolOrm.ObtenerTodos();
        List<Permiso> permisos = permisoOrm.ObtenerTodos();
        XDocument doc = XDocument.Load(ruta);
        return doc.Descendants(NombreElemento)
          .Select(n => UsuarioMapper.Map(n, roles, permisos))
          .ToList();
      }
    }

    protected override Usuario MapearDesdeXml(XElement nodo) =>
      UsuarioMapper.Map(nodo, rolOrm.ObtenerTodos(), permisoOrm.ObtenerTodos());

    protected override XElement MapearAXml(Usuario entidad) => UsuarioMapper.ToXml(entidad);
    protected override int ObtenerId(Usuario entidad) => entidad.Id;
    protected override void EstablecerId(Usuario entidad, int id) => entidad.Id = id;
  }
}
