using Senai.Gufi.WebApi.DatabaseFirst.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.WebApi.DatabaseFirst.Interfaces
{
    interface IPresencaRepository
    {
        List<Presenca> Listar();

        void Cadastrar(Presenca novoPresenca);

        void Atualizar(int id, Presenca presencaAtualizada);

        void Deletar(int id);

        Presenca BuscarPorId(int id);
    }
}
