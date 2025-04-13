using Lab_04_Roman_Qquelcca.Models;

public class ProductoRepository : IProductoRepository
{
    private readonly TiendaDb _context;

    public ProductoRepository(TiendaDb context)
    {
        _context = context;
    }

    public IEnumerable<Producto> GetAll() => _context.Productos.ToList();

    public Producto GetById(int id) => _context.Productos.Find(id);

    public void Add(Producto producto) => _context.Productos.Add(producto);

    public void Update(Producto producto) => _context.Productos.Update(producto);

    public void Delete(int id)
    {
        var producto = _context.Productos.Find(id);
        if (producto != null)
            _context.Productos.Remove(producto);
    }
}
