
using System.Diagnostics;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using MVCPractice.data.Enum;
using MVCPractice.Models;
using Microsoft.EntityFrameworkCore;

namespace MVCPractice.Controllers
{
    public class ClubController : Controller
    {
        private readonly ILogger<ClubController> _logger;

        private readonly ApplicationDbContext _context;
        public ClubController(ILogger<ClubController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Index()
        {
            var clubs = _context.Clubs.ToList();
            return View(clubs);
        }

        public IActionResult Detail(int id)
        {
            var club = _context.Clubs.Include(a => a.Address).First(club => club.Id == id);
            return View(club);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}