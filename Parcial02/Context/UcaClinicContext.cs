using Microsoft.EntityFrameworkCore;
using Parcial02.Entities.Questions;
using Parcial02.Entities.Reservations;
using Parcial02.Entities.Specialties;
using Parcial02.Entities.Users;

namespace Parcial02.Context
{
    public class UcaClinicContext : DbContext

    {
        public DbSet<User> Users { get; set; }
        
        public DbSet<Question> Questions { get; set; }
        
        public DbSet<Speciality> Specialities { get; set; }
        
        public DbSet<Reservation> Reservations { get; set; }

        //CAMBIAR STRING CONECTION 
        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlServer("Server=localhost;Database=Parcial02Clinicdb;Trusted_Connection=True;");
        
        //PRIMARY KEY DE RESERVATION CON IDENTITY
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reservation>().Property(s => s.Id)
                .ValueGeneratedOnAdd();
        }
        
    }
}