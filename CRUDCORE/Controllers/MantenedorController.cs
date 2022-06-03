using Microsoft.AspNetCore.Mvc;

using CRUDCORE.Datos;
using CRUDCORE.Models;

namespace CRUDCORE.Controllers
{
    public class MantenedorController : Controller
    {

        ContactoDatos _ContactoDatos = new ContactoDatos();
        public IActionResult Listar()
        {
            //La lista devuelve los contactos
            var oLista = _ContactoDatos.Listar();
            return View(oLista);
        }

        public IActionResult Guardar()
        {
            //SOLO DEVUELVE LA VISTA
            return View();
        }
        public IActionResult Guardar()
        {
            //LO RECIBE Y GUARDA EN LA BASE DE DATOS
            return View();
        }
    }
}
