using Microsoft.AspNetCore.Mvc;

namespace BillBoardManagementSystem.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult CreateAdvertise()
        {
            return View();
        }

    }
}
