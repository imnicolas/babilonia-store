using System.Xml.Linq;
using ENTITY;
using MAPPER;

namespace DAL.ORM
{
  public class PermisoOrm : OrmXmlBase<Permiso>
  {
    protected override string NombreArchivo => "permisos.xml";
    protected override string NombreElemento => "Permiso";
    protected override Permiso MapearDesdeXml(XElement nodo) => PermisoMapper.Map(nodo);
    protected override XElement MapearAXml(Permiso entidad) => PermisoMapper.ToXml(entidad);
    protected override int ObtenerId(Permiso entidad) => entidad.Id;
    protected override void EstablecerId(Permiso entidad, int id) => entidad.Id = id;
  }
}
