namespace trabalho_banco_de_dados.Models
{
    public class Grupo
    {
        public int GrupoId { get; set; }
        public string Tema { get; set; }
        public List<Aluno> Aluno { get; set; }

    }
}
