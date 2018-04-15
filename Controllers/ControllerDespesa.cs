using System;
using System.Collections.ObjectModel;
using Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    class ControllerDespesa
    {
        static ObservableCollection<Despesa> listaDespesas = new ObservableCollection<Despesa>();
        static int ultimoID = 0;

        public Boolean SalvarDespesa(Despesa despesaRecebida)
        {
            int id = ultimoID + 1;
            ultimoID = id;
            despesaRecebida.DespesaID = id;
            listaDespesas.Add(despesaRecebida);
            return true;
        }

        public ObservableCollection<Despesa> RetornarListaDeDespesa()
        {
            return listaDespesas;
        }

    }
}
}
