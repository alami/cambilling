using Microsoft.EntityFrameworkCore;
using Core.Entities;
using Core.Interfaces;

namespace Infrastructure.Data
{
    public class CambillingRepository : ICambillingRepository
    {            
        private readonly StoreContext _context;
        public CambillingRepository (StoreContext context)
        {
            _context = context;           
        }
        public async Task<IReadOnlyList<Cambilling>> GetCambillingsAsync()
        {
            throw new NotImplementedException();
        }
        public async Task<Cambilling> GetCambillingByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
//-------------------------------------------
        public async Task<Forpost> GetForpostByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<IReadOnlyList<Forpost>> GetForpostsAsync()
        {
            throw new NotImplementedException();
        }
//-------------------------------------------        
        public async Task<Billing> GetBillingByIdAsync(int id)
        {
             return await _context.Billings.FindAsync(id);
        }
        public async Task<IReadOnlyList<Billing>> GetBillingsAsync()
        {
            return await _context.Billings.ToListAsync();
        }
//-------------------------------------------
        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }
        public async Task<IReadOnlyList<User>> GetUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }       
    }
}