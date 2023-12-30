using Microsoft.AspNetCore.Mvc;
using MyAcademyCarBook.BusinessLayer.Abstract;
using MyAcademyCarBook.EntityLayer.Concrete;

namespace MyAcademyCarBook.PresentationLayer.Controllers
{
    public class CarCategoryController : Controller
    {
        private readonly ICarCategoryService _carCategoryService;

        public CarCategoryController(ICarCategoryService carCategoryService)
        {
            _carCategoryService = carCategoryService;
        }

        public IActionResult Index()
        {
            var values = _carCategoryService.TGetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddCarCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCarCategory(CarCategory carCategory)
        {
            _carCategoryService.TInsert(carCategory);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteCarCategory(int id)
        {
            var value = _carCategoryService.TGetById(id);
            _carCategoryService.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateCarCategory(int id)
        {
            var value = _carCategoryService.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateCarCategory(CarCategory carCategory)
        {
            _carCategoryService.TUpdate(carCategory);
            return RedirectToAction("Index");
        }



    }
}