using DAL;
using ENTITY;

namespace BLL
{
  public class RolService
  {
    private RolDao rolDao = new RolDao();

    public List<Rol> GetAllRoles() => rolDao.GetAllRoles();

    public Rol GetById(int id) => rolDao.GetRolById(id);

    public void CreateRol(Rol rol)
    {
      if (string.IsNullOrWhiteSpace(rol.NombreRol))
        throw new Exception("El nombre del rol es obligatorio.");
      rolDao.CreateRol(rol);
    }

    public void UpdateRol(Rol rol)
    {
      if (string.IsNullOrWhiteSpace(rol.NombreRol))
        throw new Exception("El nombre del rol es obligatorio.");
      rolDao.UpdateRol(rol);
    }

    public void DeleteRol(int id) => rolDao.DeleteRol(id);
  }
}
