using Microsoft.AspNetCore.Mvc;

namespace PROG6212.Controllers;

public class MakeClaimController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }


    public IActionResult Create()
    {
        return View();
    }
}