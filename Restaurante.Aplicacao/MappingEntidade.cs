using AutoMapper;
using Restaurante.Aplicacao.DTO;
using Restaurante.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Aplicacao
{
    public class MappingEntidade : Profile
    {
        public MappingEntidade()
        {
            CreateMap<Prato, PratoDTO>().ReverseMap();
        }
    }
}
