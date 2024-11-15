using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.Controllers
{
	public class MessageController : Controller
	{
		MyPortfolioContext portfolioContext = new MyPortfolioContext();
		public IActionResult Inbox()
		{
			var values = portfolioContext.Messages.ToList();
			return View(values);
		}

		public IActionResult ChangeIsReadToTrue(int id)
		{
			var value = portfolioContext.Messages.Find(id);
			value.IsRead = true;
			portfolioContext.SaveChanges();
			return RedirectToAction("Inbox");
		}

		public IActionResult ChangeIsReadToFalse(int id)
		{
			var value = portfolioContext.Messages.Find(id);
			value.IsRead = false;
			portfolioContext.SaveChanges();
			return RedirectToAction("Inbox");
		}
	}
}
