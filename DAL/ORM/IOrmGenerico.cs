namespace DAL.ORM
{
  public interface IOrmGenerico<T> where T : class
  {
    int ObtenerSiguienteId();
    List<T> ObtenerTodos();
    T ObtenerPorId(int id);
    void Insertar(T entidad);
    void Actualizar(T entidad);
    void Eliminar(int id);
  }
}
