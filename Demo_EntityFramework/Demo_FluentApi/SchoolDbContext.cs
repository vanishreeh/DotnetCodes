using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_FluentApi
{
    class SchoolDbContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-0TE71RT;Database=SchoolManagementDb;Trusted_Connection=True;");
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Address> Addresses { get; set; }
        //Fluent API to configure Properties

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .Property(s => s.StudentId)
                .HasColumnName("Id");
            modelBuilder.Entity<Student>()
                .HasOne<Grade>(s => s.Grade)
                .WithMany(g => g.Students)//collection navigation property
                .HasForeignKey(s => s.GradeId);
            //.OnDelete(DeleteBehavior.Cascade)

            modelBuilder.Entity<Student>()
                .HasOne<Address>(s => s.Adress)//student class has  refence property adress type
                .WithOne(ad => ad.Student)//reference navigation property of student type
                .HasForeignKey<Address>(ad => ad.StudentId);
                
        }
    }
}
