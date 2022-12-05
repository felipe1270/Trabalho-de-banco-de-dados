namespace trabalho_banco_de_dados.Models
{
    public class Tema
    {
        public int TemaId { get; set; }
        public string Nome { get; set; }
        public int AlunoId { get; set; }
        public List<AreaPesquisa> AreasPesquisa { get; set; }
        
        public Aluno Alunos { get; set; }
        public List<RelacionametoTemaTCC> RelacionametoTemaTCC { get; set; }
    }
}
