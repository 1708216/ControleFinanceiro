using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class ControllerReceita
    {
        public Boolean SalvarReceita(Receita receitaRecebida)
        {
            Receita teste1 = ProcurarReceitaPorId(receitaRecebida.ReceitaID);
            Receita teste2 = ProcurarReceitaPorNome(receitaRecebida.Descricao);

            if (teste1 == null && teste2 == null)
            {
                ContextoSigleton.Instancia.Receitas.Add(receitaRecebida);
                ContextoSigleton.Instancia.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Receita> RetornarListaDeReceita()
        {
            return ContextoSigleton.Instancia.Receitas.ToList();

        }

        public Receita ProcurarReceitaPorId(int id)
        {
            var u = from x in ContextoSigleton.Instancia.Receitas
                    where x.ReceitaID.Equals(id)
                    select x;
            if (u != null)
            {
                return u.FirstOrDefault();
            }
            else
            {
                return null;
            }
        }

        public Receita ProcurarReceitaPorNome(string nome)
        {
            var d = from x in ContextoSigleton.Instancia.Receitas
                    where x.Descricao.ToLower().Equals(nome.Trim().ToLower())
                    select x;
            if (d != null)
            {
                return d.FirstOrDefault();
            }
            else
            {
                return null;
            }
        }

        public Boolean ExcluirReceita(int receitaID)
        {
            Despesa d = ContextoSigleton.Instancia.Despesas.Find(receitaID);
            if (d != null && receitaID > 11)
            {
                ContextoSigleton.Instancia.Entry(d).State = System.Data.Entity.EntityState.Deleted;
                ContextoSigleton.Instancia.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
