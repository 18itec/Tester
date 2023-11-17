// Data/AppDbContext.cs
using Microsoft.EntityFrameworkCore;
using ExtratoContaCorrente.Models;

namespace ExtratoContaCorrente.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Lancamento> Lancamentos { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}
