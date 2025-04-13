using Lab_04_Roman_Qquelcca.Models;

namespace Lab_04_Roman_Qquelcca.Repositories.Unit;

public class UnitOfWork : IUnitOfWork
{
    private readonly TiendaDb _context;
    public IClienteRepository Clientes { get; }
    public IProductoRepository Productos { get; }

    public UnitOfWork(TiendaDb context, IClienteRepository clientes)
    {
        _context = context;
        Clientes = clientes;

    }
    
    public int SaveChanges() => _context.SaveChanges();
    public void Dispose() => _context.Dispose();
    public async Task<int> SaveChangesAsync() => await _context.SaveChangesAsync();

}