using DAL.ORM;
using ENTITY;

namespace DAL
{
  public class BitacoraDao
  {
    private BitacoraOrm orm = new BitacoraOrm();

    public void CreateEvento(EventoBitacora evento)
    {
      try { orm.Insertar(evento); }
      catch { /* la bitacora no debe detener el flujo principal */ }
    }

    public List<EventoBitacora> GetAllEventos()
    {
      try { return orm.ObtenerTodos(); }
      catch { return new List<EventoBitacora>(); }
    }
  }
}
