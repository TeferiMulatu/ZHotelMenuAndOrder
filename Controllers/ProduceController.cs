using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ZHotelMenuAndOrder.Controllers
{
    [Authorize]
    public class ProduceController : Controller
    {
        public IActionResult GetAll()
        {
            return View();
        }
    }
}
