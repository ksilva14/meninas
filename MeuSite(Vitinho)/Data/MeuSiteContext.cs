using Microsoft.EntityFrameworkCore;
using MeuSite.Models;

namespace MeuSite.Data
{
    public class MeuSiteContext : DbContext
    {
        public MeuSiteContext (DbContextOptions<MeuSiteContext> options)
            : base(options)
        {
        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Profissao> Profissoes { get; set; }

        public DbSet<Produto> Produtos { get; set; }
    }
}
