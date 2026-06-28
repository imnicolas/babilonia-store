using DAL.ORM;
using ENTITY;

namespace DAL
{
  public class PermisoDao
  {
    private PermisoOrm orm = new PermisoOrm();

    public List<Permiso> GetAllPermisos()
    {
      try { return orm.ObtenerTodos(); }
      catch (Exception ex) { throw new Exception("Error al obtener permisos: " + ex.Message); }
    }

    public Permiso GetPermisoById(int id)
    {
      try { return orm.ObtenerPorId(id); }
      catch (Exception ex) { throw new Exception("Error al obtener permiso: " + ex.Message); }
    }

    public void CreatePermiso(Permiso permiso)
    {
      try { orm.Insertar(permiso); }
      catch (Exception ex) { throw new Exception("Error al crear permiso: " + ex.Message); }
    }

    public void UpdatePermiso(Permiso permiso)
    {
      try { orm.Actualizar(permiso); }
      catch (Exception ex) { throw new Exception("Error al actualizar permiso: " + ex.Message); }
    }

    public void DeletePermiso(int id)
    {
      try { orm.Eliminar(id); }
      catch (Exception ex) { throw new Exception("Error al eliminar permiso: " + ex.Message); }
    }
  }
}
