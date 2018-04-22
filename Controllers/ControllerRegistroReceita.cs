using System;
using Model;
using System.Linq;
using System.Collections.Generic;

namespace Controllers
{
    public class ControllerRegistroReceita
    {
        public Boolean SalvarRegistro(RegistroDeReceita registroRecebido)
        {
            RegistroDeReceita registro = ProcurarRegistroPorId (registroRecebido.ReceitaID);

            if (registro == null)
            {
                ContextoSigleton.Instancia.RegistroDeReceitas.Add(registroRecebido);
                ContextoSigleton.Instancia.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public RegistroDeReceita ProcurarRegistroPorId(int Id)
        {
            var d = from x in ContextoSigleton.Instancia.RegistroDeReceitas
                    where x.RegistroDeReceitaID.Equals(Id)
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

        public IEnumerable<RegistroDeReceita> RetornarAsReceitasDoMes(String mes)
        {
            IEnumerable<RegistroDeReceita> ReceitasSelecionadas = from x in ContextoSigleton.Instancia.RegistroDeReceitas
                                                                  where x.Data.Contains(mes)
                                                                  select x;
            return ReceitasSelecionadas;
        }

        public double RetornarSomaDasReceitasDoMes(String mesRecebido)
        {

            double somaReceitas = 0;
            IEnumerable<RegistroDeReceita> receitasDoMes = RetornarAsReceitasDoMes(mesRecebido);

            foreach (Registro receita in receitasDoMes)
            {
                somaReceitas = somaReceitas + receita.Valor;
            }
            return somaReceitas;
        }

        public List<RegistroDeReceita> RetornarTodosOsRegistrosReceitas()
        {
            return ContextoSigleton.Instancia.RegistroDeReceitas.ToList();
        }


        public Boolean EditarRegistroDeReceita(RegistroDeReceita registroEditado)
        {
            RegistroDeReceita registroParaEditar = ProcurarRegistroPorId(registroEditado.RegistroDeReceitaID);

            if (registroParaEditar != null)
            {
                registroParaEditar.Data = registroEditado.Data;
                registroParaEditar.UsuarioID = registroEditado.UsuarioID;
                registroParaEditar.receita = registroEditado.receita;

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

        public Boolean ExcluirRegistroDeReceita(int registroDeDespesaID)
        {
            RegistroDeReceita u = ContextoSigleton.Instancia.RegistroDeReceitas.Find(registroDeDespesaID);
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