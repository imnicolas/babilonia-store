using BLL.Security;
using DAL;
using ENTITY;

namespace BLL
{
  public class UsuarioService
  {
    private UsuarioDao usuarioDao = new UsuarioDao();
    private ServicioCifrado servicioCifrado = new ServicioCifrado();

    public List<Usuario> GetAllUsuarios() => usuarioDao.GetAllUsuarios();

    public Usuario GetUsuarioById(int id) => usuarioDao.GetUsuarioById(id);

    public void RegisterUsuario(Usuario usuario, string contraseñaPlana)
    {
      if (string.IsNullOrWhiteSpace(usuario.Legajo))
        throw new Exception("El legajo es obligatorio.");

      if (string.IsNullOrWhiteSpace(contraseñaPlana) || contraseñaPlana.Length < 4)
        throw new Exception("La contraseña debe tener al menos 4 caracteres.");

      if (usuarioDao.GetUsuarioByLegajo(usuario.Legajo) != null)
        throw new Exception("Ya existe un usuario con ese legajo.");

      usuario.ContraseñaHash = servicioCifrado.EncriptarContraseña(contraseñaPlana);
      usuario.FechaUltimoCambioContraseña = DateTime.Now;
      usuario.RequiereCambioContraseña = false;
      usuario.Bloqueado = false;
      usuario.IntentosFallidos = 0;
      usuarioDao.CreateUsuario(usuario);
    }

    public void UpdateUsuario(Usuario usuario, string nuevaContraseña = null)
    {
      if (!string.IsNullOrWhiteSpace(nuevaContraseña))
        usuario.ContraseñaHash = servicioCifrado.EncriptarContraseña(nuevaContraseña);

      usuarioDao.UpdateUsuario(usuario);
    }

    public void DeleteUsuario(int id) => usuarioDao.DeleteUsuario(id);
  }
}
