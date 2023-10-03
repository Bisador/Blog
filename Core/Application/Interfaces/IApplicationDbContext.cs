using Domain.CMS.Entities; 
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Application.Interfaces;

public interface IApplicationDbContext
{
    public DbSet<Article> Articles { get; set; }
    public DbSet<Writer> Writers { get; set; }

    int SaveChanges();
    Task<int> SaveChangesAsync();
}
