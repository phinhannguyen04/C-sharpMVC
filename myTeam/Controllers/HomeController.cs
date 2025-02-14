using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using myTeam.Data;
using myTeam.Models;

namespace myTeam.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Contact (Contact model)
        {
            if (ModelState.IsValid)
            {
                model.Id = Guid.NewGuid();
                model.Title = $"Mail contact from #ID {model.Id}";
                model.DateTime = DateTime.Now;

                _context.Contacts.AddAsync(model);
                _context.SaveChanges();

                return RedirectToAction("Index", "Home");
            } 
            return View(model);
        }


        public IActionResult TestDatabaseConnection()
        {
            try
            {
                var contact = _context.Contacts.FirstOrDefault();
                if (contact != null)
                {
                    return Ok("Database connection is working!");
                }
                else
                {
                    return Ok("Database connection is working, but no contacts found.");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Database connection failed: {ex.Message}");
            }
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
