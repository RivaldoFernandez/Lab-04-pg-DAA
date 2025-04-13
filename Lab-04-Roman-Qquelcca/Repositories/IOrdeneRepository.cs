using Lab_04_Roman_Qquelcca.Models;

public interface IOrdenRepository
{
    IEnumerable<Ordene> GetAll();
    Ordene GetById(int id);
    void Add(Ordene orden);
    void Update(Ordene orden);
    void Delete(int id);
}