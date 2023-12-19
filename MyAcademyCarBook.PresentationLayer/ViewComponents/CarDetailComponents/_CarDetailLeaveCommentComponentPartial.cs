using Microsoft.AspNetCore.Mvc;

namespace MyAcademyCarBook.PresentationLayer.ViewComponents.CarDetailComponents
{
    public class _CarDetailLeaveCommentComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            ViewBag.commentId = id;
            return View();
        }
    }
}
