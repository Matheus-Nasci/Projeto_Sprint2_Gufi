using System;
using System.Collections.Generic;

namespace Senai.Gufi.WebApi.DatabaseFirst.Domains
{
    public partial class Evento
    {
        public Evento()
        {
            Presenca = new HashSet<Presenca>();
        }

        public int IdEvento { get; set; }

        public DateTime DataEvento { get; set; }

        public string NomeEvento { get; set; }

        public string Descricao { get; set; }

        public bool? AcessoLivre { get; set; }

        public int? IdInstitucao { get; set; }

        public int? IdTipoEvento { get; set; }

        public Instituicao IdInstitucaoNavigation { get; set; }

        public TipoEvento IdTipoEventoNavigation { get; set; }

        public ICollection<Presenca> Presenca { get; set; }
    }
}
