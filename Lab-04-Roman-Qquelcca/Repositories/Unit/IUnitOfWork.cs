namespace Lab_04_Roman_Qquelcca.Repositories.Unit;

public interface IUnitOfWork:IDisposable
{
    IClienteRepository Clientes { get; }
    IProductoRepository Productos { get; }
    
    
    int SaveChanges();
    Task<int> SaveChangesAsync();

}