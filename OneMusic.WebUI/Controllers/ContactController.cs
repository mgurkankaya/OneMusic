using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OneMusic.BusinessLayer.Abstract;

namespace OneMusic.WebUI.Controllers
{
    [AllowAnonymous]
    public class ContactController(IContactService _contactService) : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
