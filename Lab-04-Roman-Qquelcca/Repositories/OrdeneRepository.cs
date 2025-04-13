namespace Lab_04_Roman_Qquelcca.Repositories;
using Lab_04_Roman_Qquelcca.Models;
public class OrdeneRepository : GenericRepository<Ordene>, IOrdeneRepository
{
    private readonly TiendaDb _context;
    public OrdeneRepository(TiendaDb context) : base(context)
    {
        _context = context;
    }
}