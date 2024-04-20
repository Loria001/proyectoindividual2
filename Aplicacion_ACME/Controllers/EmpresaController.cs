using Microsoft.AspNetCore.Mvc;
using Models.ACME;
using Services.ACME;

namespace Aplicacion_ACME.Controllers
{
    public class EmpresaController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            EmpresaService empresaService = new EmpresaService();
            List<EmpresaEntidad>? listaEmpresaEntidad;

            listaEmpresaEntidad = empresaService.Listar();

            return View(listaEmpresaEntidad);
        }
    }
}
