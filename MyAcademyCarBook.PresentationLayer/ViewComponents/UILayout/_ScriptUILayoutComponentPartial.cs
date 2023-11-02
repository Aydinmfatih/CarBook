using Microsoft.AspNetCore.Mvc;

namespace MyAcademyCarBook.PresentationLayer.ViewComponents.UILayout
{
    public class _ScriptUILayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
