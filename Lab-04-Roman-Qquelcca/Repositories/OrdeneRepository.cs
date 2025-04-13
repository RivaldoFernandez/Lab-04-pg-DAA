using Lab_04_Roman_Qquelcca.Models;

public class OrdenRepository : IOrdenRepository
{
    private readonly TiendaDb _context;

    public OrdenRepository(TiendaDb context)
    {
        _context = context;
    }

    public IEnumerable<Ordene> GetAll() => _context.Ordenes.ToList();

    public Ordene GetById(int id) => _context.Ordenes.Find(id);

    public void Add(Ordene orden) => _context.Ordenes.Add(orden);

    public void Update(Ordene orden) => _context.Ordenes.Update(orden);

    public void Delete(int id)
    {
        var orden = _context.Ordenes.Find(id);
        if (orden != null)
            _context.Ordenes.Remove(orden);
    }
}