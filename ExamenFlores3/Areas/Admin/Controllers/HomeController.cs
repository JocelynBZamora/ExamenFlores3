using ExamenFlores3.Areas.Admin.Models;
using ExamenFlores3.Areas.Admin.Models.ViewModel;
using ExamenFlores3.Models.Entities;
using ExamenFlores3.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ExamenFlores3.Areas.Admin.Controllers
{
    [Area("admin")]
    public class HomeController : Controller
    {
        public readonly FloresRepository floresRepository;
        public HomeController(FloresRepository repository)
        {
            floresRepository = repository;
        }


        public IActionResult Index()
        {
            var data = floresRepository.GetAll().Select(x =>
            new FlorModel()
            {
                Nombre = x.NombreFlor,
                Id = (int)x.Id

            });

            return View(data);
        }

        public IActionResult Agregar() 
        {
            Agregarflor vm = new Agregarflor();
            return View(vm);
        }

        [HttpPost]
        public IActionResult Agrgar(Agregarflor vm) 
        {
            if (string.IsNullOrWhiteSpace(vm.Datos.NombreFlor)) 
            {
                ModelState.AddModelError(vm.Datos.NombreFlor, "Agregue un nombre");
            }
            if (string.IsNullOrWhiteSpace(vm.Datos.Origen)) 
            {
                ModelState.AddModelError(vm.Datos.Origen, "Agregue el origen");
            }
            if (string.IsNullOrWhiteSpace(vm.Datos.Descripcion))
            {
                ModelState.AddModelError(vm.Datos.Descripcion, "Agregue la descripcion");
            }
            if (ModelState.IsValid) 
            {
                floresRepository.Insert(vm.Datos);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Editar(Agregarflor vm)
        {
            if (string.IsNullOrWhiteSpace(vm.Datos.NombreFlor))
            {
                ModelState.AddModelError(vm.Datos.NombreFlor, "Agregue un nombre");
            }
            if (string.IsNullOrWhiteSpace(vm.Datos.Origen))
            {
                ModelState.AddModelError(vm.Datos.Origen, "Agregue el origen");
            }
            if (string.IsNullOrWhiteSpace(vm.Datos.Descripcion))
            {
                ModelState.AddModelError(vm.Datos.Descripcion, "Agregue la descripcion");
            }
            if (ModelState.IsValid)
            {
                floresRepository.Update(vm.Datos);
            }
            return RedirectToAction("Index");
        }
    }
}
