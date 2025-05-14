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

    public IActionResult ingresarLetra(char letra)
    {
        ViewBag.letrasErradas = new List<char>();
        const int CANTIDAD_INTENTOS = 6;
        ViewBag.finalizo = Juego.ingresarLetra(letra);
        ViewBag.palabraJugada = Juego.palabraJugada;
        ViewBag.letrasErradas = Juego.letrasErradas;
        ViewBag.letrasAdivinadas = Juego.letrasAdivinadas;
        ViewBag.palabraAdivinar = Juego.palabraAdivinar;
        
        if (ViewBag.finalizo)
        {
            return View("victoria");
        }
        else if (ViewBag.letrasErradas.Count == CANTIDAD_INTENTOS)
        {
            return View("derrota");
        }
        else
        {
            return View("juego");
        }
    }
    public IActionResult ingresarPalabra(string palabra)
    {
        ViewBag.adivino = Juego.ingresarPalabra(palabra);
        if (ViewBag.adivino == false)
        {
            return View("derrota");
        }
        else
        {
            return View("victoria");
        }

    }
    public IActionResult juego()
    {
        Juego.crearRandom();
        ViewBag.palabraAdivinar = Juego.palabraAdivinar;
        return View();
    }
    public IActionResult creditos(){
        return View();
    }
}


