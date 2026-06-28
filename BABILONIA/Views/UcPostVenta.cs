using BLL;
using ENTITY;

namespace BABILONIA.Views
{
  // CU03: Registrar cambio de calzado por talle/modelo
  public partial class UcPostVenta : UserControl
  {
    private Usuario usuarioActual;
    private VentaService ventaService = new VentaService();
    private ProductoService productoService = new ProductoService();

    public UcPostVenta()
    {
      InitializeComponent();
    }

    public void SetUsuario(Usuario usuario)
    {
      usuarioActual = usuario;
      CargarVentas();
      CargarProductos();
    }

    private void CargarVentas()
    {
      cmbVenta.DataSource = null;
      List<Venta> ventas = ventaService.GetAllVentas()
        .OrderByDescending(v => v.Fecha)
        .Take(50)
        .ToList();
      cmbVenta.DataSource = ventas;
      cmbVenta.DisplayMember = "IdVenta";
      cmbVenta.ValueMember = "IdVenta";
    }

    private void CargarProductos()
    {
      List<Producto> productos = productoService.GetAllProductos();
      cmbDevuelto.DataSource = new List<Producto>(productos);
      cmbDevuelto.ValueMember = "IdProducto";

      cmbNuevo.DataSource = new List<Producto>(productos);
      cmbNuevo.ValueMember = "IdProducto";
    }

    private void BtnRegistrarCambio_Click(object sender, EventArgs e)
    {
      if (cmbVenta.SelectedItem is not Venta venta ||
          cmbDevuelto.SelectedItem is not Producto devuelto ||
          cmbNuevo.SelectedItem is not Producto nuevo)
      {
        MessageBox.Show("Complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      try
      {
        ventaService.RegistrarCambio(venta.IdVenta, devuelto.IdProducto, nuevo.IdProducto);
        MessageBox.Show("Cambio registrado exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        CargarVentas();
        CargarProductos();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }
}
