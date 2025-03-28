using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CatalogShop.Models;

namespace CatalogShop.Controllers;

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

    public IActionResult NextPage()
    {
        return View();
    }

    public IActionResult FormPage()
    {
        return View();
    }

    [HttpPost]
    public IActionResult SubmitForm(string name, string vorname, string adresse)
    {
        // Formularverarbeitung hier
        return RedirectToAction("Index");
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

