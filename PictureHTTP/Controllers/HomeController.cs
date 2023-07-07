using Microsoft.AspNetCore.Mvc;
using PictureHTTP.Models;
using System.Diagnostics;

namespace PictureHTTP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private HomeViewModel db = new HomeViewModel();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public List<string> GetAllPictures()
        {
            return db.allPictures;
        }

        public List<string> UploadPicture(string pic)
        {
            db.allPictures.Add(pic);
            return db.allPictures;
        }
    }
}