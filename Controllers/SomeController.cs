using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Authorize]
public class SomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
} 