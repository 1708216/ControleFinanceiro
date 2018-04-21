using System;
using Model;
using System.Linq;
using System.Collections.Generic;



namespace Controllers
{
    public class ControllerRegistroDespesa
    {
        public Boolean SalvarRegistro(RegistroDeDespesa registroRecebido)
        {
            RegistroDeDespesa registro = ProcurarRegistroPorId(registroRecebido.RegistroDeDespesaID);

            if (registro == null)
            {
                ContextoSigleton.Instancia.RegistroDeDespesas.Add(registroRecebido);
                ContextoSigleton.Instancia.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public RegistroDeDespesa ProcurarRegistroPorId(int Id)
        {
            var d = from x in ContextoSigleton.Instancia.RegistroDeDespesas
                    where x.RegistroDeDespesaID.Equals(Id)
                    select x;

            if (d != null)
            {
                return d.FirstOrDefault();
            }
            else
            {
                return null;
            }
        }

        public IEnumerable<RegistroDeDespesa> RetornarAsDespesaDoMes(String mes)
        {
            IEnumerable<RegistroDeDespesa> DespesasSelecionadas = from x in ContextoSigleton.Instancia.RegistroDeDespesas
                                                                  where x.Data.Contains(mes)
                                                                  select x;
            return DespesasSelecionadas;
        }



        public double RetornarSomaDasDespesaDoMes(String mesRecebido)
        {

            double soma = 0;
            IEnumerable<RegistroDeDespesa> despesasDoMes = RetornarAsDespesaDoMes(mesRecebido);

            foreach (Registro despesa in despesasDoMes)
            {
                soma = soma + despesa.Valor;
            }
            return soma;
        }



        public List<RegistroDeDespesa> RetornarTodosOsRegistrosDespesas()
        {
            return ContextoSigleton.Instancia.RegistroDeDespesas.ToList();
        }


        public Boolean EditarRegistroDeDespesa(RegistroDeDespesa registroEditado)
        {
            RegistroDeDespesa registroParaEditar = ProcurarRegistroPorId(registroEditado.RegistroDeDespesaID);

            if (registroParaEditar != null)
            {
                registroParaEditar.Data = registroEditado.Data;
                registroParaEditar.UsuarioID = registroEditado.UsuarioID;
                registroParaEditar.despesa = registroEditado.despesa;

                ContextoSigleton.Instancia.Entry(registroParaEditar).State =
                    System.Data.Entity.EntityState.Modified;
                ContextoSigleton.Instancia.SaveChanges();

                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean ExcluirRegistroDeDespesa(int usuarioID, int usuarioLogadoID)
        {
            Usuario u = ContextoSigleton.Instancia.Usuarios.Find(usuarioID);

            if (u != null)
            {
                ContextoSigleton.Instancia.Entry(u).State = System.Data.Entity.EntityState.Deleted;
                ContextoSigleton.Instancia.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
