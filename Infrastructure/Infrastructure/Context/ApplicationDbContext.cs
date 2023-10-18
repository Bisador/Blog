
using Application.Interfaces;
using Domain.CMS.Article.Entities;
using Domain.CMS.Writer.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<Article> Articles { get; set; }
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
