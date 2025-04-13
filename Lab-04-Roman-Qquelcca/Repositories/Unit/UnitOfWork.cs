using Lab_04_Roman_Qquelcca.Models;

namespace Lab_04_Roman_Qquelcca.Repositories.Unit
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TiendaDb _context;

        public IClienteRepository Clientes { get; }
        public ICategoriaRepository Categorias { get; }
        public IProductoRepository Productos { get; }
        public IOrdenRepository Ordenes { get; }
        public IPagoRepository Pagos { get; }
        public IDetallesOrdenRepository DetallesOrden { get; }

        public UnitOfWork(
            TiendaDb context,
            IClienteRepository clienteRepository,
            ICategoriaRepository categoriaRepository,
            IProductoRepository productoRepository,
            IOrdenRepository ordenRepository,
            IPagoRepository pagoRepository,
            IDetallesOrdenRepository detallesOrdenRepository)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            Clientes = clienteRepository ?? throw new ArgumentNullException(nameof(clienteRepository));
            Categorias = categoriaRepository ?? throw new ArgumentNullException(nameof(categoriaRepository));
            Productos = productoRepository ?? throw new ArgumentNullException(nameof(productoRepository));
            Ordenes = ordenRepository ?? throw new ArgumentNullException(nameof(ordenRepository));
            Pagos = pagoRepository ?? throw new ArgumentNullException(nameof(pagoRepository));
            DetallesOrden = detallesOrdenRepository ?? throw new ArgumentNullException(nameof(detallesOrdenRepository));
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
}