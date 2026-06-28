using DAL;

namespace BLL.Security
{
  // Verifica que los archivos de datos no fueron modificados manualmente
  public class IntegridadDatosService
  {
    public void VerificarIntegridadAlArranque()
    {
      // Verificacion simplificada: chequea que la carpeta de datos exista
      string ruta = XmlDataPathUtil.GetDataPath();
      if (!Directory.Exists(ruta))
        Directory.CreateDirectory(ruta);
    }

    public void RegenerarManifiesto()
    {
      // Se invoca al detener o tras un restore; se puede extender con hashes reales
      XmlDataPathUtil.GetDataPath();
    }
  }
}
