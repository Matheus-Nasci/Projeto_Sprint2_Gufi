﻿using System;
using System.Collections.Generic;

namespace Senai.Gufi.WebApi.DatabaseFirst.Domains
{
    public partial class Usuario
    {
        public Usuario()
        {
            Presenca = new HashSet<Presenca>();
        }

        public int IdUsuario { get; set; }

        public string NomeUsuario { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public string Genero { get; set; }

        public DateTime DataNascimento { get; set; }

        public int? TipoUsuario { get; set; }

        public int? Idade { get; set; }

        public TipoUsuario TipoUsuarioNavigation { get; set; }

        public ICollection<Presenca> Presenca { get; set; }
    }
}
