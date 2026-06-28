using DAL;
using ENTITY;

namespace BLL
{
  public class PermisoService
  {
    private PermisoDao permisoDao = new PermisoDao();

    public List<Permiso> GetAllPermisos() => permisoDao.GetAllPermisos();

    public void CreatePermiso(Permiso permiso)
    {
      if (string.IsNullOrWhiteSpace(permiso.Nombre))
        throw new Exception("El nombre del permiso es obligatorio.");
      permisoDao.CreatePermiso(permiso);
    }

    public void DeletePermiso(int id) => permisoDao.DeletePermiso(id);
  }
}
