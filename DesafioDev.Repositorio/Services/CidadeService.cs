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
    }
}
