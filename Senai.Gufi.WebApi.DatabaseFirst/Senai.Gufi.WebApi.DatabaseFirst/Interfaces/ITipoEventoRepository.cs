using Senai.Gufi.WebApi.DatabaseFirst.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.WebApi.DatabaseFirst.Interfaces
{
    interface ITipoEventoRepository
    {
        List<TipoEvento> Listar();

        void Cadastrar(TipoEvento novoTipoEvento);

        void Atualizar(int id, TipoEvento tipoEventoAtualizado);

        void Deletar(int id);

        TipoEvento BuscarPorId(int id);
    }
}
