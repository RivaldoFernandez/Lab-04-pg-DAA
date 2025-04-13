using Lab_04_Roman_Qquelcca.Models;
namespace Lab_04_Roman_Qquelcca.Repositories.Unit;
public class UnitOfWork : IUnitOfWork
{
    private readonly TiendaDb _context;
    public IClienteRepository Clientes { get; }

    public UnitOfWork(TiendaDb context, IClienteRepository clienteRepository)
    {
        _context = context;
        Clientes = clienteRepository;
    }
    public int SaveChanges()
    {
        return _context.SaveChanges();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}
