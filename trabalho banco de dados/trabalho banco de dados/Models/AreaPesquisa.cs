namespace trabalho_banco_de_dados.Models
{
    public class AreaPesquisa
    {
        public int AreaPesquisaId { get; set; }
        public string Nome { get; set; }

        public List<RelacionamentoCursoAreaPesquisa> RelacionamentoCursoAreaPesquisa { get; set; }

        public int TemaId { get; set; }
        public  Tema Tema{ get; set; }
        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }
    }
}
