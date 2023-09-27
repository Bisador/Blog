using Application.Interfaces;
using Domain.Entities.CMS;
using Domain.Entities.Store;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<Article> Blogs { get; set; }
        public DbSet<Writer> Writers { get; set; }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }
        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
