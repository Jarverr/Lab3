using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    public class Kontekst: DbContext //wazne zeby dziedczyło z db context
    {
        public DbSet<Student> Students { get; set; } //typ dbset repreznetuje zbior bazodanowy jakas tabela/widok czy coś 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder); 
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"); //pobranie sqlservera zeby moc usesqlserver zrobic i tutaj conneciton string
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder) //fluent(drugi spsob)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<Student>() //obiekt pozwlajacy modyfikowac tabele, albo atrybuty albo fluent wzajemnie sie gryza
        //        .Property(x => x.Imie)
        //        .HasMaxLength(255)
        //        .IsRequired()
        //        .HasColumnName("Name");
        //    modelBuilder.Entity<Student>()
        //        .Property(x => x.Nazwisko)
        //        .HasMaxLength(255);
        //}
    }
}
