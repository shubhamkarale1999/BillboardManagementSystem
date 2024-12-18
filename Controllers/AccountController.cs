using Microsoft.AspNetCore.Mvc;

namespace BillBoardManagementSystem.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult AdminLogin()
        {
            return View();
        }
    }
}
