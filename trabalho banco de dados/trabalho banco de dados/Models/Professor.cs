namespace trabalho_banco_de_dados.Models
{
    public class Professor
    {
        public int ProfessorId { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public List<AreaPesquisa> AreaPesquisa { get; set; }
        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }
    }
}
