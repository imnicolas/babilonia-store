using BLL;

namespace BABILONIA
{
  internal static class Program
  {
    [STAThread]
    static void Main()
    {
      ApplicationConfiguration.Initialize();

      try
      {
        SistemaArranqueService arranque = new SistemaArranqueService();
        arranque.IniciarSistema();
        Application.Run(new Form1());
        arranque.DetenerSistema();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
        Application.Exit();
      }
    }
  }
}
