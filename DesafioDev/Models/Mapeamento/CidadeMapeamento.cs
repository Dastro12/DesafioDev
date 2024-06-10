using DesafioDev.Repositorio.Models;

namespace DesafioDev.Models.Mapeamento
{
    public static class CidadeMapeamento
    {
        public static Cidade MapearViewModelParaModel(CidadeViewModel cidade)
        {
            Cidade cidadebanco = new Cidade();

            cidadebanco.id = cidade.id;
            cidadebanco.nome = cidade.nome;
            cidadebanco.estado = cidade.estado;

            return cidadebanco;
        }
    }
}
