using Microsoft.AspNetCore.Mvc;

namespace MyAcademyCarBook.PresentationLayer.ViewComponents.DefaultComponents
{
    public class _DefaultFilteredCarListComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }


    }
}
