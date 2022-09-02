using Bussiness;
using Microsoft.AspNetCore.Mvc;
using Person_CRUD.Models;
using System.Diagnostics;

namespace Person_CRUD.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPersonManager _personManager;
        public HomeController(ILogger<HomeController> logger, IPersonManager personManager)
        {
            _logger = logger;
            _personManager = personManager;
        }

        public async Task<IActionResult> Index()
        {
            var list = await _personManager.GetAll();
            return View(list);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Person person)
        {
            await _personManager.CreatePerson(person);
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var resut = await _personManager.GetById(id);
            return View(resut);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Person person)
        {
            await _personManager.UpdatePerson(person);
            return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> Delete(int id)
        {
            await _personManager.Delete(id);
            return RedirectToAction("Index", "Home");
        }
    }
}