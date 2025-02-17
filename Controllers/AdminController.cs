using Microsoft.AspNetCore.Mvc;
using Core.Interfaces;


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
