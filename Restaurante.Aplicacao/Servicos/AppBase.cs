using AutoMapper;
using Restaurante.Aplicacao.DTO;
using Restaurante.Aplicacao.Interfaces;
using Restaurante.Dominio.Entidades;
using Restaurante.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Aplicacao.Servicos
{
    public class AppBase<TEntidade, TEntidadeDTO> : IAppBase<TEntidade, TEntidadeDTO>
        where TEntidade : EntidadeBase
        where TEntidadeDTO : DTOBase
    {
        private readonly IMapper iMapper;
        private readonly IServicoBase<TEntidade> servico;

        public AppBase(IMapper iMapper, IServicoBase<TEntidade> servico)
        {
            this.iMapper = iMapper;
            this.servico = servico;
        }

        public void Alterar(TEntidadeDTO entidade)
        {
            this.servico.Alterar(this.iMapper.Map<TEntidade>(entidade));
        }
        public void Excluir(int id)
        {
            servico.Excluir(id);
        }

        public void Excluir(TEntidadeDTO entidade)
        {
            servico.Excluir(iMapper.Map<TEntidade>(entidade));
        }

        public int Incluir(TEntidadeDTO entidade)
        {
            return servico.Incluir(iMapper.Map<TEntidade>(entidade));
        }

        public TEntidadeDTO SelecionarPorId(int id)
        {
            return iMapper.Map<TEntidadeDTO>(servico.SelecionarPorId(id));
        }

        public IEnumerable<TEntidadeDTO> SelecionarTodos()
        {
            return iMapper.Map<IEnumerable<TEntidadeDTO>>(servico.SelecionarTodos());
        }
    }
}
