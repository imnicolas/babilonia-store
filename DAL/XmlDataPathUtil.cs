namespace DAL
{
  public class XmlDataPathUtil
  {
    private static string rutaDatos;
    private static string rutaAuditoria;

    public static string GetDataPath()
    {
      if (rutaDatos == null)
        rutaDatos = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "datos");

      Directory.CreateDirectory(rutaDatos);
      return rutaDatos;
    }

    public static string GetAuditoriaPath()
    {
      if (rutaAuditoria == null)
        rutaAuditoria = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "auditoria");

      Directory.CreateDirectory(rutaAuditoria);
      return rutaAuditoria;
    }

    public static void SetDataPath(string ruta)
    {
      rutaDatos = ruta;
      Directory.CreateDirectory(rutaDatos);
    }
  }
}
