using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using OnlineCinema_BARS_GROUP.Data.Intarfaces;
using System;

namespace WebAPI.Controllers;

[ApiController]
public class MainController : ControllerBase
{
    private readonly IMovie _movie;
    public MainController(IMovie movie) => _movie = movie;

	/// <summary>
	/// Получить рандомный GUID в строковом формате.
	/// </summary>
	[HttpGet]
	[Route("/GetMovies")]

	public IActionResult GetMovies() {
		String a = Guid.NewGuid().ToString();
		Console.WriteLine("dddddddd " + a);
		return new JsonResult(_movie.GetAllMovies); }

    /// <summary>
    /// Получить значение конфигурации по ключу.
    /// </summary>
    [HttpGet]
    [Route("/GetConfigValue")]
    public IActionResult GetConfigValue(string key) => new JsonResult("Not founded");
}