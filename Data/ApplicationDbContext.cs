using FilmDBnew.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FilmDBnew.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<FilmModel> Films { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}