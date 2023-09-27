using Domain.Entities.CMS;
using Domain.Entities.Store;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Application.Interfaces;

public interface IApplicationDbContext
{
    public DbSet<Article> Blogs { get; set; }
    public DbSet<Writer> Writers { get; set; }

    int SaveChanges();
    Task<int> SaveChangesAsync();
}
