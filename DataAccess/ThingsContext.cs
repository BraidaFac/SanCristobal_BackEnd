using GSC_BackEnd_TP.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

#nullable disable
namespace GSC_BackEnd_TP.DataAccess

{
    public class ThingsContext : DbContext
    {
        /// <summary>
        /// Este constructor es utilizado para la creacion del contexto.
        /// </summary>
        /// <param name = "options" > Este parametro options es el que esta configurado en la clase program.</param>

        public ThingsContext(DbContextOptions options)
               : base(options)
        {
        }
       // public DbSet<Category> Categories { get; set; }
        //public DbSet<Address> Addresses { get; set; }
       // public DbSet<Thing> Things { get; set; }
        public DbSet<Person> People { get; set; }
        //public DbSet<Loan> Loans { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<Address>()
                .Property(a => a.Street)
                .HasMaxLength(100);

            modelBuilder.Entity<Address>()
                .Property(a => a.Number)
                .HasMaxLength(20);

           modelBuilder.Entity<Address>()
                .Property(a => a.City)
                .HasMaxLength(100);

        }
    }
}
