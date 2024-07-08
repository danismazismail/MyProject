using Core.Entities.Concrete;
using DataAccess.Configs;
using DataAccess.SeedData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {
            Database.Migrate();
        }

        public DbSet<Person> Person { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PersonSeedData());


            modelBuilder.ApplyConfiguration(new PersonConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}
