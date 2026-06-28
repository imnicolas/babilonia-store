using DAL.ORM;
using ENTITY;

namespace DAL
{
  public class ProveedorDao
  {
    private ProveedorOrm orm = new ProveedorOrm();

    public List<Proveedor> GetAllProveedores()
    {
      try { return orm.ObtenerTodos(); }
      catch (Exception ex) { throw new Exception("Error al obtener proveedores: " + ex.Message); }
    }

    public Proveedor GetProveedorById(int id)
    {
      try { return orm.ObtenerPorId(id); }
      catch (Exception ex) { throw new Exception("Error al obtener proveedor: " + ex.Message); }
    }

    public void CreateProveedor(Proveedor proveedor)
    {
      try { orm.Insertar(proveedor); }
      catch (Exception ex) { throw new Exception("Error al crear proveedor: " + ex.Message); }
    }

    public void UpdateProveedor(Proveedor proveedor)
    {
      try { orm.Actualizar(proveedor); }
      catch (Exception ex) { throw new Exception("Error al actualizar proveedor: " + ex.Message); }
    }

    public void DeleteProveedor(int id)
    {
      try { orm.Eliminar(id); }
      catch (Exception ex) { throw new Exception("Error al eliminar proveedor: " + ex.Message); }
    }
  }
}
