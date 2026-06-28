using System.Xml.Linq;
using ENTITY;
using MAPPER;

namespace DAL.ORM
{
  public class PedidoCompraOrm : OrmXmlBase<PedidoCompra>
  {
    protected override string NombreArchivo => "pedidos.xml";
    protected override string NombreElemento => "PedidoCompra";
    protected override PedidoCompra MapearDesdeXml(XElement nodo) => PedidoCompraMapper.Map(nodo);
    protected override XElement MapearAXml(PedidoCompra entidad) => PedidoCompraMapper.ToXml(entidad);
    protected override int ObtenerId(PedidoCompra entidad) => entidad.IdPedido;
    protected override void EstablecerId(PedidoCompra entidad, int id) => entidad.IdPedido = id;
  }
}
