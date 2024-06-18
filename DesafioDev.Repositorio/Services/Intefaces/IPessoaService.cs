using DesafioDev.Repositorio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDev.Repositorio.Services.Intefaces
{
    public interface IPessoaService
    {
        List<Pessoa> BuscarPessoas();


        bool Salvar(Pessoa pessoa);


        Pessoa BuscarPessoaId(int id);


        bool Delete(int id);
    }
}
