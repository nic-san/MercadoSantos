using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MercadoSantos.Models;

namespace MercadoSantos.Controllers;

public class FrenteDeCaixa : Controller
{
    private readonly ILogger<FrenteDeCaixa> _logger;

    public FrenteDeCaixa(ILogger<FrenteDeCaixa> logger)
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

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
