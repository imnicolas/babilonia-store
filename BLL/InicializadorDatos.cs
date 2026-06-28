using BLL.Security;
using DAL;
using ENTITY;

namespace BLL
{
  // Siembra los datos iniciales si la base de datos esta vacia (primera ejecucion)
  public class InicializadorDatos
  {
    private ServicioCifrado servicioCifrado = new ServicioCifrado();
    private PermisoDao permisoDao = new PermisoDao();
    private RolDao rolDao = new RolDao();
    private UsuarioDao usuarioDao = new UsuarioDao();
    private ProductoDao productoDao = new ProductoDao();
    private ProveedorDao proveedorDao = new ProveedorDao();

    public void InitializeIfNeeded()
    {
      InitializePermisos();
      InitializeRoles();
      InitializeUsuarios();
      InitializeProductos();
      InitializeProveedores();
    }

    private void InitializePermisos()
    {
      if (permisoDao.GetAllPermisos().Count > 0) return;

      permisoDao.CreatePermiso(new Permiso { Nombre = "Nueva Venta" });
      permisoDao.CreatePermiso(new Permiso { Nombre = "Post Venta" });
      permisoDao.CreatePermiso(new Permiso { Nombre = "Enviar Cupones" });
      permisoDao.CreatePermiso(new Permiso { Nombre = "Pedido de Reposicion" });
      permisoDao.CreatePermiso(new Permiso { Nombre = "Recepcion de Mercaderia" });
      permisoDao.CreatePermiso(new Permiso { Nombre = "Registrar Pago" });
      permisoDao.CreatePermiso(new Permiso { Nombre = "Conciliacion" });
      permisoDao.CreatePermiso(new Permiso { Nombre = "Ajuste de Stock" });
      permisoDao.CreatePermiso(new Permiso { Nombre = "Dashboard" });
      permisoDao.CreatePermiso(new Permiso { Nombre = "Gestionar Usuarios" });
      permisoDao.CreatePermiso(new Permiso { Nombre = "Generar Backup" });
    }

    private void InitializeRoles()
    {
      if (rolDao.GetAllRoles().Count > 0) return;

      List<Permiso> todos = permisoDao.GetAllPermisos();

      // Rol Dueño: acceso total
      Rol rolDueño = new Rol { Nombre = "Dueño" };
      foreach (Permiso p in todos) rolDueño.Agregar(p);
      rolDao.CreateRol(rolDueño);

      // Rol Empleada de Ventas: ventas y fidelizacion
      Rol rolVentas = new Rol { Nombre = "Empleada de Ventas" };
      foreach (string nombre in new[] { "Nueva Venta", "Post Venta", "Enviar Cupones" })
      {
        Permiso p = todos.Find(x => x.Nombre == nombre);
        if (p != null) rolVentas.Agregar(p);
      }
      rolDao.CreateRol(rolVentas);

      // Rol Encargado de Compras: pedidos, recepcion, pagos
      Rol rolCompras = new Rol { Nombre = "Encargado de Compras" };
      foreach (string nombre in new[] { "Pedido de Reposicion", "Recepcion de Mercaderia", "Registrar Pago", "Conciliacion" })
      {
        Permiso p = todos.Find(x => x.Nombre == nombre);
        if (p != null) rolCompras.Agregar(p);
      }
      rolDao.CreateRol(rolCompras);

      // Rol Encargado de Inventario: stock
      Rol rolInventario = new Rol { Nombre = "Encargado de Inventario" };
      Permiso pAjuste = todos.Find(x => x.Nombre == "Ajuste de Stock");
      if (pAjuste != null) rolInventario.Agregar(pAjuste);
      rolDao.CreateRol(rolInventario);
    }

    private void InitializeUsuarios()
    {
      if (usuarioDao.GetAllUsuarios().Count > 0) return;

      List<Rol> roles = rolDao.GetAllRoles();
      Rol rolDueño = roles.FirstOrDefault(r => r.Nombre == "Dueño");

      usuarioDao.CreateUsuario(new Usuario
      {
        Legajo = "ADMIN-01",
        Email = "admin@babiloniacalzados.com",
        ContraseñaHash = servicioCifrado.EncriptarContraseña("1234"),
        IdRol = rolDueño?.Id ?? 1,
        FechaUltimoCambioContraseña = DateTime.Now,
        RequiereCambioContraseña = false,
        Bloqueado = false,
        IntentosFallidos = 0,
        Permisos = rolDueño != null
          ? new List<ComponenteAcceso> { rolDueño }
          : new List<ComponenteAcceso>()
      });
    }

    private void InitializeProductos()
    {
      if (productoDao.GetAllProductos().Count > 0) return;

      string[] modelos = { "Confort Plus", "Ortopedic Walk", "Flex Comfort" };
      int[] talles = { 35, 36, 37, 38, 39, 40, 41, 42 };
      string[] colores = { "Negro", "Marron", "Beige" };

      foreach (string modelo in modelos)
      {
        foreach (int talle in talles)
        {
          productoDao.CreateProducto(new Producto
          {
            Modelo = modelo,
            Talle = talle,
            Color = colores[0],
            Precio = 45000m + (talle * 500),
            Stock = 10,
            StockMinimo = 3
          });
        }
      }
    }

    private void InitializeProveedores()
    {
      if (proveedorDao.GetAllProveedores().Count > 0) return;

      proveedorDao.CreateProveedor(new Proveedor
      {
        Nombre = "Calzados del Sur SRL",
        Cuit = "30-71234567-8",
        Telefono = "011-4567-8901",
        Email = "ventas@calzadosdelsur.com",
        Deuda = 0
      });
      proveedorDao.CreateProveedor(new Proveedor
      {
        Nombre = "Fabrica Ortopedica BA",
        Cuit = "30-78901234-5",
        Telefono = "011-2345-6789",
        Email = "contacto@ortopedicaba.com",
        Deuda = 0
      });
    }
  }
}
