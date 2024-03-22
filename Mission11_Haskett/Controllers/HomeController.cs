using Microsoft.AspNetCore.Mvc;
using Mission11_Haskett.Models;
using System.Diagnostics;

namespace Mission11_Haskett.Controllers
{
    public class HomeController : Controller
    {
        private IBookRepository _repo;

        public HomeController(IBookRepository temp)
        {
            _repo = temp;
        }
        public IActionResult Index()
        {
            var bookData = _repo.Books;
            return View(bookData);
        }
    }
}
