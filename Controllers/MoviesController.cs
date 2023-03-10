using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopMVC.Data;
using ShopMVC.Data.Enum;
using ShopMVC.Models;

namespace ShopMVC.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;

        public MoviesController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            
            var movies = await _context.Movies!
                .Include(a => a.Cinema)
                .OrderBy(a => a.Name)
                .ToListAsync();

            return View(movies);
        }
    }
}
