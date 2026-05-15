using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Ativ_MVC.Models;
using Ativ_MVC.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Ativ_MVC.Controllers
{
    public class MusicaController : Controller
    {
        private readonly MusicaRepository _repository;

        public MusicaController(MusicaRepository repository)
        {
            _repository = repository;
        }

[HttpGet]

        public IActionResult Index()
        {
       List<Musica> musica = _repository.ObterMusica();
            ViewBag.TotalMusica= musica.Count;
            return View(musica);        }

    [HttpGet]


       public IActionResult Cadastro()
        {
            ViewData["Title"] = "Cadastro";
            return View();

        }

  [HttpPost]
        public IActionResult Cadastro(Musica m)
        {
            string musicaString = Request.Form["Duracao_Minutos"].ToString().Replace(".", ",");

            if (decimal.TryParse(musicaString, out var duracaoConvertida))
            {
                m.Duracao_Minutos = duracaoConvertida;
            }
            m.DataCadastro = DateTime.Now; 
            
            _repository.Adicionar(m);
            return RedirectToAction("Index"); 
        }

    }
}