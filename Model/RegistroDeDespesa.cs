using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class RegistroDeDespesa : Registro
    {
        public int RegistroDeDespesaID { get; set; }
        public int DespesaID { get; set; }
        public virtual Despesa despesa { get; set; }

        // vou transformar o objeto em uma string de descrição da despesa
        // public string descricaoDespesa { get; set; }
        //   public string tipoDeoperacao { get; set; }

        //inicialmente eu criaria criaria um objeto para estanciar uma descrição de despesa
        //para ser renchido no menu outras despesas, 
        //mas precisaria de um banco já com os itens iniciais
       // public RegistroDeDespesa()
       //{
       //    Despesa despesa = new Despesa();
       // }

    }
}
