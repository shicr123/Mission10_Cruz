using Microsoft.AspNetCore.Mvc;

namespace Mission10_Cruz.Controllers;

public class BowlerController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}