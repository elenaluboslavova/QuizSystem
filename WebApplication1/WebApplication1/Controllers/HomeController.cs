using Microsoft.AspNetCore.Mvc;
using QuizSystem.Services.Quizzes;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IQuizService quizzes;

        public HomeController(ILogger<HomeController> logger, IQuizService quizzes)
        {
            _logger = logger;
            this.quizzes = quizzes;
        }

        public IActionResult Index()
        {
            var latestQuizzes = this.quizzes.All();
            return View(latestQuizzes);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}