using DesafioDev.Models;
using DesafioDev.Models.Mapeamento;
using DesafioDev.Models.Service.Interface;
using DesafioDev.Repositorio.Models;
using DesafioDev.Repositorio.Services.Intefaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioDev.Controllers
{
    public class CidadeController : Controller
    {
        private ICidadeService _cidadeService;
        private IViewRenderService _viewRenderService;

        public CidadeController(ICidadeService cidadeService,
            IViewRenderService viewRenderService)
        {
            _cidadeService = cidadeService;
            _viewRenderService = viewRenderService;
        }

        public IActionResult Index()
        {
            CidadeViewModel viemodel = new CidadeViewModel();
            viemodel.listacidades = _cidadeService.BuscarCidades();

            return View(viemodel);
        }

        public IActionResult Form(int id)
        {
            CidadeViewModel cidadeViewModel = new CidadeViewModel();

            if (id > 0)
            {
                var cidade = _cidadeService.BuscarCidade(id);

                cidadeViewModel = CidadeMapeamento.MapearModelParaViewModel(cidade);
            }

            string Form = _viewRenderService.RenderToString(this, "Form", cidadeViewModel);

            return Json(new { view = Form });
        }

        [HttpPost]
        public IActionResult Salvar(CidadeViewModel cidade)
        {
            if (ModelState.IsValid)
            {
                bool retorno = _cidadeService.Salvar(CidadeMapeamento.MapearViewModelParaModel(cidade));

                if (retorno)
                {
                    CidadeViewModel viemodel = new CidadeViewModel();
                    viemodel.listacidades = _cidadeService.BuscarCidades();
                    string tabelaView = _viewRenderService.RenderToString(this, "_TabelaCidade", viemodel);

                    return Json(new { status = true, view = tabelaView, mensagem = "Cidade salva com sucesso!" });
                }
                else
                {
                    return Json(new { status = false, mensagem = "Não foi possível salvar!" });
                }
            }
            else
            {
                return Json(new { status = false, mensagem = "Campos obrigatórios não preenchidos!" });
            }
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            bool retorno = _cidadeService.Delete(id);

            if (retorno)
            {
                CidadeViewModel viemodel = new CidadeViewModel();
                viemodel.listacidades = _cidadeService.BuscarCidades();
                string tabelaView = _viewRenderService.RenderToString(this, "_TabelaCidade", viemodel);

                return Json(new { status = true, view = tabelaView, mensagem = "Cidade excluída com sucesso!" });
            }
            else
            {
                return Json(new { status = false, mensagem = "Não foi possível excluír cidade!" });
            }
        }
    }
}
