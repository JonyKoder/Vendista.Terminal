using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Vendista.BL.Interfaces;
using Vendista.Terminal.Models;

namespace Vendista.Terminal.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IApiService _apiService;

    public HomeController(ILogger<HomeController> logger, IApiService apiService)
    {
        _logger = logger;
        _apiService = apiService;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    [Route("/get-command-types")]
    public async Task<IActionResult> GetCommandTypes()
    {
        var commandTypes = await _apiService.GetCommandTypes();
        if(commandTypes != null)
        {
            // Обработка успешного получения данных
            return Ok(commandTypes);
        }
        else
        {
            // Обработка ошибки получения данных
            return NotFound();
        }
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
