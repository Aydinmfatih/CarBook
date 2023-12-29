using Microsoft.AspNetCore.Mvc;
using MyAcademyCarBook.BusinessLayer.Abstract;
using MyAcademyCarBook.DataAccessLayer.Abstract;

namespace MyAcademyCarBook.PresentationLayer.ViewComponents.ContactComponents
{
    public class _ContactInfoComponentPartial : ViewComponent
    {
        private readonly IContactInfoService _contactInfoService;

        public _ContactInfoComponentPartial(IContactInfoService contactInfoService)
        {
            _contactInfoService = contactInfoService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _contactInfoService.TGetListAll();
            return View(values);
        }
    }
}
