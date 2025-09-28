using Microsoft.AspNetCore.Mvc;

namespace VideoTranscript.Controllers
{
    public class PersonalAccount : Controller
    {
        public IActionResult Account()
        {
            return View();
        }
    }
}
