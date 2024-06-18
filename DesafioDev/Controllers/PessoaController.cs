using DesafioDev.Models.Mapeamento;
using DesafioDev.Models.Service;
using DesafioDev.Models.Service.Interface;
using DesafioDev.Repositorio.Models;
using DesafioDev.Repositorio.Services.Intefaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioDev.Controllers
{
    public class PessoaController : Controller
    {
        private IPessoaService _pessoaService;
        private ICidadeService _cidadeService;
        private IViewRenderService _viewRenderService;



        public PessoaController(IPessoaService pessoaService,
            ICidadeService cidadeService,
            IViewRenderService viewRenderService)
        {
            _pessoaService = pessoaService;
            _cidadeService = cidadeService;
            _viewRenderService = viewRenderService;
        }

        public IActionResult Index()
        {
            PessoaViewModel viemodel = new PessoaViewModel();
            viemodel.listapessoas = _pessoaService.BuscarPessoas();
            viemodel.selectcidades = CidadeMapeamento.MapearCidadesParaSelect(_cidadeService.BuscarCidades());

            return View(viemodel);
        }

        public IActionResult Form(int id)
        {
            PessoaViewModel pessoaViewModel = new PessoaViewModel();

            if (id > 0)
            {
                var pessoa = _pessoaService.BuscarPessoaId(id);

                pessoaViewModel = PessoaMapeamento.MapearViewModelParaModel(pessoa);

            }

            string Form = _viewRenderService.RenderToString(this, "Form", pessoaViewModel);

            return Json(new { view = Form });


        }

        [HttpPost]
        public IActionResult Salvar(PessoaViewModel pessoa)
        {
            if (ModelState.IsValid)
            {
                bool retorno = _pessoaService.Salvar(PessoaMapeamento.MapearViewModelParaModel(pessoa));

                if (retorno)
                {
                    return Json(new { status = true, mensagem = "Pessoa salva com sucesso!" });
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
            bool retorno = _pessoaService.Delete(id);

            if (retorno)
            {
                return Json(new { status = true, mensagem = "Pessoa excluída com sucesso!" });
            }
            else
            {
                return Json(new { status = false, mensagem = "Não foi possível excluír pessoa!" });
            }
        }

    }
}
