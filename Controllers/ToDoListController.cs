using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
	public class ToDoListController : Controller
	{
		MyPortfolioContext portfolioContext = new MyPortfolioContext();
		public IActionResult Index()
		{
			var values = portfolioContext.ToDoListS.ToList();
			return View(values);
		}

		[HttpGet]
		public IActionResult CreateToDoList()
		{
			return View();
		}

		[HttpPost]
		public IActionResult CreateToDoList(ToDoList toDoList)
		{
			toDoList.Status = false;
			portfolioContext.ToDoListS.Add(toDoList);
			portfolioContext.SaveChanges();
			return RedirectToAction("Index");
		}

		public IActionResult DeleteToDoList(int id)
		{
			var value = portfolioContext.ToDoListS.Find(id);
			portfolioContext.ToDoListS.Remove(value);
			portfolioContext.SaveChanges();
			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult UpdateToDoList(int id)
		{
			var value = portfolioContext.ToDoListS.Find(id);
			return View(value);
		}

		[HttpPost]
		public IActionResult UpdateToDoList(ToDoList toDoList)
		{
			portfolioContext.ToDoListS.Update(toDoList);
			portfolioContext.SaveChanges();
			return RedirectToAction("Index");
		}

		public IActionResult ChangeIsDoneToFalse(int id)
		{
			var value = portfolioContext.ToDoListS.Find(id);
			value.Status = false;
			portfolioContext.SaveChanges();
			return RedirectToAction("Index");
		}

		public IActionResult ChangeIsDoneToTrue(int id)
		{
			var value = portfolioContext.ToDoListS.Find(id);
			value.Status = true;
			portfolioContext.SaveChanges();
			return RedirectToAction("Index");	
		}
	}
}
