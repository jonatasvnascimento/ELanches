using Microsoft.AspNetCore.Mvc;
using ELanches.Repositories.Interfaces;
using ELanches.ViewModels;

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
            var lanchesListViewModel = new LancheListViewModel();
            lanchesListViewModel.Lanches = _ILanchesRepository.Lanches;
            lanchesListViewModel.CategoriaAtual = "Categoria Atual";

            return View(lanchesListViewModel);
        }
    }
}
