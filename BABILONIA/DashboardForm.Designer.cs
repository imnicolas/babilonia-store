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
      panelTop = new Panel();
      lblTitulo = new Label();
      lblUsuario = new Label();
      btnCerrarSesion = new Button();
      panelNav = new Panel();
      flowNav = new FlowLayoutPanel();
      lblGrupoVentas = new Label();
      btnNuevaVenta = new Button();
      btnPostVenta = new Button();
      btnCupones = new Button();
      lblGrupoCompras = new Label();
      btnPedidoCompra = new Button();
      btnRecepcionMercaderia = new Button();
      lblGrupoPagos = new Label();
      btnPagos = new Button();
      btnConciliacion = new Button();
      lblGrupoInventario = new Label();
      btnAjusteStock = new Button();
      lblGrupoAdmin = new Label();
      btnDashboard = new Button();
      btnUsuarios = new Button();
      btnBackup = new Button();
      panelContenido = new Panel();
      panelTop.SuspendLayout();
      panelNav.SuspendLayout();
      flowNav.SuspendLayout();
      SuspendLayout();

      // --- Panel superior (header) ---
      panelTop.Dock = DockStyle.Top;
      panelTop.Height = 45;
      panelTop.BorderStyle = BorderStyle.FixedSingle;
      panelTop.Controls.Add(btnCerrarSesion);
      panelTop.Controls.Add(lblUsuario);
      panelTop.Controls.Add(lblTitulo);

      lblTitulo.AutoSize = true;
      lblTitulo.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
      lblTitulo.Location = new Point(10, 12);
      lblTitulo.Text = "Babilonia Calzados";

      lblUsuario.AutoSize = true;
      lblUsuario.Font = new Font("Microsoft Sans Serif", 8.25F);
      lblUsuario.Location = new Point(230, 14);
      lblUsuario.Text = "Usuario: -";

      btnCerrarSesion.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
      btnCerrarSesion.Location = new Point(920, 10);
      btnCerrarSesion.Size = new Size(110, 26);
      btnCerrarSesion.Text = "Cerrar Sesion";
      btnCerrarSesion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      btnCerrarSesion.Click += BtnCerrarSesion_Click;

      // --- Panel de navegacion lateral (izquierda) ---
      panelNav.Dock = DockStyle.Left;
      panelNav.Width = 185;
      panelNav.BorderStyle = BorderStyle.FixedSingle;
      panelNav.Controls.Add(flowNav);

      flowNav.Dock = DockStyle.Fill;
      flowNav.FlowDirection = FlowDirection.TopDown;
      flowNav.WrapContents = false;
      flowNav.AutoScroll = true;
      flowNav.Padding = new Padding(4, 6, 0, 4);

      // --- Botones de navegacion (todos comienzan ocultos) ---
      int btnW = 168;
      int btnH = 32;

      lblGrupoVentas.AutoSize = false;
      lblGrupoVentas.Font = new Font("Microsoft Sans Serif", 7.5F, FontStyle.Bold);
      lblGrupoVentas.ForeColor = SystemColors.GrayText;
      lblGrupoVentas.Size = new Size(btnW, 20);
      lblGrupoVentas.Text = "VENTAS";

      btnNuevaVenta.Size = new Size(btnW, btnH);
      btnNuevaVenta.Text = "Nueva Venta";
      btnNuevaVenta.Font = new Font("Microsoft Sans Serif", 8.25F);
      btnNuevaVenta.Tag = "Nueva Venta";
      btnNuevaVenta.Visible = false;
      btnNuevaVenta.Click += Menu_NuevaVenta_Click;

      btnPostVenta.Size = new Size(btnW, btnH);
      btnPostVenta.Text = "Post Venta / Cambio";
      btnPostVenta.Font = new Font("Microsoft Sans Serif", 8.25F);
      btnPostVenta.Tag = "Post Venta";
      btnPostVenta.Visible = false;
      btnPostVenta.Click += Menu_PostVenta_Click;

      btnCupones.Size = new Size(btnW, btnH);
      btnCupones.Text = "Emitir Cupon";
      btnCupones.Font = new Font("Microsoft Sans Serif", 8.25F);
      btnCupones.Tag = "Enviar Cupones";
      btnCupones.Visible = false;
      btnCupones.Click += Menu_Cupones_Click;

      lblGrupoCompras.AutoSize = false;
      lblGrupoCompras.Font = new Font("Microsoft Sans Serif", 7.5F, FontStyle.Bold);
      lblGrupoCompras.ForeColor = SystemColors.GrayText;
      lblGrupoCompras.Size = new Size(btnW, 20);
      lblGrupoCompras.Text = "COMPRAS";
      lblGrupoCompras.Visible = false;

      btnPedidoCompra.Size = new Size(btnW, btnH);
      btnPedidoCompra.Text = "Pedido de Reposicion";
      btnPedidoCompra.Font = new Font("Microsoft Sans Serif", 8.25F);
      btnPedidoCompra.Tag = "Pedido de Reposicion";
      btnPedidoCompra.Visible = false;
      btnPedidoCompra.Click += Menu_PedidoCompra_Click;

      btnRecepcionMercaderia.Size = new Size(btnW, btnH);
      btnRecepcionMercaderia.Text = "Recepcion Mercaderia";
      btnRecepcionMercaderia.Font = new Font("Microsoft Sans Serif", 8.25F);
      btnRecepcionMercaderia.Tag = "Recepcion de Mercaderia";
      btnRecepcionMercaderia.Visible = false;
      btnRecepcionMercaderia.Click += Menu_RecepcionMercaderia_Click;

      lblGrupoPagos.AutoSize = false;
      lblGrupoPagos.Font = new Font("Microsoft Sans Serif", 7.5F, FontStyle.Bold);
      lblGrupoPagos.ForeColor = SystemColors.GrayText;
      lblGrupoPagos.Size = new Size(btnW, 20);
      lblGrupoPagos.Text = "PAGOS";
      lblGrupoPagos.Visible = false;

      btnPagos.Size = new Size(btnW, btnH);
      btnPagos.Text = "Registrar Pago";
      btnPagos.Font = new Font("Microsoft Sans Serif", 8.25F);
      btnPagos.Tag = "Registrar Pago";
      btnPagos.Visible = false;
      btnPagos.Click += Menu_Pagos_Click;

      btnConciliacion.Size = new Size(btnW, btnH);
      btnConciliacion.Text = "Conciliacion Diaria";
      btnConciliacion.Font = new Font("Microsoft Sans Serif", 8.25F);
      btnConciliacion.Tag = "Conciliacion";
      btnConciliacion.Visible = false;
      btnConciliacion.Click += Menu_Conciliacion_Click;

      lblGrupoInventario.AutoSize = false;
      lblGrupoInventario.Font = new Font("Microsoft Sans Serif", 7.5F, FontStyle.Bold);
      lblGrupoInventario.ForeColor = SystemColors.GrayText;
      lblGrupoInventario.Size = new Size(btnW, 20);
      lblGrupoInventario.Text = "INVENTARIO";
      lblGrupoInventario.Visible = false;

      btnAjusteStock.Size = new Size(btnW, btnH);
      btnAjusteStock.Text = "Ajuste de Stock";
      btnAjusteStock.Font = new Font("Microsoft Sans Serif", 8.25F);
      btnAjusteStock.Tag = "Ajuste de Stock";
      btnAjusteStock.Visible = false;
      btnAjusteStock.Click += Menu_AjusteStock_Click;

      lblGrupoAdmin.AutoSize = false;
      lblGrupoAdmin.Font = new Font("Microsoft Sans Serif", 7.5F, FontStyle.Bold);
      lblGrupoAdmin.ForeColor = SystemColors.GrayText;
      lblGrupoAdmin.Size = new Size(btnW, 20);
      lblGrupoAdmin.Text = "ADMINISTRACION";
      lblGrupoAdmin.Visible = false;

      btnDashboard.Size = new Size(btnW, btnH);
      btnDashboard.Text = "Dashboard";
      btnDashboard.Font = new Font("Microsoft Sans Serif", 8.25F);
      btnDashboard.Tag = "Dashboard";
      btnDashboard.Visible = false;
      btnDashboard.Click += Menu_Dashboard_Click;

      btnUsuarios.Size = new Size(btnW, btnH);
      btnUsuarios.Text = "Gestion de Usuarios";
      btnUsuarios.Font = new Font("Microsoft Sans Serif", 8.25F);
      btnUsuarios.Tag = "Gestionar Usuarios";
      btnUsuarios.Visible = false;
      btnUsuarios.Click += Menu_Usuarios_Click;

      btnBackup.Size = new Size(btnW, btnH);
      btnBackup.Text = "Backup y Restauracion";
      btnBackup.Font = new Font("Microsoft Sans Serif", 8.25F);
      btnBackup.Tag = "Generar Backup";
      btnBackup.Visible = false;
      btnBackup.Click += Menu_Backup_Click;

      // Agregar controles al FlowLayoutPanel en el orden visual deseado
      flowNav.Controls.Add(lblGrupoVentas);
      flowNav.Controls.Add(btnNuevaVenta);
      flowNav.Controls.Add(btnPostVenta);
      flowNav.Controls.Add(btnCupones);
      flowNav.Controls.Add(lblGrupoCompras);
      flowNav.Controls.Add(btnPedidoCompra);
      flowNav.Controls.Add(btnRecepcionMercaderia);
      flowNav.Controls.Add(lblGrupoPagos);
      flowNav.Controls.Add(btnPagos);
      flowNav.Controls.Add(btnConciliacion);
      flowNav.Controls.Add(lblGrupoInventario);
      flowNav.Controls.Add(btnAjusteStock);
      flowNav.Controls.Add(lblGrupoAdmin);
      flowNav.Controls.Add(btnDashboard);
      flowNav.Controls.Add(btnUsuarios);
      flowNav.Controls.Add(btnBackup);

      // --- Panel de contenido (Fill) ---
      panelContenido.Dock = DockStyle.Fill;
      panelContenido.BorderStyle = BorderStyle.Fixed3D;

      // Orden de agregado: Fill primero, luego Left, luego Top
      Controls.Add(panelContenido);
      Controls.Add(panelNav);
      Controls.Add(panelTop);

      AutoScaleDimensions = new SizeF(6F, 13F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(1100, 650);
      Font = new Font("Microsoft Sans Serif", 8.25F);
      MinimumSize = new Size(800, 500);
      StartPosition = FormStartPosition.CenterScreen;
      Text = "Babilonia Calzados";
      WindowState = FormWindowState.Maximized;

      panelTop.ResumeLayout(false);
      panelTop.PerformLayout();
      flowNav.ResumeLayout(false);
      panelNav.ResumeLayout(false);
      ResumeLayout(false);
      PerformLayout();
    }

    private Panel panelTop;
    private Label lblTitulo;
    private Label lblUsuario;
    private Button btnCerrarSesion;
    private Panel panelNav;
    private FlowLayoutPanel flowNav;
    private Label lblGrupoVentas;
    private Button btnNuevaVenta;
    private Button btnPostVenta;
    private Button btnCupones;
    private Label lblGrupoCompras;
    private Button btnPedidoCompra;
    private Button btnRecepcionMercaderia;
    private Label lblGrupoPagos;
    private Button btnPagos;
    private Button btnConciliacion;
    private Label lblGrupoInventario;
    private Button btnAjusteStock;
    private Label lblGrupoAdmin;
    private Button btnDashboard;
    private Button btnUsuarios;
    private Button btnBackup;
    private Panel panelContenido;
  }
}
