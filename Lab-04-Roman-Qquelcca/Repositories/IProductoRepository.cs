using Lab_04_Roman_Qquelcca.Models;

public interface IProductoRepository
{
    IEnumerable<Producto> GetAll();
    Producto GetById(int id);
    void Add(Producto producto);
    void Update(Producto producto);
    void Delete(int id);
}