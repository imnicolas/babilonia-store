using BLL;
using ENTITY;

namespace BABILONIA.Views
{
  // CU11: Enviar cupon de beneficios a cliente frecuente
  public partial class UcCupones : UserControl
  {
    private Usuario usuarioActual;
    private CuponService cuponService = new CuponService();
    private ClienteService clienteService = new ClienteService();

    public UcCupones()
    {
      InitializeComponent();
    }

    public void SetUsuario(Usuario usuario)
    {
      usuarioActual = usuario;
      CargarClientes();
      CargarCupones();
    }

    private void CargarClientes()
    {
      cmbCliente.DataSource = null;
      cmbCliente.DataSource = clienteService.GetAllClientes();
      cmbCliente.DisplayMember = "ToString";
      cmbCliente.ValueMember = "IdCliente";
    }

    private void CargarCupones()
    {
      dgvCupones.DataSource = null;
      dgvCupones.DataSource = cuponService.GetAllCupones();
    }

    private void BtnEmitirCupon_Click(object sender, EventArgs e)
    {
      if (cmbCliente.SelectedItem is not Cliente cliente)
      {
        MessageBox.Show("Seleccione un cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      try
      {
        CuponFidelizacion cupon = cuponService.EmitirCupon(
          cliente.IdCliente,
          (decimal)nudDescuento.Value,
          txtDescripcion.Text,
          (int)nudDias.Value);

        MessageBox.Show($"Cupon emitido para {cliente}.\nDescuento: {cupon.Descuento}%\nVence: {cupon.FechaVencimiento:dd/MM/yyyy}",
          "Cupon Emitido", MessageBoxButtons.OK, MessageBoxIcon.Information);

        txtDescripcion.Clear();
        CargarCupones();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }
}
