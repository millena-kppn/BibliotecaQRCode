using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BibliotecaQRCode.Models
{
    public class Admin
    {
        public int Id { get; set; }
        // credenciais
        public string Login { get; set; } = "admin";
        public string Senha { get; set; } = "1234"; // depois vamos fazer hash
        // recuperação
        public string? CodigoRecuperacao { get; set; }
        public DateTime? ExpiraCodigo { get; set; }
    }
}
