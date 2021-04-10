using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using appventas.Models;
using appventas.Data;

namespace appventas.Controllers
{
    public class ContactoController : Controller
    {
        private readonly ILogger<ContactoController> _logger;
        private readonly ApplicationDbContext _context;


        public ContactoController(ILogger<ContactoController> logger,
            ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            /*var listcontactos = new List<Contacto>();
            listcontactos.Add(new Contacto(){FirstName="Juan", LastName="Perez"});
            listcontactos.Add(new Contacto(){FirstName="Bob", LastName="Marley"});
            listcontactos.Add(new Contacto(){FirstName="Kurt", LastName="Cobain"});
            */
            var listContactos=_context.DataContactos.ToList();
            ViewData["Message"] = "";
            return View(listcontactos);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Contacto objContacto)
        {
            objContacto.Status = "Registrado";
            ViewData["Message"] = "El contacto ya esta " + objContacto.Status;
            return View();
        }

    }
}
