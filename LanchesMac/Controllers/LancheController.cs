﻿using LanchesMac.Models;
using LanchesMac.Repositories.Interfaces;
using LanchesMac.Viewmodel;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancherepository;

        public LancheController(ILancheRepository lancherepository)
        {
            _lancherepository = lancherepository;
        }

        public IActionResult List(string categoria)
        {

            IEnumerable<Lanche> lanches;
            string categoriaAtual = string.Empty;

            if (string.IsNullOrEmpty(categoria))
            {
                lanches = _lancherepository.Lanches.OrderBy(l => l.LancheId);
                categoriaAtual = "Todos os lanches";
            }
            else
            {
                if(string.Equals("Normal", categoria, StringComparison.OrdinalIgnoreCase))
                {
                    lanches = _lancherepository.Lanches
                        .Where(l=> l.Categoria.CategoriaNome.Equals("Normal"))
                        .OrderBy(l =>l.Nome);
                }
                else
                {
                    lanches = _lancherepository.Lanches
                        .Where(l => l.Categoria.CategoriaNome.Equals("Natural"))
                        .OrderBy(l => l.Nome);
                }
                categoriaAtual = categoria;
            }


            var lanchesListViewModel = new LancheListViewModel
            {
                Lanches = lanches,
                    CategoriaAtual = categoriaAtual
            };

            return View(lanchesListViewModel);
        }
    }
}
