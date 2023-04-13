using Microsoft.AspNetCore.Mvc;
using ELanches.Repositories.Interfaces;

namespace ELanches.Controllers
{
    public class LancheController : Controller
    {
        public readonly ILanchesRepository _ILanchesRepository;

        public LancheController(ILanchesRepository lanchesRepository)
        {
            _ILanchesRepository = lanchesRepository;
        }

        public IActionResult List()
        {
            var lanches = _ILanchesRepository.Lanches;
            return View(lanches);
        }
    }
}
