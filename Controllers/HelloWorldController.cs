using Microsoft.AspNetCore.Mvc;
namespace NguyenGiaNguyenBTH.Controllers;

public class HelloworldController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Welcome(string name, int numTimes = 1)
    {
        ViewData["message"] = "Hello " + name;
        ViewData["NumTimes"] = numTimes;
        
        return View();
    }
}