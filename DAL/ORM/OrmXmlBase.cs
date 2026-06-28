using System.Xml.Linq;

namespace DAL.ORM
{
  public abstract class OrmXmlBase<T> : IOrmGenerico<T> where T : class
  {
    protected static readonly object CandadoPersistencia = new object();

    protected abstract string NombreArchivo { get; }
    protected abstract string NombreElemento { get; }
    protected abstract T MapearDesdeXml(XElement nodo);
    protected abstract XElement MapearAXml(T entidad);
    protected abstract int ObtenerId(T entidad);
    protected abstract void EstablecerId(T entidad, int id);
    protected virtual string DirectorioBase => XmlDataPathUtil.GetDataPath();

    public virtual int ObtenerSiguienteId()
    {
      List<T> lista = ObtenerTodos();
      if (lista.Count == 0) return 1;
      return lista.Max(ObtenerId) + 1;
    }

    public virtual List<T> ObtenerTodos()
    {
      lock (CandadoPersistencia)
      {
        string ruta = Path.Combine(DirectorioBase, NombreArchivo);
        if (!File.Exists(ruta)) return new List<T>();

        try
        {
          XDocument doc = XDocument.Load(ruta);
          return doc.Descendants(NombreElemento).Select(MapearDesdeXml).ToList();
        }
        catch
        {
          return new List<T>();
        }
      }
    }

    public virtual T ObtenerPorId(int id)
    {
      return ObtenerTodos().FirstOrDefault(e => ObtenerId(e) == id);
    }

    public virtual void Insertar(T entidad)
    {
      lock (CandadoPersistencia)
      {
        List<T> lista = ObtenerTodos();
        EstablecerId(entidad, ObtenerSiguienteId());
        lista.Add(entidad);
        GuardarLista(lista);
      }
    }

    public virtual void Actualizar(T entidad)
    {
      lock (CandadoPersistencia)
      {
        List<T> lista = ObtenerTodos();
        int indice = lista.FindIndex(e => ObtenerId(e) == ObtenerId(entidad));
        if (indice < 0)
          throw new InvalidOperationException($"No se encontro {NombreElemento} con Id={ObtenerId(entidad)}.");

        lista[indice] = entidad;
        GuardarLista(lista);
      }
    }

    public virtual void Eliminar(int id)
    {
      lock (CandadoPersistencia)
      {
        List<T> lista = ObtenerTodos();
        lista.RemoveAll(e => ObtenerId(e) == id);
        GuardarLista(lista);
      }
    }

    protected void GuardarLista(List<T> lista)
    {
      string ruta = Path.Combine(DirectorioBase, NombreArchivo);
      string raiz = "ArrayOf" + NombreElemento;
      XDocument doc = new XDocument(new XElement(raiz, lista.Select(MapearAXml)));
      doc.Save(ruta);
    }
  }
}
