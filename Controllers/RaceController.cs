
using Microsoft.AspNetCore.Mvc;


namespace MVCPractice.Controllers
{
    public class RaceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}