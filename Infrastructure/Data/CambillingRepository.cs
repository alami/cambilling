
using Core.Entities;
using Core.Interfaces;

namespace Infrastructure.Data
{
    public class CambillingRepository : ICambillingRepository
    {
        public Task<IReadOnlyList<Cambilling>> GetCambillingsAsync()
        {
            throw new NotImplementedException();
        }
        public Task<Cambilling> GetCambillingByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
//-------------------------------------------        
        public Task<Billing> GetBillingByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Billing>> GetBillingsAsync()
        {
            throw new NotImplementedException();
        }
//-------------------------------------------
        public Task<Forpost> GetForpostByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Forpost>> GetForpostsAsync()
        {
            throw new NotImplementedException();
        }
//-------------------------------------------
        public Task<User> GetUserByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<User>> GetUsersAsync()
        {
            throw new NotImplementedException();
        }       
    }
}