using Microsoft.EntityFrameworkCore;
using Petzey.Appointment.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Appointment.Data.DataAccessLayer
{
    public class AppointmentDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-DO574M60\\SQLEXPRESS;Database=Petzey-AppointmentDB;Trusted_Connection=True;Encrypt=False;MultipleActiveResultSets=true")
                .EnableSensitiveDataLogging(true);
        }
        public DbSet<Appointments> Appointments { get; set; }
    }
}
