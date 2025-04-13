namespace Lab_04_Roman_Qquelcca.Repositories;
using Lab_04_Roman_Qquelcca.Models;

public interface IClienteRepository
{
    Cliente GetById(int id);
    IEnumerable<Cliente> GetAll();
    void Add(Cliente cliente);
    void Update(Cliente cliente);
    void Delete(int id);
}

