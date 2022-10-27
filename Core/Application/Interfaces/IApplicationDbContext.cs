using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IApplicationDbContext
    {
        public DbSet<Blog> Blogs { get; set; }

        int SaveChanges();
        Task<int> SaveChangesAsync();
    }
}
