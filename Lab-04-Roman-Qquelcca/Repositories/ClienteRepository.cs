namespace Lab_04_Roman_Qquelcca.Repositories;
using Lab_04_Roman_Qquelcca.Models;
public class ClienteRepository : IClienteRepository
{
    private readonly TiendaDb _context;
    public ClienteRepository(TiendaDb context)
    {
        _context = context;
    }
    public Cliente GetById(int id)
    {
        return _context.Set<Cliente>().Find(id);
    }
    public IEnumerable<Cliente> GetAll()
    {
        return _context.Set<Cliente>().ToList();
    }
    public void Add(Cliente cliente)
    {
        _context.Set<Cliente>().Add(cliente);
    }
    public void Update(Cliente cliente)
    {
        _context.Set<Cliente>().Update(cliente);
    }
    public void Delete(int id)
    {
        var cliente = _context.Set<Cliente>().Find(id);
        if (cliente != null)
        {
            _context.Set<Cliente>().Remove(cliente);
        }
    }
}
