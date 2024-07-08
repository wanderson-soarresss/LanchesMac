using LanchesMac.Models;
using LanchesMac.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Controllers
{
    public class CarrinhoCompraController : Controller
    {
        private readonly ILancheRepository _lacheRepository;
        private readonly CarrinhoCompra _CarrinhoCompra;

        public CarrinhoCompraController(ILancheRepository lacheRepository,
            CarrinhoCompra carrinhoCompra)
        {
            _lacheRepository = lacheRepository;
            _CarrinhoCompra = carrinhoCompra;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
