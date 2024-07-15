using LanchesMac.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Components
{
    public class CategoriaMenu : ViewComponent
    {
        private readonly IcategoriaRepository _categoriaRepository;
        public CategoriaMenu(IcategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }
    }
}
