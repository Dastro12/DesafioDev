using DesafioDev.Repositorio.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace DesafioDev.Models.Mapeamento
{
    public static class CidadeMapeamento
    {
        public static Cidade MapearViewModelParaModel(CidadeViewModel cidade)
        {
            Cidade cidadebanco = new Cidade();

            cidadebanco.id = cidade.id;
            cidadebanco.nome = cidade.nome;
            cidadebanco.estado = cidade.estado;

            return cidadebanco;
        }
        public static CidadeViewModel MapearModelParaViewModel(Cidade cidade)
        {
            CidadeViewModel cidadeViewModel = new CidadeViewModel();

            cidadeViewModel.id = cidade.id;
            cidadeViewModel.nome = cidade.nome;
            cidadeViewModel.estado = cidade.estado;

            return cidadeViewModel;
        }

        public static List<SelectListItem> MapearCidadesParaSelect(List<Cidade> cidades)
        {
            List<SelectListItem> itens = new List<SelectListItem>();
            SelectListItem todos = new SelectListItem();
            todos.Text = "Todos";
            todos.Value = string.Empty;
            itens.Add(todos);

            foreach (var cidade in cidades)
            {
                SelectListItem item = new SelectListItem();
                item.Text = cidade.nome;
                item.Value = cidade.id.ToString();

                itens.Add(item);
            }

            return itens;
        }
    }
}
