using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Appointment.DTO
{
    public class AppointmentCardDTO
    {
        public int AppointmentID { get; set; }
        public string PatientName { get; set; }
        public int Age { get; set; }
        public string DoctorName { get; set; }
        public string Department { get; set; }
        public string AppointmentDate { get; set; }
        public string AppointmentTime { get; set; }
        public bool AppointmentStatus { get; set; }

    }
}
