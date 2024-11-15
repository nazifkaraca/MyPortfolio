﻿using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.Controllers
{
	public class StatisticController : Controller
	{
		MyPortfolioContext portfolioContext = new MyPortfolioContext();
		public IActionResult Index()
		{
			ViewBag.v1 = portfolioContext.Skills.Count();
			ViewBag.v2 = portfolioContext.Messages.Count();
			ViewBag.v3 = portfolioContext.Messages.Where(x => x.IsRead == true).Count();
			ViewBag.v4 = portfolioContext.Messages.Where(x => x.IsRead == false).Count();
			return View();
		}
	}
}