using BlazorApp1.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data.DAL
{
    public class DataContext : DbContext
    {
        public DbSet<Tenant>? Tenants { get; set; }

        public string DbPath { get; } = "(localdb)\\mssqllocaldb";

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer($"Data Source={DbPath}");
    }
}
