using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using JeyLabsCodePuzzle.Domain2;
using Microsoft.AspNetCore.Mvc;
using JeyLabsCodePuzzle.WebApp.Models;

namespace JeyLabsCodePuzzle.WebApp.Controllers
{
	public class HomeController : Controller
	{
		private readonly IShapeGenerator shapeGenerator;

		public HomeController(IShapeGenerator shapeGenerator)
		{
			this.shapeGenerator = shapeGenerator;
		}

		[HttpGet]
		public IActionResult Index()
		{
			var model = new ShapeGeneratorModel();

			return View(model);
		}

		[HttpPost]
		public IActionResult Index(ShapeGeneratorModel model)
		{
			if (ModelState.IsValid)
			{
				var shape = shapeGenerator.ParseCommand(model.Command);
				if (shape != null)
				{
					model.Shape = shape;
				}
				else
				{
					ModelState.AddModelError("", "Failed to understand your command");
				}
			}

			return View(model);
		}

		public IActionResult Commands()
		{
			return View();
		}



		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
