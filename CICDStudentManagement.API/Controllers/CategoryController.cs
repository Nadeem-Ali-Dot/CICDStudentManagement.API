using CICDStudentManagement.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CICDStudentManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private readonly IStudentService _Service;
        public CategoryController(IStudentService studentService)
        {
            this._Service = studentService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var students = _Service.GetAll();
            return Ok(students);
        }
    }
}