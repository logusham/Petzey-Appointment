using Petzey.Appointment.Domain.Entites;
using Petzey.Appointment.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Appointment.Domain.MappingInterface
{
    public interface IAppointmentMapping
    {
        public Appointments ChangeAppointmentFormToAppointment(AppointmentFormDTO formDTO);
        public ICollection<AppointmentDetailsDTO> ChangeAppointmentToAppointmentDetailsList(ICollection<Appointments> appointments);
        public ICollection<AppointmentCardDTO> ChangeAppointmentToAppointmentCardList(ICollection<Appointments> appointments);
        public AppointmentFormDTO ChangeAppointmentToAppointmentForm(Appointments appointment);
        public Appointments ChangeAppointmentFormToAppointmentEdit(AppointmentFormDTO formDTO);
    }
}
