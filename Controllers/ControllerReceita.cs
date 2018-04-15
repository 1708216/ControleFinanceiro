using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Collections.ObjectModel;

namespace Controllers
{
    public class ControllerReceita
    {

        static ObservableCollection<Receita> listaReceitas = new ObservableCollection<Receita>();
        static int ultimoID = 0;
        
        public Boolean SalvarReceita(Receita receitaRecebida)
        {
            int id = ultimoID + 1;
            ultimoID = id;
            receitaRecebida.ReceitaID = id;
            listaReceitas.Add(receitaRecebida);
            return true;
        }

        public ObservableCollection<Receita> RetornarListaDeReceitas()
        {
            return listaReceitas;
        }

    }
}
