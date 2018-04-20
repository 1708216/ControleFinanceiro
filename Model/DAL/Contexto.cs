using System.Data.Entity;

namespace Model.DAL
{
    public class Contexto : DbContext
    {
        public Contexto() : base("stringConn")
        {
            Database.SetInitializer(

                new ControleFinanceiroDBInitializer()

                );
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Despesa> Despesas { get; set; }
        public DbSet<Receita> receitas { get; set; }
        public DbSet<RegistroDeDespesa> RegistroDeDespesas { get; set; }
        //   public DbSet<RegistroDeReceita> RegistroDeReceitas { get; set; }
    }
}
