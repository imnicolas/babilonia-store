using DAL.ORM;
using ENTITY;

namespace DAL
{
  public class ProductoDao
  {
    private ProductoOrm orm = new ProductoOrm();

    public List<Producto> GetAllProductos()
    {
      try { return orm.ObtenerTodos(); }
      catch (Exception ex) { throw new Exception("Error al obtener productos: " + ex.Message); }
    }

    public Producto GetProductoById(int id)
    {
      try { return orm.ObtenerPorId(id); }
      catch (Exception ex) { throw new Exception("Error al obtener producto: " + ex.Message); }
    }

    public void CreateProducto(Producto producto)
    {
      try { orm.Insertar(producto); }
      catch (Exception ex) { throw new Exception("Error al crear producto: " + ex.Message); }
    }

    public void UpdateProducto(Producto producto)
    {
      try { orm.Actualizar(producto); }
      catch (Exception ex) { throw new Exception("Error al actualizar producto: " + ex.Message); }
    }

    public void DeleteProducto(int id)
    {
      try { orm.Eliminar(id); }
      catch (Exception ex) { throw new Exception("Error al eliminar producto: " + ex.Message); }
    }
  }
}
