using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Emprestimo_de_livro.Models;
using Microsoft.EntityFrameworkCore;

namespace Emprestimo_de_livro.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}

        public DbSet<EmprestimoModel> Emprestimo{ get; set;}
    }
}