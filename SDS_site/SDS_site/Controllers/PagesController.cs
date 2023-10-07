using System.Net;

namespace SDS_site.Controllers
{
    //Контролле для перехода по страницам сайта
    //-------------------------------------------------------------------------------------------------------------------------------------------------
    public class PagesController : Controller
    {
        private readonly ILogger<PagesController> _logger;

        public PagesController(ILogger<PagesController> logger)
        {
            _logger = logger;
        }

        public IActionResult HomePage()
        {
            StatisticsDisplay statisticsDisplay = new (GetIPAddress(), "HomePage");
            return View();
        }

        public IActionResult NovelPage()
        {
            StatisticsDisplay statisticsDisplay = new(GetIPAddress(), "NovelPage");
            return View();
        }

        public IActionResult GameCreationPage()
        {
            StatisticsDisplay statisticsDisplay = new(GetIPAddress(), "GameCreation");
            return View();
        }

        public IActionResult NovelDesignerPage()
        {
            StatisticsDisplay statisticsDisplay = new(GetIPAddress(), "NovelDesigner");
            return View();
        }

        public IActionResult SiteDevelopmentPage()
        {
            StatisticsDisplay statisticsDisplay = new(GetIPAddress(), "SiteDevelopment");
            return View();
        }

        public IActionResult TelegramBotDevelopmentPage()
        {
            StatisticsDisplay statisticsDisplay = new(GetIPAddress(), "TelegramBotDevelopment");
            return View();
        }

        public IActionResult SoftwareDevelopmentPage()
        {
            StatisticsDisplay statisticsDisplay = new(GetIPAddress(), "SoftwareDevelopment");
            return View();
        }

        public IActionResult DesignServicePage()
        {
            StatisticsDisplay statisticsDisplay = new(GetIPAddress(), "DesignService");
            return View();
        }

        private string GetIPAddress()
        {
            if (HttpContext.Request.Headers.ContainsKey("X-Forwarded-For")) return HttpContext.Request.Headers["X-Forwarded-For"];
            else return HttpContext.Connection.RemoteIpAddress.ToString();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
    //-------------------------------------------------------------------------------------------------------------------------------------------------
}