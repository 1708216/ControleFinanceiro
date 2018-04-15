using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class Registro
    {
        int ResgistroID { get; set; }
        DateTime Data { get; set;}
        double Valor { get; set; }
     }
}
