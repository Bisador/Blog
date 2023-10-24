
using Domain.CMS.ArticleAggregate.Entities;
using Domain.CMS.WriterAggregate.Entities;
using Microsoft.EntityFrameworkCore; 

namespace Application.Interfaces;

public interface IApplicationDbContext
{
    public DbSet<Article> Articles { get; set; }
    public DbSet<Writer> Writers { get; set; }

    int SaveChanges();
    Task<int> SaveChangesAsync();
}
