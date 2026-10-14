using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CICDStudentManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new
            {
                Status = "Healthy",
                Message = "Student Management API is running successfully."
            });
        }
    }
}
