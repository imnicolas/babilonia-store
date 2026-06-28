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
      panelHeader = new Panel();
      lblTitulo = new Label();
      lblSubtitulo = new Label();
      lblLegajo = new Label();
      txtLegajo = new TextBox();
      lblContraseña = new Label();
      txtContraseña = new TextBox();
      btnMostrarOcultar = new Button();
      btnIngresar = new Button();
      panelHeader.SuspendLayout();
      SuspendLayout();

      panelHeader.BackColor = Color.FromArgb(30, 30, 60);
      panelHeader.Controls.Add(lblTitulo);
      panelHeader.Controls.Add(lblSubtitulo);
      panelHeader.Dock = DockStyle.Top;
      panelHeader.Size = new Size(440, 110);
      panelHeader.TabIndex = 0;

      lblTitulo.AutoSize = true;
      lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
      lblTitulo.ForeColor = Color.White;
      lblTitulo.Location = new Point(35, 18);
      lblTitulo.Text = "Babilonia Calzados";

      lblSubtitulo.AutoSize = true;
      lblSubtitulo.Font = new Font("Segoe UI", 10F);
      lblSubtitulo.ForeColor = Color.LightGray;
      lblSubtitulo.Location = new Point(90, 68);
      lblSubtitulo.Text = "Gestion de Calzado y Ventas";

      lblLegajo.AutoSize = true;
      lblLegajo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
      lblLegajo.Location = new Point(70, 140);
      lblLegajo.Text = "Legajo:";

      txtLegajo.Font = new Font("Segoe UI", 12F);
      txtLegajo.Location = new Point(70, 162);
      txtLegajo.Size = new Size(300, 29);
      txtLegajo.TabIndex = 1;

      lblContraseña.AutoSize = true;
      lblContraseña.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
      lblContraseña.Location = new Point(70, 205);
      lblContraseña.Text = "Contraseña:";

      txtContraseña.Font = new Font("Segoe UI", 12F);
      txtContraseña.Location = new Point(70, 227);
      txtContraseña.PasswordChar = '•';
      txtContraseña.Size = new Size(258, 29);
      txtContraseña.TabIndex = 2;

      btnMostrarOcultar.Cursor = Cursors.Hand;
      btnMostrarOcultar.FlatStyle = FlatStyle.Flat;
      btnMostrarOcultar.Location = new Point(333, 227);
      btnMostrarOcultar.Size = new Size(37, 29);
      btnMostrarOcultar.Text = "👁";
      btnMostrarOcultar.TabIndex = 3;
      btnMostrarOcultar.Click += BtnMostrarOcultar_Click;

      btnIngresar.BackColor = Color.FromArgb(0, 122, 204);
      btnIngresar.Cursor = Cursors.Hand;
      btnIngresar.FlatAppearance.BorderSize = 0;
      btnIngresar.FlatStyle = FlatStyle.Flat;
      btnIngresar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
      btnIngresar.ForeColor = Color.White;
      btnIngresar.Location = new Point(70, 285);
      btnIngresar.Size = new Size(300, 45);
      btnIngresar.TabIndex = 4;
      btnIngresar.Text = "INGRESAR";
      btnIngresar.UseVisualStyleBackColor = false;
      btnIngresar.Click += BtnIngresar_Click;

      AcceptButton = btnIngresar;
      AutoScaleDimensions = new SizeF(7F, 17F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = Color.White;
      ClientSize = new Size(440, 380);
      Controls.Add(btnIngresar);
      Controls.Add(btnMostrarOcultar);
      Controls.Add(txtContraseña);
      Controls.Add(lblContraseña);
      Controls.Add(txtLegajo);
      Controls.Add(lblLegajo);
      Controls.Add(panelHeader);
      Font = new Font("Segoe UI", 10F);
      FormBorderStyle = FormBorderStyle.FixedSingle;
      MaximizeBox = false;
      StartPosition = FormStartPosition.CenterScreen;
      Text = "Babilonia Calzados - Acceso";
      panelHeader.ResumeLayout(false);
      panelHeader.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
    }

    private Panel panelHeader;
    private Label lblTitulo;
    private Label lblSubtitulo;
    private Label lblLegajo;
    private TextBox txtLegajo;
    private Label lblContraseña;
    private TextBox txtContraseña;
    private Button btnMostrarOcultar;
    private Button btnIngresar;
  }
}
