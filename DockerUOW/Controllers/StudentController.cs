using DockerUOW.Dto;
using DockerUOW.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DockerUOW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService studentService;

        public StudentController(IStudentService studentService)
        {
            this.studentService = studentService;
        }

        [HttpGet]
        [Produces("application/json")]
        public async Task<IEnumerable<StudentDto>> GetAllStudents()
        {
            return await studentService.GetAllStudents();
        }
    }
}
