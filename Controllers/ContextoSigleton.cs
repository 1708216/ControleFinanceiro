using Model.DAL;

namespace Controllers
{
     
    class ContextoSigleton
    {
        private static Contexto instancia;

        public static Contexto Instancia
        {
            get
            {
                if (instancia == null)
                    instancia = new Contexto();
                return instancia;
            }
        }

        private ContextoSigleton()
        {

        }
    }
}
