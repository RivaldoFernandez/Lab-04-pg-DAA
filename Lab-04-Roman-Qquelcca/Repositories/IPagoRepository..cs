using Lab_04_Roman_Qquelcca.Models;

public interface IPagoRepository
{
    IEnumerable<Pago> GetAll();
    Pago GetById(int id);
    void Add(Pago pago);
    void Update(Pago pago);
    void Delete(int id);
}