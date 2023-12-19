using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

using MyAcademyCarBook.BusinessLayer.Abstract;
using MyAcademyCarBook.BusinessLayer.ValidationRules.ServiceValidation;
using MyAcademyCarBook.EntityLayer.Concrete;

namespace MyAcademyCarBook.PresentationLayer.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public IActionResult Index()
        {
            ViewBag.title1 = "Servis Listesi";
            ViewBag.title2 = "Sizin için Servis listesi";
            return View();
        }

        public IActionResult ServiceList()
        {
            var values = _serviceService.TGetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateService()
        {

            return View();
        }

        [HttpPost]
        public IActionResult CreateService(Service service)
        {
            CreateServiceValidator validationRules = new CreateServiceValidator();
            ValidationResult result = validationRules.Validate(service);
            if (result.IsValid)
            {
                _serviceService.TInsert(service);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View(service);
        }

    }
}
