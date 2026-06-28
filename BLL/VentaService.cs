using DAL;
using ENTITY;

namespace BLL
{
  public class VentaService
  {
    private VentaDao ventaDao = new VentaDao();
    private ProductoDao productoDao = new ProductoDao();
    private ClienteDao clienteDao = new ClienteDao();

    private const decimal DescuentoJubilacion = 0.15m;

    // CU01: Iniciar venta por codigo/talle - registra venta y descuenta stock
    // CU02: Aplicar descuento jubilatorio - si el cliente es jubilado se aplica 15%
    public Venta RegistrarVenta(int idCliente, List<VentaProducto> items, string medioPago)
    {
      if (items == null || items.Count == 0)
        throw new Exception("La venta debe tener al menos un producto.");

      Cliente cliente = clienteDao.GetClienteById(idCliente);
      if (cliente == null) throw new Exception("Cliente no encontrado.");

      // Validar stock y calcular total
      decimal total = 0;
      foreach (VentaProducto item in items)
      {
        Producto producto = productoDao.GetProductoById(item.IdProducto);
        if (producto == null) throw new Exception($"Producto {item.IdProducto} no encontrado.");
        if (producto.Stock < item.Cantidad)
          throw new Exception($"Stock insuficiente para {producto.Modelo} T{producto.Talle}. Disponible: {producto.Stock}");

        item.PrecioUnitario = producto.Precio;
        total += producto.Precio * item.Cantidad;
      }

      bool aplicaDescuento = cliente.EsJubilado;
      if (aplicaDescuento)
        total = total * (1 - DescuentoJubilacion);

      Venta venta = new Venta
      {
        Fecha = DateTime.Now,
        IdCliente = idCliente,
        Total = Math.Round(total, 2),
        MedioPago = medioPago,
        TieneDescuentoJubilacion = aplicaDescuento,
        Items = items
      };

      ventaDao.CreateVenta(venta);

      // Descontar stock de cada producto vendido
      foreach (VentaProducto item in items)
      {
        Producto producto = productoDao.GetProductoById(item.IdProducto);
        producto.Stock -= item.Cantidad;
        productoDao.UpdateProducto(producto);
      }

      return venta;
    }

    // CU03: Registrar cambio de calzado - valida el ticket y ajusta el stock
    public void RegistrarCambio(int idVentaOriginal, int idProductoDevuelto, int idProductoNuevo)
    {
      Venta ventaOriginal = ventaDao.GetVentaById(idVentaOriginal);
      if (ventaOriginal == null)
        throw new Exception("No se encontro la venta original.");

      VentaProducto itemDevuelto = ventaOriginal.Items.FirstOrDefault(i => i.IdProducto == idProductoDevuelto);
      if (itemDevuelto == null)
        throw new Exception("El producto a devolver no pertenece a la venta original.");

      Producto productoNuevo = productoDao.GetProductoById(idProductoNuevo);
      if (productoNuevo == null) throw new Exception("Producto de reemplazo no encontrado.");
      if (productoNuevo.Stock < 1) throw new Exception("No hay stock del producto de reemplazo.");

      // Devolver stock del producto original
      Producto productoDevuelto = productoDao.GetProductoById(idProductoDevuelto);
      productoDevuelto.Stock += itemDevuelto.Cantidad;
      productoDao.UpdateProducto(productoDevuelto);

      // Descontar stock del producto nuevo
      productoNuevo.Stock -= itemDevuelto.Cantidad;
      productoDao.UpdateProducto(productoNuevo);

      // Actualizar la venta con el nuevo producto
      ventaOriginal.Items.Remove(itemDevuelto);
      ventaOriginal.Items.Add(new VentaProducto
      {
        IdProducto = idProductoNuevo,
        Cantidad = itemDevuelto.Cantidad,
        PrecioUnitario = productoNuevo.Precio
      });
      ventaDao.UpdateVenta(ventaOriginal);
    }

    public List<Venta> GetAllVentas() => ventaDao.GetAllVentas();

    public List<Venta> GetVentasByCliente(int idCliente)
    {
      return ventaDao.GetAllVentas().Where(v => v.IdCliente == idCliente).ToList();
    }
  }
}
