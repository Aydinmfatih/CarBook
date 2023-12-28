using Microsoft.AspNetCore.Mvc;
using MyAcademyCarBook.BusinessLayer.Abstract;

namespace MyAcademyCarBook.PresentationLayer.ViewComponents.AboutComponents
{
    public class _AboutTestimonailsComponentPartial:ViewComponent
    {
        private readonly ITestimonialService _testimonialService;

        public _AboutTestimonailsComponentPartial(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _testimonialService.TGetListAll();
            return View(values);
        }
    }
}
