using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ControleDeEstoqueDDD.Web.Models;

namespace ControleDeEstoqueDDD.Web.Controllers;

[Area("Cadastro")]
public class LocalArmazenamentoController : Controller
{
    private readonly ILogger<LocalArmazenamentoController> _logger;

    public LocalArmazenamentoController(ILogger<LocalArmazenamentoController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
}
