//using BibliotecaQRCode;
//using BibliotecaQRCode.Data;
//using BibliotecaQRCode.Models;

//namespace BibliotecaQRCode
//{

//    internal static class Program
//    {
//        /// <summary>
//        ///  The main entry point for the application.
//        /// </summary>
//        [STAThread]
//        static void Main()
//        {
//            // To customize application configuration such as set high DPI settings or default font,
//            // see https://aka.ms/applicationconfiguration.
//            ApplicationConfiguration.Initialize();
//            Application.Run(new FrmLogin());
//        }
//    }
//}

//TESTE PARA VER SE O CÓDIGO FUNCIONA
using BibliotecaQRCode.Data;   // ajuste para o namespace correto
using BibliotecaQRCode.Models; // ajuste também se necessário

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

                db.SaveChanges();
                // TESTE AQUI
                var alunos = db.Alunos.ToList();
                var livros = db.Livros.ToList();
                System.Windows.Forms.MessageBox.Show(
                    $"Total de Alunos: {alunos.Count}\n" +
                    $"Primeiro: {alunos.FirstOrDefault()?.Nome}\n\n" +
                    $"Total de Livros: {livros.Count}\n" +
                    $"Primeiro: {livros.FirstOrDefault()?.Titulo}"
                );
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new FrmEscolha());//inicia na tela de escolha entre aluno e admin
        }
    }
}