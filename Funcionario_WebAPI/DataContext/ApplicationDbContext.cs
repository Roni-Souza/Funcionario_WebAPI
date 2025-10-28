using Funcionario_WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Funcionario_WebAPI.DataContext
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<FuncionarioModel> Funcionarios { get; set; }
    }
}
