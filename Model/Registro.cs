using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class Registro
    {
        public  int ResgistroID { get; set; }
        public DateTime Data { get; set;}
        public double Valor { get; set; }
        public int UsuarioID { get; set; }

     }
}
