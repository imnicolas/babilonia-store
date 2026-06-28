using BLL;
using ENTITY;

namespace BABILONIA.Views
{
  // CU12: Visualizar dashboard integral con reportes de ventas, stock y pagos
  public partial class UcDashboard : UserControl
  {
    private Usuario usuarioActual;
    private VentaService ventaService = new VentaService();
    private ProductoService productoService = new ProductoService();
    private PagoService pagoService = new PagoService();
    private PedidoCompraService pedidoService = new PedidoCompraService();

    public UcDashboard()
    {
      InitializeComponent();
    }

    public void SetUsuario(Usuario usuario)
    {
      usuarioActual = usuario;
      CargarDashboard();
    }

    private void CargarDashboard()
    {
      try
      {
        List<Venta> ventas = ventaService.GetAllVentas();
        List<Producto> productos = productoService.GetAllProductos();
        List<Pago> pagos = pagoService.GetAllPagos();

        // Indicadores generales
        lblTotalVentas.Text = $"Total ventas registradas: {ventas.Count}";
        lblIngresoTotal.Text = $"Ingreso total: {ventas.Sum(v => v.Total):C2}";
        lblVentasDescuento.Text = $"Ventas con descuento jubilacion: {ventas.Count(v => v.TieneDescuentoJubilacion)}";

        // Stock critico
        List<Producto> bajoStock = productoService.GetProductosBajoStock();
        lblStockCritico.Text = $"Productos con stock critico: {bajoStock.Count}";
        lblStockCritico.ForeColor = bajoStock.Count > 0 ? Color.FromArgb(220, 53, 69) : Color.FromArgb(40, 167, 69);

        // Pagos del mes actual
        decimal pagosMes = pagos.Where(p => p.Fecha.Month == DateTime.Now.Month && p.Fecha.Year == DateTime.Now.Year)
                                .Sum(p => p.Monto);
        lblPagosMes.Text = $"Pagos este mes: {pagosMes:C2}";

        // Pedidos pendientes
        int pedidosPendientes = pedidoService.GetPedidosPendientes().Count;
        lblPedidosPendientes.Text = $"Pedidos pendientes: {pedidosPendientes}";

        // Top 5 productos mas vendidos
        List<Producto> todosProductos = productos;
        dgvTopProductos.DataSource = null;
        dgvTopProductos.DataSource = ventas
          .SelectMany(v => v.Items)
          .GroupBy(i => i.IdProducto)
          .Select(g =>
          {
            Producto p = todosProductos.FirstOrDefault(x => x.IdProducto == g.Key);
            return new { Modelo = p?.Modelo, Talle = p?.Talle, Vendidos = g.Sum(i => i.Cantidad) };
          })
          .OrderByDescending(x => x.Vendidos)
          .Take(5)
          .ToList();

        // Ultimas ventas
        dgvUltimasVentas.DataSource = null;
        dgvUltimasVentas.DataSource = ventas
          .OrderByDescending(v => v.Fecha)
          .Take(10)
          .Select(v => new { v.IdVenta, Fecha = v.Fecha.ToString("dd/MM/yyyy HH:mm"), Total = v.Total.ToString("C2"), v.MedioPago, DescuentoJubilacion = v.TieneDescuentoJubilacion ? "Si" : "No" })
          .ToList();
      }
      catch (Exception ex)
      {
        MessageBox.Show("Error al cargar el dashboard: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void BtnRefrescar_Click(object sender, EventArgs e)
    {
      CargarDashboard();
    }
  }
}
