using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using newmvcsharp.Models;
using Microsoft.Data.SqlClient;

namespace newmvcsharp.Controllers;

public class HomeController : Controller
{
    SqlConnection con=new SqlConnection();
    SqlCommand cmd=new SqlCommand();
    SqlDataReader? dr;


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
    public IActionResult login()
    {
        return View();
    }

    void ConnectionString(){
        con.ConnectionString="192.168.1.240\\SQLEXPRESS; database=cad_foodhub; integrated security = SSIP; TrustServerCertificate=True;";
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
