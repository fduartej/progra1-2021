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
    public class CalculadoraController : Controller
    {
        private readonly ILogger<CalculadoraController> _logger;

        public CalculadoraController(ILogger<CalculadoraController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["Message"] = "";
            return View();
        }

        [HttpPost]
        public IActionResult MiMetodoExecute(Calculadora objCalculadora)
        {
            Double result = 0.0;
            String message ="";
            if("+" == objCalculadora.Operando){
                result = objCalculadora.Operador1 + objCalculadora.Operador2;
                message ="El resultado es " + result;
            }
            if("/" == objCalculadora.Operando){
                if(objCalculadora.Operador2 == 0){
                    message ="El numero no puede ser dividido entre 0";
                }else{
                    result = objCalculadora.Operador1 / objCalculadora.Operador2;
                    message ="El resultado es " + result;
                }
                
            }
            ViewData["Message"] = message;
            return View("Index");
        }

    }
}
