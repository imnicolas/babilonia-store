using DAL.ORM;
using ENTITY;

namespace DAL
{
  public class RolDao
  {
    private RolOrm orm = new RolOrm();

    public List<Rol> GetAllRoles()
    {
      try { return orm.ObtenerTodos(); }
      catch (Exception ex) { throw new Exception("Error al obtener roles: " + ex.Message); }
    }

    public Rol GetRolById(int id)
    {
      try { return orm.ObtenerPorId(id); }
      catch (Exception ex) { throw new Exception("Error al obtener rol: " + ex.Message); }
    }

    public void CreateRol(Rol rol)
    {
      try { orm.Insertar(rol); }
      catch (Exception ex) { throw new Exception("Error al crear rol: " + ex.Message); }
    }

    public void UpdateRol(Rol rol)
    {
      try { orm.Actualizar(rol); }
      catch (Exception ex) { throw new Exception("Error al actualizar rol: " + ex.Message); }
    }

    public void DeleteRol(int id)
    {
      try { orm.Eliminar(id); }
      catch (Exception ex) { throw new Exception("Error al eliminar rol: " + ex.Message); }
    }
  }
}
