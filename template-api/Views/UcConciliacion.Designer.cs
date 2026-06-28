namespace BABILONIA.Views
{
  partial class UcConciliacion
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
      lblFecha = new Label();
      dtpFecha = new DateTimePicker();
      btnConciliar = new Button();
      dgvPagos = new DataGridView();
      lblTotal = new Label();
      ((System.ComponentModel.ISupportInitialize)dgvPagos).BeginInit();
      SuspendLayout();

      lblTitulo.AutoSize = true;
      lblTitulo.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
      lblTitulo.Location = new Point(20, 15);
      lblTitulo.Text = "Conciliacion Diaria de Pagos";

      lblFecha.AutoSize = true;
      lblFecha.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
      lblFecha.Location = new Point(20, 70);
      lblFecha.Text = "Fecha a conciliar:";

      dtpFecha.Font = new Font("Microsoft Sans Serif", 8.25F);
      dtpFecha.Format = DateTimePickerFormat.Short;
      dtpFecha.Location = new Point(20, 92);
      dtpFecha.Size = new Size(180, 28);

      btnConciliar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
      btnConciliar.Location = new Point(215, 82);
      btnConciliar.Size = new Size(180, 40);
      btnConciliar.Text = "CONCILIAR";
      btnConciliar.Click += BtnConciliar_Click;

      dgvPagos.AllowUserToAddRows = false;
      dgvPagos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      dgvPagos.Location = new Point(20, 155);
      dgvPagos.ReadOnly = true;
      dgvPagos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      dgvPagos.Size = new Size(800, 310);

      lblTotal.AutoSize = true;
      lblTotal.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
      lblTotal.Location = new Point(20, 480);
      lblTotal.Text = "Total egresos del dia: -";

      AutoScaleDimensions = new SizeF(7F, 17F);
      AutoScaleMode = AutoScaleMode.Font;
      Controls.Add(lblTitulo);
      Controls.Add(lblFecha);
      Controls.Add(dtpFecha);
      Controls.Add(btnConciliar);
      Controls.Add(dgvPagos);
      Controls.Add(lblTotal);
      Size = new Size(870, 540);
      ((System.ComponentModel.ISupportInitialize)dgvPagos).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    private Label lblTitulo;
    private Label lblFecha;
    private DateTimePicker dtpFecha;
    private Button btnConciliar;
    private DataGridView dgvPagos;
    private Label lblTotal;
  }
}
