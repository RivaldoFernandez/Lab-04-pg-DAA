using Lab_04_Roman_Qquelcca.Models;

public class CategoriaRepository : ICategoriaRepository
{
    private readonly TiendaDb _context;

    public CategoriaRepository(TiendaDb context)
    {
        _context = context;
    }

    public IEnumerable<Categoria> GetAll() => _context.Categorias.ToList();

    public Categoria GetById(int id) => _context.Categorias.Find(id);

    public void Add(Categoria categoria) => _context.Categorias.Add(categoria);

    public void Update(Categoria categoria) => _context.Categorias.Update(categoria);

    public void Delete(int id)
    {
        var categoria = _context.Categorias.Find(id);
        if (categoria != null)
            _context.Categorias.Remove(categoria);
    }
}