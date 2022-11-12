using Microsoft.AspNetCore.Mvc;
using Porfolio.Models;
using Porfolio.Services.Project;
using Porfolio.Services.Blog;
using Porfolio.Services;
using System.Diagnostics;

namespace Porfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IProductServices _product;
        private IBlogServices _blog;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _product = new ProductServices();
            _blog = new BlogServices();
        }

        public async Task<IActionResult> Index()
        {
            var list = await _product.GetProjects();
            var blogs = await _blog.GetAllAllBlogs();
            ViewBag.Projects = list;
            var indexP = new IndexViewModel()
            {
                Projects = list,
                Blogs = blogs

            };

            return View(indexP);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Blog()
        {
            return View();
        }
        public IActionResult Project()
        {
            return View();
        }
        
        public IActionResult Sent()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> OnOpenPoject(string id)
        {
            var selected = await _product.GetProject(id);
            return View("Project",selected);
        }
        [HttpPost]
        public async Task<IActionResult> OnOpenBlog(string id)
        {
            var selected = await _blog.GetBlogById(id);

            return View("Blog",selected);
        }

        [HttpPost]
        public async Task<IActionResult> OnSendMsg(string name,string email,string subject,string msg)
        {
            var model = new NotificationM()
            {
                 Name = name,
                  Email = email,
                   Subject = subject,
                    Msg = msg
            };

            NotificationService notificationService = new NotificationService();
            await notificationService.SendMsgAsync(model);

           return View("Sent");

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}