using Microsoft.AspNetCore.Mvc;
using MyAcademyCarBook.BusinessLayer.Abstract;

namespace MyAcademyCarBook.PresentationLayer.ViewComponents.ServiceComponents
{
    public class _ServicesComponentPartial:ViewComponent
    {
        private readonly IServiceService _serviceService;

        public _ServicesComponentPartial(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _serviceService.TGetListAll();
            return View(values);
        }
    }
}
