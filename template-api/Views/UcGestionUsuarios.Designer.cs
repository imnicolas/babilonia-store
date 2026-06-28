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
      // --- Columna izquierda: lista de usuarios ---
      lblUsuarios = new Label();
      lstUsuarios = new ListBox();
      // --- Columna central: formulario de usuario ---
      lblLegajo = new Label();
      txtLegajo = new TextBox();
      lblEmail = new Label();
      txtEmail = new TextBox();
      chkBloqueado = new CheckBox();
      btnGuardar = new Button();
      btnNuevo = new Button();
      btnDesbloquear = new Button();
      // --- Columna derecha superior: asignacion de roles ---
      lblRolesDisponibles = new Label();
      lstRoles = new ListBox();
      btnAsignarRol = new Button();
      btnQuitarRol = new Button();
      lblRolesUsuario = new Label();
      tvPermisos = new TreeView();
      // --- Columna derecha inferior: crear rol ---
      lblCrearRol = new Label();
      lblNombreRol = new Label();
      txtNombreRol = new TextBox();
      lblPermisos = new Label();
      clbPermisos = new CheckedListBox();
      btnCrearRol = new Button();
      SuspendLayout();

      // Titulo
      lblTitulo.AutoSize = true;
      lblTitulo.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
      lblTitulo.Location = new Point(15, 15);
      lblTitulo.Text = "Gestion de Usuarios";

      // --- Columna izquierda: usuarios ---
      lblUsuarios.AutoSize = true;
      lblUsuarios.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
      lblUsuarios.Location = new Point(15, 55);
      lblUsuarios.Text = "Usuarios:";

      lstUsuarios.Font = new Font("Microsoft Sans Serif", 8.25F);
      lstUsuarios.Location = new Point(15, 75);
      lstUsuarios.Size = new Size(185, 240);
      lstUsuarios.SelectedIndexChanged += LstUsuarios_SelectedIndexChanged;

      // --- Columna central: formulario ---
      lblLegajo.AutoSize = true;
      lblLegajo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
      lblLegajo.Location = new Point(215, 55);
      lblLegajo.Text = "Legajo:";

      txtLegajo.Font = new Font("Microsoft Sans Serif", 8.25F);
      txtLegajo.Location = new Point(215, 75);
      txtLegajo.Size = new Size(215, 22);

      lblEmail.AutoSize = true;
      lblEmail.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
      lblEmail.Location = new Point(215, 115);
      lblEmail.Text = "Email:";

      txtEmail.Font = new Font("Microsoft Sans Serif", 8.25F);
      txtEmail.Location = new Point(215, 135);
      txtEmail.Size = new Size(215, 22);

      chkBloqueado.AutoSize = true;
      chkBloqueado.Font = new Font("Microsoft Sans Serif", 8.25F);
      chkBloqueado.Location = new Point(215, 175);
      chkBloqueado.Text = "Usuario bloqueado";

      btnGuardar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
      btnGuardar.Location = new Point(215, 210);
      btnGuardar.Size = new Size(105, 32);
      btnGuardar.Text = "GUARDAR";
      btnGuardar.Click += BtnGuardar_Click;

      btnNuevo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
      btnNuevo.Location = new Point(327, 210);
      btnNuevo.Size = new Size(103, 32);
      btnNuevo.Text = "NUEVO";
      btnNuevo.Click += BtnNuevo_Click;

      btnDesbloquear.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
      btnDesbloquear.Location = new Point(215, 253);
      btnDesbloquear.Size = new Size(215, 32);
      btnDesbloquear.Text = "DESBLOQUEAR";
      btnDesbloquear.Click += BtnDesbloquear_Click;

      // --- Columna derecha: asignacion de roles ---
      lblRolesDisponibles.AutoSize = true;
      lblRolesDisponibles.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
      lblRolesDisponibles.Location = new Point(450, 55);
      lblRolesDisponibles.Text = "Roles del sistema:";

      lstRoles.Font = new Font("Microsoft Sans Serif", 8.25F);
      lstRoles.Location = new Point(450, 75);
      lstRoles.Size = new Size(250, 100);

      btnAsignarRol.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
      btnAsignarRol.Location = new Point(710, 75);
      btnAsignarRol.Size = new Size(50, 45);
      btnAsignarRol.Text = "+";
      btnAsignarRol.Click += BtnAsignarRol_Click;

      btnQuitarRol.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
      btnQuitarRol.Location = new Point(710, 130);
      btnQuitarRol.Size = new Size(50, 45);
      btnQuitarRol.Text = "-";
      btnQuitarRol.Click += BtnQuitarRol_Click;

      lblRolesUsuario.AutoSize = true;
      lblRolesUsuario.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
      lblRolesUsuario.Location = new Point(450, 190);
      lblRolesUsuario.Text = "Roles y permisos del usuario seleccionado:";

      tvPermisos.Font = new Font("Microsoft Sans Serif", 8.25F);
      tvPermisos.Location = new Point(450, 210);
      tvPermisos.Size = new Size(310, 160);

      // --- Columna derecha: crear nuevo rol ---
      lblCrearRol.AutoSize = true;
      lblCrearRol.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
      lblCrearRol.Location = new Point(450, 390);
      lblCrearRol.ForeColor = SystemColors.GrayText;
      lblCrearRol.Text = "─── Crear nuevo Rol ───────────────────";

      lblNombreRol.AutoSize = true;
      lblNombreRol.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
      lblNombreRol.Location = new Point(450, 415);
      lblNombreRol.Text = "Nombre del rol:";

      txtNombreRol.Font = new Font("Microsoft Sans Serif", 8.25F);
      txtNombreRol.Location = new Point(450, 435);
      txtNombreRol.Size = new Size(250, 22);

      lblPermisos.AutoSize = true;
      lblPermisos.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
      lblPermisos.Location = new Point(450, 470);
      lblPermisos.Text = "Permisos a incluir:";

      clbPermisos.Font = new Font("Microsoft Sans Serif", 8.25F);
      clbPermisos.Location = new Point(450, 490);
      clbPermisos.Size = new Size(310, 130);
      clbPermisos.CheckOnClick = true;

      btnCrearRol.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
      btnCrearRol.Location = new Point(450, 635);
      btnCrearRol.Size = new Size(200, 32);
      btnCrearRol.Text = "CREAR ROL";
      btnCrearRol.Click += BtnCrearRol_Click;

      AutoScaleDimensions = new SizeF(6F, 13F);
      AutoScaleMode = AutoScaleMode.Font;
      Controls.Add(lblTitulo);
      Controls.Add(lblUsuarios);
      Controls.Add(lstUsuarios);
      Controls.Add(lblLegajo);
      Controls.Add(txtLegajo);
      Controls.Add(lblEmail);
      Controls.Add(txtEmail);
      Controls.Add(chkBloqueado);
      Controls.Add(btnGuardar);
      Controls.Add(btnNuevo);
      Controls.Add(btnDesbloquear);
      Controls.Add(lblRolesDisponibles);
      Controls.Add(lstRoles);
      Controls.Add(btnAsignarRol);
      Controls.Add(btnQuitarRol);
      Controls.Add(lblRolesUsuario);
      Controls.Add(tvPermisos);
      Controls.Add(lblCrearRol);
      Controls.Add(lblNombreRol);
      Controls.Add(txtNombreRol);
      Controls.Add(lblPermisos);
      Controls.Add(clbPermisos);
      Controls.Add(btnCrearRol);
      Size = new Size(790, 690);
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
    private CheckBox chkBloqueado;
    private Button btnGuardar;
    private Button btnNuevo;
    private Button btnDesbloquear;
    private Label lblRolesDisponibles;
    private ListBox lstRoles;
    private Button btnAsignarRol;
    private Button btnQuitarRol;
    private Label lblRolesUsuario;
    private TreeView tvPermisos;
    private Label lblCrearRol;
    private Label lblNombreRol;
    private TextBox txtNombreRol;
    private Label lblPermisos;
    private CheckedListBox clbPermisos;
    private Button btnCrearRol;
  }
}
