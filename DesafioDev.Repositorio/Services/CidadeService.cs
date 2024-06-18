using DesafioDev.Repositorio.Models;
using DesafioDev.Repositorio.Services.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDev.Repositorio.Services
{
    public class CidadeService : ICidadeService
    {
        private DesafioDevContext _db;

        public CidadeService(DesafioDevContext db)
        {
            _db = db;
        }

        public List<Cidade> BuscarCidades()
        {
            return _db.Cidade.ToList();
        }
        public bool Salvar(Cidade cidade)
        {
            if (cidade.id > 0)
            {
                _db.Cidade.Update(cidade);
            }
            else
            {
                _db.Cidade.Add(cidade);
            }

            int retorno = _db.SaveChanges();

            return retorno > 0;
        }
        public Cidade BuscarCidade(int id)
        {
            var cidade = _db.Cidade.Find(id);

            return cidade;
        }
        public bool Delete(int id)
        {
            var cidade = _db.Cidade.Find(id);

            if (cidade != null)
            {
                _db.Cidade.Remove(cidade);

                int retorno = _db.SaveChanges();

                return retorno > 0;
            }
            else
            {
                return false;
            }
        }
    }
}
