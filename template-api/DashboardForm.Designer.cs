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
      panelHeader = new Panel();
      lblTitulo = new Label();
      lblUsuario = new Label();
      btnCerrarSesion = new Button();
      panelLateral = new Panel();
      btnNuevaVenta = new Button();
      btnPostVenta = new Button();
      btnCupones = new Button();
      btnPedidoCompra = new Button();
      btnRecepcionMercaderia = new Button();
      btnPagos = new Button();
      btnConciliacion = new Button();
      btnAjusteStock = new Button();
      btnDashboard = new Button();
      btnUsuarios = new Button();
      btnBackup = new Button();
      panelContenido = new Panel();
      panelHeader.SuspendLayout();
      panelLateral.SuspendLayout();
      SuspendLayout();

      // panelHeader
      panelHeader.BackColor = Color.FromArgb(30, 30, 60);
      panelHeader.Controls.Add(lblTitulo);
      panelHeader.Controls.Add(lblUsuario);
      panelHeader.Controls.Add(btnCerrarSesion);
      panelHeader.Dock = DockStyle.Top;
      panelHeader.Size = new Size(1200, 60);
      panelHeader.TabIndex = 0;

      lblTitulo.AutoSize = true;
      lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
      lblTitulo.ForeColor = Color.White;
      lblTitulo.Location = new Point(20, 15);
      lblTitulo.Text = "BABILONIA CALZADOS";

      lblUsuario.AutoSize = true;
      lblUsuario.Font = new Font("Segoe UI", 10F);
      lblUsuario.ForeColor = Color.LightGray;
      lblUsuario.Location = new Point(730, 20);
      lblUsuario.Text = "Usuario:";

      btnCerrarSesion.BackColor = Color.FromArgb(220, 53, 69);
      btnCerrarSesion.Cursor = Cursors.Hand;
      btnCerrarSesion.FlatAppearance.BorderSize = 0;
      btnCerrarSesion.FlatStyle = FlatStyle.Flat;
      btnCerrarSesion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
      btnCerrarSesion.ForeColor = Color.White;
      btnCerrarSesion.Location = new Point(1075, 15);
      btnCerrarSesion.Size = new Size(120, 30);
      btnCerrarSesion.Text = "Cerrar Sesion";
      btnCerrarSesion.UseVisualStyleBackColor = false;
      btnCerrarSesion.Click += BtnCerrarSesion_Click;

      // panelLateral
      panelLateral.BackColor = Color.FromArgb(45, 45, 90);
      panelLateral.Controls.Add(btnNuevaVenta);
      panelLateral.Controls.Add(btnPostVenta);
      panelLateral.Controls.Add(btnCupones);
      panelLateral.Controls.Add(btnPedidoCompra);
      panelLateral.Controls.Add(btnRecepcionMercaderia);
      panelLateral.Controls.Add(btnPagos);
      panelLateral.Controls.Add(btnConciliacion);
      panelLateral.Controls.Add(btnAjusteStock);
      panelLateral.Controls.Add(btnDashboard);
      panelLateral.Controls.Add(btnUsuarios);
      panelLateral.Controls.Add(btnBackup);
      panelLateral.Dock = DockStyle.Left;
      panelLateral.Location = new Point(0, 60);
      panelLateral.Size = new Size(230, 600);
      panelLateral.TabIndex = 1;

      // Botones del menú lateral - todos usan Dock=Top para apilarse
      ConfigurarBotonMenu(btnNuevaVenta, "Nueva Venta", "Nueva Venta", Menu_NuevaVenta_Click);
      ConfigurarBotonMenu(btnPostVenta, "Post Venta / Cambio", "Post Venta", Menu_PostVenta_Click);
      ConfigurarBotonMenu(btnCupones, "Enviar Cupones", "Enviar Cupones", Menu_Cupones_Click);
      ConfigurarBotonMenu(btnPedidoCompra, "Pedido de Reposicion", "Pedido de Reposicion", Menu_PedidoCompra_Click);
      ConfigurarBotonMenu(btnRecepcionMercaderia, "Recepcion Mercaderia", "Recepcion de Mercaderia", Menu_RecepcionMercaderia_Click);
      ConfigurarBotonMenu(btnPagos, "Registrar Pago", "Registrar Pago", Menu_Pagos_Click);
      ConfigurarBotonMenu(btnConciliacion, "Conciliacion Diaria", "Conciliacion", Menu_Conciliacion_Click);
      ConfigurarBotonMenu(btnAjusteStock, "Ajuste de Stock", "Ajuste de Stock", Menu_AjusteStock_Click);
      ConfigurarBotonMenu(btnDashboard, "Dashboard / Reportes", "Dashboard", Menu_Dashboard_Click);
      ConfigurarBotonMenu(btnUsuarios, "Gestionar Usuarios", "Gestionar Usuarios", Menu_Usuarios_Click);
      ConfigurarBotonMenu(btnBackup, "Backup / Restaurar", "Generar Backup", Menu_Backup_Click);

      // panelContenido
      panelContenido.BackColor = Color.White;
      panelContenido.Dock = DockStyle.Fill;
      panelContenido.Location = new Point(230, 60);
      panelContenido.TabIndex = 2;

      // DashboardForm
      AutoScaleDimensions = new SizeF(7F, 17F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(1200, 660);
      Controls.Add(panelContenido);
      Controls.Add(panelLateral);
      Controls.Add(panelHeader);
      Font = new Font("Segoe UI", 10F);
      FormBorderStyle = FormBorderStyle.FixedSingle;
      MaximizeBox = false;
      StartPosition = FormStartPosition.CenterScreen;
      Text = "Babilonia Calzados";
      panelHeader.ResumeLayout(false);
      panelHeader.PerformLayout();
      panelLateral.ResumeLayout(false);
      ResumeLayout(false);
    }

    private void ConfigurarBotonMenu(Button btn, string texto, string tag, EventHandler handler)
    {
      btn.Dock = DockStyle.Top;
      btn.FlatAppearance.BorderSize = 0;
      btn.FlatStyle = FlatStyle.Flat;
      btn.ForeColor = Color.White;
      btn.Height = 48;
      btn.Text = "  " + texto;
      btn.TextAlign = ContentAlignment.MiddleLeft;
      btn.Tag = tag;
      btn.Cursor = Cursors.Hand;
      btn.Visible = false;
      btn.Click += handler;
    }

    private Panel panelHeader;
    private Label lblTitulo;
    private Label lblUsuario;
    private Button btnCerrarSesion;
    private Panel panelLateral;
    private Button btnNuevaVenta;
    private Button btnPostVenta;
    private Button btnCupones;
    private Button btnPedidoCompra;
    private Button btnRecepcionMercaderia;
    private Button btnPagos;
    private Button btnConciliacion;
    private Button btnAjusteStock;
    private Button btnDashboard;
    private Button btnUsuarios;
    private Button btnBackup;
    private Panel panelContenido;
  }
}
