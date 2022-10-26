using Microsoft.AspNetCore.Mvc;

namespace BookList.Controllers
{
    public class UserController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
