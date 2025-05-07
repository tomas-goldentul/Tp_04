using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Tp_04.Models;

namespace Tp_04.Controllers;

public class HomeController : Controller
{
    static string palabraAdivinar;
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
        List<char> letrasAdivinadas = new List<char>();
        List<char> palabraJugada = new List<char>();
        List<char> letrasErradas = new List<char>();
        if (palabraAdivinar.Contains(letra))
        {
            letrasAdivinadas.Add(letra);
        }
        else
        {
            letrasErradas.Add(letra);
        }

        for (int i = 0; i < palabraAdivinar.Length; i++)
        {
            if (letrasAdivinadas.Contains(palabraAdivinar[i]))
            {
                palabraJugada.Add(palabraAdivinar[i]);
            }
            else
            {
                palabraJugada.Add('_');
            }

        }
        ViewBag.palabraJugada = palabraJugada;
        ViewBag.letrasErradas = letrasErradas;
        ViewBag.letrasAdivinadas = letrasAdivinadas;
        ViewBag.palabraAdivinar = palabraAdivinar;
        return View("juego");
    }
    public IActionResult ingresarPalabra(string palabra)
    {
        bool adivino = false;
        if (palabra == palabraAdivinar)
        {
            adivino = true;
        }
        ViewBag.adivino = adivino;
        return View("juego");
    }
    public IActionResult juego()
    {
   int num;
        Random r = new Random();
        num = r.Next(0, CargarPalabras.listaPalabras.Count - 1);
        palabraAdivinar = CargarPalabras.listaPalabras[num];
        ViewBag.palabraAdivinar = palabraAdivinar;
        return View();
    }
}


