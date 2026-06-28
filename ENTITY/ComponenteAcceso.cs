namespace ENTITY
{
  // Componente abstracto del patron Composite para Roles y Permisos
  public abstract class ComponenteAcceso
  {
    public int Id { get; set; }
    public string Nombre { get; set; }

    public virtual void Agregar(ComponenteAcceso componente)
    {
      throw new NotImplementedException();
    }

    public virtual void Quitar(ComponenteAcceso componente)
    {
      throw new NotImplementedException();
    }

    public virtual List<ComponenteAcceso> ObtenerHijos()
    {
      return new List<ComponenteAcceso>();
    }
  }
}
