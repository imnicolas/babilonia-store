namespace BABILONIA
{
  partial class DashboardForm
  {
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null)) components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      menuPrincipal = new MenuStrip();
      mnuVentas = new ToolStripMenuItem();
      mnuNuevaVenta = new ToolStripMenuItem();
      mnuPostVenta = new ToolStripMenuItem();
      mnuCupones = new ToolStripMenuItem();
      mnuCompras = new ToolStripMenuItem();
      mnuPedidoCompra = new ToolStripMenuItem();
      mnuRecepcionMercaderia = new ToolStripMenuItem();
      mnuPagos = new ToolStripMenuItem();
      mnuRegistrarPago = new ToolStripMenuItem();
      mnuConciliacion = new ToolStripMenuItem();
      mnuInventario = new ToolStripMenuItem();
      mnuAjusteStock = new ToolStripMenuItem();
      mnuAdministracion = new ToolStripMenuItem();
      mnuDashboard = new ToolStripMenuItem();
      mnuUsuarios = new ToolStripMenuItem();
      mnuBackup = new ToolStripMenuItem();
      mnuSistema = new ToolStripMenuItem();
      mnuCerrarSesion = new ToolStripMenuItem();
      panelEstado = new StatusStrip();
      lblUsuario = new ToolStripStatusLabel();
      panelContenido = new Panel();
      menuPrincipal.SuspendLayout();
      panelEstado.SuspendLayout();
      SuspendLayout();

      // --- MenuStrip (dock Top) ---
      menuPrincipal.Dock = DockStyle.Top;
      menuPrincipal.Items.AddRange(new ToolStripItem[] {
        mnuVentas, mnuCompras, mnuPagos, mnuInventario, mnuAdministracion, mnuSistema
      });

      mnuVentas.Text = "&Ventas";
      mnuVentas.DropDownItems.AddRange(new ToolStripItem[] { mnuNuevaVenta, mnuPostVenta, mnuCupones });

      mnuNuevaVenta.Text = "Nueva Venta";
      mnuNuevaVenta.Tag = "Nueva Venta";
      mnuNuevaVenta.Click += Menu_NuevaVenta_Click;

      mnuPostVenta.Text = "Post Venta / Cambio";
      mnuPostVenta.Tag = "Post Venta";
      mnuPostVenta.Click += Menu_PostVenta_Click;

      mnuCupones.Text = "Emitir Cupon de Fidelizacion";
      mnuCupones.Tag = "Enviar Cupones";
      mnuCupones.Click += Menu_Cupones_Click;

      mnuCompras.Text = "&Compras";
      mnuCompras.DropDownItems.AddRange(new ToolStripItem[] { mnuPedidoCompra, mnuRecepcionMercaderia });

      mnuPedidoCompra.Text = "Pedido de Reposicion";
      mnuPedidoCompra.Tag = "Pedido de Reposicion";
      mnuPedidoCompra.Click += Menu_PedidoCompra_Click;

      mnuRecepcionMercaderia.Text = "Recepcion de Mercaderia";
      mnuRecepcionMercaderia.Tag = "Recepcion de Mercaderia";
      mnuRecepcionMercaderia.Click += Menu_RecepcionMercaderia_Click;

      mnuPagos.Text = "&Pagos";
      mnuPagos.DropDownItems.AddRange(new ToolStripItem[] { mnuRegistrarPago, mnuConciliacion });

      mnuRegistrarPago.Text = "Registrar Pago a Proveedor";
      mnuRegistrarPago.Tag = "Registrar Pago";
      mnuRegistrarPago.Click += Menu_Pagos_Click;

      mnuConciliacion.Text = "Conciliacion Diaria";
      mnuConciliacion.Tag = "Conciliacion";
      mnuConciliacion.Click += Menu_Conciliacion_Click;

      mnuInventario.Text = "&Inventario";
      mnuInventario.DropDownItems.AddRange(new ToolStripItem[] { mnuAjusteStock });

      mnuAjusteStock.Text = "Ajuste de Stock";
      mnuAjusteStock.Tag = "Ajuste de Stock";
      mnuAjusteStock.Click += Menu_AjusteStock_Click;

      mnuAdministracion.Text = "&Administracion";
      mnuAdministracion.DropDownItems.AddRange(new ToolStripItem[] { mnuDashboard, mnuUsuarios, mnuBackup });

      mnuDashboard.Text = "Dashboard";
      mnuDashboard.Tag = "Dashboard";
      mnuDashboard.Click += Menu_Dashboard_Click;

      mnuUsuarios.Text = "Gestion de Usuarios";
      mnuUsuarios.Tag = "Gestionar Usuarios";
      mnuUsuarios.Click += Menu_Usuarios_Click;

      mnuBackup.Text = "Backup y Restauracion";
      mnuBackup.Tag = "Generar Backup";
      mnuBackup.Click += Menu_Backup_Click;

      mnuSistema.Text = "&Sistema";
      mnuSistema.DropDownItems.AddRange(new ToolStripItem[] { mnuCerrarSesion });

      mnuCerrarSesion.Text = "Cerrar Sesion / Salir";
      mnuCerrarSesion.Click += Menu_CerrarSesion_Click;

      // --- StatusStrip (dock Bottom) ---
      panelEstado.Dock = DockStyle.Bottom;
      panelEstado.Items.AddRange(new ToolStripItem[] { lblUsuario });

      lblUsuario.Text = "Usuario: -";

      // --- Panel de contenido (dock Fill, queda entre menu y status) ---
      panelContenido.Dock = DockStyle.Fill;
      panelContenido.BorderStyle = BorderStyle.Fixed3D;

      // Orden de agregado importa: Fill debe agregarse antes que Top/Bottom
      // para que DockStyle.Fill ocupe el espacio restante correctamente
      Controls.Add(panelContenido);
      Controls.Add(panelEstado);
      Controls.Add(menuPrincipal);

      AutoScaleDimensions = new SizeF(6F, 13F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(1024, 600);
      Font = new Font("Microsoft Sans Serif", 8.25F);
      MainMenuStrip = menuPrincipal;
      MinimumSize = new Size(800, 500);
      StartPosition = FormStartPosition.CenterScreen;
      Text = "Babilonia Calzados";
      WindowState = FormWindowState.Maximized;

      menuPrincipal.ResumeLayout(false);
      menuPrincipal.PerformLayout();
      panelEstado.ResumeLayout(false);
      panelEstado.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
    }

    private MenuStrip menuPrincipal;
    private ToolStripMenuItem mnuVentas;
    private ToolStripMenuItem mnuNuevaVenta;
    private ToolStripMenuItem mnuPostVenta;
    private ToolStripMenuItem mnuCupones;
    private ToolStripMenuItem mnuCompras;
    private ToolStripMenuItem mnuPedidoCompra;
    private ToolStripMenuItem mnuRecepcionMercaderia;
    private ToolStripMenuItem mnuPagos;
    private ToolStripMenuItem mnuRegistrarPago;
    private ToolStripMenuItem mnuConciliacion;
    private ToolStripMenuItem mnuInventario;
    private ToolStripMenuItem mnuAjusteStock;
    private ToolStripMenuItem mnuAdministracion;
    private ToolStripMenuItem mnuDashboard;
    private ToolStripMenuItem mnuUsuarios;
    private ToolStripMenuItem mnuBackup;
    private ToolStripMenuItem mnuSistema;
    private ToolStripMenuItem mnuCerrarSesion;
    private StatusStrip panelEstado;
    private ToolStripStatusLabel lblUsuario;
    private Panel panelContenido;
  }
}
