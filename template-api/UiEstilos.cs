namespace BABILONIA
{
  public static class UiEstilos
  {
    public static readonly Color ColorEncabezado = Color.FromArgb(30, 30, 60);
    public static readonly Color ColorMenuLateral = Color.FromArgb(45, 45, 90);
    public static readonly Color ColorPrimario = Color.FromArgb(0, 122, 204);
    public static readonly Color ColorExito = Color.FromArgb(40, 167, 69);
    public static readonly Color ColorPeligro = Color.FromArgb(220, 53, 69);
    public static readonly Color ColorFondo = Color.White;
    public static readonly Color ColorTituloModulo = Color.FromArgb(30, 30, 60);
    public static readonly Color ColorTextoSecundario = Color.LightGray;

    public static readonly Font FuenteBase = new Font("Segoe UI", 10F);
    public static readonly Font FuenteTituloModulo = new Font("Segoe UI", 18F, FontStyle.Bold);
    public static readonly Font FuenteTituloLogin = new Font("Segoe UI", 22F, FontStyle.Bold);
    public static readonly Font FuenteEtiqueta = new Font("Segoe UI", 10F, FontStyle.Bold);
    public static readonly Font FuenteBoton = new Font("Segoe UI", 10F, FontStyle.Bold);
    public static readonly Font FuenteBotonLogin = new Font("Segoe UI", 12F, FontStyle.Bold);

    public static void AplicarBotonPrimario(Button button)
    {
      button.BackColor = ColorPrimario;
      button.ForeColor = Color.White;
      button.FlatStyle = FlatStyle.Flat;
      button.FlatAppearance.BorderSize = 0;
      button.Cursor = Cursors.Hand;
      button.Font = FuenteBoton;
      button.UseVisualStyleBackColor = false;
    }

    public static void AplicarBotonExito(Button button)
    {
      button.BackColor = ColorExito;
      button.ForeColor = Color.White;
      button.FlatStyle = FlatStyle.Flat;
      button.FlatAppearance.BorderSize = 0;
      button.Cursor = Cursors.Hand;
      button.Font = FuenteBoton;
      button.UseVisualStyleBackColor = false;
    }

    public static void AplicarBotonPeligro(Button button)
    {
      button.BackColor = ColorPeligro;
      button.ForeColor = Color.White;
      button.FlatStyle = FlatStyle.Flat;
      button.FlatAppearance.BorderSize = 0;
      button.Cursor = Cursors.Hand;
      button.Font = FuenteBoton;
      button.UseVisualStyleBackColor = false;
    }

    public static void AplicarBotonSecundario(Button button)
    {
      button.BackColor = ColorEncabezado;
      button.ForeColor = Color.White;
      button.FlatStyle = FlatStyle.Flat;
      button.FlatAppearance.BorderSize = 0;
      button.Cursor = Cursors.Hand;
      button.Font = FuenteBoton;
      button.UseVisualStyleBackColor = false;
    }

    public static void AplicarBotonMenuLateral(Button button)
    {
      button.FlatStyle = FlatStyle.Flat;
      button.FlatAppearance.BorderSize = 0;
      button.ForeColor = Color.White;
      button.TextAlign = ContentAlignment.MiddleLeft;
      button.UseVisualStyleBackColor = true;
      button.Cursor = Cursors.Hand;
      button.Font = FuenteBase;
    }

    public static void AplicarEtiquetaCampo(Label label)
    {
      label.Font = FuenteEtiqueta;
    }

    public static void AplicarTituloModulo(Label label)
    {
      label.Font = FuenteTituloModulo;
      label.ForeColor = ColorTituloModulo;
    }
  }
}
