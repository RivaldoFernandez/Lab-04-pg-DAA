using Lab_04_Roman_Qquelcca.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab_04_Roman_Qquelcca.Repositories
{
    public class DetallesOrdenRepository : IDetallesOrdenRepository
    {
        private readonly TiendaDb _context;

        public DetallesOrdenRepository(TiendaDb context)
        {
            _context = context;
        }
        public async Task<Detallesorden> GetByIdAsync(int id)
        {
            return await _context.Set<Detallesorden>().FindAsync(id);
        }

        public async Task<IEnumerable<Detallesorden>> GetAllAsync()
        {
            return await _context.Set<Detallesorden>().ToListAsync();
        }

        public async Task AddAsync(Detallesorden detalle)
        {
            await _context.Set<Detallesorden>().AddAsync(detalle);
        }

        public async Task UpdateAsync(Detallesorden detalle)
        {
            _context.Set<Detallesorden>().Update(detalle);
            await Task.CompletedTask;  // Simula un proceso asincrónico
        }

        public async Task DeleteAsync(int id)
        {
            var detalle = await _context.Set<Detallesorden>().FindAsync(id);
            if (detalle != null)
            {
                _context.Set<Detallesorden>().Remove(detalle);
                await Task.CompletedTask; // Simula un proceso asincrónico
            }
        }
    }
}