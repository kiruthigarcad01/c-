using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using firstsiteincsharp.Models;

namespace firstsiteincsharp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Admin()
    {
        return View();
    }
    public IActionResult Course()
    {
        return View();
    }
    public IActionResult Librarian()
    {
        return View();
    }
    public IActionResult Student()
    {
        return View();
    }
    public IActionResult Contact()
    {
        return View();
    }
    public IActionResult Login()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
