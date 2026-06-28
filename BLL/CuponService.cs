using DAL;
using ENTITY;

namespace BLL
{
  public class CuponService
  {
    private CuponDao cuponDao = new CuponDao();
    private ClienteDao clienteDao = new ClienteDao();

    // CU11: Enviar cupon de beneficios a cliente frecuente
    public CuponFidelizacion EmitirCupon(int idCliente, decimal descuento, string descripcion, int diasVigencia)
    {
      Cliente cliente = clienteDao.GetClienteById(idCliente);
      if (cliente == null) throw new Exception("Cliente no encontrado.");
      if (descuento <= 0 || descuento > 100)
        throw new Exception("El descuento debe ser entre 1 y 100.");

      CuponFidelizacion cupon = new CuponFidelizacion
      {
        IdCliente = idCliente,
        Descripcion = string.IsNullOrWhiteSpace(descripcion) ? "Beneficio fidelizacion" : descripcion,
        Descuento = descuento,
        FechaEmision = DateTime.Now,
        FechaVencimiento = DateTime.Now.AddDays(diasVigencia)
      };

      cuponDao.CreateCupon(cupon);
      return cupon;
    }

    public List<CuponFidelizacion> GetCuponesByCliente(int idCliente)
    {
      return cuponDao.GetCuponesByCliente(idCliente);
    }

    public List<CuponFidelizacion> GetAllCupones() => cuponDao.GetAllCupones();
  }
}
