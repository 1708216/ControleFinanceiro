using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class RegistroDeReceita : Registro
    {
        int RegistroReceitaID {get;set;}
        Receita receita { get; set; }

        public RegistroDeReceita ()
        {
            Receita receita = new Receita();
        }
    }
}
