﻿using System.Diagnostics;
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

    public IActionResult Dealer()
    {
        return View();
    }
    public IActionResult Customer()
    {
        return View();
    }
    [HttpGet]
    public IActionResult login()
    {
        return View();
    }

    void ConnectionString(){
        con.ConnectionString="data source=192.168.1.240\\SQLEXPRESS; database=cad_foodhub; user id=CADBATCH01; password=CAD@123pass; TrustServerCertificate=True;";
    }

    [HttpPost]
    public IActionResult Verifylogin(logModel lmodel){

        ConnectionString();
        con.Open();
        cmd.Connection=con;
        cmd.CommandText="select * from LOGIN_ID where ID='"+lmodel.ID+"' and Password='"+lmodel.Password+" '; ";

        dr=cmd.ExecuteReader();

        if (dr.Read())               
        {    
        if(lmodel.ID=="Dealer") 
        {   
            return RedirectToAction("Index", "Dealer");
        }
        else if (lmodel.ID=="Customer")
        {
            return RedirectToAction("Index", "Customer");
        }

        else
        {
            return RedirectToAction("Index", "Home");
        }


        }

        else
        {     con.Close();
              return View("Error");

        }
      
        





    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
