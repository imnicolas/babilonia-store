using DAL.ORM;
using ENTITY;

namespace DAL
{
  public class UsuarioDao
  {
    private UsuarioOrm orm = new UsuarioOrm();

    public List<Usuario> GetAllUsuarios()
    {
      try { return orm.ObtenerTodos(); }
      catch (Exception ex) { throw new Exception("Error al obtener usuarios: " + ex.Message); }
    }

    public Usuario GetUsuarioById(int id)
    {
      try { return orm.ObtenerPorId(id); }
      catch (Exception ex) { throw new Exception("Error al obtener usuario: " + ex.Message); }
    }

    public Usuario GetUsuarioByLegajo(string legajo)
    {
      try
      {
        return GetAllUsuarios().FirstOrDefault(u =>
          u.Legajo != null && u.Legajo.Equals(legajo, StringComparison.OrdinalIgnoreCase));
      }
      catch (Exception ex) { throw new Exception("Error al obtener usuario por legajo: " + ex.Message); }
    }

    public void CreateUsuario(Usuario usuario)
    {
      try { orm.Insertar(usuario); }
      catch (Exception ex) { throw new Exception("Error al crear usuario: " + ex.Message); }
    }

    public void UpdateUsuario(Usuario usuario)
    {
      try { orm.Actualizar(usuario); }
      catch (Exception ex) { throw new Exception("Error al actualizar usuario: " + ex.Message); }
    }

    public void DeleteUsuario(int id)
    {
      try { orm.Eliminar(id); }
      catch (Exception ex) { throw new Exception("Error al eliminar usuario: " + ex.Message); }
    }
  }
}
