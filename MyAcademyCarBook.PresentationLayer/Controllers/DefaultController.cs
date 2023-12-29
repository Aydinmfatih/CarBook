using Microsoft.AspNetCore.Mvc;

namespace MyAcademyCarBook.PresentationLayer.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
