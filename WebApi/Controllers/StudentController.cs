using Data.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Business;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentBusines studentBusines;

        public StudentController(StudentBusines studentBusines)
        {
            this.studentBusines = studentBusines;
        }

        [HttpPost]
        public IActionResult Post(Student student)
        {
            studentBusines.Add(student);

            return StatusCode(StatusCodes.Status201Created);
        }
    }
}
