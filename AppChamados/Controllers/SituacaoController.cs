using AppChamados.Domain;
using AppChamados.Models;
using AppChamados.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AppChamados.Controllers
{
    public class SituacaoController : Controller
    {
        private readonly ISituacaoRepository _repository;

        public SituacaoController(ISituacaoRepository situacaoRepository)
        {
            _repository = situacaoRepository;
        }

        public IActionResult Index()
        {
            var situacoes = _repository.GetAll();
            return View(situacoes);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Situacao situacao)
        {
            _repository.Create(situacao);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var chamado = _repository.GetById(id);
            return View(chamado);
        }

        [HttpPost]
        public IActionResult Update(Situacao situacao)
        {
            _repository.Update(situacao);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}