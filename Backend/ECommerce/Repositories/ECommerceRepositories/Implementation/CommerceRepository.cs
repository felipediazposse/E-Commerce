using ECommerce.DataContext;
using ECommerce.Models.ECommerceModels;
using ECommerce.Repositories.ECommerceRepositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Repositories.ECommerceRepositories.Implementation
{
    public class CommerceRepository : ICommerceRepository
    {
        private readonly ECommerceDbContext _context;

        public CommerceRepository(ECommerceDbContext context)
        {
            _context = context;
        }

        public async Task<Commerce?> GetByIdAsync(int id)
        {
            return await _context.Commerces
                .Include(c => c.Address)
                .Include(c => c.Categories)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<IEnumerable<Commerce>> GetByNameAsync(string name)
        {
            return await _context.Commerces
                .Include(c => c.Address)
                .Include(c => c.Categories)
                .Where(c => c.Name.Contains(name))
                .ToListAsync();
        }

        public async Task<IEnumerable<Commerce>> GetAllAsync()
        {
            return await _context.Commerces
                .Include(c => c.Address)
                .Include(c => c.Categories)
                .ToListAsync();
        }

        public async Task<Commerce> CreateAsync(Commerce commerce)
        {
            _context.Commerces.Add(commerce);
            await _context.SaveChangesAsync();
            return commerce;
        }

        public async Task<Commerce> UpdateAsync(Commerce commerce)
        {
            _context.Entry(commerce).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return commerce;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var commerce = await _context.Commerces.FindAsync(id);
            if (commerce == null)
                return false;

            commerce.IsActive = false;
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
