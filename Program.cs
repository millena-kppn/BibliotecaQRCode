//aqui
using BibliotecaQRCode.Data;   // ajuste para o namespace correto
using BibliotecaQRCode.Models; // ajuste tamb�m se necess�rio
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
                    // For�a a senha fixa 1234
                    admin.Senha = "1234";
                    // Limpa qualquer c�digo de recupera��o ativo
                    admin.CodigoRecuperacao = null;
                    admin.ExpiraCodigo = null;
                }
                else
                {
                    // Se n�o existir, cria um admin novo
                    db.Admins.Add(new Admin
                    {
                        Login = "admin",
                        Senha = "1234"
                    });
                }

                db.SaveChanges();
            }
            // s� inicia a aplica��o DEPOIS do update
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmEscolha()); // inicia na tela de escolha entre aluno e admin
        }
    }
}
