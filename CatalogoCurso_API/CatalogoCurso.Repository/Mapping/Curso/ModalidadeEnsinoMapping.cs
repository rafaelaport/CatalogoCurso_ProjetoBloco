using CatalogoCurso.Domain.Curso;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Repository.Mapping.Curso
{

    public class ModalidadeEnsinoMapping : IEntityTypeConfiguration<ModalidadeEnsino>
    {
        public void Configure(EntityTypeBuilder<ModalidadeEnsino> builder)
        {
            builder.ToTable("ModalidadeEnsino");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Descricao).IsRequired().HasMaxLength(200);

            builder.Property(x => x.DataCadastro).IsRequired();
            builder.Property(x => x.Ativo).IsRequired();
        }
    }
}
