using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ControleDeEstoqueDDD.Web.Models;

namespace ControleDeEstoqueDDD.Web.Controllers;

[Area("Cadastro")]
public class EstadoController : Controller
{
    private readonly ILogger<EstadoController> _logger;

    public EstadoController(ILogger<EstadoController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
}
