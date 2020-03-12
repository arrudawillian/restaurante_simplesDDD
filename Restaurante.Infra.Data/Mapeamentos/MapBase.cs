using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restaurante.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Infra.Data.Mapeamentos
{
    public class MapBase<T> : IEntityTypeConfiguration<T> where T : EntidadeBase
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).IsRequired().HasColumnName("Id");
        }
    }
}
