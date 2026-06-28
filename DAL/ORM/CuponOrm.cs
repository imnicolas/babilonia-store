using System.Xml.Linq;
using ENTITY;
using MAPPER;

namespace DAL.ORM
{
  public class CuponOrm : OrmXmlBase<CuponFidelizacion>
  {
    protected override string NombreArchivo => "cupones.xml";
    protected override string NombreElemento => "CuponFidelizacion";
    protected override CuponFidelizacion MapearDesdeXml(XElement nodo) => CuponMapper.Map(nodo);
    protected override XElement MapearAXml(CuponFidelizacion entidad) => CuponMapper.ToXml(entidad);
    protected override int ObtenerId(CuponFidelizacion entidad) => entidad.IdCupon;
    protected override void EstablecerId(CuponFidelizacion entidad, int id) => entidad.IdCupon = id;
  }
}
