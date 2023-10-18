
using Domain.CMS.Article.Entities;
using Domain.CMS.Writer.Entities;
using Microsoft.EntityFrameworkCore; 

namespace Application.Interfaces;

public interface IApplicationDbContext
{
    public DbSet<Article> Articles { get; set; }
    public DbSet<Writer> Writers { get; set; }

    int SaveChanges();
    Task<int> SaveChangesAsync();
}
