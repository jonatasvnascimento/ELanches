using ELanches.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ELanches.Components
{
    public class CategoriaMenu : ViewComponent
    {
        public readonly ICategoriaRepository _ICategoriaRepository;

        public CategoriaMenu(ICategoriaRepository iCategoriaRepository)
        {
            _ICategoriaRepository = iCategoriaRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categorias = _ICategoriaRepository.Categorias.OrderBy(c => c.CategoriaNome);
            return View(categorias);
        }
    }
}
