using Microsoft.AspNetCore.Mvc;

namespace VideoTranscript.Controllers
{
    public class PersonalAccountController : Controller
    {
        public IActionResult Account()
        {
            return View();
        }
    }
}
