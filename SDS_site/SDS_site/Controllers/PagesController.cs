using Microsoft.AspNetCore.Mvc;
using SDS_site.Models;
using System.Diagnostics;

namespace SDS_site.Controllers
{
    public class PagesController : Controller
    {
        private readonly ILogger<PagesController> _logger;

        public PagesController(ILogger<PagesController> logger)
        {
            _logger = logger;
        }

        public IActionResult HomePage()
        {
            return View();
        }

        public IActionResult NovelPage()
        {
            return View();
        }

        public IActionResult GameCreationPage()
        {
            return View();
        }

        public IActionResult NovelDesignerPage()
        {
            return View();
        }

        public IActionResult SiteDevelopmentPage()
        {
            return View();
        }

        public IActionResult TelegramBotDevelopment()
        {
            return View();
        }

        public IActionResult SoftwareDevelopmentPage()
        {
            return View();
        }

        public IActionResult DesignServicePage()
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