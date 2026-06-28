using DAL;
using ENTITY;

namespace BLL
{
  public class ProveedorService
  {
    private ProveedorDao proveedorDao = new ProveedorDao();

    public List<Proveedor> GetAllProveedores() => proveedorDao.GetAllProveedores();

    public Proveedor GetProveedorById(int id) => proveedorDao.GetProveedorById(id);

    public void CreateProveedor(Proveedor proveedor)
    {
      if (string.IsNullOrWhiteSpace(proveedor.Nombre))
        throw new Exception("El nombre del proveedor es obligatorio.");
      if (string.IsNullOrWhiteSpace(proveedor.Cuit))
        throw new Exception("El CUIT es obligatorio.");
      proveedorDao.CreateProveedor(proveedor);
    }

    public void UpdateProveedor(Proveedor proveedor) => proveedorDao.UpdateProveedor(proveedor);

    public void DeleteProveedor(int id) => proveedorDao.DeleteProveedor(id);
  }
}
