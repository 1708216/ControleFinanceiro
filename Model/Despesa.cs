using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public  class Despesa
    {
        public int DespesaID {get; set;}
        public string Descricao {get; set;}
        private int NumeroOperador {get; set;}

        public override string ToString()
        {
            return string.Format(this.Descricao);
        }
    }
}
