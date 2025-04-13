using Lab_04_Roman_Qquelcca.Models;

public interface ICategoriaRepository
{
    IEnumerable<Categoria> GetAll();
    Categoria GetById(int id);
    void Add(Categoria categoria);
    void Update(Categoria categoria);
    void Delete(int id);
}