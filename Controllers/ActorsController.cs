using Microsoft.AspNetCore.Mvc;
using ShopMVC.Data;
using ShopMVC.Data.Services;

namespace ShopMVC.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            
            var data = await _service.GetAll();
            return View(data);
        }
    }
}