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
    }
}
