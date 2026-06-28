using DAL;
using ENTITY;

namespace BLL
{
  public class BitacoraService
  {
    private BitacoraDao bitacoraDao = new BitacoraDao();

    public void RegisterEvent(string tipoEvento, string legajo, string descripcion, string resultado)
    {
      bitacoraDao.CreateEvento(new EventoBitacora
      {
        TipoEvento = tipoEvento,
        FechaHora = DateTime.Now,
        Legajo = legajo,
        Descripcion = descripcion,
        Resultado = resultado
      });
    }

    public List<EventoBitacora> GetAllEvents()
    {
      return bitacoraDao.GetAllEventos();
    }
  }
}
