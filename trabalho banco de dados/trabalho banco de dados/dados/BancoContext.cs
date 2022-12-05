using Microsoft.EntityFrameworkCore;
using trabalho_banco_de_dados.Models;

namespace trabalho_banco_de_dados.dados
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }
        
        // public DbSet<ContatoModel> Contatos { get; set; }
        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<AreaPesquisa> AreaPesquisa { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Examinador> Examinador { get; set; }
        public DbSet<Grupo> Grupo { get; set; }
        public DbSet<Professor> Professor { get; set; }
        public DbSet<RelacionamentoCursoAreaPesquisa> RelacionamentoCursoAreaPesquisa { get; set; }
        public DbSet<RelacionamentoExaminadorTCC> RelacionamentoExaminadorTCC { get; set; }
        public DbSet<RelacionametoTemaTCC> RelacionametoTemaTCC { get; set; }
        public DbSet<TCC> TCC { get; set; }
        public DbSet<Tema> Tema { get; set; }
    }
}
