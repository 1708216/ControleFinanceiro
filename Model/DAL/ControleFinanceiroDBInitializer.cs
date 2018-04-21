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
            itensDoMenuInserirDespesas.Add(new Despesa() { DespesaID = 2 ,Descricao = "INTERNET" });
            itensDoMenuInserirDespesas.Add(new Despesa() { DespesaID = 3, Descricao = "LUZ" });
            itensDoMenuInserirDespesas.Add(new Despesa() { DespesaID = 4, Descricao = "ÁGUA" });
            itensDoMenuInserirDespesas.Add(new Despesa() { DespesaID = 5, Descricao = "CARTÃO DE CRÉDITO" });
            itensDoMenuInserirDespesas.Add(new Despesa() { DespesaID = 6, Descricao = "EDUCACÃO" });
            itensDoMenuInserirDespesas.Add(new Despesa() { DespesaID = 7, Descricao = "SEGURO DO CARRO" });
            itensDoMenuInserirDespesas.Add(new Despesa() { DespesaID = 8, Descricao = "LANCHE" });
            itensDoMenuInserirDespesas.Add(new Despesa() { DespesaID = 9, Descricao = "ALMOÇO" });
            itensDoMenuInserirDespesas.Add(new Despesa() { DespesaID = 10, Descricao = "MECÂNICO" });
            itensDoMenuInserirDespesas.Add(new Despesa() { DespesaID = 11, Descricao = "ACADEMIA" });
            itensDoMenuInserirDespesas.Add(new Despesa() { DespesaID = 12, Descricao = "DESPESAS MÉDICAS" });
            itensDoMenuInserirDespesas.Add(new Despesa() { DespesaID = 13, Descricao = "BAR" });
            itensDoMenuInserirDespesas.Add(new Despesa() { DespesaID = 14, Descricao = "DENTISTA" });
            itensDoMenuInserirDespesas.Add(new Despesa() { DespesaID = 12, Descricao = "SALÃO DE BELEZA" });
            itensDoMenuInserirDespesas.Add(new Despesa() { DespesaID = 13, Descricao = "EMPREGADA DOMESTICA" });
            itensDoMenuInserirDespesas.Add(new Despesa() { DespesaID = 14, Descricao = "GASOLINA" });
            itensDoMenuInserirDespesas.Add(new Despesa() { DespesaID = 12, Descricao = "CONDOMÍNIO" });
            itensDoMenuInserirDespesas.Add(new Despesa() { DespesaID = 13, Descricao = "IPVA" });
            itensDoMenuInserirDespesas.Add(new Despesa() { DespesaID = 14, Descricao = "GÁS" });
            itensDoMenuInserirDespesas.Add(new Despesa() { DespesaID = 12, Descricao = "DESPESAS COM VIAGEM" });
            itensDoMenuInserirDespesas.Add(new Despesa() { DespesaID = 13, Descricao = "PRESENTE" });
            itensDoMenuInserirDespesas.Add(new Despesa() { DespesaID = 14, Descricao = "FINANCIAMENTO IMOBILIÁRIO" });
            itensDoMenuInserirDespesas.Add(new Despesa() { DespesaID = 12, Descricao = "IPTU" });
            itensDoMenuInserirDespesas.Add(new Despesa() { DespesaID = 13, Descricao = "FARMÁCIA" });
            itensDoMenuInserirDespesas.Add(new Despesa() { DespesaID = 14, Descricao = "PLANO DO CELULAR" });
            itensDoMenuInserirDespesas.Add(new Despesa() { DespesaID = 12, Descricao = "LAZER" });
    
            contexto.Despesas.AddRange(itensDoMenuInserirDespesas);
            contexto.Usuarios.AddRange(usuarioAdministrador);
            contexto.SaveChanges();
    
    }


}
}
