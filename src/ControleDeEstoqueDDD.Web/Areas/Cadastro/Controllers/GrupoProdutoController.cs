using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ControleDeEstoqueDDD.Web.Models;

namespace ControleDeEstoqueDDD.Web.Controllers;

[Area("Cadastro")]
public class GrupoProdutoController : Controller
{
    private readonly ILogger<GrupoProdutoController> _logger;

    public GrupoProdutoController(ILogger<GrupoProdutoController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
}