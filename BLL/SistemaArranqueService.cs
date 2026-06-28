using BLL.Security;

namespace BLL
{
  public class SistemaArranqueService
  {
    private IntegridadDatosService integridadService = new IntegridadDatosService();
    private InicializadorDatos inicializador = new InicializadorDatos();

    public void IniciarSistema()
    {
      inicializador.InitializeIfNeeded();
      integridadService.VerificarIntegridadAlArranque();
    }

    public void DetenerSistema()
    {
      integridadService.RegenerarManifiesto();
    }
  }
}
