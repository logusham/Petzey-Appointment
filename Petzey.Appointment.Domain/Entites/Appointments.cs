using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Appointment.Domain.Entites
{
    public class Appointments
    {
        [Key]
        public int Id { get; set; }
        public string AppointmentDate { get; set; }
        public string AppointmentTime { get; set; }
        [AllowNull]
        public string Message { get; set; }
        public bool AppointmentStatus { get; set; }
        [Required]
        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        public Patients Patient { get; set; }
        [Required]
        [ForeignKey("Vet")]
        public int VetId { get; set; }
        public Vets Vet { get; set; }

    }
}
