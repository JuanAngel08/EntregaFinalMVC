using Microsoft.AspNetCore.Mvc;
using SistemaMotocicletas.Services;
using SistemaMotocicletas.Models;

namespace SistemaMotocicletas.Controllers
{
    public class TallerController : Controller
    {


        private readonly TallerServices tallerServices;
         
        public TallerController(TallerServices tallerServices)
        {
            this.tallerServices = tallerServices;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {

           var talleres= await  tallerServices.GetAllTalleres();
            return View(talleres);
        }

        [HttpPost]
        public async Task<IActionResult> Crear(string nombreTaller, string direccionTaller, string zonaTaller)
        {
            var taller = Taller.Build(Guid.NewGuid(),nombreTaller, direccionTaller, zonaTaller);

            await this.tallerServices.Crear(taller);
            return View();
        }

        [HttpGet]
        public IActionResult Crear( ) {

            return View();
        }
    }
}
