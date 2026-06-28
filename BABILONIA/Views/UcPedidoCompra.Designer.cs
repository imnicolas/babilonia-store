namespace BABILONIA.Views
{
  partial class UcPedidoCompra
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
      lblProducto = new Label();
      cmbProducto = new ComboBox();
      nudCantidad = new NumericUpDown();
      btnAgregarItem = new Button();
      dgvItems = new DataGridView();
      btnGenerarPedido = new Button();
      lblPedidos = new Label();
      dgvPedidos = new DataGridView();
      ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
      ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
      ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
      SuspendLayout();

      lblTitulo.AutoSize = true;
      lblTitulo.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
      lblTitulo.Location = new Point(20, 15);
      lblTitulo.Text = "Pedido de Reposicion";

      lblProveedor.AutoSize = true;
      lblProveedor.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
      lblProveedor.Location = new Point(20, 65);
      lblProveedor.Text = "Proveedor:";

      cmbProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
      cmbProveedor.Font = new Font("Microsoft Sans Serif", 8.25F);
      cmbProveedor.Location = new Point(20, 87);
      cmbProveedor.Size = new Size(350, 28);

      lblProducto.AutoSize = true;
      lblProducto.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
      lblProducto.Location = new Point(20, 135);
      lblProducto.Text = "Producto (ordenados por stock critico):";

      cmbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
      cmbProducto.Font = new Font("Microsoft Sans Serif", 8.25F);
      cmbProducto.Location = new Point(20, 157);
      cmbProducto.Size = new Size(400, 28);

      nudCantidad.Font = new Font("Microsoft Sans Serif", 8.25F);
      nudCantidad.Location = new Point(435, 157);
      nudCantidad.Minimum = 1;
      nudCantidad.Maximum = 999;
      nudCantidad.Value = 10;
      nudCantidad.Size = new Size(80, 28);

      btnAgregarItem.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
      btnAgregarItem.Location = new Point(525, 154);
      btnAgregarItem.Size = new Size(110, 32);
      btnAgregarItem.Text = "+ Agregar";
      btnAgregarItem.Click += BtnAgregarItem_Click;

      dgvItems.AllowUserToAddRows = false;
      dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      dgvItems.Location = new Point(20, 205);
      dgvItems.ReadOnly = true;
      dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      dgvItems.Size = new Size(700, 160);

      btnGenerarPedido.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
      btnGenerarPedido.Location = new Point(450, 375);
      btnGenerarPedido.Size = new Size(270, 45);
      btnGenerarPedido.Text = "GENERAR PEDIDO";
      btnGenerarPedido.Click += BtnGenerarPedido_Click;

      lblPedidos.AutoSize = true;
      lblPedidos.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
      lblPedidos.Location = new Point(20, 435);
      lblPedidos.Text = "Pedidos existentes:";

      dgvPedidos.AllowUserToAddRows = false;
      dgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      dgvPedidos.Location = new Point(20, 460);
      dgvPedidos.ReadOnly = true;
      dgvPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      dgvPedidos.Size = new Size(700, 130);

      AutoScaleDimensions = new SizeF(7F, 17F);
      AutoScaleMode = AutoScaleMode.Font;
      Controls.Add(lblTitulo);
      Controls.Add(lblProveedor);
      Controls.Add(cmbProveedor);
      Controls.Add(lblProducto);
      Controls.Add(cmbProducto);
      Controls.Add(nudCantidad);
      Controls.Add(btnAgregarItem);
      Controls.Add(dgvItems);
      Controls.Add(btnGenerarPedido);
      Controls.Add(lblPedidos);
      Controls.Add(dgvPedidos);
      Size = new Size(870, 620);
      ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
      ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
      ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    private Label lblTitulo;
    private Label lblProveedor;
    private ComboBox cmbProveedor;
    private Label lblProducto;
    private ComboBox cmbProducto;
    private NumericUpDown nudCantidad;
    private Button btnAgregarItem;
    private DataGridView dgvItems;
    private Button btnGenerarPedido;
    private Label lblPedidos;
    private DataGridView dgvPedidos;
  }
}
