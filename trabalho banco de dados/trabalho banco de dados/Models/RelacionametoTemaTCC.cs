namespace trabalho_banco_de_dados.Models
{
    public class RelacionametoTemaTCC
    {
        public int RelacionametoTemaTCCId { get; set; }

        public int TCCId { get; set; }
        public TCC TCC { get; set; }
        public int TemaId { get; set; }
        public Tema Tema { get; set; }
    }
}
