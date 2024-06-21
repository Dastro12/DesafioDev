using DesafioDev.Repositorio.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioDev.Models.Service.Interface
{
    public class PessoaViewModel
    {

        public int id { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [MaxLength(70, ErrorMessage = "Tamanho Máximo 25 caracters")]
        public string nome { get; set; }

       
        [MaxLength(2, ErrorMessage = "Tamanho Máximo 25 caracters")]
        public string tipo_pessoa { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [MaxLength(14, ErrorMessage = "Tamanho Máximo 25 caracters")]
        public string cpf_cnpj { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [MaxLength(8, ErrorMessage = "Tamanho Máximo 25 caracters")]
        public string cep { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [MaxLength(100, ErrorMessage = "Tamanho Máximo 25 caracters")]
        public string endereco { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public int numero { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [MaxLength(20, ErrorMessage = "Tamanho Máximo 25 caracters")]
        public string complemento { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [MaxLength(50, ErrorMessage = "Tamanho Máximo 25 caracters")]
        public string bairro { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public DateTime data_nascimento_fundacao { get; set; }

        public DateTime data_cadastro { get; set; } 

        [Required(ErrorMessage = "Campo Obrigatório")]
        [MaxLength(50, ErrorMessage = "Tamanho Máximo 25 caracters")]
        public string email { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [MaxLength(20, ErrorMessage = "Tamanho Máximo 25 caracters")]
        public string celular { get; set; }

        public string sit_cadastral { get; set; }

        public int cidade_id { get; set; }

        public string estado { get; set; }

        public List<Pessoa> listapessoas { get; set; }

        public List<SelectListItem> selectcidades { get; set; }


    }
}
