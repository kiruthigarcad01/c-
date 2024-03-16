using  Microsoft.AspNetCore.Mvc;


public class DealerController : Controller
{
private readonly ILogger<DealerController> _logger;

    public DealerController(ILogger<DealerController> logger)
    {
        _logger = logger;
    }
    public IActionResult Index()
 	{
        return View("Index", "_Layout Dealer");
  	}
    public IActionResult Hotels()
 	{
        return View();
  	}
    public IActionResult Menus()
 	{
        return View();
  	}
}
   
