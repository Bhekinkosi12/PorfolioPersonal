using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace Porfolio.Controllers
{
    public class EditController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> OnCreate()
        {
            return View();
        }

    }
}
