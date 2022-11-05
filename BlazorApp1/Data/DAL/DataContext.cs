using BlazorApp1.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data.DAL
{
    public class DataContext : DbContext
    {
        public DbSet<Tenant>? Tenants { get; set; }

        //local: "(localdb)\\mssqllocaldb"
        public string DbPath { get; } = "h1use0ulyws4lqr1.cbetxkdyhwsb.us-east-1.rds.amazonaws.com";

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseMySql(connectionString: @"server=h1use0ulyws4lqr1.cbetxkdyhwsb.us-east-1.rds.amazonaws.com;port=3306;database=ufeod924dcfkuvyf;uid=y5otpv72mfiikjie;password=uf8mtryxwbusd4is;",
            new MySqlServerVersion(new Version(8, 0, 0)));
    }
}
