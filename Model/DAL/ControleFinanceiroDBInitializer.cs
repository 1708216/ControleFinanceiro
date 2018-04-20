using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model.DAL
{
    public class ControleFinanceiroDBInitializer : DropCreateDatabaseIfModelChanges<Contexto>
    {

        protected override void Seed(Contexto contexto)
        {
            List<Despesa> itensDoMenuInserirDespesas = new List<Despesa>();
            List<Usuario> usuarioAdministrador = new List<Usuario>();

            usuarioAdministrador.Add(new Usuario()
            {
                UsuarioID = 1,
                nomeUsuario = "ADMINISTRADOR",
                loginUsuario = "admin",
                senhaUsuario = "admin",
                nivelDePermissão = 1
            });

            usuarioAdministrador.Add(new Usuario()
            {
                UsuarioID = 2,
                nomeUsuario = "USUARIO TESTE",
                loginUsuario = "usuario",
                senhaUsuario = "teste",
                nivelDePermissão = 2
            });
            itensDoMenuInserirDespesas.Add(new Despesa() { DespesaID = 1, Descricao = "MERCADO" });
            itensDoMenuInserirDespesas.Add(new Despesa() { Descricao = "INTERNET" });
            itensDoMenuInserirDespesas.Add(new Despesa() { Descricao = "LUZ" });

            contexto.Despesas.AddRange(itensDoMenuInserirDespesas);
            contexto.Usuarios.AddRange(usuarioAdministrador);
            contexto.SaveChanges();
    
    }


}
}
