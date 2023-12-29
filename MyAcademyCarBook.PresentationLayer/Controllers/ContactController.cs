using Microsoft.AspNetCore.Mvc;
using MyAcademyCarBook.BusinessLayer.Abstract;
using MyAcademyCarBook.EntityLayer.Concrete;

namespace MyAcademyCarBook.PresentationLayer.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            var values = _contactService.TGetListAll();
            return View(values);
        }

        public IActionResult DeleteContact(int id)
        {
            var value = _contactService.TGetById(id);
            _contactService.TDelete(value);
            return RedirectToAction("Index");
        }

        public IActionResult UIContact()
        {
            ViewBag.title1 = "Bize Ulaşın";
            ViewBag.title2 = "Size en kısa sürede dönüş yapacağız";
            return View();
        }
        [HttpPost]
        public IActionResult CreateContact(Contact contact)
        {
            _contactService.TInsert(contact);
            return RedirectToAction("UIContact");
        }

    }
}
