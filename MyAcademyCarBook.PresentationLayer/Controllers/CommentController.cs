using Microsoft.AspNetCore.Mvc;
using MyAcademyCarBook.BusinessLayer.Abstract;
using MyAcademyCarBook.EntityLayer.Concrete;

namespace MyAcademyCarBook.PresentationLayer.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SendComment(Comment comment)
        {
            Comment value = new Comment()
            {
                NameSurname = comment.NameSurname,
                Description = comment.Description,
                CarId = comment.CarId,
                CreatedDate = DateTime.Now,
            };
            _commentService.TInsert(comment);

            var carId = _commentService.TGetListAll().Where(x => x.CarId == comment.CarId).Select(y => y.CarId).FirstOrDefault();

            return RedirectToAction("CarDetail", "Car", new { id = carId });
        }
    }
}
