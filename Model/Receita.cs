

namespace Model
{
    public class Receita
    {
        public int ReceitaID { get; set; }
        public string Descricao { get; set; }
        private int NumeroOperador { get; set; }

        public override string ToString()
        {
            return string.Format(this.Descricao);
        }


    }
}
