using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Appointment.DTO
{
    public class AppointmentFormDTO
    {
        public int Id { get; set; }
        public string AppointmentDate { get; set; }
        public string AppointmentTime { get; set; }
        public string Message { get; set; }
        public bool AppointmentStatus { get; set; }
        public PatientsDTO patientsDTO { get; set; }
        public VetsDTO VetsDTO { get; set; }
    }
}
