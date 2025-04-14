using Lab_04_Roman_Qquelcca.Models;

namespace Lab_04_Roman_Qquelcca.Repositories
{
    public interface IDetallesOrdenRepository
    {
        Task<Detallesorden> GetByIdAsync(int id);
        Task<IEnumerable<Detallesorden>> GetAllAsync();
        Task AddAsync(Detallesorden detalle);
        Task UpdateAsync(Detallesorden detalle);
        Task DeleteAsync(int id);
    }
}