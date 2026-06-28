using System.IO.Compression;
using BLL.Security;
using DAL;

namespace BLL
{
  public class BackupService
  {
    private BitacoraService bitacoraService = new BitacoraService();
    private IntegridadDatosService integridadService = new IntegridadDatosService();

    // CU: Generacion de backup - comprime la carpeta datos/ en un .zip y registra el evento
    public void GenerateBackup(string rutaDestinoZip, string legajoLogueado)
    {
      try
      {
        string rutaDatos = XmlDataPathUtil.GetDataPath();

        if (!Directory.Exists(rutaDatos))
          throw new DirectoryNotFoundException("No se encontro el directorio de datos para respaldar.");

        if (File.Exists(rutaDestinoZip))
          File.Delete(rutaDestinoZip);

        ZipFile.CreateFromDirectory(rutaDatos, rutaDestinoZip, CompressionLevel.Optimal, false);

        bitacoraService.RegisterEvent("Generacion de Backup", legajoLogueado,
          $"Backup generado en: {rutaDestinoZip}", "Exito");
      }
      catch (Exception ex)
      {
        bitacoraService.RegisterEvent("Error Generacion de Backup", legajoLogueado,
          $"Fallo al generar backup: {ex.Message}", "Error");
        throw;
      }
    }

    // CU: Restauracion de backup - extrae el .zip sobre la carpeta datos/ y registra el evento
    public void RestoreBackup(string rutaOrigenZip, string legajoLogueado)
    {
      try
      {
        string rutaDatos = XmlDataPathUtil.GetDataPath();

        if (!File.Exists(rutaOrigenZip))
          throw new FileNotFoundException("No se encontro el archivo de backup.");

        if (!Directory.Exists(rutaDatos))
          Directory.CreateDirectory(rutaDatos);
        else
        {
          foreach (string file in Directory.GetFiles(rutaDatos))
            File.Delete(file);
        }

        ZipFile.ExtractToDirectory(rutaOrigenZip, rutaDatos, true);
        integridadService.RegenerarManifiesto();

        bitacoraService.RegisterEvent("Restauracion de Backup", legajoLogueado,
          $"Backup restaurado desde: {rutaOrigenZip}", "Exito");
      }
      catch (Exception ex)
      {
        bitacoraService.RegisterEvent("Error Restauracion de Backup", legajoLogueado,
          $"Fallo al restaurar backup: {ex.Message}", "Error");
        throw;
      }
    }
  }
}
