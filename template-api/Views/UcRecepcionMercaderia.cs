using BLL;
using ENTITY;

namespace BABILONIA.Views
{
  // CU05: Recepcionar mercaderia con control de talles
  public partial class UcRecepcionMercaderia : UserControl
  {
    private Usuario usuarioActual;
    private PedidoCompraService pedidoService = new PedidoCompraService();
    private ProductoService productoService = new ProductoService();
    private PedidoCompra pedidoSeleccionado;

    public UcRecepcionMercaderia()
    {
      InitializeComponent();
    }

    public void SetUsuario(Usuario usuario)
    {
      usuarioActual = usuario;
      CargarPedidosPendientes();
    }

    private void CargarPedidosPendientes()
    {
      lstPedidos.DataSource = null;
      lstPedidos.DataSource = pedidoService.GetPedidosPendientes();
      lstPedidos.DisplayMember = "IdPedido";
    }

    private void LstPedidos_SelectedIndexChanged(object sender, EventArgs e)
    {
      pedidoSeleccionado = lstPedidos.SelectedItem as PedidoCompra;
      if (pedidoSeleccionado == null) return;

      lblInfoPedido.Text = $"Pedido N° {pedidoSeleccionado.IdPedido} - Estado: {pedidoSeleccionado.Estado} - Fecha: {pedidoSeleccionado.Fecha:dd/MM/yyyy}";

      List<Producto> productos = productoService.GetAllProductos();
      dgvRecepcion.DataSource = null;
      dgvRecepcion.DataSource = pedidoSeleccionado.Items.Select(i =>
      {
        Producto p = productos.FirstOrDefault(x => x.IdProducto == i.IdProducto);
        return new
        {
          IdProducto = i.IdProducto,
          Modelo = p?.Modelo,
          Talle = p?.Talle,
          CantidadPedida = i.CantidadPedida,
          CantidadRecibida = i.CantidadRecibida,
          StockActual = p?.Stock
        };
      }).ToList();
    }

    private void BtnRecepcionar_Click(object sender, EventArgs e)
    {
      if (pedidoSeleccionado == null)
      {
        MessageBox.Show("Seleccione un pedido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      try
      {
        // Leer las cantidades recibidas ingresadas en la grilla
        List<PedidoProducto> cantidades = new List<PedidoProducto>();
        foreach (DataGridViewRow row in dgvRecepcion.Rows)
        {
          if (row.Cells["IdProducto"].Value == null) continue;
          cantidades.Add(new PedidoProducto
          {
            IdProducto = Convert.ToInt32(row.Cells["IdProducto"].Value),
            CantidadRecibida = Convert.ToInt32(row.Cells["CantidadRecibida"].Value ?? 0)
          });
        }

        pedidoService.RecepcionarMercaderia(pedidoSeleccionado.IdPedido, cantidades, txtObservaciones.Text);
        MessageBox.Show("Mercaderia recepcionada. Stock actualizado.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        txtObservaciones.Clear();
        CargarPedidosPendientes();
        dgvRecepcion.DataSource = null;
        lblInfoPedido.Text = string.Empty;
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }
}
