using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDev.Repositorio.Models
{
   public class Pessoa
    {
        public int id { get; set; }

        public string nome { get; set; }

        public string tipo_pessoa { get; set; }

        public string cpf_cnpj { get; set; }

        public string cep { get; set; }

        public string endereco { get; set; }
        
        public int numero { get; set; }

        public string complemento { get; set; }

        public string bairro { get; set; }

        public DateTime data_nascimento_fundacao { get; set; }

        public DateTime data_cadastro{ get; set; }

        public string email { get; set; }

        public string celular { get; set; }

        public string sit_cadastral { get; set; }

        public int cidade_id { get; set; }




    }
}
