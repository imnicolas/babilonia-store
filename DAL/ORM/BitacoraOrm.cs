using System.Xml.Linq;
using ENTITY;
using MAPPER;

namespace DAL.ORM
{
  public class BitacoraOrm : OrmXmlBase<EventoBitacora>
  {
    // La bitacora se guarda en la carpeta de auditoria, no en datos
    protected override string DirectorioBase => XmlDataPathUtil.GetAuditoriaPath();
    protected override string NombreArchivo => "bitacora.xml";
    protected override string NombreElemento => "EventoBitacora";
    protected override EventoBitacora MapearDesdeXml(XElement nodo) => BitacoraMapper.Map(nodo);
    protected override XElement MapearAXml(EventoBitacora entidad) => BitacoraMapper.ToXml(entidad);
    protected override int ObtenerId(EventoBitacora entidad) => entidad.Id;
    protected override void EstablecerId(EventoBitacora entidad, int id) => entidad.Id = id;
  }
}
