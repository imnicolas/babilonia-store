namespace ENTITY
{
  public class Pago
  {
    public int IdPago { get; set; }
    public DateTime Fecha { get; set; }
    public int IdProveedor { get; set; }
    public decimal Monto { get; set; }
    public string MedioPago { get; set; } // Efectivo, Transferencia, Cheque
    public string Descripcion { get; set; }
  }
}
