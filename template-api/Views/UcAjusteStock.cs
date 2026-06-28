using BLL;
using ENTITY;

namespace BABILONIA.Views
{
  // CU09: Registrar ajuste de stock por calzado en mal estado (merma/rotura)
  // CU10: Emitir alerta por stock bajo (se detecta automaticamente al cargar la vista)
  public partial class UcAjusteStock : UserControl
  {
    private Usuario usuarioActual;
    private ProductoService productoService = new ProductoService();

    public UcAjusteStock()
    {
      InitializeComponent();
    }

    public void SetUsuario(Usuario usuario)
    {
      usuarioActual = usuario;
      CargarProductos();
      MostrarAlertasStockCritico();
    }

    private void CargarProductos()
    {
      cmbProducto.DataSource = null;
      cmbProducto.DataSource = productoService.GetAllProductos();
      cmbProducto.DisplayMember = "ToString";
      cmbProducto.ValueMember = "IdProducto";
    }

    // CU10: detecta productos con stock <= stockMinimo y los muestra en el panel de alertas
    private void MostrarAlertasStockCritico()
    {
      List<Producto> bajoStock = productoService.GetProductosBajoStock();
      dgvAlertas.DataSource = null;
      dgvAlertas.DataSource = bajoStock;
      lblAlertas.Text = bajoStock.Count > 0
        ? $"⚠ {bajoStock.Count} producto(s) con stock critico"
        : "✓ No hay productos con stock critico";
      lblAlertas.ForeColor = bajoStock.Count > 0 ? Color.FromArgb(220, 53, 69) : Color.FromArgb(40, 167, 69);
    }

    private void BtnAplicarAjuste_Click(object sender, EventArgs e)
    {
      if (cmbProducto.SelectedItem is not Producto producto)
      {
        MessageBox.Show("Seleccione un producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      try
      {
        int cantidad = (int)nudCantidad.Value;
        if (rbBaja.Checked) cantidad = -cantidad;

        productoService.AjustarStock(producto.IdProducto, cantidad, txtMotivo.Text);

        string accion = cantidad < 0 ? "bajado" : "agregado";
        MessageBox.Show($"Stock {accion} exitosamente. Stock actual actualizado.",
          "Ajuste Aplicado", MessageBoxButtons.OK, MessageBoxIcon.Information);

        txtMotivo.Clear();
        nudCantidad.Value = 1;
        CargarProductos();
        MostrarAlertasStockCritico();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }
}
