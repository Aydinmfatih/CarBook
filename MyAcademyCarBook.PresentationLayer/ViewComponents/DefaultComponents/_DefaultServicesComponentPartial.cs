using Microsoft.AspNetCore.Mvc;
using MyAcademyCarBook.BusinessLayer.Abstract;

namespace MyAcademyCarBook.PresentationLayer.ViewComponents.DefaultComponents
{
    public class _DefaultServicesComponentPartial:ViewComponent
    {
        private readonly IServiceService _serviceService;

        public _DefaultServicesComponentPartial(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _serviceService.TGetListAll().Take(3).ToList();
            return View(values);
        }
    }
}
