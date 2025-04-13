namespace Lab_04_Roman_Qquelcca.Repositories;
using Lab_04_Roman_Qquelcca.Models;

public class DetallesOrdenRepository : GenericRepository<Detallesorden>, IDetallesOrdenRepository
{
    private readonly TiendaDb _context;
    public DetallesOrdenRepository(TiendaDb context) : base(context)
    {
        _context = context;
    }
}