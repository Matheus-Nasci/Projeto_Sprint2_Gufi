using Senai.Gufi.WebApi.DatabaseFirst.Domains;
using Senai.Gufi.WebApi.DatabaseFirst.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.WebApi.DatabaseFirst.Repositories
{
    public class InstituicaoRepository : IInstituicaoRepository
    {
        GufiContext ctx = new GufiContext();

        public void Atualizar(int id, Instituicao instituicaoAtualizada)
        {
            Instituicao instituicaoBuscada = ctx.Instituicao.Find(id);

            instituicaoBuscada.Cnpj= instituicaoAtualizada.Cnpj;

            instituicaoBuscada.NomeFantasia = instituicaoAtualizada.NomeFantasia;

            instituicaoBuscada.Endereco = instituicaoAtualizada.Endereco;

            ctx.Instituicao.Update(instituicaoAtualizada);

            ctx.SaveChanges();
        }

        public Instituicao BuscarPorId(int id)
        {
            return ctx.Instituicao.FirstOrDefault(u => u.IdInstituicao == id);
        }

        public void Cadastrar(Instituicao novaInstituicao)
        {
            ctx.Instituicao.Add(novaInstituicao);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            ctx.Instituicao.Remove(BuscarPorId(id));

            ctx.SaveChanges();
        }

        public List<Instituicao> Listar()
        {
            return ctx.Instituicao.ToList();
        }
    }
}
