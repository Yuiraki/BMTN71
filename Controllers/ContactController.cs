using Microsoft.AspNetCore.Mvc;
using startup.Models;

namespace startup.Controllers
{
    public class ContactController : Controller
    {
        private readonly DataContext _context;

        public ContactController(DataContext context)
        {
            _context = context;
        }

        // GET: /Contact
        public IActionResult Index()
        {
            return View();
        }

        // POST: /Contact
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(Contact model)
        {
            if (ModelState.IsValid)
            {
                _context.Contacts.Add(model);
                _context.SaveChanges();

                ViewBag.Success = "Gửi liên hệ thành công!";
                ModelState.Clear();
            }

            return View();
        }
    }
}
