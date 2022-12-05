using trabalho_banco_de_dados.Models;

namespace trabalho_banco_de_dados.Repositorio
{
    public interface IAlunoRepositorio
    {
        Aluno AlunoPorId(int id);
        List<Aluno> ListarAlunos();
        Aluno Cadastrar(Aluno aluno);
    }
}
