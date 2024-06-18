using DesafioDev.Repositorio.Models;
using System.Collections.Generic;

namespace DesafioDev.Repositorio.Services.Intefaces
{
    public interface ICidadeService
    {
        List<Cidade> BuscarCidades();

        bool Salvar(Cidade cidade);

        Cidade BuscarCidade(int id);

        bool Delete(int id);
    }

}
