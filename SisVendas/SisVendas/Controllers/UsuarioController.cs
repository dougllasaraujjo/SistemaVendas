using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SisVendas.Models;
using SisVendas.Repositories;

namespace SisVendas.Controllers
{
    public class UsuarioController : Controller
    {

        private readonly IUsuarioRepository usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            this.usuarioRepository = usuarioRepository;
        }

        public IActionResult Adiciona()
        {
            usuarioRepository.SaveUsuario(new Usuario());
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
