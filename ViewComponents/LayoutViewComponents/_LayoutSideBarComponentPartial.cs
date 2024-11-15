using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace MyPortfolio.ViewComponents.LayoutViewComponents
{
	public class _LayoutSideBarComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
