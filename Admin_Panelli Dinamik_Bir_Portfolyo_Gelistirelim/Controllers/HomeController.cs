using Admin_Panelli_Dinamik_Bir_Portfolyo_Gelistirelim.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Admin_Panelli_Dinamik_Bir_Portfolyo_Gelistirelim.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
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
