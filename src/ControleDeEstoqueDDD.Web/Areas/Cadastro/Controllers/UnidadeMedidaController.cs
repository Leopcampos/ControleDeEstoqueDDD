using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ControleDeEstoqueDDD.Web.Models;

namespace ControleDeEstoqueDDD.Web.Controllers;

[Area("Cadastro")]
public class UnidadeMedidaController : Controller
{
    private readonly ILogger<UnidadeMedidaController> _logger;

    public UnidadeMedidaController(ILogger<UnidadeMedidaController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
}
