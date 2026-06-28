using BLL;
using ENTITY;

namespace BABILONIA.Views
{
  // CU04: Generar pedido de reposicion por stock minimo
  public partial class UcPedidoCompra : UserControl
  {
    private Usuario usuarioActual;
    private PedidoCompraService pedidoService = new PedidoCompraService();
    private ProveedorService proveedorService = new ProveedorService();
    private ProductoService productoService = new ProductoService();
    private List<PedidoProducto> itemsPedido = new List<PedidoProducto>();

    public UcPedidoCompra()
    {
      InitializeComponent();
    }

    public void SetUsuario(Usuario usuario)
    {
      usuarioActual = usuario;
      CargarProveedores();
      CargarProductosBajoStock();
      CargarPedidos();
    }

    private void CargarProveedores()
    {
      cmbProveedor.DataSource = null;
      cmbProveedor.DataSource = proveedorService.GetAllProveedores();
      cmbProveedor.DisplayMember = "Nombre";
      cmbProveedor.ValueMember = "IdProveedor";
    }

    private void CargarProductosBajoStock()
    {
      cmbProducto.DataSource = null;
      // Muestra primero los productos con stock bajo
      List<Producto> todos = productoService.GetAllProductos();
      List<Producto> ordenados = todos.OrderBy(p => p.Stock - p.StockMinimo).ToList();
      cmbProducto.DataSource = ordenados;
      cmbProducto.DisplayMember = "ToString";
      cmbProducto.ValueMember = "IdProducto";
    }

    private void CargarPedidos()
    {
      dgvPedidos.DataSource = null;
      dgvPedidos.DataSource = pedidoService.GetAllPedidos().OrderByDescending(p => p.Fecha).ToList();
    }

    private void BtnAgregarItem_Click(object sender, EventArgs e)
    {
      if (cmbProducto.SelectedItem is not Producto producto) return;

      PedidoProducto existente = itemsPedido.FirstOrDefault(i => i.IdProducto == producto.IdProducto);
      if (existente != null)
        existente.CantidadPedida += (int)nudCantidad.Value;
      else
        itemsPedido.Add(new PedidoProducto
        {
          IdProducto = producto.IdProducto,
          CantidadPedida = (int)nudCantidad.Value
        });

      ActualizarGrillaItems();
    }

    private void ActualizarGrillaItems()
    {
      List<Producto> productos = productoService.GetAllProductos();
      dgvItems.DataSource = null;
      dgvItems.DataSource = itemsPedido.Select(i =>
      {
        Producto p = productos.FirstOrDefault(x => x.IdProducto == i.IdProducto);
        return new { Modelo = p?.Modelo, Talle = p?.Talle, CantidadPedida = i.CantidadPedida, StockActual = p?.Stock };
      }).ToList();
    }

    private void BtnGenerarPedido_Click(object sender, EventArgs e)
    {
      if (cmbProveedor.SelectedItem is not Proveedor proveedor)
      {
        MessageBox.Show("Seleccione un proveedor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }
      if (itemsPedido.Count == 0)
      {
        MessageBox.Show("Agregue al menos un producto al pedido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      try
      {
        PedidoCompra pedido = pedidoService.GenerarPedidoReposicion(proveedor.IdProveedor, itemsPedido);
        MessageBox.Show($"Pedido N° {pedido.IdPedido} generado para {proveedor.Nombre}.",
          "Pedido Generado", MessageBoxButtons.OK, MessageBoxIcon.Information);

        itemsPedido = new List<PedidoProducto>();
        ActualizarGrillaItems();
        CargarPedidos();
        CargarProductosBajoStock();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }
}
