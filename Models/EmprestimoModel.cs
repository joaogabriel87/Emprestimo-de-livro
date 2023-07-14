using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Emprestimo_de_livro.Models
{
    public class EmprestimoModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Digite o nome do Recebedor")]
        public string Recebedor { get; set; }
        [Required(ErrorMessage = "Digite o nome do Fornecedor")]
        public string Fornecedor { get; set; }
        [Required(ErrorMessage = "Digite o nome do Livro")]
        public string LivroEmprestado { get; set;}
        public DateTime dataUltimaAtualizacao { get; set; } = DateTime.Now;

        
    }
}