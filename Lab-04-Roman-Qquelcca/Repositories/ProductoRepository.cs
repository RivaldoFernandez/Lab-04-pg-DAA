namespace Lab_04_Roman_Qquelcca.Repositories;
using Lab_04_Roman_Qquelcca.Models;

public class ProductoRepository : GenericRepository<Producto>, IProductoRepository
{
    private readonly TiendaDb _context;
    public ProductoRepository(TiendaDb context) : base(context)
    {
        _context = context;
    }
}