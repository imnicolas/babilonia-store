namespace BABILONIA.Views
{
  partial class UcPagos
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
      lblProveedor = new Label();
      cmbProveedor = new ComboBox();
      lblDeuda = new Label();
      lblMonto = new Label();
      nudMonto = new NumericUpDown();
      lblMedioPago = new Label();
      cmbMedioPago = new ComboBox();
      lblDescripcion = new Label();
      txtDescripcion = new TextBox();
      btnRegistrarPago = new Button();
      dgvPagos = new DataGridView();
      ((System.ComponentModel.ISupportInitialize)nudMonto).BeginInit();
      ((System.ComponentModel.ISupportInitialize)dgvPagos).BeginInit();
      SuspendLayout();

      lblTitulo.AutoSize = true;
      lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
      lblTitulo.ForeColor = Color.FromArgb(30, 30, 60);
      lblTitulo.Location = new Point(20, 15);
      lblTitulo.Text = "Registrar Pago a Proveedor";

      lblProveedor.AutoSize = true;
      lblProveedor.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
      lblProveedor.Location = new Point(20, 65);
      lblProveedor.Text = "Proveedor:";

      cmbProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
      cmbProveedor.Font = new Font("Segoe UI", 11F);
      cmbProveedor.Location = new Point(20, 87);
      cmbProveedor.Size = new Size(350, 28);
      cmbProveedor.SelectedIndexChanged += CmbProveedor_SelectedIndexChanged;

      lblDeuda.AutoSize = true;
      lblDeuda.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
      lblDeuda.ForeColor = Color.FromArgb(220, 53, 69);
      lblDeuda.Location = new Point(390, 95);
      lblDeuda.Text = "Deuda actual: $0,00";

      lblMonto.AutoSize = true;
      lblMonto.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
      lblMonto.Location = new Point(20, 135);
      lblMonto.Text = "Monto a pagar ($):";

      nudMonto.DecimalPlaces = 2;
      nudMonto.Font = new Font("Segoe UI", 11F);
      nudMonto.Location = new Point(20, 157);
      nudMonto.Maximum = 9999999;
      nudMonto.Minimum = 0;
      nudMonto.Size = new Size(160, 28);

      lblMedioPago.AutoSize = true;
      lblMedioPago.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
      lblMedioPago.Location = new Point(200, 135);
      lblMedioPago.Text = "Medio de Pago:";

      cmbMedioPago.DropDownStyle = ComboBoxStyle.DropDownList;
      cmbMedioPago.Font = new Font("Segoe UI", 11F);
      cmbMedioPago.Items.AddRange(new object[] { "Efectivo", "Transferencia", "Cheque" });
      cmbMedioPago.Location = new Point(200, 157);
      cmbMedioPago.SelectedIndex = 0;
      cmbMedioPago.Size = new Size(170, 28);

      lblDescripcion.AutoSize = true;
      lblDescripcion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
      lblDescripcion.Location = new Point(20, 200);
      lblDescripcion.Text = "Descripcion / Factura N°:";

      txtDescripcion.Font = new Font("Segoe UI", 11F);
      txtDescripcion.Location = new Point(20, 222);
      txtDescripcion.Size = new Size(400, 28);

      btnRegistrarPago.BackColor = Color.FromArgb(0, 122, 204);
      btnRegistrarPago.FlatAppearance.BorderSize = 0;
      btnRegistrarPago.FlatStyle = FlatStyle.Flat;
      btnRegistrarPago.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
      btnRegistrarPago.ForeColor = Color.White;
      btnRegistrarPago.Location = new Point(550, 212);
      btnRegistrarPago.Size = new Size(230, 45);
      btnRegistrarPago.Text = "REGISTRAR PAGO";
      btnRegistrarPago.UseVisualStyleBackColor = false;
      btnRegistrarPago.Click += BtnRegistrarPago_Click;

      dgvPagos.AllowUserToAddRows = false;
      dgvPagos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      dgvPagos.Location = new Point(20, 290);
      dgvPagos.ReadOnly = true;
      dgvPagos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      dgvPagos.Size = new Size(800, 240);

      AutoScaleDimensions = new SizeF(7F, 17F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = Color.White;
      Controls.Add(lblTitulo);
      Controls.Add(lblProveedor);
      Controls.Add(cmbProveedor);
      Controls.Add(lblDeuda);
      Controls.Add(lblMonto);
      Controls.Add(nudMonto);
      Controls.Add(lblMedioPago);
      Controls.Add(cmbMedioPago);
      Controls.Add(lblDescripcion);
      Controls.Add(txtDescripcion);
      Controls.Add(btnRegistrarPago);
      Controls.Add(dgvPagos);
      Size = new Size(870, 560);
      ((System.ComponentModel.ISupportInitialize)nudMonto).EndInit();
      ((System.ComponentModel.ISupportInitialize)dgvPagos).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    private Label lblTitulo;
    private Label lblProveedor;
    private ComboBox cmbProveedor;
    private Label lblDeuda;
    private Label lblMonto;
    private NumericUpDown nudMonto;
    private Label lblMedioPago;
    private ComboBox cmbMedioPago;
    private Label lblDescripcion;
    private TextBox txtDescripcion;
    private Button btnRegistrarPago;
    private DataGridView dgvPagos;
  }
}
