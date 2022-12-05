using System.Reflection.Metadata;

namespace trabalho_banco_de_dados.Models
{
    public class RelacionamentoCursoAreaPesquisa
    {
        public int RelacionamentoCursoAreaPesquisaId { get; set; }
        public int CursoId { get; set; }
        public Curso Curso { get; set; }
        public int AreaPesquisaId { get; set; }
        public AreaPesquisa AreaPesquisa { get; set; }


    }
}
