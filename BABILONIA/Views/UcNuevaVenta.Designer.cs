namespace BABILONIA.Views
{
  partial class UcNuevaVenta
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
      lblProducto = new Label();
      cmbProducto = new ComboBox();
      lblCantidad = new Label();
      nudCantidad = new NumericUpDown();
      btnAgregarItem = new Button();
      dgvItems = new DataGridView();
      btnQuitarItem = new Button();
      lblMedioPago = new Label();
      cmbMedioPago = new ComboBox();
      btnConfirmarVenta = new Button();
      ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
      ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
      SuspendLayout();

      lblTitulo.AutoSize = true;
      lblTitulo.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
      lblTitulo.Location = new Point(20, 15);
      lblTitulo.Text = "Nueva Venta";

      lblCliente.AutoSize = true;
      lblCliente.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
      lblCliente.Location = new Point(20, 65);
      lblCliente.Text = "Cliente:";

      cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
      cmbCliente.Font = new Font("Microsoft Sans Serif", 8.25F);
      cmbCliente.Location = new Point(20, 87);
      cmbCliente.Size = new Size(400, 28);

      lblProducto.AutoSize = true;
      lblProducto.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
      lblProducto.Location = new Point(20, 135);
      lblProducto.Text = "Producto:";

      cmbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
      cmbProducto.Font = new Font("Microsoft Sans Serif", 8.25F);
      cmbProducto.Location = new Point(20, 157);
      cmbProducto.Size = new Size(400, 28);

      lblCantidad.AutoSize = true;
      lblCantidad.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
      lblCantidad.Location = new Point(435, 135);
      lblCantidad.Text = "Cantidad:";

      nudCantidad.Font = new Font("Microsoft Sans Serif", 8.25F);
      nudCantidad.Location = new Point(435, 157);
      nudCantidad.Minimum = 1;
      nudCantidad.Maximum = 999;
      nudCantidad.Value = 1;
      nudCantidad.Size = new Size(80, 28);

      btnAgregarItem.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
      btnAgregarItem.Location = new Point(530, 154);
      btnAgregarItem.Size = new Size(120, 32);
      btnAgregarItem.Text = "+ Agregar";
      btnAgregarItem.Click += BtnAgregarItem_Click;

      dgvItems.AllowUserToAddRows = false;
      dgvItems.AllowUserToDeleteRows = false;
      dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dgvItems.Location = new Point(20, 205);
      dgvItems.ReadOnly = true;
      dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      dgvItems.Size = new Size(800, 200);

      btnQuitarItem.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
      btnQuitarItem.Location = new Point(20, 415);
      btnQuitarItem.Size = new Size(140, 32);
      btnQuitarItem.Text = "- Quitar Item";
      btnQuitarItem.Click += BtnQuitarItem_Click;

      lblMedioPago.AutoSize = true;
      lblMedioPago.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
      lblMedioPago.Location = new Point(20, 470);
      lblMedioPago.Text = "Medio de Pago:";

      cmbMedioPago.DropDownStyle = ComboBoxStyle.DropDownList;
      cmbMedioPago.Font = new Font("Microsoft Sans Serif", 8.25F);
      cmbMedioPago.Items.AddRange(new object[] { "Efectivo", "Transferencia", "Debito", "Credito" });
      cmbMedioPago.Location = new Point(20, 492);
      cmbMedioPago.SelectedIndex = 0;
      cmbMedioPago.Size = new Size(200, 28);

      btnConfirmarVenta.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
      btnConfirmarVenta.Location = new Point(580, 482);
      btnConfirmarVenta.Size = new Size(240, 45);
      btnConfirmarVenta.Text = "CONFIRMAR VENTA";
      btnConfirmarVenta.Click += BtnConfirmarVenta_Click;

      AutoScaleDimensions = new SizeF(7F, 17F);
      AutoScaleMode = AutoScaleMode.Font;
      Controls.Add(lblTitulo);
      Controls.Add(lblCliente);
      Controls.Add(cmbCliente);
      Controls.Add(lblProducto);
      Controls.Add(cmbProducto);
      Controls.Add(lblCantidad);
      Controls.Add(nudCantidad);
      Controls.Add(btnAgregarItem);
      Controls.Add(dgvItems);
      Controls.Add(btnQuitarItem);
      Controls.Add(lblMedioPago);
      Controls.Add(cmbMedioPago);
      Controls.Add(btnConfirmarVenta);
      Size = new Size(870, 560);
      ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
      ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    private Label lblTitulo;
    private Label lblCliente;
    private ComboBox cmbCliente;
    private Label lblProducto;
    private ComboBox cmbProducto;
    private Label lblCantidad;
    private NumericUpDown nudCantidad;
    private Button btnAgregarItem;
    private DataGridView dgvItems;
    private Button btnQuitarItem;
    private Label lblMedioPago;
    private ComboBox cmbMedioPago;
    private Button btnConfirmarVenta;
  }
}
