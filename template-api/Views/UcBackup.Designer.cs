namespace BABILONIA.Views
{
  partial class UcBackup
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
      panelAcciones = new Panel();
      lblDescripcionBackup = new Label();
      btnGenerarBackup = new Button();
      lblDescripcionRestore = new Label();
      btnRestaurar = new Button();
      lblEstado = new Label();
      lblHistorial = new Label();
      dgvBitacora = new DataGridView();
      panelAcciones.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)dgvBitacora).BeginInit();
      SuspendLayout();

      lblTitulo.AutoSize = true;
      lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
      lblTitulo.ForeColor = Color.FromArgb(30, 30, 60);
      lblTitulo.Location = new Point(20, 15);
      lblTitulo.Text = "Backup y Restauracion";

      panelAcciones.BackColor = Color.FromArgb(240, 248, 255);
      panelAcciones.BorderStyle = BorderStyle.FixedSingle;
      panelAcciones.Location = new Point(20, 65);
      panelAcciones.Size = new Size(830, 160);
      panelAcciones.Controls.Add(lblDescripcionBackup);
      panelAcciones.Controls.Add(btnGenerarBackup);
      panelAcciones.Controls.Add(lblDescripcionRestore);
      panelAcciones.Controls.Add(btnRestaurar);

      lblDescripcionBackup.AutoSize = true;
      lblDescripcionBackup.Font = new Font("Segoe UI", 10F);
      lblDescripcionBackup.Location = new Point(15, 20);
      lblDescripcionBackup.Text = "Generar un archivo ZIP con toda la base de datos XML actual para respaldo seguro.";

      btnGenerarBackup.BackColor = Color.FromArgb(0, 122, 204);
      btnGenerarBackup.FlatAppearance.BorderSize = 0;
      btnGenerarBackup.FlatStyle = FlatStyle.Flat;
      btnGenerarBackup.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
      btnGenerarBackup.ForeColor = Color.White;
      btnGenerarBackup.Location = new Point(15, 50);
      btnGenerarBackup.Size = new Size(220, 45);
      btnGenerarBackup.Text = "GENERAR BACKUP";
      btnGenerarBackup.UseVisualStyleBackColor = false;
      btnGenerarBackup.Click += BtnGenerarBackup_Click;

      lblDescripcionRestore.AutoSize = true;
      lblDescripcionRestore.Font = new Font("Segoe UI", 10F);
      lblDescripcionRestore.ForeColor = Color.FromArgb(180, 30, 30);
      lblDescripcionRestore.Location = new Point(430, 20);
      lblDescripcionRestore.Text = "Restaurar la base de datos desde un archivo ZIP de backup previo (reemplaza datos actuales).";

      btnRestaurar.BackColor = Color.FromArgb(220, 53, 69);
      btnRestaurar.FlatAppearance.BorderSize = 0;
      btnRestaurar.FlatStyle = FlatStyle.Flat;
      btnRestaurar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
      btnRestaurar.ForeColor = Color.White;
      btnRestaurar.Location = new Point(430, 50);
      btnRestaurar.Size = new Size(220, 45);
      btnRestaurar.Text = "RESTAURAR BACKUP";
      btnRestaurar.UseVisualStyleBackColor = false;
      btnRestaurar.Click += BtnRestaurar_Click;

      lblEstado.AutoSize = true;
      lblEstado.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
      lblEstado.Location = new Point(15, 115);
      lblEstado.Text = string.Empty;
      panelAcciones.Controls.Add(lblEstado);

      lblHistorial.AutoSize = true;
      lblHistorial.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
      lblHistorial.Location = new Point(20, 245);
      lblHistorial.Text = "Historial de operaciones de backup en bitacora:";

      dgvBitacora.AllowUserToAddRows = false;
      dgvBitacora.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      dgvBitacora.Location = new Point(20, 270);
      dgvBitacora.ReadOnly = true;
      dgvBitacora.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      dgvBitacora.Size = new Size(830, 280);

      AutoScaleDimensions = new SizeF(7F, 17F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = Color.White;
      Controls.Add(lblTitulo);
      Controls.Add(panelAcciones);
      Controls.Add(lblHistorial);
      Controls.Add(dgvBitacora);
      Size = new Size(870, 590);
      panelAcciones.ResumeLayout(false);
      panelAcciones.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)dgvBitacora).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    private Label lblTitulo;
    private Panel panelAcciones;
    private Label lblDescripcionBackup;
    private Button btnGenerarBackup;
    private Label lblDescripcionRestore;
    private Button btnRestaurar;
    private Label lblEstado;
    private Label lblHistorial;
    private DataGridView dgvBitacora;
  }
}
