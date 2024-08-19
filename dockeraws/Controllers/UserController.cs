using dockeraws.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dockeraws.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        [HttpGet(Name = "GetUsers")]
        public ActionResult Index()
        {

            List<User> users = new List<User>();

            users.Add(new User { Name = "Anantha", desgination = "Software Engineer", country = "India", city = "Kumbakonam" });
            users.Add(new User { Name = "Kumar", desgination = "Software Engineer", country = "India", city = "Kumbakonam" });
            users.Add(new User { Name = "Sai", desgination = "Studen", country = "India", city = "Kumbakonam" });
            users.Add(new User { Name = "Anusuya", desgination = "Asst.Professor", country = "India", city = "Kumbakonam" });
            users.Add(new User { Name = "Madan", desgination = "Sr.Software Engineer", country = "India", city = "Kumbakonam" });
            return Ok(users);
        }




        [HttpGet("health")]
        public IActionResult HealthCheck()
        {
            return Ok("Healthy");
        }









    }
}
