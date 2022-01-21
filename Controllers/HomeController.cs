using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using amantini.davide._5h.PrimaWeb.Models;

namespace amantini.davide._5h.PrimaWeb.Controllers
{
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

    public IActionResult Persone()
    {
      List<Persona> p = new();
      p.Add(new() { ID = 1, Nome = "Davide", Cognome = "Amantini" });
      p.Add(new() { ID = 2, Nome = "Michele", Cognome = "Farneti" });

      return View(p);
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
}
