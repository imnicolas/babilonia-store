namespace BABILONIA.Views
{
  partial class UcRecepcionMercaderia
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
      lblPedidos = new Label();
      lstPedidos = new ListBox();
      lblInfoPedido = new Label();
      dgvRecepcion = new DataGridView();
      lblObservaciones = new Label();
      txtObservaciones = new TextBox();
      btnRecepcionar = new Button();
      ((System.ComponentModel.ISupportInitialize)dgvRecepcion).BeginInit();
      SuspendLayout();

      lblTitulo.AutoSize = true;
      lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
      lblTitulo.ForeColor = Color.FromArgb(30, 30, 60);
      lblTitulo.Location = new Point(20, 15);
      lblTitulo.Text = "Recepcion de Mercaderia";

      lblPedidos.AutoSize = true;
      lblPedidos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
      lblPedidos.Location = new Point(20, 65);
      lblPedidos.Text = "Pedidos Pendientes:";

      lstPedidos.Font = new Font("Segoe UI", 11F);
      lstPedidos.Location = new Point(20, 87);
      lstPedidos.Size = new Size(200, 150);
      lstPedidos.SelectedIndexChanged += LstPedidos_SelectedIndexChanged;

      lblInfoPedido.AutoSize = true;
      lblInfoPedido.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
      lblInfoPedido.ForeColor = Color.DimGray;
      lblInfoPedido.Location = new Point(235, 95);
      lblInfoPedido.Size = new Size(500, 20);

      dgvRecepcion.AllowUserToAddRows = false;
      dgvRecepcion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      dgvRecepcion.Location = new Point(20, 250);
      dgvRecepcion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      dgvRecepcion.Size = new Size(800, 200);

      lblObservaciones.AutoSize = true;
      lblObservaciones.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
      lblObservaciones.Location = new Point(20, 468);
      lblObservaciones.Text = "Observaciones:";

      txtObservaciones.Font = new Font("Segoe UI", 11F);
      txtObservaciones.Location = new Point(20, 490);
      txtObservaciones.Size = new Size(500, 28);

      btnRecepcionar.BackColor = Color.FromArgb(0, 122, 204);
      btnRecepcionar.FlatAppearance.BorderSize = 0;
      btnRecepcionar.FlatStyle = FlatStyle.Flat;
      btnRecepcionar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
      btnRecepcionar.ForeColor = Color.White;
      btnRecepcionar.Location = new Point(560, 480);
      btnRecepcionar.Size = new Size(260, 45);
      btnRecepcionar.Text = "RECEPCIONAR MERCADERIA";
      btnRecepcionar.UseVisualStyleBackColor = false;
      btnRecepcionar.Click += BtnRecepcionar_Click;

      AutoScaleDimensions = new SizeF(7F, 17F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = Color.White;
      Controls.Add(lblTitulo);
      Controls.Add(lblPedidos);
      Controls.Add(lstPedidos);
      Controls.Add(lblInfoPedido);
      Controls.Add(dgvRecepcion);
      Controls.Add(lblObservaciones);
      Controls.Add(txtObservaciones);
      Controls.Add(btnRecepcionar);
      Size = new Size(870, 560);
      ((System.ComponentModel.ISupportInitialize)dgvRecepcion).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    private Label lblTitulo;
    private Label lblPedidos;
    private ListBox lstPedidos;
    private Label lblInfoPedido;
    private DataGridView dgvRecepcion;
    private Label lblObservaciones;
    private TextBox txtObservaciones;
    private Button btnRecepcionar;
  }
}
