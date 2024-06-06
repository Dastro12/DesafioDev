using DesafioDev.Repositorio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioDev.Models
{
    public class CidadeViewModel
    {
        public int id { get; set; }

        [Required(ErrorMessage ="Campo Obrigatório")]
        public string nome { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string estado { get; set; }

        public List<Cidade> listacidades { get; set; }
    }
}
