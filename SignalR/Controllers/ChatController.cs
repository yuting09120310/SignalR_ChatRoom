using Microsoft.AspNetCore.Mvc;
using SignalR.Models;
using System.Diagnostics;

namespace SignalR.Controllers
{
	public class ChatController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public ChatController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult ChatRoom()
		{
			return View();
		}

	}
}