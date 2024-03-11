using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using bootstrap.Models;

namespace bootstrap.Controllers;

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

    public IActionResult ParkPlan()
    {
        return View();
    }

    public IActionResult Homes()
    {
        return View();
    }



    public IActionResult HomesX()
    {
        return View();
    }
    public IActionResult Calendar()
    {
        return View();
    }

    public IActionResult Location()
    {
        return View();
    }
    public IActionResult AboutUs()
    {
        return View();
    }

    public IActionResult Rules()
    {
        return View();
    }



    public IActionResult NewProperty()
    {
        return View();
    }


    public IActionResult residence()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
