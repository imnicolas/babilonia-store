namespace BABILONIA.Views
{
  partial class UcCupones
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
      lblCliente = new Label();
      cmbCliente = new ComboBox();
      lblDescuento = new Label();
      nudDescuento = new NumericUpDown();
      lblDias = new Label();
      nudDias = new NumericUpDown();
      lblDescripcion = new Label();
      txtDescripcion = new TextBox();
      btnEmitirCupon = new Button();
      dgvCupones = new DataGridView();
      ((System.ComponentModel.ISupportInitialize)nudDescuento).BeginInit();
      ((System.ComponentModel.ISupportInitialize)nudDias).BeginInit();
      ((System.ComponentModel.ISupportInitialize)dgvCupones).BeginInit();
      SuspendLayout();

      lblTitulo.AutoSize = true;
      lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
      lblTitulo.ForeColor = Color.FromArgb(30, 30, 60);
      lblTitulo.Location = new Point(20, 15);
      lblTitulo.Text = "Cupones de Fidelizacion";

      lblCliente.AutoSize = true;
      lblCliente.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
      lblCliente.Location = new Point(20, 65);
      lblCliente.Text = "Cliente:";

      cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
      cmbCliente.Font = new Font("Segoe UI", 11F);
      cmbCliente.Location = new Point(20, 87);
      cmbCliente.Size = new Size(400, 28);

      lblDescuento.AutoSize = true;
      lblDescuento.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
      lblDescuento.Location = new Point(20, 135);
      lblDescuento.Text = "Descuento (%):";

      nudDescuento.Font = new Font("Segoe UI", 11F);
      nudDescuento.Location = new Point(20, 157);
      nudDescuento.Minimum = 1;
      nudDescuento.Maximum = 50;
      nudDescuento.Value = 10;
      nudDescuento.Size = new Size(90, 28);

      lblDias.AutoSize = true;
      lblDias.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
      lblDias.Location = new Point(130, 135);
      lblDias.Text = "Vigencia (dias):";

      nudDias.Font = new Font("Segoe UI", 11F);
      nudDias.Location = new Point(130, 157);
      nudDias.Minimum = 1;
      nudDias.Maximum = 365;
      nudDias.Value = 30;
      nudDias.Size = new Size(90, 28);

      lblDescripcion.AutoSize = true;
      lblDescripcion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
      lblDescripcion.Location = new Point(20, 200);
      lblDescripcion.Text = "Descripcion:";

      txtDescripcion.Font = new Font("Segoe UI", 11F);
      txtDescripcion.Location = new Point(20, 222);
      txtDescripcion.Size = new Size(400, 28);

      btnEmitirCupon.BackColor = Color.FromArgb(0, 122, 204);
      btnEmitirCupon.FlatAppearance.BorderSize = 0;
      btnEmitirCupon.FlatStyle = FlatStyle.Flat;
      btnEmitirCupon.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
      btnEmitirCupon.ForeColor = Color.White;
      btnEmitirCupon.Location = new Point(20, 270);
      btnEmitirCupon.Size = new Size(200, 40);
      btnEmitirCupon.Text = "EMITIR CUPON";
      btnEmitirCupon.UseVisualStyleBackColor = false;
      btnEmitirCupon.Click += BtnEmitirCupon_Click;

      dgvCupones.AllowUserToAddRows = false;
      dgvCupones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      dgvCupones.Location = new Point(20, 330);
      dgvCupones.ReadOnly = true;
      dgvCupones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      dgvCupones.Size = new Size(800, 200);

      AutoScaleDimensions = new SizeF(7F, 17F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = Color.White;
      Controls.Add(lblTitulo);
      Controls.Add(lblCliente);
      Controls.Add(cmbCliente);
      Controls.Add(lblDescuento);
      Controls.Add(nudDescuento);
      Controls.Add(lblDias);
      Controls.Add(nudDias);
      Controls.Add(lblDescripcion);
      Controls.Add(txtDescripcion);
      Controls.Add(btnEmitirCupon);
      Controls.Add(dgvCupones);
      Size = new Size(870, 560);
      ((System.ComponentModel.ISupportInitialize)nudDescuento).EndInit();
      ((System.ComponentModel.ISupportInitialize)nudDias).EndInit();
      ((System.ComponentModel.ISupportInitialize)dgvCupones).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    private Label lblTitulo;
    private Label lblCliente;
    private ComboBox cmbCliente;
    private Label lblDescuento;
    private NumericUpDown nudDescuento;
    private Label lblDias;
    private NumericUpDown nudDias;
    private Label lblDescripcion;
    private TextBox txtDescripcion;
    private Button btnEmitirCupon;
    private DataGridView dgvCupones;
  }
}
