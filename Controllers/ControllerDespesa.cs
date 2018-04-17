using System;
using System.Collections.Generic;
using Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class ControllerDespesa
    {

        public Boolean SalvarDespesa(Despesa despesaRecebida)
        {
            Despesa despesa = ProcurarDespesaPorId(despesaRecebida.DespesaID);

            if (despesa == null)
            {
                ContextoSigleton.Instancia.Despesas.Add(despesaRecebida);
                ContextoSigleton.Instancia.SaveChanges();
                return true;
            }else
            {
                return false;
            }
        }

        public List<Despesa> RetornarListaDeDespesa()
        {
            return ContextoSigleton.Instancia.Despesas.ToList();
        }


        public void CriarObjetosDoMenuDespesaRapida()
        {
             Despesa mercado = new Despesa( );
        }

       public Despesa ProcurarDespesaPorId(int id)
        {
            var u = from x in ContextoSigleton.Instancia.Despesas
                    where x.DespesaID.Equals(id)
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

        public Despesa ProcurarDespesaPorNome(string nome)
        {
            var d = from x in ContextoSigleton.Instancia.Despesas
                    where x.Descricao.ToLower().Equals(nome.Trim().ToLower())
                    select x;
            if(d != null)
            {
                return d.FirstOrDefault();
            }
            else
            {
                return null;
            }   
        }
    }
}
