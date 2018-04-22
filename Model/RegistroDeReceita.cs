using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class RegistroDeReceita : Registro
    {
        public int RegistroDeReceitaID {get;set;}
        public int ReceitaID { get; set; }
        public virtual Receita receita { get; set; }
    }
}
