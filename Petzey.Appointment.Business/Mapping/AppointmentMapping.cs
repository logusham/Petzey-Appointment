using Petzey.Appointment.Domain.Entites;
using Petzey.Appointment.Domain.MappingInterface;
using Petzey.Appointment.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Appointment.Data.Mapping
{
    public class AppointmentMapping : IAppointmentMapping
    {
        public Appointments ChangeAppointmentFormToAppointment(AppointmentFormDTO formDTO)
        {
            Appointments appointment = new Appointments()
            {
                AppointmentDate = formDTO.AppointmentDate,
                AppointmentTime = formDTO.AppointmentTime,
                AppointmentStatus = formDTO.AppointmentStatus,
                Message = formDTO.Message,
                Patient = new Patients()
                {
                    PatientName = formDTO.patientsDTO.PatientName,
                    Age = formDTO.patientsDTO.Age,
                    Email = formDTO.patientsDTO.Email,
                    Phone = formDTO.patientsDTO.Phone,
                    Address = formDTO.patientsDTO.Address
                },
                Vet = new Vets()
                {
                    DoctorName = formDTO.VetsDTO.DoctorName,
                    Department = formDTO.VetsDTO.Department
                }
        };
            return appointment;
        }
        public ICollection<AppointmentDetailsDTO> ChangeAppointmentToAppointmentDetailsList(ICollection<Appointments> appointments)
        {
            ICollection<AppointmentDetailsDTO> appointmentDetails = new List<AppointmentDetailsDTO>();
            foreach(var app in appointments)
            {
                AppointmentDetailsDTO detailsDTO = new AppointmentDetailsDTO()
                {
                    PatientName = app.Patient.PatientName,
                    Address = app.Patient.Address
                };
                appointmentDetails.Add(detailsDTO);
            }
            return appointmentDetails;

        }
        public ICollection<AppointmentCardDTO> ChangeAppointmentToAppointmentCardList(ICollection<Appointments> appointments)
        {
            ICollection<AppointmentCardDTO> appointmentCards = new List<AppointmentCardDTO> ();
            foreach (var app in appointments)
            {
                AppointmentCardDTO cardDTO = new AppointmentCardDTO()
                {
                    AppointmentID = app.Id,
                    PatientName = app.Patient.PatientName,
                    Age = app.Patient.Age,
                    DoctorName = app.Vet.DoctorName,
                    Department = app.Vet.Department,
                    AppointmentDate = app.AppointmentDate,
                    AppointmentTime = app.AppointmentTime,
                    AppointmentStatus = app.AppointmentStatus
                };
                appointmentCards.Add(cardDTO);
                
            }
            return appointmentCards;
        }

        public AppointmentFormDTO ChangeAppointmentToAppointmentForm(Appointments appointment)
        {
            AppointmentFormDTO formDTO = new AppointmentFormDTO()
            {
                Id = appointment.Id,
                AppointmentDate = appointment.AppointmentDate,
                AppointmentTime = appointment.AppointmentTime,
                AppointmentStatus = appointment.AppointmentStatus,
                Message = appointment.Message,
                patientsDTO = new PatientsDTO()
                {
                    PatientName = appointment.Patient.PatientName,
                    Age = appointment.Patient.Age,
                    Address = appointment.Patient.Address,
                    Email = appointment.Patient.Email,
                    Phone = appointment.Patient.Phone
                },
                VetsDTO = new VetsDTO()
                {
                    DoctorName = appointment.Vet.DoctorName,
                    Department = appointment.Vet.Department
                }
            };
            return formDTO;
        }
        public Appointments ChangeAppointmentFormToAppointmentEdit(AppointmentFormDTO formDTO)
        {
            Appointments appointment = new Appointments()
            {
                Id = formDTO.Id,
                AppointmentDate = formDTO.AppointmentDate,
                AppointmentTime = formDTO.AppointmentTime,
                AppointmentStatus = formDTO.AppointmentStatus,
                Message = formDTO.Message,
                PatientId = formDTO.Id,
                VetId = formDTO.Id,
                Patient = new Patients()
                {
                    Id = formDTO.Id,
                    PatientName = formDTO.patientsDTO.PatientName,
                    Age = formDTO.patientsDTO.Age,
                    Email = formDTO.patientsDTO.Email,
                    Phone = formDTO.patientsDTO.Phone,
                    Address = formDTO.patientsDTO.Address
                },
                Vet = new Vets()
                {
                    Id = formDTO.Id,
                    DoctorName = formDTO.VetsDTO.DoctorName,
                    Department = formDTO.VetsDTO.Department
                }
            };
            return appointment;
        }
    }
}
