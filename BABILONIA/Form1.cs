using BLL;
using ENTITY;

namespace BABILONIA
{
  // CU: Autenticacion de usuario - punto de entrada del sistema
  public partial class Form1 : Form
  {
    private AuthService authService = new AuthService();

    public Form1()
    {
      InitializeComponent();
    }

    private void BtnIngresar_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrWhiteSpace(txtLegajo.Text) || string.IsNullOrWhiteSpace(txtContraseña.Text))
      {
        MessageBox.Show("Complete legajo y contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      try
      {
        ResultadoAutenticacion resultado = authService.Authenticate(txtLegajo.Text.Trim(), txtContraseña.Text);

        if (resultado.RequiereCambioContraseña)
        {
          using (CambioContraseñaForm cambio = new CambioContraseñaForm(resultado.Usuario))
          {
            if (cambio.ShowDialog() != DialogResult.OK) return;
          }
        }

        DashboardForm dashboard = new DashboardForm(resultado.Usuario, this);
        Hide();
        txtContraseña.Clear();
        dashboard.Show();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
        txtContraseña.Clear();
        txtContraseña.Focus();
      }
    }

    private void ChkMostrar_CheckedChanged(object sender, EventArgs e)
    {
      txtContraseña.PasswordChar = chkMostrar.Checked ? '\0' : '*';
    }
  }
}
