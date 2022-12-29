using Petzey.Appointment.Domain.Entites;
using Petzey.Appointment.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Appointment.Domain.RepositoryInterface
{
    public interface IAppointmentRepository
    {
        public bool CreateAppointment(Appointments appointment);
        public bool UpdateAppointment(Appointments appointments);
        public bool DeleteAppointment(int Id);
        public ICollection<Appointments> GetAllAppointment();
        public Appointments GetAppointment(int Id);
        public ICollection<Appointments> GetAllAppointmentByName(string name);
        public int GetAppointmentId();
    }
}
