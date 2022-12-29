using Microsoft.EntityFrameworkCore;
using Petzey.Appointment.Data.DataAccessLayer;
using Petzey.Appointment.Domain.Entites;
using Petzey.Appointment.Domain.RepositoryInterface;
using Petzey.Appointment.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Appointment.Data.Repository
{
    public class AppointmentRepository : IAppointmentRepository
    {
        AppointmentDbContext db;
        public AppointmentRepository()
        {
            db = new AppointmentDbContext();
        }
        public bool CreateAppointment(Appointments appointment)
        {
            db.Appointments.Add(appointment);
            db.SaveChanges();
            return true;
        }

        public bool DeleteAppointment(int Id)
        {
            var appointment = db.Appointments.Include(x => x.Vet).Include(x => x.Patient).Where(x => x.Id == Id).First();
            if (appointment != null)
            {
                db.Remove(appointment);
                db.Remove(appointment.Patient);
                db.Remove(appointment.Vet);
                db.SaveChanges();
                return true;
            }
            return false;
            
        }

        public ICollection<Appointments> GetAllAppointment()
        {
            var appointments = db.Appointments.Include(x => x.Vet).Include(x => x.Patient).ToList();
            return appointments;
        }

        public ICollection<Appointments> GetAllAppointmentByName(string name)
        {
            var appointments = db.Appointments.Include(x => x.Vet).Include(x => x.Patient).Where(x => x.Vet.DoctorName == name).ToList();
            return appointments;
        }

        public Appointments GetAppointment(int Id)
        {
            var appointments = db.Appointments.Include(x => x.Vet).Include(x => x.Patient).Where(x => x.Id == Id).First();
            return appointments;
            
        }

        public int GetAppointmentId()
        {
            Appointments appointments = db.Appointments.OrderByDescending(x => x.Id).First();
            return appointments.Id;
        }

        public bool UpdateAppointment(Appointments appointments)
        {
            var app = db.Appointments.Find(appointments.Id);
            if (app != null)
            {
                db.Update(appointments);
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
