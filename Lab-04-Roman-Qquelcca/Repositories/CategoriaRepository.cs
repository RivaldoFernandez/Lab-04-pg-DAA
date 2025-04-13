namespace Lab_04_Roman_Qquelcca.Repositories;

using Lab_04_Roman_Qquelcca.Models;
public class CategoriaRepository: GenericRepository<Categoria>, ICategoriaRepository
{
    private readonly TiendaDb _context;
    public CategoriaRepository(TiendaDb context) : base(context)
    {
        _context = context;
    }
}