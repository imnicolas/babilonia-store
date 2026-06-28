namespace ENTITY
{
  // Composite: un Rol agrupa multiples ComponenteAcceso (Permisos u otros Roles)
  public class Rol : ComponenteAcceso
  {
    public string NombreRol
    {
      get => Nombre;
      set => Nombre = value;
    }

    private List<ComponenteAcceso> hijos = new List<ComponenteAcceso>();

    public override void Agregar(ComponenteAcceso componente)
    {
      hijos.Add(componente);
    }

    public override void Quitar(ComponenteAcceso componente)
    {
      hijos.Remove(componente);
    }

    public override List<ComponenteAcceso> ObtenerHijos()
    {
      return hijos;
    }
  }
}
