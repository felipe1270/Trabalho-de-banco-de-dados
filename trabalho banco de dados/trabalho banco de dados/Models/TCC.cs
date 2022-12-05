namespace trabalho_banco_de_dados.Models
{
    public class TCC
    {
        public int TCCId { get; set; }
        public string VesaoEntrega { get; set;}
        public string Tipo { get; set;}
        public double Nota { get; set;}

        public List<Aluno> Aluno { get; set;}
        public List<RelacionametoTemaTCC> RelacionametoTemaTCC { get; set;}
        public List<RelacionamentoExaminadorTCC> RelacionamentoExaminadorTCC { get; set; }
    }
}
