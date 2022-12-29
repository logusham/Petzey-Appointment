using Petzey.Appointment.Data.Mapping;
using Petzey.Appointment.Data.Repository;
using Petzey.Appointment.Domain.BusinessInterface;
using Petzey.Appointment.Domain.Entites;
using Petzey.Appointment.Domain.MappingInterface;
using Petzey.Appointment.Domain.RepositoryInterface;
using Petzey.Appointment.DTO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Appointment.Data.Business
{
    public class AppointmentService : IAppointmentService
    {
        IAppointmentMapping mapping;
        IAppointmentRepository repo;
        public AppointmentService()
        {
            mapping = new AppointmentMapping();
            repo = new AppointmentRepository();
        }
        public bool CreateAppointment(AppointmentFormDTO formDTO)
        {
            Appointments appointment = mapping.ChangeAppointmentFormToAppointment(formDTO);
            repo.CreateAppointment(appointment);
            return true;
        }

        public bool DeleteAppointment(int id)
        {
            repo.DeleteAppointment(id);
            return true;
        }

        public bool EditAppointment(AppointmentFormDTO formDTO)
        {
            Appointments appointment = mapping.ChangeAppointmentFormToAppointmentEdit(formDTO);
            repo.UpdateAppointment(appointment);
            return true;
        }

        public ICollection<Appointments> GetAllAppointment()
        {
             return repo.GetAllAppointment();
        }

        public ICollection<AppointmentCardDTO> GetAllAppointmentCards(string name)
        {
            ICollection<Appointments> appointments = repo.GetAllAppointmentByName(name);
            ICollection<AppointmentCardDTO> appointmentCards = mapping.ChangeAppointmentToAppointmentCardList(appointments);
            return appointmentCards;
        }

        public ICollection<AppointmentDetailsDTO> GetAllAppointmentDetails(string name)
        {
            ICollection<Appointments> appointments = repo.GetAllAppointmentByName(name);
            ICollection<AppointmentDetailsDTO> appointmentDetails = mapping.ChangeAppointmentToAppointmentDetailsList(appointments);
            return appointmentDetails;
        }

        public AppointmentFormDTO GetAppointmentForm(int id)
        {
            Appointments appointment = repo.GetAppointment(id);
            AppointmentFormDTO appointmentForm = mapping.ChangeAppointmentToAppointmentForm(appointment);
            return appointmentForm;
        }

        public int GetAppointmentId()
        {
            return repo.GetAppointmentId();
        }
    }
}
