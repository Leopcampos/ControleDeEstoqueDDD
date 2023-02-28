using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ControleDeEstoqueDDD.Web.Models;

namespace ControleDeEstoqueDDD.Web.Controllers;

[Area("Cadastro")]
public class MarcaProdutoController : Controller
{
    private readonly ILogger<MarcaProdutoController> _logger;

    public MarcaProdutoController(ILogger<MarcaProdutoController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
}
