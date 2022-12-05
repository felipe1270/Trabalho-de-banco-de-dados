namespace trabalho_banco_de_dados.Models
{
    public class RelacionamentoExaminadorTCC
    {
        public int RelacionamentoExaminadorTCCId { get; set; }
        public int TCCId { get; set; }
        public TCC TCC { get; set; }
        public int ExaminadorId { get; set; }
        public Examinador Examinador { get; set; }
    }
}
