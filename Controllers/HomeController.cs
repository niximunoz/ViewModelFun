using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    [HttpGet("/")]
    public IActionResult Index()
    {
        string mensaje = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
        return View("Index", mensaje);
    }
    [HttpGet("/numbers")]
    public IActionResult Numbers()
    {
        int[] numArray = { 1, 2, 3, 4, 6 };
        return View("Numbers", numArray);
    }
    [HttpGet("/users")]
    public IActionResult Users()
    {
        List<string> usersNames = new List<string>();
        usersNames.Add("Alex Davidson");
        usersNames.Add("Jose nuñez");
        usersNames.Add("Maria Briceño");
        usersNames.Add("Maite Flores");
        return View("Users", usersNames);
    }
    [HttpGet("user")]
    public IActionResult AUser()
    {
        User newUser = new User()
        {
            FirstName = "Nichole",
            LastName = "King"
        };
        return View("User", newUser);
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
