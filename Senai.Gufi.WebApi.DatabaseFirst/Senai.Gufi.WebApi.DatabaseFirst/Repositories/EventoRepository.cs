using Senai.Gufi.WebApi.DatabaseFirst.Domains;
using Senai.Gufi.WebApi.DatabaseFirst.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.WebApi.DatabaseFirst.Repositories
{
    public class EventoRepository : IEventoRepository
    {
        GufiContext ctx = new GufiContext();

        public void Atualizar(int id, Evento eventoAtualizado)
        {
            Evento eventoBuscado = ctx.Evento.Find(id);

            eventoBuscado.DataEvento = eventoAtualizado.DataEvento;

            eventoBuscado.NomeEvento = eventoAtualizado.NomeEvento;

            eventoBuscado.Descricao = eventoAtualizado.Descricao;

            eventoBuscado.AcessoLivre = eventoAtualizado.AcessoLivre;

            eventoBuscado.IdInstitucao = eventoAtualizado.IdTipoEvento;

            eventoBuscado.IdTipoEvento = eventoAtualizado.IdTipoEvento;

            ctx.Evento.Update(eventoAtualizado);

            ctx.SaveChanges();
        }

        public Evento BuscarPorId(int id)
        {
            return ctx.Evento.FirstOrDefault(te => te.IdEvento == id);
        }

        public void Cadastrar(Evento novoEvento)
        {
            ctx.Evento.Add(novoEvento);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            ctx.Evento.Remove(BuscarPorId(id));

            ctx.SaveChanges();
        }

        public List<Evento> Listar()
        {
            return ctx.Evento.ToList();
        }
    }
}
