using System.Reflection.PortableExecutable;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Vendista.BL;
using Vendista.BL.Entityes;
using Vendista.Terminal.Models;

namespace Vendista.Terminal.Controllers;

public class EventsController : Controller
{
    private readonly ILogger<EventsController> _logger;
    private IDataManager _dataManager;

    public EventsController(ILogger<EventsController> logger, IDataManager dataManager)
    {
        _logger = logger;
        _dataManager = dataManager;
        _dataManager.Auth("user1", "password1");
    }
    [HttpPost]
    [Route("/sendCommand")]
    public async Task<IActionResult> SendCommandAsync(int id)
    {
        await _dataManager.SendAsync($"terminals/{id}/commands", id);
        return Ok();
    }
    /// <summary>
    /// Список всех событий по умолчанию
    /// </summary>
    /// <returns></returns>
    public async Task<IActionResult> Index()
    {
        //Заполняем дроп лист выбора автоматов
        await SetMachinesDropList();

        //Формируем запрос событий на сегодня
        var model = await _dataManager.GetEventsItems<EventResults>("events", new Dictionary<string, string>()
        {
            { "Since", $"{DateTime.Now:yyyy-MM-dd}" }
        });
        return View(model.items);
    }

    /// <summary>
    /// Список событий по фильтру
    /// </summary>
    /// <param name="pars">Набор параметров</param>
    /// <returns></returns>
    [HttpPost]
    public async Task<IActionResult> Index(EventsActionParameters pars)
    {
        //Проверка параметров запроса
        if (!ModelState.IsValid)
        {
            //Можно формировать сообщение или отправить на страницу ошибок, пока так
            //TODO Не в продакшен
            return BadRequest();
        }

        //Заполняем дроп лист выбора автоматов
        await SetMachinesDropList();

        //Формируем запрос событий
        //Конвертация даты из формата ДД.ММ.ГГГГ в ГГГГ-ММ-ДД происходит при маппинге параметров в классе EventsActionParameters
        var model = await _dataManager.GetEventsItems<EventResults>("events", pars.ToDictionary());

        //Сохраняем выбранный в фильтре аппарат
        ViewData["Select_Machine_Id"] = pars.Machine_id ?? "";


        return View(model.items);
    }

    /// <summary>
    /// Заполнение списка доступных автоматов (машин)
    /// </summary>
    /// <remarks>
    /// Заполняет список в ViewData["Machines"]
    /// </remarks>
    /// <returns></returns>
    private async Task SetMachinesDropList()
    {
        //Запрос машин
        var machines = await _dataManager.GetItems<RootObject>("machines");

        //Мапинг в дроп лист
        var resultList = machines.items.Select(x =>
            new SelectListItem(
                $"{x.name} | {x.address} | {x.model}",
                x.model_id.ToString())).ToList();

        //Значение для "Все"
        resultList.Insert(0, new SelectListItem(" Все ", ""));

        ViewData["Machines"] = resultList;
    }
}