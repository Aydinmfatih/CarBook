using Microsoft.AspNetCore.Mvc;
using MyAcademyCarBook.BusinessLayer.Abstract;
using MyAcademyCarBook.DataAccessLayer.Concrete;

namespace MyAcademyCarBook.PresentationLayer.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ICarService _carService;
        private readonly CarBookContext _context;

        public DashboardController(ICarService carService, CarBookContext context)
        {
            _carService = carService;
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _carService.TGetAllCarsWithBrands();
            ViewBag.count = _context.Cars.Count();
            var value = _context.Prices.Max(x => x.PriceValue);
            ViewBag.maxprice = _context.Prices.Max(x => x.PriceValue);
            ViewBag.testimonials=_context.Testimonials.Count();
            ViewBag.avg = _context.Prices.Average(x => x.PriceValue);
            ViewBag.brand = _context.Brands.Count();
            return View(values);
        }
    }
}
