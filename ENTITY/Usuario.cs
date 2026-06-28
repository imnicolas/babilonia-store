namespace ENTITY
{
  public class Usuario
  {
    public int Id { get; set; }
    public string Legajo { get; set; }
    public string Email { get; set; }
    public string ContraseñaHash { get; set; }
    public int IdRol { get; set; }

    public bool Bloqueado { get; set; }
    public int IntentosFallidos { get; set; }
    public bool RequiereCambioContraseña { get; set; }
    public DateTime? FechaUltimoCambioContraseña { get; set; }
    public List<string> HistorialContraseñas { get; set; } = new List<string>();

    // Composite: mix de Roles y Permisos directos
    public List<ComponenteAcceso> Permisos { get; set; } = new List<ComponenteAcceso>();
  }
}
