using Restaurante.Dominio.Entidades;
using Restaurante.Dominio.Interfaces.Repositorios;
using Restaurante.Infra.Data.Contextos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Infra.Data.Repositorios
{
    public class PratoRepositorio : RepositorioBase<Prato>, IPratoRepositorio
    {
        public PratoRepositorio(Contexto contexto) : base(contexto)
        {
        }
    }
}
