
using System.Data.Common;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCPractice.data.Enum;
using MVCPractice.Models;
using Microsoft.EntityFrameworkCore;


namespace MVCPractice.Controllers
{
    public class RaceController : Controller
    {

        private readonly ApplicationDbContext _context;

        private ILogger<RaceController> _logger;

        public RaceController(ILogger<RaceController> logger, ApplicationDbContext context)
        {
            _context = context;
            _logger = logger;
        }
        public IActionResult Index()
        {

            var races = _context.Races.ToList();
            return View(races);
        }

        public IActionResult Detail(int id)
        {
            var race = _context.Races.Include(a => a.Address).First(r => r.Id == id);
            return View(race);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}