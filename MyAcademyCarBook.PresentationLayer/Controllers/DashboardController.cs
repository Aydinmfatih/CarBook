using Microsoft.AspNetCore.Mvc;
using MyAcademyCarBook.BusinessLayer.Abstract;

namespace MyAcademyCarBook.PresentationLayer.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ICarService _carService;

        public DashboardController(ICarService carService)
        {
            _carService = carService;
        }

        public IActionResult Index()
        {
            var values = _carService.TGetAllCarsWithBrands();
            ViewBag.count = _carService.TGetAllCarsWithBrands().Count();
            return View(values);
        }
    }
}
