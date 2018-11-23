using System.Linq;
using AppChamados.Domain;
using AppChamados.Models;
using AppChamados.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AppChamados.Controllers
{
    public class ChamadoController : Controller
    {
        private readonly IChamadoRepository _repositoryChamado;
        private readonly IClienteRepository _repositoryCliente;
        private readonly ISituacaoRepository _repositorySituacao;

        public ChamadoController(IChamadoRepository chamadoRepository,
                                IClienteRepository clienteRepository,
                                ISituacaoRepository situacaoRepository)
        {
            _repositoryChamado = chamadoRepository;
            _repositoryCliente = clienteRepository;
            _repositorySituacao = situacaoRepository;
        }

        public IActionResult Index()
        {
            var chamados = _repositoryChamado.GetAll().OrderByDescending(x => x.dataChamado);
            return View(chamados);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.clientes = _repositoryCliente.GetAll();
            ViewBag.situacoes = _repositorySituacao.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Chamado chamado)
        {
            _repositoryChamado.Create(chamado);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var chamado = _repositoryChamado.GetById(id);
            ViewBag.situacoes = _repositorySituacao.GetAll();
            return View(chamado); 
        }

        [HttpPost]
        public IActionResult Update(Chamado chamado)
        {
            _repositoryChamado.Update(chamado);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _repositoryChamado.Delete(id);
            return RedirectToAction("Index");
        }

    }
}