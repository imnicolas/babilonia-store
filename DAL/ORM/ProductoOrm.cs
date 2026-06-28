using System.Xml.Linq;
using ENTITY;
using MAPPER;

namespace DAL.ORM
{
  public class ProductoOrm : OrmXmlBase<Producto>
  {
    protected override string NombreArchivo => "productos.xml";
    protected override string NombreElemento => "Producto";
    protected override Producto MapearDesdeXml(XElement nodo) => ProductoMapper.Map(nodo);
    protected override XElement MapearAXml(Producto entidad) => ProductoMapper.ToXml(entidad);
    protected override int ObtenerId(Producto entidad) => entidad.IdProducto;
    protected override void EstablecerId(Producto entidad, int id) => entidad.IdProducto = id;
  }
}
