using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ControleDeEstoqueDDD.Web.Models;

namespace ControleDeEstoqueDDD.Web.Controllers;

[Area("Cadastro")]
public class CidadeController : Controller
{
    private readonly ILogger<CidadeController> _logger;

    public CidadeController(ILogger<CidadeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
}
