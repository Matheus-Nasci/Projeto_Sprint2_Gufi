using Senai.Gufi.WebApi.DatabaseFirst.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.WebApi.DatabaseFirst.Interfaces
{
    interface IInstituicaoRepository
    {
        List<Instituicao> Listar();

        void Cadastrar(Instituicao novaInstituicao);

        void Atualizar(int id, Instituicao instituicaoAtualizada);

        void Deletar(int id);

        Instituicao BuscarPorId(int id);
    }
}
