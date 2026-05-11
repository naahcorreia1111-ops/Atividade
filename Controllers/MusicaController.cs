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

        public IActionResult Index()
        {
List<Musica> musica = _repository.ObterMusica();

            return View(musica);        }

    
    }
}