using DAL.ORM;
using ENTITY;

namespace DAL
{
  public class CuponDao
  {
    private CuponOrm orm = new CuponOrm();

    public List<CuponFidelizacion> GetAllCupones()
    {
      try { return orm.ObtenerTodos(); }
      catch (Exception ex) { throw new Exception("Error al obtener cupones: " + ex.Message); }
    }

    public void CreateCupon(CuponFidelizacion cupon)
    {
      try { orm.Insertar(cupon); }
      catch (Exception ex) { throw new Exception("Error al crear cupon: " + ex.Message); }
    }

    public List<CuponFidelizacion> GetCuponesByCliente(int idCliente)
    {
      try { return GetAllCupones().Where(c => c.IdCliente == idCliente).ToList(); }
      catch (Exception ex) { throw new Exception("Error al obtener cupones del cliente: " + ex.Message); }
    }
  }
}
