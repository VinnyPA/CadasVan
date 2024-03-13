using Microsoft.AspNetCore.Mvc;

namespace Cadasvan.Controllers
{
    public class Aluno : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
    }
}
