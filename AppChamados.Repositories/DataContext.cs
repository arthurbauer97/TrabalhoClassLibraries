using AppChamados.Domain;
using Microsoft.EntityFrameworkCore;

namespace AppChamados.Repositories
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        { }

        public DbSet<Chamado> Chamados {get; set;}
        public DbSet<Cliente> Clientes {get; set;}
        public DbSet<Situacao> Situacoes {get; set;}
    }
}