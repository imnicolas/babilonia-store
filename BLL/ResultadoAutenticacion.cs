using ENTITY;

namespace BLL
{
  public class ResultadoAutenticacion
  {
    public Usuario Usuario { get; set; }
    public bool RequiereCambioContraseña { get; set; }
    public bool ContraseñaVencida { get; set; }
  }
}
