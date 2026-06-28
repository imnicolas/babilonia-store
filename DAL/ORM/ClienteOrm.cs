using System.Xml.Linq;
using ENTITY;
using MAPPER;

namespace DAL.ORM
{
  public class ClienteOrm : OrmXmlBase<Cliente>
  {
    protected override string NombreArchivo => "clientes.xml";
    protected override string NombreElemento => "Cliente";
    protected override Cliente MapearDesdeXml(XElement nodo) => ClienteMapper.Map(nodo);
    protected override XElement MapearAXml(Cliente entidad) => ClienteMapper.ToXml(entidad);
    protected override int ObtenerId(Cliente entidad) => entidad.IdCliente;
    protected override void EstablecerId(Cliente entidad, int id) => entidad.IdCliente = id;
  }
}
