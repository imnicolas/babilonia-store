using BLL;
using ENTITY;

namespace BABILONIA.Views
{
  // CU13: Gestionar usuarios del sistema con asignacion de roles y permisos (patron Composite)
  public partial class UcGestionUsuarios : UserControl
  {
    private Usuario usuarioActual;
    private UsuarioService usuarioService = new UsuarioService();
    private RolService rolService = new RolService();
    private PermisoService permisoService = new PermisoService();
    private List<Usuario> listaUsuarios = new List<Usuario>();
    private List<Rol> listaRoles = new List<Rol>();
    private List<Permiso> listaPermisos = new List<Permiso>();
    private Usuario? usuarioSeleccionado = null;

    public UcGestionUsuarios()
    {
      InitializeComponent();
    }

    public void SetUsuario(Usuario usuario)
    {
      usuarioActual = usuario;
      CargarDatos();
    }

    private void CargarDatos()
    {
      listaUsuarios = usuarioService.GetAllUsuarios();
      listaRoles = rolService.GetAllRoles();
      listaPermisos = permisoService.GetAllPermisos();

      lstUsuarios.DataSource = null;
      lstUsuarios.DataSource = listaUsuarios;
      lstUsuarios.DisplayMember = "Legajo";

      cmbRol.DataSource = null;
      cmbRol.DataSource = listaRoles;
      cmbRol.DisplayMember = "NombreRol";

      CargarArbolPermisos();
    }

    // Visualizacion del arbol de permisos usando patron Composite
    private void CargarArbolPermisos()
    {
      tvPermisos.Nodes.Clear();

      foreach (Rol rol in listaRoles)
      {
        TreeNode nodoRol = new TreeNode(rol.NombreRol);
        nodoRol.Tag = rol;
        foreach (ComponenteAcceso hijo in rol.ObtenerHijos())
        {
          TreeNode nodoPermiso = new TreeNode(hijo.Nombre);
          nodoPermiso.Tag = hijo;
          nodoRol.Nodes.Add(nodoPermiso);
        }
        tvPermisos.Nodes.Add(nodoRol);
      }
      tvPermisos.ExpandAll();
    }

    private void LstUsuarios_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (lstUsuarios.SelectedItem is not Usuario u) return;
      usuarioSeleccionado = u;
      txtLegajo.Text = u.Legajo;
      txtEmail.Text = u.Email;

      // Marcar el rol asignado en el combo
      Rol? rolAsignado = listaRoles.FirstOrDefault(r => u.Permisos.OfType<Rol>().Any(ur => ur.NombreRol == r.NombreRol));
      if (rolAsignado != null)
        cmbRol.SelectedItem = rolAsignado;

      chkBloqueado.Checked = u.Bloqueado;
    }

    private void BtnGuardar_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrWhiteSpace(txtLegajo.Text))
      {
        MessageBox.Show("Ingrese el legajo del usuario.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      try
      {
        if (usuarioSeleccionado == null)
        {
          // Nuevo usuario
          Usuario nuevo = new Usuario
          {
            Legajo = txtLegajo.Text.Trim(),
            Email = txtEmail.Text.Trim(),
            Permisos = new List<ComponenteAcceso>(),
            Bloqueado = false
          };

          if (cmbRol.SelectedItem is Rol rolSeleccionado)
            nuevo.Permisos.Add(rolSeleccionado);

          usuarioService.RegisterUsuario(nuevo, "1234");
          MessageBox.Show("Usuario creado con contraseña por defecto '1234'.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
          // Actualizar usuario existente
          usuarioSeleccionado.Email = txtEmail.Text.Trim();
          usuarioSeleccionado.Bloqueado = chkBloqueado.Checked;
          usuarioSeleccionado.IntentosFallidos = usuarioSeleccionado.Bloqueado ? usuarioSeleccionado.IntentosFallidos : 0;

          if (cmbRol.SelectedItem is Rol rolSeleccionado)
          {
            usuarioSeleccionado.Permisos.RemoveAll(p => p is Rol);
            usuarioSeleccionado.Permisos.Insert(0, rolSeleccionado);
          }

          usuarioService.UpdateUsuario(usuarioSeleccionado);
          MessageBox.Show("Usuario actualizado correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        LimpiarFormulario();
        CargarDatos();
      }
      catch (Exception ex)
      {
        MessageBox.Show("Error al guardar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void BtnNuevo_Click(object sender, EventArgs e)
    {
      LimpiarFormulario();
    }

    private void BtnDesbloquear_Click(object sender, EventArgs e)
    {
      if (usuarioSeleccionado == null)
      {
        MessageBox.Show("Seleccione un usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }
      try
      {
        usuarioSeleccionado.Bloqueado = false;
        usuarioSeleccionado.IntentosFallidos = 0;
        usuarioService.UpdateUsuario(usuarioSeleccionado);
        MessageBox.Show("Usuario desbloqueado.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        CargarDatos();
      }
      catch (Exception ex)
      {
        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void LimpiarFormulario()
    {
      usuarioSeleccionado = null;
      txtLegajo.Clear();
      txtEmail.Clear();
      chkBloqueado.Checked = false;
      txtLegajo.ReadOnly = false;
    }
  }
}
