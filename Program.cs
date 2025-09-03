//aqui
using BibliotecaQRCode.Data;   // ajuste para o namespace correto
using BibliotecaQRCode.Models; // ajuste também se necessário
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BibliotecaQRCode
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // garante que o banco tem dados iniciais
            using (var db = new BibliotecaContext())
            {
                if (!db.Alunos.Any())
                    db.Alunos.Add(new Aluno { Nome = "Ana", Matricula = "2025A001", Curso = "ADS" });

                if (!db.Livros.Any())
                    db.Livros.Add(new Livro { Titulo = "Clean Code", Autor = "R. Martin", CodigoQR = "LIVRO-0001" });

                // banco de dados admin
                var admin = db.Admins.FirstOrDefault(a => a.Login == "admin");
                if (admin != null)
                {
                    // Força a senha fixa 1234
                    admin.Senha = "1234";
                    // Limpa qualquer código de recuperação ativo
                    admin.CodigoRecuperacao = null;
                    admin.ExpiraCodigo = null;
                }
                else
                {
                    // Se não existir, cria um admin novo
                    db.Admins.Add(new Admin
                    {
                        Login = "admin",
                        Senha = "1234"
                    });
                }

                db.SaveChanges();
            }
            // só inicia a aplicação DEPOIS do update
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmEscolha()); // inicia na tela de escolha entre aluno e admin
        }
    }
}
