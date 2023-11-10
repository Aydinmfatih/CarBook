using Microsoft.AspNetCore.Mvc;
using MyAcademyCarBook.BusinessLayer.Abstract;
using MyAcademyCarBook.DataAccessLayer.Concrete;

namespace MyAcademyCarBook.PresentationLayer.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarService _carService;
        private readonly ICarDetailService _carDetailService;
        public CarController(ICarService carService, ICarDetailService carDetailService)
        {
            _carService = carService;
            _carDetailService = carDetailService;
        }

        public IActionResult Index()
        {
            var values = _carService.TGetListAll();
            return View(values);
        }

        public IActionResult Index2()
        {
            var values = _carService.TGetAllCarsWithBrands();
            return View(values);
        }
        public IActionResult CarList()
        {
            ViewBag.title1 = "Araç Listesi";
            ViewBag.title2 = "Sizin için araç listesi";
            var values = _carService.TGetAllCarsWithBrands();
            return View(values);
        }

        public IActionResult CarDetail(int id)
        {
            ViewBag.title1 = "Araç Detayı";
            ViewBag.title2 = "Son Araç detayı";
            ViewBag.i = id;
            var value = _carDetailService.TGetCarDetailByCarId(id);
            ViewBag.v = value.Description;
            return View();
        }
    }
}
