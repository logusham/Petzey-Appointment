using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Petzey.Appointment.Data.Business;
using Petzey.Appointment.Domain.BusinessInterface;
using Petzey.Appointment.Domain.Entites;
using Petzey.Appointment.DTO;

namespace Petzey.Appointment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        IAppointmentService service;
        public AppointmentController()
        {
            service = new AppointmentService();
        }

        [HttpPost]
        [Route("create")]
        public IActionResult CreateAppointment(AppointmentFormDTO formDTO)
        {
            try
            {
                if(formDTO == null)
                {
                    return NotFound();
                }
                service.CreateAppointment(formDTO);
                return Ok("Done");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        [Route("edit")]
        public IActionResult EditAppointment(AppointmentFormDTO formDTO)
        {
            try
            {
                if(formDTO == null)
                {
                    return NotFound();
                }
                 service.EditAppointment(formDTO);
                return Ok("Done");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteAppointment(int id)
        {
            service.DeleteAppointment(id);
            return Ok("Done");
        }
        [HttpGet]
        [Route("form/{id}")]
        public IActionResult GetAppointmentForm(int id)
        {
            try
            {
                AppointmentFormDTO appointmentForm = service.GetAppointmentForm(id);
                if (appointmentForm == null)
                {
                    return NotFound();
                }
                return Ok(appointmentForm);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpGet]
        [Route("allpatientsdetails")]
        public IActionResult GetAllAppointmentDetails(string doctorName)
        {
            try
            {
                var appointmentsDetails = service.GetAllAppointmentDetails(doctorName);
                if (appointmentsDetails == null)
                {
                    return NotFound();
                }
                return Ok(appointmentsDetails);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("allappointmentcards")]
        public IActionResult GetAllAppointmentCard(string doctorName)
        {
            try
            {
                var appointmentCards = service.GetAllAppointmentCards(doctorName);
                if(appointmentCards == null)
                {
                    return NotFound();
                }
                return Ok(appointmentCards);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("allappointment")]
        public IActionResult GetAllAppointment()
        {
            
            try
            {
                ICollection<Appointments> appointments = service.GetAllAppointment();
                if (appointments == null)
                {
                    return NotFound();
                }
                return Ok(appointments);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpGet]
        [Route("appointmentid")]
        public IActionResult GetAppointmentId()
        {
            try
            {
                int Id = service.GetAppointmentId() + 1;
                if (Id <= 0)
                {
                    return NotFound();
                }
                return Ok(Id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
