using Microsoft.AspNetCore.Mvc;
using MyAcademyCarBook.BusinessLayer.Abstract;
using MyAcademyCarBook.EntityLayer.Concrete;

namespace MyAcademyCarBook.PresentationLayer.Controllers
{
    public class BrandController : Controller
    {
        private readonly IBrandService _brandService;

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        public IActionResult Index()
        {
            var values = _brandService.TGetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddBrand()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddBrand(Brand brand)
        {
            _brandService.TInsert(brand);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteBrand(int id)
        {
            _brandService.TDelete(_brandService.TGetById(id));
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateBrand(int id)
        {
            var value = _brandService.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateBrand(Brand brand)
        {
            _brandService.TInsert(brand);
            return RedirectToAction("Index");
        }

        public IActionResult GetBrandSearchBynName(string p)
        {
            ViewData["CurrentFilter"] = p;
            var values = from x in _brandService.TGetListAll() select x;
            if (!string.IsNullOrEmpty(p))
            {
                values = values.Where(y => y.BrandName.Contains(p));
            }
            
            return View(values.ToList());
        }
    }
}
