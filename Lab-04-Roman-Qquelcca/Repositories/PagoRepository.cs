using Lab_04_Roman_Qquelcca.Models;

public class PagoRepository : IPagoRepository
{
    private readonly TiendaDb _context;

    public PagoRepository(TiendaDb context)
    {
        _context = context;
    }

    public IEnumerable<Pago> GetAll() => _context.Pagos.ToList();

    public Pago GetById(int id) => _context.Pagos.Find(id);

    public void Add(Pago pago) => _context.Pagos.Add(pago);

    public void Update(Pago pago) => _context.Pagos.Update(pago);

    public void Delete(int id)
    {
        var pago = _context.Pagos.Find(id);
        if (pago != null)
            _context.Pagos.Remove(pago);
    }
}