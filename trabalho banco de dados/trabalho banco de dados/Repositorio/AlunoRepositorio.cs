using trabalho_banco_de_dados.dados;
using trabalho_banco_de_dados.Models;

namespace trabalho_banco_de_dados.Repositorio
{
    public class AlunoRepositorio : IAlunoRepositorio
    {
        private readonly BancoContext _bancoContext;
         
        public AlunoRepositorio(BancoContext bancoContext)
        {
            _bancoContext= bancoContext; 
        }

        public Aluno AlunoPorId(int id)
        {
            return _bancoContext.Aluno.FirstOrDefault(x => x.AlunoId ==id);
        }

        public Aluno Cadastrar(Aluno aluno)
        {
            aluno.Grupo = new Grupo();
            aluno.TCCId = 1;
            _bancoContext.Aluno.Add(aluno);
            _bancoContext.SaveChanges();

            return aluno;
        }

        public List<Aluno> ListarAlunos()
        {
            return _bancoContext.Aluno.ToList();
        }
    }
}
