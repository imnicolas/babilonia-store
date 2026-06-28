namespace BABILONIA
{
  partial class Form1
  {
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null)) components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      grpAcceso = new GroupBox();
      lblLegajo = new Label();
      txtLegajo = new TextBox();
      lblContraseña = new Label();
      txtContraseña = new TextBox();
      chkMostrar = new CheckBox();
      btnIngresar = new Button();
      lblTitulo = new Label();
      grpAcceso.SuspendLayout();
      SuspendLayout();

      lblTitulo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
      lblTitulo.Location = new Point(12, 12);
      lblTitulo.Size = new Size(358, 28);
      lblTitulo.Text = "Babilonia Calzados";
      lblTitulo.TextAlign = ContentAlignment.MiddleCenter;

      grpAcceso.Location = new Point(12, 48);
      grpAcceso.Size = new Size(358, 170);
      grpAcceso.Text = "Ingreso al sistema";
      grpAcceso.Controls.Add(lblLegajo);
      grpAcceso.Controls.Add(txtLegajo);
      grpAcceso.Controls.Add(lblContraseña);
      grpAcceso.Controls.Add(txtContraseña);
      grpAcceso.Controls.Add(chkMostrar);

      lblLegajo.AutoSize = true;
      lblLegajo.Location = new Point(16, 30);
      lblLegajo.Text = "Legajo:";

      txtLegajo.Location = new Point(16, 48);
      txtLegajo.Size = new Size(320, 20);
      txtLegajo.TabIndex = 1;

      lblContraseña.AutoSize = true;
      lblContraseña.Location = new Point(16, 82);
      lblContraseña.Text = "Contraseña:";

      txtContraseña.Location = new Point(16, 100);
      txtContraseña.PasswordChar = '*';
      txtContraseña.Size = new Size(320, 20);
      txtContraseña.TabIndex = 2;

      chkMostrar.AutoSize = true;
      chkMostrar.Location = new Point(16, 132);
      chkMostrar.TabIndex = 3;
      chkMostrar.Text = "Mostrar contraseña";
      chkMostrar.CheckedChanged += ChkMostrar_CheckedChanged;

      btnIngresar.Location = new Point(12, 232);
      btnIngresar.Size = new Size(358, 28);
      btnIngresar.TabIndex = 4;
      btnIngresar.Text = "Ingresar";
      btnIngresar.Click += BtnIngresar_Click;

      AcceptButton = btnIngresar;
      AutoScaleDimensions = new SizeF(6F, 13F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(382, 272);
      Controls.Add(lblTitulo);
      Controls.Add(grpAcceso);
      Controls.Add(btnIngresar);
      Font = new Font("Microsoft Sans Serif", 8.25F);
      FormBorderStyle = FormBorderStyle.FixedDialog;
      MaximizeBox = false;
      StartPosition = FormStartPosition.CenterScreen;
      Text = "Babilonia Calzados - Acceso";
      grpAcceso.ResumeLayout(false);
      grpAcceso.PerformLayout();
      ResumeLayout(false);
    }

    private GroupBox grpAcceso;
    private Label lblTitulo;
    private Label lblLegajo;
    private TextBox txtLegajo;
    private Label lblContraseña;
    private TextBox txtContraseña;
    private CheckBox chkMostrar;
    private Button btnIngresar;
  }
}
