using Microsoft.AspNetCore.Mvc;
using MyAcademyCarBook.BusinessLayer.Abstract;

namespace MyAcademyCarBook.PresentationLayer.ViewComponents.ServiceComponents
{
    public class _HowItWorksStepComponentPartial:ViewComponent
    {
        private readonly IHowItWorkStepService _howItWorkStepService;

        public _HowItWorksStepComponentPartial(IHowItWorkStepService howItWorkStepService)
        {
            _howItWorkStepService = howItWorkStepService;
        }

        public  IViewComponentResult Invoke()
        {
            var values = _howItWorkStepService.TGetListAll();
            return View(values);
        }
    }
}
