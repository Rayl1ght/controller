using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Ymagazin.Models;

namespace Ymagazin.Controllers
{
    public class HomeController : Controller
    {
        Context db;
        public HomeController(Context context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.Clients.ToList());
        }
    }
}