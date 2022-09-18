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
    [HttpPost]
    public List<Temporadas> VerTemporadas(int IdSerie){
        return BD.ListarTemporadasPorSerie(IdSerie);
    }
    [HttpPost]
    public Serie VerSerie(int IdSerie){
        return BD.ListarSeriePorId(IdSerie);
    }
    [HttpPost]
    public List<Actor> VerActores(int IdSerie){
        return BD.ListarActoresPorSerie(IdSerie);
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
