using API_SIMPLE_CI_CD.Service;
using Microsoft.AspNetCore.Mvc;

namespace API_SIMPLE_CI_CD.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet("hello")]
        public IActionResult GetHello()
        {
            var service = new AdditionService();

            int resultat = service.Addition(40, 2);

            return Ok( new { message = $"bonjour {resultat} "  });
        }
        

           
        
    }
}
