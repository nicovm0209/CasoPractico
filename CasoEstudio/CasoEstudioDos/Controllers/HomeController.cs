using CasoEstudioDos.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CasoEstudioDos.Controllers
{
    public class HomeController : Controller

    {

        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var comments = _context.Comments.ToList();
            return View(comments);
        }

        [HttpPost]
        public IActionResult AgregarComentario(string contenido)
        {
            if (!string.IsNullOrEmpty(contenido))
            {
                var comment = new Comment { Contenido = contenido };
                _context.Comments.Add(comment);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }

}
