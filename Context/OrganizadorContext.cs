using Microsoft.EntityFrameworkCore;
using TrilhaApiDesafio.Models;

namespace TrilhaApiDesafio.Context
{
    public class OrganizadorContext : DbContext   

    {
        private readonly IConfiguration _configuration;

        public OrganizadorContext(DbContextOptions<OrganizadorContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        public DbSet<Tarefa> Tarefas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)   

        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("ConexaoPadrao"));
        }

    }
}