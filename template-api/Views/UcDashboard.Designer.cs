namespace BABILONIA.Views
{
  partial class UcDashboard
  {
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null)) components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      lblTitulo = new Label();
      btnRefrescar = new Button();
      panelIndicadores = new Panel();
      lblTotalVentas = new Label();
      lblIngresoTotal = new Label();
      lblVentasDescuento = new Label();
      lblStockCritico = new Label();
      lblPagosMes = new Label();
      lblPedidosPendientes = new Label();
      lblTopProductos = new Label();
      dgvTopProductos = new DataGridView();
      lblUltimasVentas = new Label();
      dgvUltimasVentas = new DataGridView();
      panelIndicadores.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)dgvTopProductos).BeginInit();
      ((System.ComponentModel.ISupportInitialize)dgvUltimasVentas).BeginInit();
      SuspendLayout();

      lblTitulo.AutoSize = true;
      lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
      lblTitulo.ForeColor = Color.FromArgb(30, 30, 60);
      lblTitulo.Location = new Point(20, 15);
      lblTitulo.Text = "Dashboard - Babilonia Calzados";

      btnRefrescar.BackColor = Color.FromArgb(40, 167, 69);
      btnRefrescar.FlatAppearance.BorderSize = 0;
      btnRefrescar.FlatStyle = FlatStyle.Flat;
      btnRefrescar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
      btnRefrescar.ForeColor = Color.White;
      btnRefrescar.Location = new Point(720, 10);
      btnRefrescar.Size = new Size(120, 35);
      btnRefrescar.Text = "↻ Refrescar";
      btnRefrescar.UseVisualStyleBackColor = false;
      btnRefrescar.Click += BtnRefrescar_Click;

      // Panel de indicadores
      panelIndicadores.BackColor = Color.FromArgb(240, 248, 255);
      panelIndicadores.BorderStyle = BorderStyle.FixedSingle;
      panelIndicadores.Location = new Point(20, 65);
      panelIndicadores.Size = new Size(830, 120);
      panelIndicadores.Controls.Add(lblTotalVentas);
      panelIndicadores.Controls.Add(lblIngresoTotal);
      panelIndicadores.Controls.Add(lblVentasDescuento);
      panelIndicadores.Controls.Add(lblStockCritico);
      panelIndicadores.Controls.Add(lblPagosMes);
      panelIndicadores.Controls.Add(lblPedidosPendientes);

      ConfigurarLabelIndicador(lblTotalVentas, "Total ventas: -", new Point(10, 15));
      ConfigurarLabelIndicador(lblIngresoTotal, "Ingreso total: -", new Point(10, 45));
      ConfigurarLabelIndicador(lblVentasDescuento, "Ventas con jubilacion: -", new Point(10, 75));
      ConfigurarLabelIndicador(lblStockCritico, "Stock critico: -", new Point(430, 15));
      ConfigurarLabelIndicador(lblPagosMes, "Pagos este mes: -", new Point(430, 45));
      ConfigurarLabelIndicador(lblPedidosPendientes, "Pedidos pendientes: -", new Point(430, 75));

      lblTopProductos.AutoSize = true;
      lblTopProductos.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
      lblTopProductos.Location = new Point(20, 205);
      lblTopProductos.Text = "Top 5 productos mas vendidos:";

      dgvTopProductos.AllowUserToAddRows = false;
      dgvTopProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      dgvTopProductos.Location = new Point(20, 230);
      dgvTopProductos.ReadOnly = true;
      dgvTopProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      dgvTopProductos.Size = new Size(380, 140);

      lblUltimasVentas.AutoSize = true;
      lblUltimasVentas.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
      lblUltimasVentas.Location = new Point(420, 205);
      lblUltimasVentas.Text = "Ultimas 10 ventas:";

      dgvUltimasVentas.AllowUserToAddRows = false;
      dgvUltimasVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      dgvUltimasVentas.Location = new Point(420, 230);
      dgvUltimasVentas.ReadOnly = true;
      dgvUltimasVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      dgvUltimasVentas.Size = new Size(430, 330);

      AutoScaleDimensions = new SizeF(7F, 17F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = Color.White;
      Controls.Add(lblTitulo);
      Controls.Add(btnRefrescar);
      Controls.Add(panelIndicadores);
      Controls.Add(lblTopProductos);
      Controls.Add(dgvTopProductos);
      Controls.Add(lblUltimasVentas);
      Controls.Add(dgvUltimasVentas);
      Size = new Size(870, 590);
      panelIndicadores.ResumeLayout(false);
      panelIndicadores.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)dgvTopProductos).EndInit();
      ((System.ComponentModel.ISupportInitialize)dgvUltimasVentas).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    private void ConfigurarLabelIndicador(Label lbl, string texto, Point ubicacion)
    {
      lbl.AutoSize = true;
      lbl.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
      lbl.Location = ubicacion;
      lbl.Text = texto;
    }

    private Label lblTitulo;
    private Button btnRefrescar;
    private Panel panelIndicadores;
    private Label lblTotalVentas;
    private Label lblIngresoTotal;
    private Label lblVentasDescuento;
    private Label lblStockCritico;
    private Label lblPagosMes;
    private Label lblPedidosPendientes;
    private Label lblTopProductos;
    private DataGridView dgvTopProductos;
    private Label lblUltimasVentas;
    private DataGridView dgvUltimasVentas;
  }
}
