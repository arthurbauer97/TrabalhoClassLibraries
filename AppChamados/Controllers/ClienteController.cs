using System.Linq;
using AppChamados.Domain;
using AppChamados.Models;
using AppChamados.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AppChamados.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteRepository _repository;

        public ClienteController(IClienteRepository clienteRepository)
        {
            _repository = clienteRepository;
        }

        public IActionResult Index()
        {
            var clientes = _repository.GetAll();
            return View(clientes);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Cliente cliente)
        {
            _repository.Create(cliente);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var chamado = _repository.GetById(id);
            return View(chamado);
        }

        [HttpPost]
        public IActionResult Update(Cliente cliente)
        {
            _repository.Update(cliente);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}