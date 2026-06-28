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
      List<Proveedor> proveedores = proveedorService.GetAllProveedores();
      cmbProveedor.DataSource = null;
      cmbProveedor.DataSource = proveedores;
      cmbProveedor.DisplayMember = "Nombre";
      cmbProveedor.ValueMember = "IdProveedor";
    }

    private void CargarPagos()
    {
      List<Pago> pagos = pagoService.GetAllPagos().OrderByDescending(p => p.Fecha).ToList();
      List<Proveedor> proveedores = proveedorService.GetAllProveedores();

      dgvPagos.DataSource = pagos.Select(p => new
      {
        N = p.IdPago,
        Proveedor = proveedores.FirstOrDefault(pv => pv.IdProveedor == p.IdProveedor)?.Nombre ?? "-",
        Fecha = p.Fecha.ToString("dd/MM/yyyy HH:mm"),
        Monto = $"$ {p.Monto:N2}",
        p.MedioPago,
        p.Descripcion
      }).ToList();
    }

    private void CmbProveedor_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (cmbProveedor.SelectedItem is Proveedor proveedor)
        lblDeuda.Text = $"Deuda actual: $ {proveedor.Deuda:N2}";
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

        MessageBox.Show($"Pago de $ {pago.Monto:N2} registrado para {proveedor.Nombre}.\nRecibo N° {pago.IdPago}.",
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
