using BLL;
using ENTITY;

namespace BABILONIA.Views
{
  // CU08: Conciliar pagos y gastos diarios
  public partial class UcConciliacion : UserControl
  {
    private Usuario usuarioActual;
    private PagoService pagoService = new PagoService();

    public UcConciliacion()
    {
      InitializeComponent();
      dtpFecha.Value = DateTime.Today;
    }

    public void SetUsuario(Usuario usuario)
    {
      usuarioActual = usuario;
    }

    private void BtnConciliar_Click(object sender, EventArgs e)
    {
      try
      {
        var (pagos, total) = pagoService.ConciliarPagosDiarios(dtpFecha.Value);

        dgvPagos.DataSource = null;
        dgvPagos.DataSource = pagos;

        lblTotal.Text = $"Total egresos del dia {dtpFecha.Value:dd/MM/yyyy}: {total:C2}";
        lblTotal.ForeColor = total > 0 ? Color.FromArgb(220, 53, 69) : Color.DimGray;

        if (pagos.Count == 0)
          MessageBox.Show("No hay pagos registrados para la fecha seleccionada.", "Sin movimientos",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }
}
