using Microsoft.EntityFrameworkCore;
using MeuSiteII.Models;

namespace MeuSiteII.Data
{
    public class MeuSiteContext : DbContext
    {
        public MeuSiteContext(DbContextOptions<MeuSiteContext> Options) : base(Options){
        }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Profissao> Profissoes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}