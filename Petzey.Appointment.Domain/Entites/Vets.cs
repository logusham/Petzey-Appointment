using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Appointment.Domain.Entites
{
    public class Vets
    {
        [Key]
        public int Id { get; set; }
        public string DoctorName { get; set; }
        public string Department { get; set; }
    }
}
