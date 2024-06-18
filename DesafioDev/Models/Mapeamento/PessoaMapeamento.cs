using DesafioDev.Models.Service.Interface;
using DesafioDev.Repositorio.Models;
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
            pessoabanco.data_cadastro = pessoa.data_cadastro;
            pessoabanco.email= pessoa.email;
            pessoabanco.celular = pessoa.celular;
            pessoabanco.sit_cadastral = pessoa.sit_cadastral;
            pessoabanco.cidade_id = pessoa.cidade_id;

            return pessoabanco;
        }

        internal static PessoaViewModel MapearViewModelParaModel(Pessoa pessoa)
        {
            throw new NotImplementedException();
        }
    }
}
