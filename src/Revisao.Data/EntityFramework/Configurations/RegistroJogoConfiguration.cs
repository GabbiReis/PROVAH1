using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Revisao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Data.EntityFramework.Configurations
{
    public class RegistroJogoConfiguration : IEntityTypeConfiguration<RegistroJogo>
    {
        public void Configure(EntityTypeBuilder<RegistroJogo> builder)
        {
            builder.ToTable("ResgistrarJogo");
            builder.HasKey(a => a.id);

            builder
                .Property(a => a.id)
                .UseIdentityColumn()
                .HasColumnName("id")
                .HasColumnType("int");

            builder
                .Property(a => a.primeiroNumero)
                .HasColumnName("Primeiro_Numero")
                .HasColumnType("int");

            builder
                .Property(a => a.segundoNumero)
                .HasColumnName("Segundo_Numero")
                .HasColumnType("int");

            builder
                .Property(a => a.terceiroNumero)
                .HasColumnName("Terceiro_Numero")
                .HasColumnType("int");

            builder
                .Property(a => a.quartoNumero)
                .HasColumnName("Quarto_Numero")
                .HasColumnType("int");

            builder
                .Property(a => a.quintoNumero)
                .HasColumnName("Quinto_Numero")
                .HasColumnType("int");

            builder
                .Property(a => a.sextoNumero)
                .HasColumnName("Sexto_Numero")
                .HasColumnType("int");

        }
    }
}
