using AppointmentScheduling1.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppointmentScheduling1.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AccountController(ApplicationDbContext db)
        {
                _db = db;  
        }

        public IActionResult Index()
        {

            return View();
        }
    }
}
