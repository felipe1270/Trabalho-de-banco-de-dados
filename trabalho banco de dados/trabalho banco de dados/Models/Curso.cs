namespace trabalho_banco_de_dados.Models
{
    public class Curso
    {
        public int CursoId { get; set; }
        public string nome { get; set;}

        public string departamento { get; set;}
        public List<RelacionamentoCursoAreaPesquisa> RelacionamentoCursoAreaPesquisa { get; set; }
    }
}
