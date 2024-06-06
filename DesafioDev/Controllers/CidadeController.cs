using DesafioDev.Models;
using DesafioDev.Repositorio.Services.Intefaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioDev.Controllers
{
    public class CidadeController : Controller
    {
        private ICidadeService _cidadeService;

        public CidadeController(ICidadeService cidadeService)
        {
            _cidadeService = cidadeService;
        }

        public IActionResult Index()
        {
            CidadeViewModel viemodel = new CidadeViewModel();
            viemodel.listacidades = _cidadeService.BuscarCidades();

            return View(viemodel);
        }
    }
}
