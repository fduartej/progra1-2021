using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using appventas.Models;

namespace appventas.Controllers
{
    public class ContactoController : Controller
    {
        private readonly ILogger<ContactoController> _logger;

        public ContactoController(ILogger<ContactoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var listcontactos = new List<Contacto>();
            listcontactos.Add(new Contacto(){FirstName="Juan", LastName="Perez"});
            listcontactos.Add(new Contacto(){FirstName="Bob", LastName="Marley"});
            listcontactos.Add(new Contacto(){FirstName="Kurt", LastName="Cobain"});
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
