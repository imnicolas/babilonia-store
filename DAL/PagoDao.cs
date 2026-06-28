using DAL.ORM;
using ENTITY;

namespace DAL
{
  public class PagoDao
  {
    private PagoOrm orm = new PagoOrm();

    public List<Pago> GetAllPagos()
    {
      try { return orm.ObtenerTodos(); }
      catch (Exception ex) { throw new Exception("Error al obtener pagos: " + ex.Message); }
    }

    public void CreatePago(Pago pago)
    {
      try { orm.Insertar(pago); }
      catch (Exception ex) { throw new Exception("Error al registrar pago: " + ex.Message); }
    }

    public List<Pago> GetPagosByProveedor(int idProveedor)
    {
      try { return GetAllPagos().Where(p => p.IdProveedor == idProveedor).ToList(); }
      catch (Exception ex) { throw new Exception("Error al obtener pagos del proveedor: " + ex.Message); }
    }
  }
}
