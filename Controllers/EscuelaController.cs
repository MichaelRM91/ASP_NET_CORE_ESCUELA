using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using asp_net_core.Models;

namespace asp_net_core.Controllers
{
    public class EscuelaController : Controller
    {
        
        public IActionResult Index()
        {
            ViewBag.CosaDinamica = "La Monja";
            var escuela = _context.Escuelas.FirstOrDefault();
            return View(escuela);
        }

        private EscuelaContext _context;
        public EscuelaController(EscuelaContext context)
        {
           _context = context; 
        }
    }
}