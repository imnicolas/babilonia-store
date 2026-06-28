using System.Xml.Linq;
using ENTITY;
using MAPPER;

namespace DAL.ORM
{
  public class RolOrm : OrmXmlBase<Rol>
  {
    protected override string NombreArchivo => "roles.xml";
    protected override string NombreElemento => "Rol";
    protected override Rol MapearDesdeXml(XElement nodo) => RolMapper.Map(nodo);
    protected override XElement MapearAXml(Rol entidad) => RolMapper.ToXml(entidad);
    protected override int ObtenerId(Rol entidad) => entidad.Id;
    protected override void EstablecerId(Rol entidad, int id) => entidad.Id = id;
  }
}
