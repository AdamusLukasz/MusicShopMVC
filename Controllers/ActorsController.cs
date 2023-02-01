using Microsoft.AspNetCore.Mvc;
using ShopMVC.Data;
using ShopMVC.Data.Services;
using ShopMVC.Models;

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

        // Get: Actors/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName, ProfilePictureURL, Bio")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            _service.Add(actor);
            return RedirectToAction(nameof(Index));
        }

        //Get: Actors/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = _service.GetById(id);
            if (actorDetails == null)
            {
                return View("Empty");
            }
            return View(actorDetails);
        }
    }
}