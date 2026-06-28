using System.Text;

namespace BLL.Security
{
  // Cifrado Base64 para contrasenas y datos sensibles
  public class ServicioCifrado
  {
    public string EncriptarContraseña(string contraseñaPlana)
    {
      return Convert.ToBase64String(Encoding.UTF8.GetBytes(contraseñaPlana));
    }

    public bool VerificarContraseña(string contraseñaPlana, string hashAlmacenado)
    {
      try { return EncriptarContraseña(contraseñaPlana) == hashAlmacenado; }
      catch { return false; }
    }

    public string Encriptar(string textoPlano)
    {
      if (string.IsNullOrEmpty(textoPlano)) throw new ArgumentNullException(nameof(textoPlano));
      return Convert.ToBase64String(Encoding.UTF8.GetBytes(textoPlano));
    }

    public string Desencriptar(string textoCifrado)
    {
      if (string.IsNullOrEmpty(textoCifrado)) throw new ArgumentNullException(nameof(textoCifrado));
      return Encoding.UTF8.GetString(Convert.FromBase64String(textoCifrado));
    }
  }
}
