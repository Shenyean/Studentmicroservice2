using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.EntityFrameworkCore.Extensions;
using Microsoft.EntityFrameworkCore;
using StudentMicroservice2.Models;


namespace StudentMicroservice2.DbContexts
{
    public class StudentContext: DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Cca> Ccas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cca>().HasData(
                new Cca
                {
                    Id = 1,
                    Name = "Football",
                    Description = "Div A and Div B Football team",
                },
                new Cca
                {
                    Id = 2,
                    Name = "Choir",
                    Description = "Sing",
                },
                new Cca
                {
                    Id = 3,
                    Name = "Art Class",
                    Description = "Draw",
                }
            );
        }
    }
}
