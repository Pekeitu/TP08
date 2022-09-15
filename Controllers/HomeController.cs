using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP08_Finkel_Rozen.Models;

namespace TP08_Finkel_Rozen.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.Series = BD.ListarSerie();
        return View();
    }

    public List<Temporadas> VerTemporadas(int IdSerie){
        ViewBag.Temporada = BD.ListarTemporadasPorSerie(IdSerie);
        return ViewBag.Temporada;
    }

    public List<Temporadas> VerSerie(int IdSerie){
        ViewBag.Serie = BD.ListarSeriePorId(IdSerie);
        return ViewBag.Serie;
    }

    public List<Actor> VerActores(int IdSerie){
        ViewBag.Actor = BD.ListarActoresPorSerie(IdSerie);
        return ViewBag.Actor;
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
