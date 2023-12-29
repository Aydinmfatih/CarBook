using Microsoft.AspNetCore.Mvc;
using MyAcademyCarBook.BusinessLayer.Abstract;

namespace MyAcademyCarBook.PresentationLayer.ViewComponents.DefaultComponents
{
    public class _DefaultCarCarouselComponentPartial:ViewComponent
    {
        private readonly ICarService _carService;

        public _DefaultCarCarouselComponentPartial(ICarService carService)
        {
            _carService = carService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _carService.TGetAllCarsWithBrands().Take(5).ToList();
            return View(values);
        }
    }
}
