using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyAcademyCarBook.BusinessLayer.Abstract;

namespace MyAcademyCarBook.PresentationLayer.ViewComponents.DefaultComponents
{
    public class _DefaultFilteredCarListComponentPartial : ViewComponent
    {
        private readonly ICarService _carService;
        private readonly ICarCategoryService _carCategoryService;
        private readonly IBrandService _brandService;

        public _DefaultFilteredCarListComponentPartial(ICarService carService, ICarCategoryService carCategoryService, IBrandService brandService)
        {
            _carService = carService;
            _carCategoryService = carCategoryService;
            _brandService = brandService;
        }

        public IViewComponentResult Invoke()
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
            List<SelectListItem> value3 = _carService.TGetListAll()
       .Select(x => new SelectListItem
       {
           Text = x.GearType,
           Value = x.CarId.ToString()
       })
       .ToList();

            ViewBag.brand = value1;
            ViewBag.category = value2;
            ViewBag.geartype = value3;

            return View();
        }


    }
}
