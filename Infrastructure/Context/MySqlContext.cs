using API.DDD.Domain.Entitys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace API.DDD.Infrastructure.Context
{
    public class MySqlContext : DbContext
    {

        public DbSet<Client> Clients { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        public MySqlContext()
        {
        }

        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options) { }

        public override int SaveChanges()
        {
            //Sempre irá inserir poré não irá modificar a Data de Inclusão
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("InclusionDate") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("InclusionDate").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("InclusionDate").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }
} 
