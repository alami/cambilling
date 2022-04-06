using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
            
        }
        public DbSet<Cambilling> Cambillings { get; set; }  
        public DbSet<Billing> Billings { get; set; }  
        public DbSet<Forpost> Forposts { get; set; }  
        public DbSet<User> Users { get; set; }  
    }
}