using System;
using System.ComponentModel.DataAnnotations;

namespace BibliotecaQRCode.Models
{
    public class Emprestimo
    {
        public int Id { get; set; }

        [Required]
        public int AlunoId { get; set; }

        [Required]
        public int LivroId { get; set; }

        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucao { get; set; }

        // "Em andamento" ou "Devolvido"
        [Required, MaxLength(20)]
        public string Status { get; set; } = "Em andamento";

        public Aluno? Aluno { get; set; }
        public Livro? Livro { get; set; }
    }
}

