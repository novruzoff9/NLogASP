using Microsoft.AspNetCore.Mvc;
using NLog;
using NLogForASP.Models;
using System.Diagnostics;

namespace NLogForASP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        Logger logger = LogManager.GetCurrentClassLogger();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _logger.LogDebug(1, "NLog HomeController-a inject olundu!");
        }

        public IActionResult Index()
        {

            _logger.LogInformation("HomeController-un Index səhifəsi işə düşdü");
            logger.Trace("Trace üçün log");
            logger.Info("Informasiya üçün log");
            logger.Debug("Debug üçün log");
            logger.Warn("Xəbərdarlıq üçün log");
            logger.Error("Xəta üçün log");
            logger.Fatal("Çökmə üçün log");
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
