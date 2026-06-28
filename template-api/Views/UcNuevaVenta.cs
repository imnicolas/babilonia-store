using BLL;
using ENTITY;

namespace BABILONIA.Views
{
  // CU01: Iniciar venta por codigo/talle
  // CU02: Aplicar descuento jubilatorio (15%) cuando el cliente es jubilado
  public partial class UcNuevaVenta : UserControl
  {
    private Usuario usuarioActual;
    private VentaService ventaService = new VentaService();
    private ClienteService clienteService = new ClienteService();
    private ProductoService productoService = new ProductoService();
    private List<VentaProducto> itemsVenta = new List<VentaProducto>();

    public UcNuevaVenta()
    {
      InitializeComponent();
    }

    public void SetUsuario(Usuario usuario)
    {
      usuarioActual = usuario;
      CargarClientes();
      CargarProductos();
    }

    private void CargarClientes()
    {
      cmbCliente.DataSource = null;
      cmbCliente.DataSource = clienteService.GetAllClientes();
      cmbCliente.DisplayMember = "ToString";
      cmbCliente.ValueMember = "IdCliente";
    }

    private void CargarProductos()
    {
      cmbProducto.DataSource = null;
      cmbProducto.DataSource = productoService.GetAllProductos();
      cmbProducto.ValueMember = "IdProducto";
    }

    private void BtnAgregarItem_Click(object sender, EventArgs e)
    {
      if (cmbProducto.SelectedItem is not Producto producto) return;

      int cantidad = (int)nudCantidad.Value;
      if (cantidad < 1) return;

      VentaProducto existente = itemsVenta.FirstOrDefault(i => i.IdProducto == producto.IdProducto);
      if (existente != null)
        existente.Cantidad += cantidad;
      else
        itemsVenta.Add(new VentaProducto { IdProducto = producto.IdProducto, Cantidad = cantidad });

      ActualizarGrilla();
    }

    private void BtnQuitarItem_Click(object sender, EventArgs e)
    {
      if (dgvItems.CurrentRow?.DataBoundItem is VentaProducto item)
      {
        itemsVenta.Remove(item);
        ActualizarGrilla();
      }
    }

    private void ActualizarGrilla()
    {
      List<Producto> productos = productoService.GetAllProductos();
      dgvItems.DataSource = null;
      dgvItems.DataSource = itemsVenta.Select(i =>
      {
        Producto p = productos.FirstOrDefault(x => x.IdProducto == i.IdProducto);
        return new
        {
          Producto = p?.ToString(),
          Precio = $"$ {p?.Precio:N2}",
          Cantidad = i.Cantidad,
          Subtotal = $"$ {(p?.Precio ?? 0) * i.Cantidad:N2}",
          i.IdProducto
        };
      }).ToList();
    }

    private void BtnConfirmarVenta_Click(object sender, EventArgs e)
    {
      if (cmbCliente.SelectedItem is not Cliente cliente)
      {
        MessageBox.Show("Seleccione un cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }
      if (itemsVenta.Count == 0)
      {
        MessageBox.Show("Agregue al menos un producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      try
      {
        Venta venta = ventaService.RegistrarVenta(cliente.IdCliente, itemsVenta, cmbMedioPago.Text);

        string msg = $"Venta N° {venta.IdVenta} registrada exitosamente.\n" +
                     $"Total: $ {venta.Total:N2}\n" +
                     (venta.TieneDescuentoJubilacion ? "Se aplicó descuento del 15% por jubilación." : string.Empty);

        MessageBox.Show(msg, "Venta Confirmada", MessageBoxButtons.OK, MessageBoxIcon.Information);

        itemsVenta = new List<VentaProducto>();
        ActualizarGrilla();
        CargarProductos();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }
}
