using System.Xml.Linq;
using ENTITY;
using MAPPER;

namespace DAL.ORM
{
  public class PagoOrm : OrmXmlBase<Pago>
  {
    protected override string NombreArchivo => "pagos.xml";
    protected override string NombreElemento => "Pago";
    protected override Pago MapearDesdeXml(XElement nodo) => PagoMapper.Map(nodo);
    protected override XElement MapearAXml(Pago entidad) => PagoMapper.ToXml(entidad);
    protected override int ObtenerId(Pago entidad) => entidad.IdPago;
    protected override void EstablecerId(Pago entidad, int id) => entidad.IdPago = id;
  }
}
