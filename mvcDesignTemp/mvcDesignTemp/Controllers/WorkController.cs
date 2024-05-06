using Microsoft.AspNetCore.Mvc;

namespace mvcDesignTemp.Controllers
{
    public class WorkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
