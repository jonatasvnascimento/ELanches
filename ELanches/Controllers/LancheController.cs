﻿using Microsoft.AspNetCore.Mvc;
using ELanches.Repositories.Interfaces;
using ELanches.ViewModels;
using ELanches.Models;

namespace ELanches.Controllers
{
    public class LancheController : Controller
    {
        public readonly ILanchesRepository _ILanchesRepository;

        public LancheController(ILanchesRepository lanchesRepository)
        {
            _ILanchesRepository = lanchesRepository;
        }

        public IActionResult List(string categoria)
        {
            IEnumerable<Lanche> lanches;
            string categoriaAtual = string.Empty;

            if (string.IsNullOrEmpty(categoria))
            {
                lanches = _ILanchesRepository.Lanches.OrderBy(l => l.LancheId);
                categoria = "Todos os lanches";
            }
            else
            {
                if (string.Equals("Normal", categoria, StringComparison.OrdinalIgnoreCase))
                {
                    lanches = _ILanchesRepository.Lanches
                        .Where(l => l.Categoria.CategoriaNome.Equals("Normal"))
                        .OrderBy(l => l.Nome);
                }
                else
                {
                    lanches = _ILanchesRepository.Lanches
                        .Where(l => l.Categoria.CategoriaNome.Equals("Natural"))
                        .OrderBy(l => l.Nome);
                }
            }

            var lanchesListViewModel = new LancheListViewModel
            {
                CategoriaAtual = categoria,
                Lanches = lanches
            };

            return View(lanchesListViewModel);
        }
    }
}
