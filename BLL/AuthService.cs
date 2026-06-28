using BLL.Security;
using DAL;
using ENTITY;

namespace BLL
{
  public class AuthService
  {
    private UsuarioDao usuarioDao = new UsuarioDao();
    private ServicioCifrado servicioCifrado = new ServicioCifrado();

    // CU: Autenticacion de usuario - valida legajo/contrasena y controla intentos fallidos
    public ResultadoAutenticacion Authenticate(string legajo, string contraseña)
    {
      if (string.IsNullOrWhiteSpace(legajo) || string.IsNullOrWhiteSpace(contraseña))
        throw new Exception("El legajo y la contraseña son obligatorios.");

      Usuario usuario = usuarioDao.GetUsuarioByLegajo(legajo);

      if (usuario == null)
        throw new Exception("No existe ningún usuario con ese legajo.");

      if (usuario.Bloqueado)
        throw new Exception("Usuario bloqueado por intentos fallidos. Contacte al administrador.");

      if (!servicioCifrado.VerificarContraseña(contraseña, usuario.ContraseñaHash))
      {
        usuario.IntentosFallidos++;
        if (usuario.IntentosFallidos >= 5)
          usuario.Bloqueado = true;

        usuarioDao.UpdateUsuario(usuario);
        throw new Exception("La contraseña es incorrecta.");
      }

      usuario.IntentosFallidos = 0;
      usuarioDao.UpdateUsuario(usuario);

      bool vencida = usuario.FechaUltimoCambioContraseña.HasValue &&
                     (DateTime.Now - usuario.FechaUltimoCambioContraseña.Value).TotalDays > 90;

      return new ResultadoAutenticacion
      {
        Usuario = usuario,
        RequiereCambioContraseña = usuario.RequiereCambioContraseña || vencida,
        ContraseñaVencida = vencida
      };
    }

    public void ChangePassword(int idUsuario, string contraseñaActual, string contraseñaNueva)
    {
      Usuario usuario = usuarioDao.GetUsuarioById(idUsuario);

      if (usuario == null) throw new Exception("El usuario no existe.");

      if (!servicioCifrado.VerificarContraseña(contraseñaActual, usuario.ContraseñaHash))
        throw new Exception("La contraseña actual no es válida.");

      if (string.IsNullOrWhiteSpace(contraseñaNueva) || contraseñaNueva.Length < 4)
        throw new Exception("La contraseña debe tener al menos 4 caracteres.");

      foreach (string hashAnterior in usuario.HistorialContraseñas)
      {
        if (servicioCifrado.VerificarContraseña(contraseñaNueva, hashAnterior))
          throw new Exception("No puede reutilizar una contraseña anterior.");
      }

      usuario.HistorialContraseñas.Add(usuario.ContraseñaHash);
      usuario.ContraseñaHash = servicioCifrado.EncriptarContraseña(contraseñaNueva);
      usuario.RequiereCambioContraseña = false;
      usuario.FechaUltimoCambioContraseña = DateTime.Now;
      usuario.IntentosFallidos = 0;
      usuario.Bloqueado = false;
      usuarioDao.UpdateUsuario(usuario);
    }

    public void DesbloquearUsuario(int idUsuario)
    {
      Usuario usuario = usuarioDao.GetUsuarioById(idUsuario);
      if (usuario == null) throw new Exception("El usuario no existe.");

      usuario.Bloqueado = false;
      usuario.IntentosFallidos = 0;
      usuarioDao.UpdateUsuario(usuario);
    }
  }
}
