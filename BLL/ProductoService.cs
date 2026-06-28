using DAL;
using ENTITY;

namespace BLL
{
  public class ProductoService
  {
    private ProductoDao productoDao = new ProductoDao();

    public List<Producto> GetAllProductos() => productoDao.GetAllProductos();

    public Producto GetProductoById(int id) => productoDao.GetProductoById(id);

    public List<Producto> GetProductosBajoStock()
    {
      return productoDao.GetAllProductos()
        .Where(p => p.Stock <= p.StockMinimo)
        .ToList();
    }

    public void CreateProducto(Producto producto)
    {
      if (string.IsNullOrWhiteSpace(producto.Modelo))
        throw new Exception("El modelo es obligatorio.");
      if (producto.Precio <= 0)
        throw new Exception("El precio debe ser mayor a cero.");
      productoDao.CreateProducto(producto);
    }

    public void UpdateProducto(Producto producto) => productoDao.UpdateProducto(producto);

    public void AjustarStock(int idProducto, int cantidad, string motivo)
    {
      Producto producto = productoDao.GetProductoById(idProducto);
      if (producto == null) throw new Exception("Producto no encontrado.");
      if (producto.Stock + cantidad < 0)
        throw new Exception("El ajuste resulta en stock negativo.");

      producto.Stock += cantidad;
      productoDao.UpdateProducto(producto);
    }

    public void DeleteProducto(int id) => productoDao.DeleteProducto(id);
  }
}
