using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyAcademyCarBook.BusinessLayer.Abstract;
using MyAcademyCarBook.DataAccessLayer.Concrete;
using MyAcademyCarBook.EntityLayer.Concrete;

namespace MyAcademyCarBook.PresentationLayer.ViewComponents.CarDetailComponents
{
    public class _CarDetailCategoryComponentPartial:ViewComponent
    {

        private readonly ICarCategoryService _carCategoryService;
        private readonly CarBookContext _context;
        public _CarDetailCategoryComponentPartial(ICarCategoryService carCategoryService, CarBookContext context)
        {
            _carCategoryService = carCategoryService;
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var values = _carCategoryService.TGetListAll();
            return View(values);
        }
    }
}
