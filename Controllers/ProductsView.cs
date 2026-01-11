using Microsoft.AspNetCore.Mvc;
using startup.Models;

namespace startup.Controllers
{
    public class ProductsView : Controller
    {
        private readonly DataContext _context;

        public ProductsView(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/slug")]
        public IActionResult Details(string slug)
        {
            if(slug == null) { return NotFound(); };
            var pr = _context.products.FirstOrDefault(x => x.Slug == slug);
            return View(pr);

        }
    }
}
