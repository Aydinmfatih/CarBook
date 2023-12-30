using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyAcademyCarBook.BusinessLayer.Abstract;
using MyAcademyCarBook.DataAccessLayer.Concrete;
using MyAcademyCarBook.EntityLayer.Concrete;
using Newtonsoft.Json.Linq;
using X.PagedList;

namespace MyAcademyCarBook.PresentationLayer.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarService _carService;
        private readonly ICarDetailService _carDetailService;
        private readonly IBrandService _brandService;
        private readonly ICarCategoryService _carCategoryService;
        private readonly ICarStatusService _carStatusService;
        public CarController(ICarService carService, ICarDetailService carDetailService, IBrandService brandService, ICarCategoryService carCategoryService, ICarStatusService carStatusService)
        {
            _carService = carService;
            _carDetailService = carDetailService;
            _brandService = brandService;
            _carCategoryService = carCategoryService;
            _carStatusService = carStatusService;
        }

        public IActionResult Index()
        {
            var values = _carService.TGetAllCarsWithBrands();
            return View(values);
        }

        public IActionResult Index2()
        {
            var values = _carService.TGetAllCarsWithBrands();
            return View(values);
        }
        public IActionResult CarList(int page = 1)
        {

            ViewBag.title1 = "Araç Listesi";
            ViewBag.title2 = "Sizin için araç listesi";

            var allCars = _carService.TGetAllCarsWithBrands().ToPagedList(page,4);


            return View(allCars);
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

        [HttpGet]
        public IActionResult DeleteCar(int id)
        {
            var value = _carService.TGetById(id);
            _carService.TDelete(value);
            return View();
        }

        [HttpGet]
        public IActionResult UpdateCar(int id)
        {
            var value = _carService.TGetById(id);
            List<SelectListItem> categories = _carCategoryService.TGetListAll()
                .Where(x => x.CategoryName != null)
                .Select(x => new SelectListItem
                {
                    Text = x.CategoryName,
                    Value = x.CarCategoryId.ToString()
                })
                .ToList();

            List<SelectListItem> brands = _brandService.TGetListAll()
                .Where(x => x.BrandName != null)
                .Select(x => new SelectListItem
                {
                    Text = x.BrandName,
                    Value = x.BrandId.ToString()
                })
                .ToList();

            List<SelectListItem> statuses = _carStatusService.TGetListAll()
                .Where(x => x.CarStatusName != null)
                .Select(x => new SelectListItem
                {
                    Text = x.CarStatusName,
                    Value = x.CarStatusId.ToString()
                })
                .ToList();

            // ViewBag'e bu listeleri ekleyin
            ViewBag.CarCategoryList = categories;
            ViewBag.BrandList = brands;
            ViewBag.CarStatusList = statuses;

            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateCar(Car car)
        {
            _carService.TUpdate(car);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CreateCar()
        {
            List<SelectListItem> value1 = _brandService.TGetListAll()
        .Where(x => x.BrandName != null)
        .Select(x => new SelectListItem
        {
            Text = x.BrandName,
            Value = x.BrandId.ToString()
        })
        .ToList();
            List<SelectListItem> value2 = _carCategoryService.TGetListAll()
        .Where(x => x.CategoryName != null)
        .Select(x => new SelectListItem
        {
            Text = x.CategoryName,
            Value = x.CarCategoryId.ToString()
        })
        .ToList();
            List<SelectListItem> value3 = _carStatusService.TGetListAll()
       .Where(x => x.CarStatusName != null)
       .Select(x => new SelectListItem
       {
           Text = x.CarStatusName,
           Value = x.CarStatusId.ToString()
       })
       .ToList();

            ViewBag.brand = value1;
            ViewBag.category = value2;
            ViewBag.status = value3;

            return View();
        }
        [HttpPost]
        public IActionResult CreateCar(Car car)
        {
            _carService.TInsert(car);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult RentCar(int seatCount, string gearType, int brandId, int categoryId)
        {
            var values = _carService.TGetAllCarsWithBrands().Where(x => x.PersonCount == seatCount && x.GearType == gearType && x.BrandId == brandId && x.CarCategoryId == categoryId).ToList();

            return View(values);
        }

    }
}
