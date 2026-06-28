namespace BABILONIA.Views
{
  partial class UcPostVenta
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
      lblVenta = new Label();
      cmbVenta = new ComboBox();
      lblDevuelto = new Label();
      cmbDevuelto = new ComboBox();
      lblNuevo = new Label();
      cmbNuevo = new ComboBox();
      btnRegistrarCambio = new Button();
      SuspendLayout();

      lblTitulo.AutoSize = true;
      lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
      lblTitulo.ForeColor = Color.FromArgb(30, 30, 60);
      lblTitulo.Location = new Point(20, 15);
      lblTitulo.Text = "Post Venta - Cambio de Calzado";

      lblVenta.AutoSize = true;
      lblVenta.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
      lblVenta.Location = new Point(20, 70);
      lblVenta.Text = "Numero de Venta:";

      cmbVenta.DropDownStyle = ComboBoxStyle.DropDownList;
      cmbVenta.Font = new Font("Segoe UI", 11F);
      cmbVenta.Location = new Point(20, 92);
      cmbVenta.Size = new Size(200, 28);

      lblDevuelto.AutoSize = true;
      lblDevuelto.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
      lblDevuelto.Location = new Point(20, 145);
      lblDevuelto.Text = "Producto a devolver:";

      cmbDevuelto.DropDownStyle = ComboBoxStyle.DropDownList;
      cmbDevuelto.Font = new Font("Segoe UI", 11F);
      cmbDevuelto.Location = new Point(20, 167);
      cmbDevuelto.Size = new Size(400, 28);

      lblNuevo.AutoSize = true;
      lblNuevo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
      lblNuevo.Location = new Point(20, 220);
      lblNuevo.Text = "Producto de reemplazo:";

      cmbNuevo.DropDownStyle = ComboBoxStyle.DropDownList;
      cmbNuevo.Font = new Font("Segoe UI", 11F);
      cmbNuevo.Location = new Point(20, 242);
      cmbNuevo.Size = new Size(400, 28);

      btnRegistrarCambio.BackColor = Color.FromArgb(0, 122, 204);
      btnRegistrarCambio.FlatAppearance.BorderSize = 0;
      btnRegistrarCambio.FlatStyle = FlatStyle.Flat;
      btnRegistrarCambio.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
      btnRegistrarCambio.ForeColor = Color.White;
      btnRegistrarCambio.Location = new Point(20, 305);
      btnRegistrarCambio.Size = new Size(260, 45);
      btnRegistrarCambio.Text = "REGISTRAR CAMBIO";
      btnRegistrarCambio.UseVisualStyleBackColor = false;
      btnRegistrarCambio.Click += BtnRegistrarCambio_Click;

      AutoScaleDimensions = new SizeF(7F, 17F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = Color.White;
      Controls.Add(lblTitulo);
      Controls.Add(lblVenta);
      Controls.Add(cmbVenta);
      Controls.Add(lblDevuelto);
      Controls.Add(cmbDevuelto);
      Controls.Add(lblNuevo);
      Controls.Add(cmbNuevo);
      Controls.Add(btnRegistrarCambio);
      Size = new Size(700, 400);
      ResumeLayout(false);
      PerformLayout();
    }

    private Label lblTitulo;
    private Label lblVenta;
    private ComboBox cmbVenta;
    private Label lblDevuelto;
    private ComboBox cmbDevuelto;
    private Label lblNuevo;
    private ComboBox cmbNuevo;
    private Button btnRegistrarCambio;
  }
}
