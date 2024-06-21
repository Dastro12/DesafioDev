using DesafioDev.Models.Service.Interface;
using DesafioDev.Repositorio.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioDev.Models.Mapeamento
{
    public class PessoaMapeamento
    {
        public static Pessoa MapearViewModelParaModel(PessoaViewModel pessoa)
        {
            Pessoa pessoabanco = new Pessoa();

            pessoabanco.id = pessoa.id;
            pessoabanco.nome = pessoa.nome;
            pessoabanco.tipo_pessoa = pessoa.tipo_pessoa;
            pessoabanco.cpf_cnpj = pessoa.cpf_cnpj;
            pessoabanco.cep = pessoa.cep;
            pessoabanco.endereco = pessoa.endereco;
            pessoabanco.numero = pessoa.numero;
            pessoabanco.complemento = pessoa.complemento;
            pessoabanco.bairro = pessoa.bairro;
            pessoabanco.data_nascimento_fundacao = pessoa.data_nascimento_fundacao;
            pessoabanco.email = pessoa.email;
            pessoabanco.celular = pessoa.celular;
            pessoabanco.sit_cadastral = pessoa.sit_cadastral;
            pessoabanco.cidade_id = pessoa.cidade_id;

            if (!(pessoabanco.id > 0))
                pessoabanco.data_cadastro = DateTime.Now;

            return pessoabanco;
        }

       public static PessoaViewModel MapearModelParaViewModel(Pessoa pessoa)
        {
            PessoaViewModel PessoaViewModel = new PessoaViewModel();

            PessoaViewModel.id = pessoa.id;
            PessoaViewModel.nome = pessoa.nome;
            PessoaViewModel.tipo_pessoa = pessoa.tipo_pessoa;
            PessoaViewModel.cpf_cnpj = pessoa.cpf_cnpj;
            PessoaViewModel.cep = pessoa.cep;
            PessoaViewModel.endereco = pessoa.endereco;
            PessoaViewModel.numero = pessoa.numero;
            PessoaViewModel.complemento = pessoa.complemento;
            PessoaViewModel.bairro = pessoa.bairro;
            PessoaViewModel.data_nascimento_fundacao = pessoa.data_nascimento_fundacao;
            PessoaViewModel.email = pessoa.email;
            PessoaViewModel.celular = pessoa.celular;
            PessoaViewModel.sit_cadastral = pessoa.sit_cadastral;
            PessoaViewModel.cidade_id = pessoa.cidade_id;
            PessoaViewModel.data_cadastro = pessoa.data_cadastro;
            

            return PessoaViewModel;
        }

    }
}
   