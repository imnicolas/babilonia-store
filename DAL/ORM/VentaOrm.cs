using System.Xml.Linq;
using ENTITY;
using MAPPER;

namespace DAL.ORM
{
  public class VentaOrm : OrmXmlBase<Venta>
  {
    protected override string NombreArchivo => "ventas.xml";
    protected override string NombreElemento => "Venta";
    protected override Venta MapearDesdeXml(XElement nodo) => VentaMapper.Map(nodo);
    protected override XElement MapearAXml(Venta entidad) => VentaMapper.ToXml(entidad);
    protected override int ObtenerId(Venta entidad) => entidad.IdVenta;
    protected override void EstablecerId(Venta entidad, int id) => entidad.IdVenta = id;
  }
}
