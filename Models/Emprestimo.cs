namespace BibliotecaQRCode.Models
{
    public class Emprestimo
    {
        public int Id { get; set; }

        public int AlunoId { get; set; }
        public Aluno? Aluno { get; set; }

        public int LivroId { get; set; }
        public Livro? Livro { get; set; }

        public DateTime DataEmprestimo { get; set; }

        // Data real da devolução (fica NULL enquanto estiver emprestado)
        public DateTime? DataDevolucao { get; set; }

        // <— NOVO: status explícito
        public string Status { get; set; } = "Emprestado";
    }
}

