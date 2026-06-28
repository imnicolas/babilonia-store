using BABILONIA.Views;
using ENTITY;

namespace BABILONIA
{
  // MenuStrip cuyos items se habilitan/deshabilitan segun el Composite de Permisos del usuario
  public partial class DashboardForm : Form
  {
    private Usuario usuarioActual;
    private Form1 formLogin;

    public DashboardForm(Usuario usuario, Form1 loginForm)
    {
      InitializeComponent();
      usuarioActual = usuario;
      formLogin = loginForm;

      string roles = string.Join(", ", usuario.Permisos.OfType<Rol>().Select(r => r.Nombre));
      lblUsuario.Text = $"Usuario: {usuario.Legajo}  |  Rol: {(string.IsNullOrEmpty(roles) ? "Sin rol asignado" : roles)}";

      CargarMenuPorPermisos();
      CargarVistaPorDefecto();
    }

    private void CargarMenuPorPermisos()
    {
      List<string> permisos;
      try
      {
        permisos = ObtenerTodosLosPermisos();
      }
      catch (Exception ex)
      {
        lblUsuario.Text += $"  [Error permisos: {ex.Message}]";
        return;
      }

      lblUsuario.Text += $"  [{permisos.Count} permisos]";

      // Paso 1: ocultar todos los subitems (igual que VALHALLA oculta todos los botones primero)
      foreach (ToolStripMenuItem topItem in menuPrincipal.Items.OfType<ToolStripMenuItem>())
        foreach (ToolStripMenuItem sub in topItem.DropDownItems.OfType<ToolStripMenuItem>())
          sub.Visible = false;

      // Paso 2: mostrar los subitems que coinciden con permisos del usuario
      foreach (string permiso in permisos)
        foreach (ToolStripMenuItem topItem in menuPrincipal.Items.OfType<ToolStripMenuItem>())
          foreach (ToolStripMenuItem sub in topItem.DropDownItems.OfType<ToolStripMenuItem>())
            if (sub.Tag is string tag && tag == permiso)
              sub.Visible = true;

      // Paso 3: items sin Tag siempre visibles (ej: Cerrar Sesion)
      foreach (ToolStripMenuItem topItem in menuPrincipal.Items.OfType<ToolStripMenuItem>())
        foreach (ToolStripMenuItem sub in topItem.DropDownItems.OfType<ToolStripMenuItem>())
          if (!(sub.Tag is string))
            sub.Visible = true;

      // Paso 4: ocultar item de nivel superior si no tiene ningun subitem visible
      foreach (ToolStripMenuItem topItem in menuPrincipal.Items.OfType<ToolStripMenuItem>())
        topItem.Visible = topItem.DropDownItems.OfType<ToolStripMenuItem>().Any(s => s.Visible);
    }

    // Recorre el Composite para obtener todos los permisos (directos y los heredados de Roles)
    private List<string> ObtenerTodosLosPermisos()
    {
      List<string> lista = new List<string>();
      if (usuarioActual.Permisos == null) return lista;
      foreach (ComponenteAcceso comp in usuarioActual.Permisos)
      {
        if (comp is Permiso p)
          lista.Add(p.Nombre);
        else if (comp is Rol r)
          foreach (ComponenteAcceso hijo in r.ObtenerHijos())
            if (!string.IsNullOrEmpty(hijo.Nombre))
              lista.Add(hijo.Nombre);
      }
      return lista.Distinct().ToList();
    }

    private void CargarVistaPorDefecto()
    {
      List<string> permisos = ObtenerTodosLosPermisos();
      if (permisos.Contains("Dashboard"))
      {
        UcDashboard uc = new UcDashboard();
        uc.SetUsuario(usuarioActual);
        CargarVista(uc);
      }
    }

    private void CargarVista(UserControl vista)
    {
      panelContenido.Controls.Clear();
      vista.Dock = DockStyle.Fill;
      panelContenido.Controls.Add(vista);
    }

    private void Menu_NuevaVenta_Click(object sender, EventArgs e)
    {
      UcNuevaVenta uc = new UcNuevaVenta();
      uc.SetUsuario(usuarioActual);
      CargarVista(uc);
    }

    private void Menu_PostVenta_Click(object sender, EventArgs e)
    {
      UcPostVenta uc = new UcPostVenta();
      uc.SetUsuario(usuarioActual);
      CargarVista(uc);
    }

    private void Menu_Cupones_Click(object sender, EventArgs e)
    {
      UcCupones uc = new UcCupones();
      uc.SetUsuario(usuarioActual);
      CargarVista(uc);
    }

    private void Menu_PedidoCompra_Click(object sender, EventArgs e)
    {
      UcPedidoCompra uc = new UcPedidoCompra();
      uc.SetUsuario(usuarioActual);
      CargarVista(uc);
    }

    private void Menu_RecepcionMercaderia_Click(object sender, EventArgs e)
    {
      UcRecepcionMercaderia uc = new UcRecepcionMercaderia();
      uc.SetUsuario(usuarioActual);
      CargarVista(uc);
    }

    private void Menu_Pagos_Click(object sender, EventArgs e)
    {
      UcPagos uc = new UcPagos();
      uc.SetUsuario(usuarioActual);
      CargarVista(uc);
    }

    private void Menu_Conciliacion_Click(object sender, EventArgs e)
    {
      UcConciliacion uc = new UcConciliacion();
      uc.SetUsuario(usuarioActual);
      CargarVista(uc);
    }

    private void Menu_AjusteStock_Click(object sender, EventArgs e)
    {
      UcAjusteStock uc = new UcAjusteStock();
      uc.SetUsuario(usuarioActual);
      CargarVista(uc);
    }

    private void Menu_Dashboard_Click(object sender, EventArgs e)
    {
      UcDashboard uc = new UcDashboard();
      uc.SetUsuario(usuarioActual);
      CargarVista(uc);
    }

    private void Menu_Usuarios_Click(object sender, EventArgs e)
    {
      UcGestionUsuarios uc = new UcGestionUsuarios();
      uc.SetUsuario(usuarioActual);
      CargarVista(uc);
    }

    private void Menu_Backup_Click(object sender, EventArgs e)
    {
      UcBackup uc = new UcBackup();
      uc.SetUsuario(usuarioActual);
      CargarVista(uc);
    }

    private void Menu_CerrarSesion_Click(object sender, EventArgs e)
    {
      DialogResult dr = MessageBox.Show("¿Desea cambiar de usuario?", "Cerrar Sesion",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

      if (dr == DialogResult.Yes)
      {
        formLogin.Show();
        Close();
      }
      else
      {
        Application.Exit();
      }
    }

    protected override void OnFormClosed(FormClosedEventArgs e)
    {
      base.OnFormClosed(e);
      if (!formLogin.Visible) Application.Exit();
    }
  }
}
