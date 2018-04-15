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
        static List<Usuario> listaUsuarios = new List<Usuario>();
        static int ultimoId = 0;

        public Boolean SalvarUsuario(Usuario novoUsuario)
        {
            Usuario usuario = ProcurarUsuarioPorNome(novoUsuario.nomeUsuario);

            if (usuario == null)
            {
                int id = ultimoId + 1;
                ultimoId = id;
                novoUsuario.UsuarioID = id;
                listaUsuarios.Add(novoUsuario);
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


        public Usuario ProcurarUsuarioPorNome(string usuario)
        {
            var u = from x in listaUsuarios
                    where x.nomeUsuario.ToLower().Equals(usuario.Trim().ToLower())
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
            var u = from x in listaUsuarios
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
            var u = from x in listaUsuarios
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
            return listaUsuarios;
        }

        public Boolean EditarUsuario(Usuario usuarioEditado)
        {
            Usuario usuario = ProcurarUsuarioPorId(usuarioEditado.UsuarioID);
            usuario.nomeUsuario = usuarioEditado.nomeUsuario;
            usuario.loginUsuario = usuarioEditado.loginUsuario;
            usuario.senhaUsuario = usuarioEditado.senhaUsuario;
            usuario.nivelDePermissão = usuarioEditado.nivelDePermissão;

            return true;
        }

        public Boolean ExcluirUsuario(int id)
        {
            Usuario usuario = ProcurarUsuarioPorId(id);

            if (usuario != null)
            {
                listaUsuarios.Remove(usuario);
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
