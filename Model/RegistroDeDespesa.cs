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
        public Despesa despesa { get; set; }

       public RegistroDeDespesa()
        {
            Despesa despesa = new Despesa();
        }

    }
}
