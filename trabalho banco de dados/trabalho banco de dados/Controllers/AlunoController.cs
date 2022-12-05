using Microsoft.AspNetCore.Mvc;
using trabalho_banco_de_dados.dados;
using trabalho_banco_de_dados.Models;
using trabalho_banco_de_dados.Repositorio;

namespace trabalho_banco_de_dados.Controllers
{
    public class AlunoController : Controller
    {
        private Aluno AlunoLogado;
        private readonly IAlunoRepositorio _alunoRepositorio;

        public AlunoController(IAlunoRepositorio alunoRepositorio)
        {
            _alunoRepositorio = alunoRepositorio;
        }
        public IActionResult Index()
        {
             List<Aluno> alunos = _alunoRepositorio.ListarAlunos();
            return View(alunos);
        }
        public IActionResult Cadastrar()
        {
            return View();
        }
        public IActionResult AlunoInicio(int Id)  
        {
            Aluno aluno = _alunoRepositorio.AlunoPorId(Id);
            AlunoLogado = aluno;
            return View(); 
        }
        [HttpPost]
        public IActionResult Cadastrar(Aluno aluno)
        {
            _alunoRepositorio.Cadastrar(aluno);
            AlunoLogado = aluno;
            return RedirectToAction("AlunoInicio");
        }

    }
}
