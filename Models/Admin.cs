using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//aqui
namespace BibliotecaQRCode.Models
{
    public class Admin
    {
        public int Id { get; set; }
        public string Login { get; set; } = "admin"; // padrão
        public string Senha { get; set; } = "1234"; // senha inicial
        public string? CodigoRecuperacao { get; set; }
        public DateTime? ExpiraCodigo { get; set; }
    }
}
