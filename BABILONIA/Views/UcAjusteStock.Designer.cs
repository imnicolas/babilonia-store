namespace BABILONIA.Views
{
  partial class UcAjusteStock
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
      lblProducto = new Label();
      cmbProducto = new ComboBox();
      lblCantidad = new Label();
      nudCantidad = new NumericUpDown();
      rbBaja = new RadioButton();
      rbAlta = new RadioButton();
      lblMotivo = new Label();
      txtMotivo = new TextBox();
      btnAplicarAjuste = new Button();
      lblAlertas = new Label();
      dgvAlertas = new DataGridView();
      ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
      ((System.ComponentModel.ISupportInitialize)dgvAlertas).BeginInit();
      SuspendLayout();

      lblTitulo.AutoSize = true;
      lblTitulo.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
      lblTitulo.Location = new Point(20, 15);
      lblTitulo.Text = "Ajuste de Stock";

      lblProducto.AutoSize = true;
      lblProducto.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
      lblProducto.Location = new Point(20, 65);
      lblProducto.Text = "Producto:";

      cmbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
      cmbProducto.Font = new Font("Microsoft Sans Serif", 8.25F);
      cmbProducto.Location = new Point(20, 87);
      cmbProducto.Size = new Size(450, 28);

      lblCantidad.AutoSize = true;
      lblCantidad.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
      lblCantidad.Location = new Point(20, 135);
      lblCantidad.Text = "Cantidad:";

      nudCantidad.Font = new Font("Microsoft Sans Serif", 8.25F);
      nudCantidad.Location = new Point(20, 157);
      nudCantidad.Minimum = 1;
      nudCantidad.Maximum = 9999;
      nudCantidad.Value = 1;
      nudCantidad.Size = new Size(90, 28);

      rbBaja.AutoSize = true;
      rbBaja.Checked = true;
      rbBaja.Font = new Font("Microsoft Sans Serif", 8.25F);
      rbBaja.Location = new Point(130, 160);
      rbBaja.Text = "Baja (merma/rotura)";

      rbAlta.AutoSize = true;
      rbAlta.Font = new Font("Microsoft Sans Serif", 8.25F);
      rbAlta.Location = new Point(310, 160);
      rbAlta.Text = "Alta (ajuste positivo)";

      lblMotivo.AutoSize = true;
      lblMotivo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
      lblMotivo.Location = new Point(20, 205);
      lblMotivo.Text = "Motivo del ajuste:";

      txtMotivo.Font = new Font("Microsoft Sans Serif", 8.25F);
      txtMotivo.Location = new Point(20, 227);
      txtMotivo.Size = new Size(450, 28);

      btnAplicarAjuste.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
      btnAplicarAjuste.Location = new Point(20, 280);
      btnAplicarAjuste.Size = new Size(220, 42);
      btnAplicarAjuste.Text = "APLICAR AJUSTE";
      btnAplicarAjuste.Click += BtnAplicarAjuste_Click;

      lblAlertas.AutoSize = true;
      lblAlertas.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
      lblAlertas.Location = new Point(20, 350);
      lblAlertas.Text = "Cargando alertas...";

      dgvAlertas.AllowUserToAddRows = false;
      dgvAlertas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      dgvAlertas.Location = new Point(20, 378);
      dgvAlertas.ReadOnly = true;
      dgvAlertas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      dgvAlertas.Size = new Size(800, 180);

      AutoScaleDimensions = new SizeF(7F, 17F);
      AutoScaleMode = AutoScaleMode.Font;
      Controls.Add(lblTitulo);
      Controls.Add(lblProducto);
      Controls.Add(cmbProducto);
      Controls.Add(lblCantidad);
      Controls.Add(nudCantidad);
      Controls.Add(rbBaja);
      Controls.Add(rbAlta);
      Controls.Add(lblMotivo);
      Controls.Add(txtMotivo);
      Controls.Add(btnAplicarAjuste);
      Controls.Add(lblAlertas);
      Controls.Add(dgvAlertas);
      Size = new Size(870, 590);
      ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
      ((System.ComponentModel.ISupportInitialize)dgvAlertas).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    private Label lblTitulo;
    private Label lblProducto;
    private ComboBox cmbProducto;
    private Label lblCantidad;
    private NumericUpDown nudCantidad;
    private RadioButton rbBaja;
    private RadioButton rbAlta;
    private Label lblMotivo;
    private TextBox txtMotivo;
    private Button btnAplicarAjuste;
    private Label lblAlertas;
    private DataGridView dgvAlertas;
  }
}
