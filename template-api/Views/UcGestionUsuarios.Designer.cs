namespace BABILONIA.Views
{
  partial class UcGestionUsuarios
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
      lblUsuarios = new Label();
      lstUsuarios = new ListBox();
      lblLegajo = new Label();
      txtLegajo = new TextBox();
      lblEmail = new Label();
      txtEmail = new TextBox();
      lblRol = new Label();
      cmbRol = new ComboBox();
      chkBloqueado = new CheckBox();
      btnGuardar = new Button();
      btnNuevo = new Button();
      btnDesbloquear = new Button();
      lblArbol = new Label();
      tvPermisos = new TreeView();
      SuspendLayout();

      lblTitulo.AutoSize = true;
      lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
      lblTitulo.ForeColor = Color.FromArgb(30, 30, 60);
      lblTitulo.Location = new Point(20, 15);
      lblTitulo.Text = "Gestion de Usuarios";

      lblUsuarios.AutoSize = true;
      lblUsuarios.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
      lblUsuarios.Location = new Point(20, 65);
      lblUsuarios.Text = "Usuarios:";

      lstUsuarios.Font = new Font("Segoe UI", 10F);
      lstUsuarios.Location = new Point(20, 85);
      lstUsuarios.Size = new Size(200, 280);
      lstUsuarios.SelectedIndexChanged += LstUsuarios_SelectedIndexChanged;

      lblLegajo.AutoSize = true;
      lblLegajo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
      lblLegajo.Location = new Point(240, 65);
      lblLegajo.Text = "Legajo:";

      txtLegajo.Font = new Font("Segoe UI", 11F);
      txtLegajo.Location = new Point(240, 85);
      txtLegajo.Size = new Size(230, 28);

      lblEmail.AutoSize = true;
      lblEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
      lblEmail.Location = new Point(240, 130);
      lblEmail.Text = "Email:";

      txtEmail.Font = new Font("Segoe UI", 11F);
      txtEmail.Location = new Point(240, 150);
      txtEmail.Size = new Size(230, 28);

      lblRol.AutoSize = true;
      lblRol.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
      lblRol.Location = new Point(240, 195);
      lblRol.Text = "Rol asignado:";

      cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
      cmbRol.Font = new Font("Segoe UI", 11F);
      cmbRol.Location = new Point(240, 215);
      cmbRol.Size = new Size(230, 28);

      chkBloqueado.AutoSize = true;
      chkBloqueado.Font = new Font("Segoe UI", 10F);
      chkBloqueado.Location = new Point(240, 265);
      chkBloqueado.Text = "Usuario bloqueado";

      btnGuardar.BackColor = Color.FromArgb(0, 122, 204);
      btnGuardar.FlatAppearance.BorderSize = 0;
      btnGuardar.FlatStyle = FlatStyle.Flat;
      btnGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
      btnGuardar.ForeColor = Color.White;
      btnGuardar.Location = new Point(240, 305);
      btnGuardar.Size = new Size(110, 38);
      btnGuardar.Text = "GUARDAR";
      btnGuardar.UseVisualStyleBackColor = false;
      btnGuardar.Click += BtnGuardar_Click;

      btnNuevo.BackColor = Color.FromArgb(100, 100, 100);
      btnNuevo.FlatAppearance.BorderSize = 0;
      btnNuevo.FlatStyle = FlatStyle.Flat;
      btnNuevo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
      btnNuevo.ForeColor = Color.White;
      btnNuevo.Location = new Point(360, 305);
      btnNuevo.Size = new Size(110, 38);
      btnNuevo.Text = "NUEVO";
      btnNuevo.UseVisualStyleBackColor = false;
      btnNuevo.Click += BtnNuevo_Click;

      btnDesbloquear.BackColor = Color.FromArgb(40, 167, 69);
      btnDesbloquear.FlatAppearance.BorderSize = 0;
      btnDesbloquear.FlatStyle = FlatStyle.Flat;
      btnDesbloquear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
      btnDesbloquear.ForeColor = Color.White;
      btnDesbloquear.Location = new Point(240, 355);
      btnDesbloquear.Size = new Size(230, 38);
      btnDesbloquear.Text = "DESBLOQUEAR USUARIO";
      btnDesbloquear.UseVisualStyleBackColor = false;
      btnDesbloquear.Click += BtnDesbloquear_Click;

      lblArbol.AutoSize = true;
      lblArbol.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
      lblArbol.Location = new Point(490, 65);
      lblArbol.Text = "Arbol de roles y permisos (Composite):";

      tvPermisos.Font = new Font("Segoe UI", 10F);
      tvPermisos.Location = new Point(490, 85);
      tvPermisos.Size = new Size(340, 450);

      AutoScaleDimensions = new SizeF(7F, 17F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = Color.White;
      Controls.Add(lblTitulo);
      Controls.Add(lblUsuarios);
      Controls.Add(lstUsuarios);
      Controls.Add(lblLegajo);
      Controls.Add(txtLegajo);
      Controls.Add(lblEmail);
      Controls.Add(txtEmail);
      Controls.Add(lblRol);
      Controls.Add(cmbRol);
      Controls.Add(chkBloqueado);
      Controls.Add(btnGuardar);
      Controls.Add(btnNuevo);
      Controls.Add(btnDesbloquear);
      Controls.Add(lblArbol);
      Controls.Add(tvPermisos);
      Size = new Size(870, 590);
      ResumeLayout(false);
      PerformLayout();
    }

    private Label lblTitulo;
    private Label lblUsuarios;
    private ListBox lstUsuarios;
    private Label lblLegajo;
    private TextBox txtLegajo;
    private Label lblEmail;
    private TextBox txtEmail;
    private Label lblRol;
    private ComboBox cmbRol;
    private CheckBox chkBloqueado;
    private Button btnGuardar;
    private Button btnNuevo;
    private Button btnDesbloquear;
    private Label lblArbol;
    private TreeView tvPermisos;
  }
}
