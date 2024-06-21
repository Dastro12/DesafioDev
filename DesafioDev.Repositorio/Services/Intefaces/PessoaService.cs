using DesafioDev.Repositorio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDev.Repositorio.Services.Intefaces
{
    public class PessoaService : IPessoaService
    {
        private DesafioDevContext _db;

        public PessoaService(DesafioDevContext db)
        {
            _db = db;
        }
        public List<Pessoa> BuscarPessoas()
        {
            return _db.Pessoa.ToList();
        }

        public bool Salvar(Pessoa pessoa)
        {
            if (pessoa.id > 0)
            {
                _db.Pessoa.Update(pessoa);
            }
            else
            {
                _db.Pessoa.Add(pessoa);
            }

            int retorno = _db.SaveChanges();

            return retorno > 0;
        }

        public Pessoa BuscarPessoaId(int id)
        {
            var pessoa = _db.Pessoa.Find(id);

            return pessoa;
        }
        public bool Delete(int id)
        {
            var pessoa = _db.Pessoa.Find(id);

            if (pessoa != null)
            {
                _db.Pessoa.Remove(pessoa);

                int retorno = _db.SaveChanges();

                return retorno > 0;
            }
            else
            {
                return false;
            }
        }
        public List<Pessoa> FiltrarPessoas(string tipoPessoa, int cidadeId, string estado)
        {
            var query = _db.Pessoa.AsQueryable();

            if (!string.IsNullOrEmpty(tipoPessoa))
            {
                query = query.Where(p => p.tipo_pessoa == tipoPessoa);
            }

            if (cidadeId > 0)
            {
                query = query.Where(p => p.cidade_id == cidadeId);
            }

            if (!string.IsNullOrEmpty(estado))
            {
                //query = (from p in _db.Pessoa
                //             join c in _db.Cidade on p.cidade_id equals c.id
                //             where string.IsNullOrEmpty(estado) ? p != null : c.estado == estado
                //             select p).AsQueryable();

                query = query.Where(p => _db.Cidade.Any(c => c.id == p.cidade_id && c.estado == estado));
            }

            return query.ToList();
        }

    }
}
