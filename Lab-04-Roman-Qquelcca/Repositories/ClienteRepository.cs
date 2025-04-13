namespace Lab_04_Roman_Qquelcca.Repositories;

using Lab_04_Roman_Qquelcca.Models;
public class ClienteRepository : GenericRepository<Cliente>, IClienteRepository
{
    private readonly TiendaDb _context;
    public ClienteRepository(TiendaDb context) : base(context)
    {
        _context = context;
    }
}