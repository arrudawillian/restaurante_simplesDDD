using Restaurante.Dominio.Entidades;
using Restaurante.Dominio.Interfaces.Repositorios;
using Restaurante.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Dominio.Servicos
{
    public class ServicoBase<TEntidade> : IServicoBase<TEntidade> where TEntidade : EntidadeBase
    {
        private readonly IRepositorioBase<TEntidade> repositorio;

        public ServicoBase(IRepositorioBase<TEntidade> repositorio)
        {
            this.repositorio = repositorio;
        }

        public void Alterar(TEntidade entidade)
        {
            this.repositorio.Alterar(entidade);
        }

        public void Excluir(int id)
        {
            this.repositorio.Excluir(id);
        }

        public void Excluir(TEntidade entidade)
        {
            this.repositorio.Excluir(entidade);
        }

        public int Incluir(TEntidade entidade)
        {
            return this.repositorio.Incluir(entidade);
        }

        public TEntidade SelecionarPorId(int id)
        {
            return this.repositorio.SelecionarPorId(id);
        }

        public IEnumerable<TEntidade> SelecionarTodos()
        {
            return this.repositorio.SelecionarTodos();
        }
    }
}
