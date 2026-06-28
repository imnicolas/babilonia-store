using BLL;
using ENTITY;

namespace BABILONIA.Views
{
  // CU14: Generar backup de la base de datos XML y restaurar desde un backup previo
  // El sistema registra en la bitacora el resultado de cada operacion
  public partial class UcBackup : UserControl
  {
    private Usuario usuarioActual;
    private BackupService backupService = new BackupService();
    private BitacoraService bitacoraService = new BitacoraService();

    public UcBackup()
    {
      InitializeComponent();
    }

    public void SetUsuario(Usuario usuario)
    {
      usuarioActual = usuario;
      CargarHistorialBitacora();
    }

    private void CargarHistorialBitacora()
    {
      try
      {
        List<EventoBitacora> eventos = bitacoraService.GetAllEvents();
        dgvBitacora.DataSource = null;
        dgvBitacora.DataSource = eventos
          .Where(e => e.TipoEvento.Contains("Backup") || e.TipoEvento.Contains("Restauracion"))
          .OrderByDescending(e => e.FechaHora)
          .Select(e => new
          {
            Tipo = e.TipoEvento,
            Fecha = e.FechaHora.ToString("dd/MM/yyyy HH:mm:ss"),
            e.Legajo,
            e.Descripcion,
            e.Resultado
          })
          .ToList();
      }
      catch
      {
        // Si la bitacora aun no tiene registros, no mostrar error
      }
    }

    private void BtnGenerarBackup_Click(object sender, EventArgs e)
    {
      using SaveFileDialog sfd = new SaveFileDialog
      {
        Title = "Guardar Backup",
        Filter = "Archivos ZIP|*.zip",
        FileName = $"babilonia_backup_{DateTime.Now:yyyyMMdd_HHmmss}.zip"
      };

      if (sfd.ShowDialog() != DialogResult.OK) return;

      try
      {
        btnGenerarBackup.Enabled = false;
        lblEstado.Text = "Generando backup...";
        lblEstado.ForeColor = Color.FromArgb(0, 122, 204);
        Application.DoEvents();

        backupService.GenerateBackup(sfd.FileName, usuarioActual.Legajo);

        lblEstado.Text = "Backup generado exitosamente.";
        lblEstado.ForeColor = Color.FromArgb(40, 167, 69);
        MessageBox.Show($"Backup creado en:\n{sfd.FileName}", "Backup Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        CargarHistorialBitacora();
      }
      catch (Exception ex)
      {
        lblEstado.Text = "Error al generar backup.";
        lblEstado.ForeColor = Color.FromArgb(220, 53, 69);
        MessageBox.Show("Error al generar backup: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      finally
      {
        btnGenerarBackup.Enabled = true;
      }
    }

    private void BtnRestaurar_Click(object sender, EventArgs e)
    {
      DialogResult confirmacion = MessageBox.Show(
        "ADVERTENCIA: Esta accion reemplazara TODOS los datos actuales con los del backup seleccionado.\n¿Desea continuar?",
        "Confirmar Restauracion",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning);

      if (confirmacion != DialogResult.Yes) return;

      using OpenFileDialog ofd = new OpenFileDialog
      {
        Title = "Seleccionar Backup a Restaurar",
        Filter = "Archivos ZIP|*.zip"
      };

      if (ofd.ShowDialog() != DialogResult.OK) return;

      try
      {
        btnRestaurar.Enabled = false;
        lblEstado.Text = "Restaurando backup...";
        lblEstado.ForeColor = Color.FromArgb(0, 122, 204);
        Application.DoEvents();

        backupService.RestoreBackup(ofd.FileName, usuarioActual.Legajo);

        lblEstado.Text = "Restauracion completada exitosamente.";
        lblEstado.ForeColor = Color.FromArgb(40, 167, 69);
        MessageBox.Show("Restauracion completada. Reinicie la aplicacion para aplicar todos los cambios.", "Restauracion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        CargarHistorialBitacora();
      }
      catch (Exception ex)
      {
        lblEstado.Text = "Error al restaurar backup.";
        lblEstado.ForeColor = Color.FromArgb(220, 53, 69);
        MessageBox.Show("Error al restaurar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      finally
      {
        btnRestaurar.Enabled = true;
      }
    }
  }
}
