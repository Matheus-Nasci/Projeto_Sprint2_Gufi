using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Senai.Gufi.WebApi.DatabaseFirst.Domains;

namespace Senai.Gufi.WebApi.DatabaseFirst.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        GufiContext ctx = new GufiContext();

        public void Atualizar(int id, Usuario usuarioAtualizado)
        {
            Usuario usuarioBuscado = ctx.Usuario.Find(id);

            usuarioBuscado.NomeUsuario = usuarioAtualizado.NomeUsuario;

            usuarioBuscado.Email = usuarioAtualizado.Email;

            usuarioBuscado.Senha = usuarioAtualizado.Senha;

            usuarioBuscado.Genero = usuarioAtualizado.Genero;

            usuarioBuscado.DataNascimento = usuarioAtualizado.DataNascimento;

            usuarioBuscado.TipoUsuario = usuarioAtualizado.TipoUsuario;

            usuarioBuscado.Idade = usuarioAtualizado.Idade;
            
        }

        public Usuario BuscarPorId(int id)
        {
            return ctx.Usuario.FirstOrDefault(u => u.IdUsuario == id);
        }

        public void Cadastrar(Usuario novoUsuario)
        {
            ctx.Usuario.Add(novoUsuario);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            ctx.Usuario.Remove(BuscarPorId(id));

            ctx.SaveChanges();
        }

        public List<Usuario> Listar()
        {
            return ctx.Usuario.ToList();
        }

        public Usuario BuscarPorEmailSenha(string email, string senha)
        {
            return ctx.Usuario.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }
    }
}
