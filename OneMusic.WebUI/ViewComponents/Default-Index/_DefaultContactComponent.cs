using Microsoft.AspNetCore.Mvc;
using OneMusic.BusinessLayer.Abstract;

namespace OneMusic.WebUI.ViewComponents.Default_Index
{
    public class _DefaultContactComponent(IMessageService _messageService): ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
