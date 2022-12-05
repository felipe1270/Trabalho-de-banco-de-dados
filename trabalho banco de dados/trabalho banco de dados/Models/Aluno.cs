namespace trabalho_banco_de_dados.Models
{
    public class Aluno
    {
        public int AlunoId { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Nome { get; set; }


        public List<Professor> Professores{ get; set; }
        public List<Tema> Temas { get; set; }

        public int TCCId { get; set; }
        public TCC TCC { get; set; }

        public int GrupoId { get; set; }
        public Grupo Grupo { get; set; }
    }
}
