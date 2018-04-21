using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class Registro
    {
        public int registroID { get; set; }
       // public DateTime Data { get; set;}
        public string Data { get; set; }
        public double Valor { get; set; }
        public int UsuarioID { get; set; }
        public int Hora { get; set; }

     }
}
