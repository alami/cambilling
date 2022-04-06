using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface ICambillingRepository
    {
        Task<Cambilling>GetCambillingByIdAsync(int id);
        Task<IReadOnlyList<Cambilling>>GetCambillingsAsync();
        Task<User>GetUserByIdAsync(int id);
        Task<IReadOnlyList<User>>GetUsersAsync();
        Task<Billing>GetBillingByIdAsync(int id);
        Task<IReadOnlyList<Billing>>GetBillingsAsync();
        Task<Forpost>GetForpostByIdAsync(int id);
        Task<IReadOnlyList<Forpost>>GetForpostsAsync();    }
}