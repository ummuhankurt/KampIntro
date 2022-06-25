using EntityFrameworkDemo.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkDemo
{
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=UMMUHANKURT;Database=Northwind;Trusted_Connection=true");

        }
        public DbSet<Product> Products { get; set; } // veritabanındaki product ile model classını ilişkilendiriyoruz.
        public DbSet<Personel> Personels { get; set; }
        // Bu metodu neden yazıyoruz? Veritabanındaki isimler ile model classındaki isimler uyuşmadığı zaman.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // sadece adminlerin tabloları için; yani sadece adminleri ilgilendiren kısım için;
            // modelBuilder.HasDefaultSchema("admin"); kullanılabilir.
            // default şema dbo'dur.
            // fluent mapping.
            modelBuilder.Entity<Personel>().ToTable("Employees");
            modelBuilder.Entity<Personel>().Property(p => p.Id).HasColumnName("EmployeeID");
            modelBuilder.Entity<Personel>().Property(p => p.Name).HasColumnName("FirstName");
            modelBuilder.Entity<Personel>().Property(p => p.Surname).HasColumnName("LastName");


             
        }
    }
}
