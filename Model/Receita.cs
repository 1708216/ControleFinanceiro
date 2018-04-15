using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Receita
    {
        public int ReceitaID {get; set;}
        public string Descricao {get; set;}
        private int NumeroOperador {get; set;}

        public Receita()
        {
            NumeroOperador = 2;
        }
    }
}
