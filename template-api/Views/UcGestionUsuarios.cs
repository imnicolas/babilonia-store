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
      int? idActual = usuarioSeleccionado?.Id;

      listaUsuarios = usuarioService.GetAllUsuarios();
      listaRoles = rolService.GetAllRoles();
      listaPermisos = permisoService.GetAllPermisos();

      lstUsuarios.DataSource = null;
      lstUsuarios.DataSource = listaUsuarios;
      lstUsuarios.DisplayMember = "Legajo";

      lstRoles.DataSource = null;
      lstRoles.DataSource = new List<Rol>(listaRoles);
      lstRoles.DisplayMember = "NombreRol";

      clbPermisos.Items.Clear();
      foreach (Permiso p in listaPermisos)
        clbPermisos.Items.Add(p.Nombre);

      // Re-seleccionar el usuario anterior si corresponde
      if (idActual.HasValue)
      {
        int idx = listaUsuarios.FindIndex(u => u.Id == idActual.Value);
        if (idx >= 0)
        {
          lstUsuarios.SelectedIndex = idx;
          return;
        }
      }

      tvPermisos.Nodes.Clear();
    }

    // Visualizacion del arbol de permisos del usuario seleccionado (patron Composite)
    private void CargarArbolPermisos()
    {
      tvPermisos.Nodes.Clear();
      if (usuarioSeleccionado == null) return;

      foreach (ComponenteAcceso comp in usuarioSeleccionado.Permisos)
      {
        if (comp is Rol r)
        {
          TreeNode nodoRol = new TreeNode(r.NombreRol);
          nodoRol.Tag = r;
          foreach (ComponenteAcceso hijo in r.ObtenerHijos())
          {
            TreeNode nodoP = new TreeNode(hijo.Nombre);
            nodoP.Tag = hijo;
            nodoRol.Nodes.Add(nodoP);
          }
          tvPermisos.Nodes.Add(nodoRol);
        }
        else if (comp is Permiso p)
        {
          TreeNode nodoP = new TreeNode(p.Nombre);
          nodoP.Tag = p;
          tvPermisos.Nodes.Add(nodoP);
        }
      }

      tvPermisos.ExpandAll();
    }

    private void LstUsuarios_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (lstUsuarios.SelectedItem is not Usuario u) return;
      usuarioSeleccionado = u;
      txtLegajo.Text = u.Legajo;
      txtEmail.Text = u.Email;
      chkBloqueado.Checked = u.Bloqueado;
      CargarArbolPermisos();
    }

    // Asignar el rol seleccionado en lstRoles al usuario seleccionado
    private void BtnAsignarRol_Click(object sender, EventArgs e)
    {
      if (usuarioSeleccionado == null)
      {
        MessageBox.Show("Seleccione un usuario de la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }
      if (lstRoles.SelectedItem is not Rol rolSeleccionado)
      {
        MessageBox.Show("Seleccione un rol de la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      bool yaLoTiene = usuarioSeleccionado.Permisos.OfType<Rol>().Any(r => r.Id == rolSeleccionado.Id);
      if (yaLoTiene)
      {
        MessageBox.Show($"El usuario ya tiene el rol '{rolSeleccionado.NombreRol}'.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      try
      {
        usuarioSeleccionado.Permisos.Add(rolSeleccionado);
        usuarioService.UpdateUsuario(usuarioSeleccionado);
        CargarDatos();
      }
      catch (Exception ex)
      {
        MessageBox.Show("Error al asignar rol: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    // Quitar el rol seleccionado en lstRoles del usuario seleccionado
    private void BtnQuitarRol_Click(object sender, EventArgs e)
    {
      if (usuarioSeleccionado == null)
      {
        MessageBox.Show("Seleccione un usuario de la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }
      if (lstRoles.SelectedItem is not Rol rolSeleccionado)
      {
        MessageBox.Show("Seleccione el rol a quitar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      int removidos = usuarioSeleccionado.Permisos.RemoveAll(p => p is Rol r && r.Id == rolSeleccionado.Id);
      if (removidos == 0)
      {
        MessageBox.Show($"El usuario no tiene el rol '{rolSeleccionado.NombreRol}'.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      try
      {
        usuarioService.UpdateUsuario(usuarioSeleccionado);
        CargarDatos();
      }
      catch (Exception ex)
      {
        MessageBox.Show("Error al quitar rol: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    // Crear un nuevo Rol con los permisos marcados en clbPermisos
    private void BtnCrearRol_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrWhiteSpace(txtNombreRol.Text))
      {
        MessageBox.Show("Ingrese el nombre del rol.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }
      if (clbPermisos.CheckedItems.Count == 0)
      {
        MessageBox.Show("Seleccione al menos un permiso para el rol.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      try
      {
        Rol nuevoRol = new Rol { NombreRol = txtNombreRol.Text.Trim() };

        foreach (string nombrePermiso in clbPermisos.CheckedItems.Cast<string>())
        {
          Permiso p = listaPermisos.FirstOrDefault(x => x.Nombre == nombrePermiso);
          if (p != null) nuevoRol.Agregar(p);
        }

        rolService.CreateRol(nuevoRol);
        MessageBox.Show($"Rol '{nuevoRol.NombreRol}' creado exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        txtNombreRol.Clear();
        for (int i = 0; i < clbPermisos.Items.Count; i++)
          clbPermisos.SetItemChecked(i, false);

        CargarDatos();
      }
      catch (Exception ex)
      {
        MessageBox.Show("Error al crear rol: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
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
          // Nuevo usuario: se crea con el rol seleccionado en lstRoles (si hay uno)
          Usuario nuevo = new Usuario
          {
            Legajo = txtLegajo.Text.Trim(),
            Email = txtEmail.Text.Trim(),
            Permisos = new List<ComponenteAcceso>(),
            Bloqueado = false
          };

          if (lstRoles.SelectedItem is Rol rolInicial)
            nuevo.Permisos.Add(rolInicial);

          usuarioService.RegisterUsuario(nuevo, "1234");
          MessageBox.Show("Usuario creado con contraseña por defecto '1234'.\nUse los botones + / - para asignar o quitar roles.",
            "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
          // Actualizar datos del usuario (email y estado de bloqueo)
          usuarioSeleccionado.Email = txtEmail.Text.Trim();
          usuarioSeleccionado.Bloqueado = chkBloqueado.Checked;
          if (!usuarioSeleccionado.Bloqueado)
            usuarioSeleccionado.IntentosFallidos = 0;

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
      txtLegajo.ReadOnly = false;
      txtLegajo.Clear();
      txtEmail.Clear();
      chkBloqueado.Checked = false;
      tvPermisos.Nodes.Clear();
    }
  }
}
