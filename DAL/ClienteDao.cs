using DAL.ORM;
using ENTITY;

namespace DAL
{
  public class ClienteDao
  {
    private ClienteOrm orm = new ClienteOrm();

    public List<Cliente> GetAllClientes()
    {
      try { return orm.ObtenerTodos(); }
      catch (Exception ex) { throw new Exception("Error al obtener clientes: " + ex.Message); }
    }

    public Cliente GetClienteById(int id)
    {
      try { return orm.ObtenerPorId(id); }
      catch (Exception ex) { throw new Exception("Error al obtener cliente: " + ex.Message); }
    }

    public void CreateCliente(Cliente cliente)
    {
      try { orm.Insertar(cliente); }
      catch (Exception ex) { throw new Exception("Error al crear cliente: " + ex.Message); }
    }

    public void UpdateCliente(Cliente cliente)
    {
      try { orm.Actualizar(cliente); }
      catch (Exception ex) { throw new Exception("Error al actualizar cliente: " + ex.Message); }
    }

    public void DeleteCliente(int id)
    {
      try { orm.Eliminar(id); }
      catch (Exception ex) { throw new Exception("Error al eliminar cliente: " + ex.Message); }
    }
  }
}
