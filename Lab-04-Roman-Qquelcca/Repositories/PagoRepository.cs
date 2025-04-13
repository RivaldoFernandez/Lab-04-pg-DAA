namespace Lab_04_Roman_Qquelcca.Repositories;

using Lab_04_Roman_Qquelcca.Models;
public class PagoRepository : GenericRepository<Pago>, IPagoRepository
{
    private readonly TiendaDb _context;
    public PagoRepository(TiendaDb context) : base(context)
    {
        _context = context;
    }
}