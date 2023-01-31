using Microsoft.AspNetCore.Mvc;
using ShopMVC.Data;

namespace ShopMVC.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDbContext _context;

        public ProducersController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var producers = _context.Producers!.ToList();
            return View();
        }
    }
}
