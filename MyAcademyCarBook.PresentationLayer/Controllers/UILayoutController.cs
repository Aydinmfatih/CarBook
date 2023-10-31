using Microsoft.AspNetCore.Mvc;

namespace MyAcademyCarBook.PresentationLayer.Controllers
{
	public class UILayoutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
