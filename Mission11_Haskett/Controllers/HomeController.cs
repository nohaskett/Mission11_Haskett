using Microsoft.AspNetCore.Mvc;
using Mission11_Haskett.Models;
using System.Diagnostics;

namespace Mission11_Haskett.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
