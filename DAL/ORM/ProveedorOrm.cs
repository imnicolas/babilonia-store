using System.Xml.Linq;
using ENTITY;
using MAPPER;

namespace DAL.ORM
{
  public class ProveedorOrm : OrmXmlBase<Proveedor>
  {
    protected override string NombreArchivo => "proveedores.xml";
    protected override string NombreElemento => "Proveedor";
    protected override Proveedor MapearDesdeXml(XElement nodo) => ProveedorMapper.Map(nodo);
    protected override XElement MapearAXml(Proveedor entidad) => ProveedorMapper.ToXml(entidad);
    protected override int ObtenerId(Proveedor entidad) => entidad.IdProveedor;
    protected override void EstablecerId(Proveedor entidad, int id) => entidad.IdProveedor = id;
  }
}
