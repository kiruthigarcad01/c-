



using Microsoft.AspNetCore.Mvc;

namespace newmvcsharp.Controllers
{
    public class CustomerController : Controller
    {
        [Route("Customer/CustomerIndex")]
        public IActionResult CustomerIndex()
        {
            return View();
        }

        [Route("Customer/ListHotels")]
        public IActionResult ListHotels()
        {
            return View();
        }

        [Route("Customer/ListOfItems")]
        public IActionResult ListOfItems()
        {
            return View();
        }
    }
}
