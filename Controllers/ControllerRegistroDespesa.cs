using System;
using Model;
using System.Linq;
using System.Collections.Generic;



namespace Controllers
{
    public class ControllerRegistroDespesa
    {
        public Boolean SalvarRegistro (RegistroDeDespesa registroRecebido)
        {
            RegistroDeDespesa registro = ProcurarRegistroPorId(registroRecebido.RegistroDeDespesaID);

            if(registro == null)
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

        public RegistroDeDespesa ProcurarRegistroPorId ( int Id)
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

        public List<RegistroDeDespesa> RetornarTodosOsRegistrosDespesas()
        {
            return ContextoSigleton.Instancia.RegistroDeDespesas.ToList();
        }

        public Boolean EditarUsuario(RegistroDeDespesa registroEditado)
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

        public Boolean ExcluirUsuario(int usuarioID)
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
