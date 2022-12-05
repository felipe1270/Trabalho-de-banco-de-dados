namespace trabalho_banco_de_dados.Models
{
    public class Examinador
    {
        public int ExaminadorId { get; set; }
        public string Nome { get;}

        public DateTime DataNascimento { get; set;}

        public List<RelacionamentoExaminadorTCC> RelacionamentoExaminadorTCC { get; set; }
    }
}
