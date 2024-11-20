using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StartupWEBAPIEra.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public List<string> student = new List<string>()
        {
            "Name",
            "Age",
            "Rank"
        };
        [HttpGet]
        public IActionResult studentDetails()
        {
            return Ok(student);
        }
    }
}
