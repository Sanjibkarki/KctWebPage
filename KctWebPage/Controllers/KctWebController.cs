using Microsoft.AspNetCore.Mvc;
using KctWebPage.KctWebPageInterface;


namespace KctWebPage.Controllers
{
    public class KctWebController : Controller
    {
        private readonly IKctInterface _service;

        public KctWebController(IKctInterface service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var items = _service.GetAllItems();
            return View(items); // Will render a view passing list of KctWebModel
        }
    }
}
