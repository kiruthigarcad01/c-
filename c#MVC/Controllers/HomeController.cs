using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using c_MVC.Models;
using Microsoft.Data.SqlClient;

namespace c_MVC.Controllers;

public class HomeController : Controller
{
SqlConnection con=new SqlConnection();
SqlCommand com=SqlCommand();

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

    public IActionResult Login()
    {
        return View();
    }

    void connectionString(){

    con.connectionString="192.168.1.240\SQLEXPRESS"; database="cad_foodhub; integrated security = SSPI"; TrustServerCertificate=True;";

    }

     public IActionResult Verify(){
        return View();

     }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
