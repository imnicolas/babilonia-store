using BLL;
using ENTITY;

namespace BABILONIA
{
  // Formulario forzado al primer login o cuando la contraseña venció
  public partial class CambioContraseñaForm : Form
  {
    private Usuario usuario;
    private AuthService authService = new AuthService();

    public CambioContraseñaForm(Usuario usuario)
    {
      InitializeComponent();
      this.usuario = usuario;
    }

    private void BtnCambiar_Click(object sender, EventArgs e)
    {
      try
      {
        if (txtNueva.Text != txtConfirmar.Text)
          throw new Exception("Las contraseñas nuevas no coinciden.");

        authService.ChangePassword(usuario.Id, txtActual.Text, txtNueva.Text);
        MessageBox.Show("Contraseña cambiada exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        DialogResult = DialogResult.OK;
        Close();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }
}
