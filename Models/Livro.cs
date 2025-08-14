using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BibliotecaQRCode.Models
{
    public class Livro
    {
        public int Id { get; set; }

        [Required, MaxLength(180)]
        public string Titulo { get; set; } = "";

        [MaxLength(120)]
        public string? Autor { get; set; }

        // Código único que vai dentro do QR impresso no livro
        [Required, MaxLength(100)]
        public string CodigoQR { get; set; } = "";

        public ICollection<Emprestimo> Emprestimos { get; set; } = new List<Emprestimo>();
    }
}

