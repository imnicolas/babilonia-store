using DAL;
using ENTITY;

namespace BLL
{
  public class PagoService
  {
    private PagoDao pagoDao = new PagoDao();
    private ProveedorDao proveedorDao = new ProveedorDao();

    // CU06: Registrar pago a proveedor y CU07: Actualizar deuda del proveedor
    public Pago RegistrarPago(int idProveedor, decimal monto, string medioPago, string descripcion)
    {
      Proveedor proveedor = proveedorDao.GetProveedorById(idProveedor);
      if (proveedor == null) throw new Exception("Proveedor no encontrado.");
      if (monto <= 0) throw new Exception("El monto debe ser mayor a cero.");

      Pago pago = new Pago
      {
        Fecha = DateTime.Now,
        IdProveedor = idProveedor,
        Monto = monto,
        MedioPago = medioPago,
        Descripcion = descripcion ?? string.Empty
      };

      pagoDao.CreatePago(pago);

      // Actualizar deuda del proveedor
      proveedor.Deuda = Math.Max(0, proveedor.Deuda - monto);
      proveedorDao.UpdateProveedor(proveedor);

      return pago;
    }

    // CU08: Conciliar pagos y gastos diarios - devuelve pagos del dia con totales
    public (List<Pago> pagos, decimal totalDia) ConciliarPagosDiarios(DateTime fecha)
    {
      List<Pago> pagosDelDia = pagoDao.GetAllPagos()
        .Where(p => p.Fecha.Date == fecha.Date)
        .ToList();

      decimal total = pagosDelDia.Sum(p => p.Monto);
      return (pagosDelDia, total);
    }

    public List<Pago> GetPagosByProveedor(int idProveedor) => pagoDao.GetPagosByProveedor(idProveedor);

    public List<Pago> GetAllPagos() => pagoDao.GetAllPagos();
  }
}
