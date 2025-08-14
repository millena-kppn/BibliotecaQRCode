using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BibliotecaQRCode.Models
{
    public class Aluno
    {
        public int Id { get; set; }

        [Required, MaxLength(120)]
        public string Nome { get; set; } = "";

        [Required, MaxLength(50)]
        public string Matricula { get; set; } = "";

        [MaxLength(80)]
        public string? Curso { get; set; }

        public ICollection<Emprestimo> Emprestimos { get; set; } = new List<Emprestimo>();
    }
}

