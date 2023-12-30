using Microsoft.AspNetCore.Mvc;
using MyAcademyCarBook.BusinessLayer.Abstract;
using MyAcademyCarBook.EntityLayer.Concrete;

namespace MyAcademyCarBook.PresentationLayer.Controllers
{
    public class AdminCarDetail : Controller
    {
        private readonly ICarDetailService _carDetailService;

        public AdminCarDetail(ICarDetailService carDetailService)
        {
            _carDetailService = carDetailService;
        }

        public IActionResult Index()
        {
            var values = _carDetailService.TGetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddCarDetail()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCarDetail(CarDetail carDetail)
        {
            _carDetailService.TInsert(carDetail);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteCarDetail(int id)
        {
            _carDetailService.TDelete(_carDetailService.TGetById(id));
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateCarDetail(int id)
        {
            var value = _carDetailService.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateCarDetail(CarDetail carDetail)
        {
            _carDetailService.TUpdate(carDetail);
            return RedirectToAction("Index");
        }
    }
}
