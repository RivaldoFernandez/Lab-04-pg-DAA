namespace Lab_04_Roman_Qquelcca.Repositories.Unit;

public interface IUnitOfWork:IDisposable
{
    IClienteRepository Clientes { get; }
    int SaveChanges();

}

