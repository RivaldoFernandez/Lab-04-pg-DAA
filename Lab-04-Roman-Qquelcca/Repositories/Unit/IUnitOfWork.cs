namespace Lab_04_Roman_Qquelcca.Repositories.Unit;

public interface IUnitOfWork:IDisposable
{
    IClienteRepository Clientes { get; }
    ICategoriaRepository Categorias { get; }
    IProductoRepository Productos { get; }
    IOrdenRepository Ordenes { get; }
    IPagoRepository Pagos { get; }
    IDetallesOrdenRepository DetallesOrden { get; }
    int SaveChanges();

}



