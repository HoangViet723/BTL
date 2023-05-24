using QuanLyBookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace QuanLyBookStore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

    }
}