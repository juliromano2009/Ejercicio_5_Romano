using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ejercicio5.Models;

namespace Ejercicio5.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public iActionResult EsApto(int edad, double ingresoMensual, bool estaTrabajando, double montoSolicitado, double deudasPrevias)
    {
        Cliente cliente = new Cliente();
        if(cliente.esApto(edad, ingresoMensual, estaTrabajando, montoSolicitado, deudasPrevias))
        {
            return View();
        }
        else
        {
            return View("NoEsApto");
        }

    }
}