using Petzey.Appointment.Domain.Entites;
using Petzey.Appointment.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Appointment.Domain.BusinessInterface
{
    public interface IAppointmentService 
    {
        public bool CreateAppointment(AppointmentFormDTO formDTO);
        public bool EditAppointment(AppointmentFormDTO formDTO);
        public bool DeleteAppointment(int id);
        public ICollection<AppointmentDetailsDTO> GetAllAppointmentDetails(string name);
        public ICollection<AppointmentCardDTO> GetAllAppointmentCards(string name);
        public AppointmentFormDTO GetAppointmentForm(int id);
        public ICollection<Appointments> GetAllAppointment();
        public int GetAppointmentId();
    }
}
