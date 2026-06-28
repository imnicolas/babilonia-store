using DAL;
using ENTITY;

namespace BLL
{
  public class ClienteService
  {
    private ClienteDao clienteDao = new ClienteDao();

    public List<Cliente> GetAllClientes() => clienteDao.GetAllClientes();

    public Cliente GetClienteById(int id) => clienteDao.GetClienteById(id);

    public void CreateCliente(Cliente cliente)
    {
      if (string.IsNullOrWhiteSpace(cliente.Nombre) || string.IsNullOrWhiteSpace(cliente.Apellido))
        throw new Exception("Nombre y apellido son obligatorios.");
      if (string.IsNullOrWhiteSpace(cliente.Dni))
        throw new Exception("El DNI es obligatorio.");

      clienteDao.CreateCliente(cliente);
    }

    public void UpdateCliente(Cliente cliente) => clienteDao.UpdateCliente(cliente);

    public void DeleteCliente(int id) => clienteDao.DeleteCliente(id);
  }
}
