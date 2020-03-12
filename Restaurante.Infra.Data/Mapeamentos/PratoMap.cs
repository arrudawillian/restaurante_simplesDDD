using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restaurante.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Infra.Data.Mapeamentos
{
    public class PratoMap : MapBase<Prato>
    {
        public PratoMap()
        {
        }

        public override void Configure(EntityTypeBuilder<Prato> builder)
        {
            base.Configure(builder);
            builder.ToTable("prato");
            builder.Property(c => c.Nome).IsRequired().HasColumnName("Nome").HasMaxLength(100);
            builder.Property(c => c.Preco).IsRequired().HasColumnName("Preco");
        }
    }
}
