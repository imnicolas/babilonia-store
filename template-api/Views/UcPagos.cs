using BLL;
using ENTITY;

namespace BABILONIA.Views
{
  // CU06: Registrar pago a proveedor
  // CU07: Actualizar deuda del proveedor (ocurre automaticamente al registrar el pago)
  public partial class UcPagos : UserControl
  {
    private Usuario usuarioActual;
    private PagoService pagoService = new PagoService();
    private ProveedorService proveedorService = new ProveedorService();

    public UcPagos()
    {
      InitializeComponent();
    }

    public void SetUsuario(Usuario usuario)
    {
      usuarioActual = usuario;
      CargarProveedores();
      CargarPagos();
    }

    private void CargarProveedores()
    {
      cmbProveedor.DataSource = null;
      cmbProveedor.DataSource = proveedorService.GetAllProveedores();
      cmbProveedor.DisplayMember = "ToString";
      cmbProveedor.ValueMember = "IdProveedor";
    }

    private void CargarPagos()
    {
      dgvPagos.DataSource = null;
      dgvPagos.DataSource = pagoService.GetAllPagos().OrderByDescending(p => p.Fecha).ToList();
    }

    private void CmbProveedor_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (cmbProveedor.SelectedItem is Proveedor proveedor)
        lblDeuda.Text = $"Deuda actual: {proveedor.Deuda:C2}";
    }

    private void BtnRegistrarPago_Click(object sender, EventArgs e)
    {
      if (cmbProveedor.SelectedItem is not Proveedor proveedor)
      {
        MessageBox.Show("Seleccione un proveedor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      try
      {
        Pago pago = pagoService.RegistrarPago(
          proveedor.IdProveedor,
          nudMonto.Value,
          cmbMedioPago.Text,
          txtDescripcion.Text);

        MessageBox.Show($"Pago de {pago.Monto:C2} registrado para {proveedor.Nombre}.\nRecibo N° {pago.IdPago}.",
          "Pago Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);

        txtDescripcion.Clear();
        nudMonto.Value = 0;
        CargarProveedores();
        CargarPagos();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }
}
