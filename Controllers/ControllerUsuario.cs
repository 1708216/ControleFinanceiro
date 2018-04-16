using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controllers
{
    public class ControllerUsuario
    {

        public Boolean SalvarUsuario(Usuario novoUsuario)
        {
            Usuario usuario = ProcurarUsuarioPorNome(novoUsuario.nomeUsuario);
             
            if (usuario == null)
            {
                ContextoSigleton.Instancia.Usuarios.Add(novoUsuario);
                ContextoSigleton.Instancia.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean ValidarLoginESenha(Usuario usuario)
        {
            Usuario loginParaVerificacao = ProcurarUsuarioPorLogin(usuario.loginUsuario);

            if (loginParaVerificacao != null)
            {
                if (loginParaVerificacao.senhaUsuario.Equals(usuario.senhaUsuario))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public Usuario ProcurarUsuarioPorNome(string nomeUsuario)
        {
            var u = from x in ContextoSigleton.Instancia.Usuarios 
                    where x.nomeUsuario.ToLower().Equals(nomeUsuario.Trim().ToLower())
                    select x;

            if (u != null)
            {
                return u.FirstOrDefault();
            }
            else
            {
                return null;
            }
        }

        public Usuario ProcurarUsuarioPorLogin(string login)
        {
            var u = from x in ContextoSigleton.Instancia.Usuarios
                    where x.loginUsuario.ToLower().Equals(login.Trim().ToLower())
                    select x;
            if (u != null)
            {
                return u.FirstOrDefault();
            }
            else
            {
                return null;
            }
        }
        public Usuario ProcurarUsuarioPorId(int id)
        {
            var u = from x in ContextoSigleton.Instancia.Usuarios
                    where x.UsuarioID.Equals(id)
                    select x;
            if (u != null)
            {
                return u.FirstOrDefault();
            }
            else
            {
                return null;
            }
        }

        public List<Usuario> RetornarListaDeTodosOsUsuarios()
        {
            return ContextoSigleton.Instancia.Usuarios.ToList();
        }

        public Boolean EditarUsuario(Usuario usuarioEditado)
        {
            Usuario usuarioParaEditar = ProcurarUsuarioPorId(usuarioEditado.UsuarioID);
            if(usuarioParaEditar != null)
            {
                usuarioParaEditar.nomeUsuario = usuarioEditado.nomeUsuario;
                usuarioParaEditar.loginUsuario = usuarioEditado.loginUsuario;
                usuarioParaEditar.senhaUsuario = usuarioEditado.senhaUsuario;
                usuarioParaEditar.nivelDePermissão = usuarioEditado.nivelDePermissão;

                ContextoSigleton.Instancia.Entry(usuarioParaEditar).State =
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
