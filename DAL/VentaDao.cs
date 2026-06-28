using DAL.ORM;
using ENTITY;

namespace DAL
{
  public class VentaDao
  {
    private VentaOrm orm = new VentaOrm();

    public List<Venta> GetAllVentas()
    {
      try { return orm.ObtenerTodos(); }
      catch (Exception ex) { throw new Exception("Error al obtener ventas: " + ex.Message); }
    }

    public Venta GetVentaById(int id)
    {
      try { return orm.ObtenerPorId(id); }
      catch (Exception ex) { throw new Exception("Error al obtener venta: " + ex.Message); }
    }

    public void CreateVenta(Venta venta)
    {
      try { orm.Insertar(venta); }
      catch (Exception ex) { throw new Exception("Error al registrar venta: " + ex.Message); }
    }

    public void UpdateVenta(Venta venta)
    {
      try { orm.Actualizar(venta); }
      catch (Exception ex) { throw new Exception("Error al actualizar venta: " + ex.Message); }
    }
  }
}
