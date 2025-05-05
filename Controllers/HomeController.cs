using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Tp_04.Models;

namespace Tp_04.Controllers;

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
    public IActionResult elegirPalabra()
    {
        int num;
        Random r = new Random();
        num = r.Next(1, 5);
        public static string palabraAdivinar = CargarPalabras.listaPalabras[num];
    }
    public IActionResult ingresarLetra(char letra)
    {
        if
        return View();
    }
    public IActionResult ingresarPalabra(string palabra)
    {
        return View();
    }
}
