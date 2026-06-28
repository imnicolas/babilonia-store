namespace BABILONIA
{
  partial class CambioContraseñaForm
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
      lblActual = new Label();
      txtActual = new TextBox();
      lblNueva = new Label();
      txtNueva = new TextBox();
      lblConfirmar = new Label();
      txtConfirmar = new TextBox();
      btnCambiar = new Button();
      SuspendLayout();

      lblTitulo.AutoSize = true;
      lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
      lblTitulo.ForeColor = Color.FromArgb(30, 30, 60);
      lblTitulo.Location = new Point(80, 20);
      lblTitulo.Text = "Cambio de Contraseña";

      lblActual.AutoSize = true;
      lblActual.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
      lblActual.Location = new Point(40, 70);
      lblActual.Text = "Contraseña actual:";

      txtActual.Font = new Font("Segoe UI", 11F);
      txtActual.Location = new Point(40, 92);
      txtActual.PasswordChar = '•';
      txtActual.Size = new Size(300, 27);
      txtActual.TabIndex = 1;

      lblNueva.AutoSize = true;
      lblNueva.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
      lblNueva.Location = new Point(40, 135);
      lblNueva.Text = "Nueva contraseña:";

      txtNueva.Font = new Font("Segoe UI", 11F);
      txtNueva.Location = new Point(40, 157);
      txtNueva.PasswordChar = '•';
      txtNueva.Size = new Size(300, 27);
      txtNueva.TabIndex = 2;

      lblConfirmar.AutoSize = true;
      lblConfirmar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
      lblConfirmar.Location = new Point(40, 200);
      lblConfirmar.Text = "Confirmar nueva contraseña:";

      txtConfirmar.Font = new Font("Segoe UI", 11F);
      txtConfirmar.Location = new Point(40, 222);
      txtConfirmar.PasswordChar = '•';
      txtConfirmar.Size = new Size(300, 27);
      txtConfirmar.TabIndex = 3;

      btnCambiar.BackColor = Color.FromArgb(0, 122, 204);
      btnCambiar.FlatAppearance.BorderSize = 0;
      btnCambiar.FlatStyle = FlatStyle.Flat;
      btnCambiar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
      btnCambiar.ForeColor = Color.White;
      btnCambiar.Location = new Point(40, 275);
      btnCambiar.Size = new Size(300, 40);
      btnCambiar.TabIndex = 4;
      btnCambiar.Text = "CAMBIAR CONTRASEÑA";
      btnCambiar.UseVisualStyleBackColor = false;
      btnCambiar.Click += BtnCambiar_Click;

      AutoScaleDimensions = new SizeF(7F, 17F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = Color.White;
      ClientSize = new Size(380, 345);
      Controls.Add(lblTitulo);
      Controls.Add(lblActual);
      Controls.Add(txtActual);
      Controls.Add(lblNueva);
      Controls.Add(txtNueva);
      Controls.Add(lblConfirmar);
      Controls.Add(txtConfirmar);
      Controls.Add(btnCambiar);
      Font = new Font("Segoe UI", 10F);
      FormBorderStyle = FormBorderStyle.FixedDialog;
      MaximizeBox = false;
      MinimizeBox = false;
      StartPosition = FormStartPosition.CenterParent;
      Text = "Cambiar Contraseña";
      ResumeLayout(false);
      PerformLayout();
    }

    private Label lblTitulo;
    private Label lblActual;
    private TextBox txtActual;
    private Label lblNueva;
    private TextBox txtNueva;
    private Label lblConfirmar;
    private TextBox txtConfirmar;
    private Button btnCambiar;
  }
}
